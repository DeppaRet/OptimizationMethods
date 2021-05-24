using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace WindowsFormsApp1.Forms
{
   public partial class Simulation : Form
   {
      double[,] sdata = null;
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
         string result = "Максимальное прибыль от реализации продукта составляет " + maxValue.ToString() +
         " у.е. и достигается при температурах T1=" + T1.ToString() + ", T2=" + T2.ToString();
         resultText.Text = result;
      }


      private void Simulation_Load(object sender, EventArgs e)
      {
         
      }

      private void Build_Click(object sender, EventArgs e)
      {
         int value0 = 30;
         int value1 = 100;
         int value2 = 500;
         int value3 = 2500;
         int value4 = 3800;
         int value5 = 1500;
         double S;


         for (double x = -3; x <= 3; x += 0.01)
         {
            for (double y = -2; y <= 6; y += 0.01)
            {
               if (x - y < -3)
                  continue;
               S = 1 * (2 * 1 * (Math.Pow((y - x), 2) + Math.Pow((1 * 1 - x), 2))) * 100 / 10;
               S = Math.Round(S, 0) * 10;
               if (S == value1)
               {
                  equalLines.Series[0].Points.AddXY(x, y);
               }
               else if (S == value2)
               {
                  equalLines.Series[1].Points.AddXY(x, y);
               }
               else if (S == value3)
               {
                  equalLines.Series[2].Points.AddXY(x, y);
               }
               else if (S == value0)
               {
                  equalLines.Series[2].Points.AddXY(x, y);
               }
               else if (S == value4)
               {
                  equalLines.Series[0].Points.AddXY(x, y);
               }
               else if (S == value5)
               {
                  equalLines.Series[1].Points.AddXY(x, y);
               }
            }
         }
      }
      C1.Win.C1Chart3D.Chart3DDataSetGrid sphere_set = null;
      private void build3D_Click(object sender, EventArgs e)
      {
         
         sdata = (double[,])Array.CreateInstance(typeof(double), 60, 90);

         for (int i = 0; i < 60; i++)
         {
            for (int j = 0; j < 90; j++)
            {
               if ((i/10.0 - 3) - (j/10.0 - 2) < -3)
               {
                  sdata[i, j] = 0;
                  continue;
               }
               sdata[i, j] = 1 * (2 * 1 * (Math.Pow(((j/10.0-2) - (i/10.0-3)), 2) + Math.Pow((1 * 1 - (i/10.0-3)), 2))) * 100;
            }
         }
         sphere_set = new C1.Win.C1Chart3D.Chart3DDataSetGrid(-3, -2, 0.1, 0.1, sdata);
         c1Chart3D1.ChartGroups[0].ChartData.SetGrid = sphere_set;
      }
   }
}

//Point3D[] pt3d = new Point3D[ResultTable.RowCount];
//pt3d[i] = new Point3D();
//pt3d[i].X = float.Parse(ResultTable.Rows[i].Cells[0].Value.ToString());
//pt3d[i].Y = float.Parse(ResultTable.Rows[i].Cells[1].Value.ToString());
//pt3d[i].Z = float.Parse(ResultTable.Rows[i].Cells[2].Value.ToString());



//pt3d[i].X = float.Parse(x.ToString());
//pt3d[i].Y = float.Parse(y.ToString());
//pt3d[i].Z = float.Parse(z.ToString());
//x += 0.1;
//y += 10;
//z += 0.2;

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

//OpenGL gl = openGLControl1.OpenGL;

////  Очищает буфер кадра 
//gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

////  загружает нулевую матрицу мировых координат
//gl.LoadIdentity();
//gl.LookAt(-10, 10, 10000, 0, 0, 0, 0, 1, 0);
//gl.Begin(BeginMode.Points);
//for (int i = 0; i < ResultTable.Rows.Count - 1; i++)
//{
//   double x = Convert.ToDouble(ResultTable.Rows[i].Cells[0].Value);
//   double y = Convert.ToDouble(ResultTable.Rows[i].Cells[1].Value);
//   double z = Convert.ToDouble(ResultTable.Rows[i].Cells[2].Value);
//   gl.Vertex(x, y, z);
//   gl.Color(1.0f, 0.0f, 0.0f);
//}
//gl.End();