using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
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

   class Box
   {
      static double f(double x, double y, double a, double b, double v1, double v2, double alfa, double beta, double gamma)
         => alfa * Math.Pow(y - x, a) + (beta / v1) * Math.Pow(x + y - gamma * v2, b);  //Функция  double S = alpha * (consumption * mu * (Math.Pow((temperature_2 - temperature_1), speed) Math.Pow((beta* pressure - temperature_1), speed)));
      static double f(double x, double y)
         => Math.Pow(y - x, 2) + Math.Pow(x + y * 10, 2) / 9;
      static double f(Point point)
         => Math.Pow(point.y - point.x, 2) + Math.Pow(point.x + point.y - 10, 2) / 9;

      static Random random = new Random();
      static double gx, gy, hx, hy;
      static double epsilon = 0.001;
      static Point[] complex = new Point[4];

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
               complex[i].x = gx + random.NextDouble() * (hx - gx);
               complex[i].y = gy + random.NextDouble() * (hy - gy);
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

      public static double[,] startPoints(int n, double[,] borders, int coefA, int coefB, int coefC)
      {
         gx = -3;
         gy = -2;
         hx = 3;
         hy = 6;

         ComplexGenerator();

         int counter = 0;
         double B = 0;
         do
         {
            counter++;
            for (int i = 0; i < 4; i++)
               Console.WriteLine($"{i + 1}) ({Math.Round(complex[i].x, 2)}, {Math.Round(complex[i].y, 2)})");

            int bestIndex = 0;
            int worstIndex = 0;

            for (int i = 1; i < 4; i++)
            {
               if (f(complex[bestIndex]) < f(complex[i]))
                  bestIndex = i;
               else if (f(complex[worstIndex]) > f(complex[i]))
                  worstIndex = i;
            }

            Point C = new Point();
            C.x = (complex.Sum(value => value.x) - complex[worstIndex].x) / 3;
            C.y = (complex.Sum(value => value.y) - complex[worstIndex].y) / 3;

            Console.WriteLine($"C) ({Math.Round(C.x, 2)}, {Math.Round(C.y, 2)})");


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

               while (f(newPoint) < f(complex[worstIndex]))
               {
                  newPoint.x = (newPoint.x + complex[bestIndex].x) / 2;
                  newPoint.y = (newPoint.y + complex[bestIndex].y) / 2;
               }
               complex[worstIndex] = newPoint;
            }

            Console.WriteLine($"new) ({Math.Round(complex[newPointIndex].x, 2)}, {Math.Round(complex[newPointIndex].y, 2)})");

            Console.WriteLine();
         } while (B > epsilon);
         double[,] points = new double[n, 2*n];
         return points;


         Console.WriteLine(counter);
         Console.ReadLine();
         //int N = 0;
         //if (n < 5)
         //{
         //   N = 2 * n;
         //}
         //else
         //{
         //   N = n + 1;
         //}

         //double g, h;
         //int k = 0;
         //double[,] points = new double[n, N];

         //for (int i = 0; i < N; i++)
         //{
         //   double rnd = random.NextDouble();
         //   for (int j = 0; j < n; j++)
         //   {
         //      g = borders[j, 0];
         //      h = borders[j, 1];                //    0 1 2 3 
         //      points[j, i] = g + rnd * (h - g); // 0  
         //   }                                    // 1
         //   if (coefA*points[0,i]+coefB*points[1,i] <= coefC*1)
         //   {

         //   }

         //   k++;
         //}


         
      }
   }
}
