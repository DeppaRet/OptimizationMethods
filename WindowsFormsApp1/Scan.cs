using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Forms;


namespace WindowsFormsApp1
{
   class Scan
   {
      public static DataTable calculate(double alpha, double beta, double mu, double pressure, double speed, double consumption, double[] tempT1, double[] tempT2, double accuracy)
      {
         DataTable table = new DataTable();
         double lowerT1 = tempT1[0];
         double highestT1 = tempT1[1];
         double lowerT2 = tempT2[0];
         double highestT2 = tempT2[1];
         double stepT1 = accuracy;
         double stepT2 = accuracy;
         double S = 0;
         double previousValue = 0;
         double i = 0, j = 0;
         table.Columns.Add("T1", typeof(double));
         table.Columns.Add("T2", typeof(double));
         table.Columns.Add("Value", typeof(double));
         for (i = lowerT1; i < highestT1; i += stepT1)
         {
            for (j = lowerT2; j < highestT2; j += stepT2)
            {
               if (i - j >= -3)
               {
                  S = alpha * (consumption * mu * (Math.Pow((j - i), speed) + Math.Pow((beta * pressure - i), speed))) * 100;
                  table.Rows.Add(Math.Round(i, 2), Math.Round(j, 2), Math.Round(S, 2));
               }
            }
         }
         return table;
      }
   }
}
