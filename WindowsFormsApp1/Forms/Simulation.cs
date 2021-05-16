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

      //void prepare3dChart(Chart chart, ChartArea ca)
      //{
      //   ca.Area3DStyle.Enable3D = true;  // set the chartarea to 3D!
      //   ca.AxisX.Minimum = -5;
      //   ca.AxisY.Minimum = -5;
      //   ca.AxisX.Maximum = 6;
      //   ca.AxisY.Maximum = 6;
      //   ca.AxisX.Interval = 1;
      //   ca.AxisY.Interval = 1;
      //   ca.AxisX.Title = "T1";
      //   ca.AxisY.Title = "T2";
      //   ca.AxisX.MajorGrid.Interval = 1;
      //   ca.AxisY.MajorGrid.Interval = 1;
      //   ca.AxisX.MinorGrid.Enabled = true;
      //   ca.AxisY.MinorGrid.Enabled = true;
      //   ca.AxisX.MinorGrid.Interval = 1;
      //   ca.AxisY.MinorGrid.Interval = 1;
      //   ca.AxisX.MinorGrid.LineColor = Color.LightSlateGray;
      //   ca.AxisY.MinorGrid.LineColor = Color.LightSlateGray;

      //   // we add two series:
      //   chart.Series.Clear();
      //   for (int i = 0; i < 1; i++)
      //   {
      //      Series s = chart.Series.Add("S" + i.ToString("00"));
      //      s.ChartType = SeriesChartType.Bubble;   // this ChartType has a YValue array
      //      s.MarkerStyle = MarkerStyle.Circle;
      //      s["PixelPointWidth"] = "100";
      //      s["PixelPointGapDepth"] = "1";
      //   }
      //   chart.ApplyPaletteColors();

      //   addTestData(chart);
      //}

      //void addTestData(Chart chart)
      //{
      //   for (int i = 0; i < 10; i++)
      //   {
      //      double x = Convert.ToDouble(ResultTable.Rows[i].Cells[0].Value);
      //      double y = Convert.ToDouble(ResultTable.Rows[i].Cells[1].Value);
      //      double z = -5 +i; //Convert.ToDouble(ResultTable.Rows[i].Cells[2].Value);
      //      AddXY3d(chart.Series[0], x, y, z);
      //      //AddXY3d(chart.Series[1], x - 111, y - 222, z);
      //   }
      //   //Random rnd = new Random(9);
      //   //for (int i = 0; i < 100; i++)
      //   //{
      //   //   double x = Math.Cos(i / 10f) * 88 + rnd.Next(5);
      //   //   double y = Math.Sin(i / 11f) * 88 + rnd.Next(5);
      //   //   double z = Math.Sqrt(i * 2f) * 88 + rnd.Next(5);

      //   //   AddXY3d(chart.Series[0], x, y, z);
      //   //   AddXY3d(chart.Series[1], x - 111, y - 222, z);
      //   //}
      //}

      //int AddXY3d(Series s, double xVal, double yVal, double zVal)
      //{
      //   int p = s.Points.AddXY(xVal, yVal, zVal);
      //   // the DataPoint are transparent to the regular chart drawing:
      //   s.Points[p].Color = Color.Transparent;
      //   return p;
      //}

      //private void chart1_PostPaint(object sender, ChartPaintEventArgs e)
      //{
      //   Chart chart = sender as Chart;

      //   if (chart.Series.Count < 1) return;
      //   if (chart.Series[0].Points.Count < 1) return;

      //   ChartArea ca = chart.ChartAreas[0];
      //   e.ChartGraphics.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

      //   List<List<PointF>> data = new List<List<PointF>>();
      //   foreach (Series s in chart.Series)
      //      data.Add(GetPointsFrom3D(ca, s, s.Points.ToList(), e.ChartGraphics));

      //   renderLines(data, e.ChartGraphics.Graphics, chart, true);  // pick one!
      //   renderPoints(data, e.ChartGraphics.Graphics, chart, 6);   // pick one!
      //}

      //List<PointF> GetPointsFrom3D(ChartArea ca, Series s,
      //   List<DataPoint> dPoints, ChartGraphics cg)
      //{
      //   var p3t = dPoints.Select(x => new Point3D((float)ca.AxisX.ValueToPosition(x.XValue),
      //      (float)ca.AxisY.ValueToPosition(x.YValues[0]),
      //      (float)ca.AxisY.ValueToPosition(x.YValues[1]))).ToArray();
      //   ca.TransformPoints(p3t.ToArray());

      //   return p3t.Select(x => cg.GetAbsolutePoint(new PointF(x.X, x.Y))).ToList();
      //}

      //void renderLines(List<List<PointF>> data, Graphics graphics, Chart chart, bool curves)
      //{
      //   for (int i = 0; i < chart.Series.Count; i++)
      //   {
      //      if (data[i].Count > 1)
      //         using (Pen pen = new Pen(Color.FromArgb(64, chart.Series[i].Color), 2.5f))
      //            if (curves) graphics.DrawCurve(pen, data[i].ToArray());
      //            else graphics.DrawLines(pen, data[i].ToArray());
      //   }
      //}

      //void renderPoints(List<List<PointF>> data, Graphics graphics, Chart chart, float width)
      //{
      //   for (int s = 0; s < chart.Series.Count; s++)
      //   {
      //      Series S = chart.Series[s];
      //      for (int p = 0; p < S.Points.Count; p++)
      //         using (SolidBrush brush = new SolidBrush(Color.FromArgb(64, S.Color)))
      //            graphics.FillEllipse(brush, data[s][p].X - width / 2,
      //               data[s][p].Y - width / 2, width, width);
      //   }
      //}

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
         //prepare3dChart(equalLines, equalLines.ChartAreas[0]);
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