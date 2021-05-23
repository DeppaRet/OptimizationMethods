using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;

namespace BoxOptimiz
{
   public class Point
   {
      public double x { get; set; }
      public double y { get; set; }
      public bool valid
      {
         get => x - y >= -3;
      }

      public Point() { }

      public Point(double x, double y)
      {
         this.x = x;
         this.y = y;
      }
   }

   public class Box
   {
      static double gx, gy, hx, hy;

      //Функция  double S = alpha * (consumption * mu * (Math.Pow((temperature_2 - temperature_1), speed) Math.Pow((beta* pressure - temperature_1), speed)));

      static double f(Point point, double alpha, double beta, double mu, double consumption, double speed, double pressure)
      {
         double res = alpha * (consumption * mu * (Math.Pow((point.y - point.x), speed) + Math.Pow((beta * pressure - point.x), speed))) * 100;
         return res;
      }

      static Point[] complex = new Point[4];
      static Random Random = new Random();

      static void ComplexGenerator()
      {
         int P = 0;
         double validXSum = 0;
         double validYSum = 0;
         while (P == 0)
         {
            for (int i = 0; i < 4; i++)
            {
               complex[i] = new Point();
               complex[i].x = gx + Random.NextDouble() * (hx - gx);
               complex[i].y = gy + Random.NextDouble() * (hy - gy);
               if (complex[i].valid)
               {
                  P++;
                  validXSum += complex[i].x;
                  validYSum += complex[i].y;
               }
            }
         }

         for (int i = 0; i < 4; i++)
         {
            while (!complex[i].valid)
            {
               complex[i].x = (complex[i].x + validXSum / 2) / 2;
               complex[i].y = (complex[i].y + validYSum / 2) / 2;
            }
         }
      }

      public static DataTable calculate(double alpha, double beta, double mu, double pressure, double speed, double consumption, double[] tempT1, double[] tempT2, double accuracy)
      {
         DataTable table = new DataTable();
         double epsilon = accuracy;

         gx = tempT1[0];
         gy = tempT2[0];
         hx = tempT1[1];
         hy = tempT2[1];
         table.Columns.Add("T1", typeof(double));
         table.Columns.Add("T2", typeof(double));
         table.Columns.Add("Value", typeof(double));
         //table.Columns.Add("Value", typeof(double));

         ComplexGenerator();


         System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-IN");

         int counter = 0;
         double B = 0;
         do
         {
            counter++;
            for (int i = 0; i < 4; i++)
               table.Rows.Add(Math.Round(complex[i].x, 2), Math.Round(complex[i].y, 2), Math.Round(f(complex[i], alpha, beta, mu, consumption, speed, pressure), 2));
               

            int bestIndex = 0;
            int worstIndex = 0;

            for (int i = 1; i < 4; i++)
            {
               if (f(complex[bestIndex], alpha, beta, mu, consumption, speed, pressure) < f(complex[i], alpha, beta, mu, consumption, speed, pressure))
                  bestIndex = i;
               else if (f(complex[worstIndex], alpha, beta, mu, consumption, speed, pressure) > f(complex[i], alpha, beta, mu, consumption, speed, pressure))
                  worstIndex = i;
            }

            Point C = new Point();
            C.x = (complex.Sum(value => value.x) - complex[worstIndex].x) / 3;
            C.y = (complex.Sum(value => value.y) - complex[worstIndex].y) / 3;


            B = (Math.Abs(C.x - complex[worstIndex].x) + Math.Abs(C.x - complex[bestIndex].x) + Math.Abs(C.y - complex[worstIndex].y) + Math.Abs(C.y - complex[bestIndex].y)) / 4;

            Point newPoint = new Point();
            int newPointIndex = worstIndex;
            if (B > epsilon)
            {
               newPoint.x = 2.3 * C.x - 1.3 * complex[worstIndex].x;
               newPoint.y = 2.3 * C.y - 1.3 * complex[worstIndex].y;

               if (newPoint.x < gx)
                  newPoint.x = gx + epsilon;
               else if (newPoint.x > hx)
                  newPoint.x = hx - epsilon;

               if (newPoint.y < gy)
                  newPoint.y = gy + epsilon;
               else if (newPoint.y > hy)
                  newPoint.y = hy - epsilon;

               while (!newPoint.valid)
               {
                  newPoint.x = (newPoint.x + C.x) / 2;
                  newPoint.y = (newPoint.y + C.y) / 2;
               }

               while (f(newPoint, alpha, beta, mu, consumption, speed, pressure) < f(complex[worstIndex], alpha, beta, mu, consumption, speed, pressure))
               {
                  newPoint.x = (newPoint.x + complex[bestIndex].x) / 2;
                  newPoint.y = (newPoint.y + complex[bestIndex].y) / 2;
               }
               complex[worstIndex] = newPoint;
            }
            double s = f(complex[bestIndex], alpha, beta, mu, consumption, speed, pressure);
            //Console.WriteLine("Значение функции: " + Math.Round(s, 1));
            //Console.WriteLine($"new) ({Math.Round(complex[newPointIndex].x, 2)}, {Math.Round(complex[newPointIndex].y, 2)})");

            //Console.WriteLine();
         } while (B > epsilon);
         return table;
      }
   }
}

