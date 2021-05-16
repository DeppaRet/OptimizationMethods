using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
   public partial class Simulation : Form
   {
      public DataTable table;
      public static Simulation Instance { get; private set; } // тут будет форма
      public Simulation(DataTable table2)
      {
         InitializeComponent();
         table = table2;
         Instance = this;
         updateTable();
      }

      private void closeButton_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void minimizeButton_Click(object sender, EventArgs e)
      {
         this.WindowState = FormWindowState.Minimized;
      }
      
      public void updateTable()
      {
         ResultTable.DataSource = table;
         this.ResultTable.Sort(this.ResultTable.Columns["Value"], ListSortDirection.Descending);
         double T1 = Convert.ToDouble(ResultTable.Rows[0].Cells[0].Value);
         double T2 = Convert.ToDouble(ResultTable.Rows[0].Cells[1].Value);
         double maxValue = Convert.ToDouble(ResultTable.Rows[0].Cells[2].Value);
         totalCost.Text = maxValue.ToString();
         calculatedAmount.Text = (maxValue / 100).ToString();
         temperature1.Text = T1.ToString();
         temperature2.Text = T2.ToString();
         string result = "Максимальное значение функции составляет " + maxValue.ToString() +
         " у.е. и достигается при температурах T1=" + T1.ToString() + ", T2=" + T2.ToString();
         resultText.Text = result;
      }

      public static void scanMethod(double alpha, double beta, double mu, double pressure, double speed, double consumption, double[] tempT1, double[] tempT2, double accuracy)
      {
         
         //double lowerT1 = tempT1[0];
         //double highestT1 = tempT1[1];
         //double lowerT2 = tempT2[0];
         //double highestT2 = tempT2[1];
         //double stepT1 = 1;
         //double stepT2 = 1;
         //double S = 0;
         //double previousValue = 0;
         //double i = 0, j = 0;
         //for (i = lowerT1; i < highestT1; i += stepT1)
         //{
         //   for (j = lowerT2; j < highestT2; j += stepT2)
         //   {
         //      if (i - j >= -3)
         //      {
         //         S = alpha * (consumption * mu * (Math.Pow((j - i), speed) + Math.Pow((beta * pressure - i), speed)));
                  
         //      }
         //   }
         //}

         //
      }

      private void Simulation_Load(object sender, EventArgs e)
      {
         
      }
   }
}


//do
//{

//for (i = lowerT1; i < highestT1; i += stepT1)
//{
//   S = alpha * (consumption * mu * (Math.Pow((j - i), speed) + Math.Pow((beta * pressure - i), speed)));
//   if (S < previousValue)
//   {
//      stepT1 = stepT1 * (-1) / 2;
//   }
//   previousValue = S;
//   if (stepT1 < accuracy)
//   {

//      break;
//   }

//}
//for (j = lowerT2; j < highestT2; j += stepT2)
//{
//   S = alpha * (consumption * mu * (Math.Pow((j - i), speed) + Math.Pow((beta * pressure - i), speed)));
//   {
//      stepT2 = stepT2 * (-1) / 2;
//   }
//   previousValue = S;
//   if (stepT2 < accuracy)
//      break;
//}
//} while (stepT1 > accuracy || stepT2 > accuracy);