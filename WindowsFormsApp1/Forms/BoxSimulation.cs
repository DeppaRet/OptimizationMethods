using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1.Forms
{
   public partial class BoxSimulation : Form
   {
      public DataTable table;
      public BoxSimulation(DataTable table2)
      {
         InitializeComponent();
         table = table2;
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

      private void Build_Click(object sender, EventArgs e)
      {
         steps.Series.Clear();
         int size = table.Rows.Count / 4;
         int k = 0;
         for (int i = 0; i < size; i++)
         {
            
            if (i % 2 == 0)
            {
               var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
               {
                  Name = "Series"+i,
                  Color = System.Drawing.Color.Green,
                  BorderWidth = 3,
                  IsVisibleInLegend = false,
                  ChartType = SeriesChartType.Point
               };

               this.steps.Series.Add(series1);
               steps.Series[i].Points.AddXY(table.Rows[k][0], table.Rows[k][1]);
               steps.Series[i].Points.AddXY(table.Rows[k+1][0], table.Rows[k+1][1]);
               steps.Series[i].Points.AddXY(table.Rows[k+2][0],table.Rows[k+2][1]);
               steps.Series[i].Points.AddXY(table.Rows[k+3][0], table.Rows[k+3][1]);
            }
            else
            {
               var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
               {
                  Name = "Series"+i,
                  Color = System.Drawing.Color.Red,
                  BorderWidth = 3,
                  IsVisibleInLegend = false,
                  ChartType = SeriesChartType.Point
               };

               this.steps.Series.Add(series1);
               steps.Series[i].Points.AddXY(table.Rows[k][0], table.Rows[i][1]);
               steps.Series[i].Points.AddXY(table.Rows[k+1][0], table.Rows[k+1][1]);
               steps.Series[i].Points.AddXY(table.Rows[k+2][0], table.Rows[k+2][1]);
               steps.Series[i].Points.AddXY(table.Rows[k+3][0], table.Rows[k+3][1]);
            }

            k += 4;
         }
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
         string result = "Максимальное прибыль от реализации продукта составляет " + maxValue.ToString() +
                         " у.е. и достигается при температурах T1=" + T1.ToString() + ", T2=" + T2.ToString();
         resultText.Text = result;

         //prepare3dChart(equalLines, equalLines.ChartAreas[0]);
      }
   }
}
