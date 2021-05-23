using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1.Forms;
using BoxOptimiz;

namespace WindowsFormsApp1
{
   public partial class Researcher : Form
   {
      static DataSet ds = new DataSet();
      static SQLiteDataAdapter adapter = new SQLiteDataAdapter();
      static DataTable table = new DataTable();
      static string choosenDB = "";
      private bool isLoad = false;
      public Researcher()
      {
         InitializeComponent();
      }

      private void closeButton_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void minimizeButton_Click(object sender, EventArgs e)
      {
         this.WindowState = FormWindowState.Minimized;
      }

      private void amountOfProductButton_Click(object sender, EventArgs e)
      {
         if(!check())
            return;
         double alpha = Convert.ToDouble(alphaText.Text);
         double beta = Convert.ToDouble(betaText.Text);
         double mu = Convert.ToDouble(muText.Text);
         double pressure = Convert.ToDouble(reactorPressure.Text); //A
         double speed = Convert.ToDouble(rotationalSpeed.Text);    //N
         double consumption = Convert.ToDouble(mixtureCons.Text);  //G
         double[] tempT1 = new[] {Convert.ToDouble(lowerT1.Text), Convert.ToDouble(highestT1.Text)};
         double[] tempT2 = new[] {Convert.ToDouble(lowerT2.Text), Convert.ToDouble(highestT2.Text)};
         double accuracy = Convert.ToDouble(accuracyValue.Text);
         if(choosenMethod.Text == "Метод сканирования")
         {
            DataTable table;
            table = Scan.calculate(alpha, beta, mu, pressure, speed, consumption, tempT1, tempT2, accuracy);
            Simulation simulation = new Simulation(table);
            simulation.Show();
         }
         else
         {
            DataTable table;
            table = Box.calculate(alpha, beta, mu, pressure, speed, consumption, tempT1, tempT2, accuracy);
            BoxSimulation boxSimulation = new BoxSimulation(table);
            boxSimulation.Show();
         }
         

      }

      private void highestT1_TextChanged(object sender, EventArgs e)
      {

      }

      private void Researcher_Load(object sender, EventArgs e)
      {
         string command = "SELECT (Name) FROM tasks";
         choosenDB = "Tasks.db";
         task.DataSource = requestAnswer(command, "1");
         task.DisplayMember = "Name";
         isLoad = true;
      }

      public static DataTable requestAnswer(string cmd, string tmp)
      {
         using (SQLiteConnection Connect = new SQLiteConnection("Data Source =" + choosenDB))
         {
            Connect.Open();
            adapter = new SQLiteDataAdapter(cmd, Connect);
            Connect.Close();
            table = new DataTable();
            adapter.Fill(table);
            return table;
         }
      }

      private void task_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (isLoad)
         {
            
            string command = $"SELECT Task, LowerT1, HigherT1, LowerT2, HigherT2, SecondLimit, Consumption, Pressure, Speed, Price FROM Tasks WHere name = '{task.Text}'";
            DataTable table1 = requestAnswer(command, "1");
            choosenTask.Text = table1.Rows[0].ItemArray[0].ToString();
            lowerT1.Text = table1.Rows[0].ItemArray[1].ToString();
            highestT1.Text = table1.Rows[0].ItemArray[2].ToString();
            lowerT2.Text = table1.Rows[0].ItemArray[3].ToString();
            highestT2.Text = table1.Rows[0].ItemArray[4].ToString();
            secondLimitation.Text = table1.Rows[0].ItemArray[5].ToString();
            mixtureCons.Text = table1.Rows[0].ItemArray[6].ToString();
            reactorPressure.Text = table1.Rows[0].ItemArray[7].ToString();
            rotationalSpeed.Text =  table1.Rows[0].ItemArray[8].ToString();
            costOnePiece.Text = table1.Rows[0].ItemArray[9].ToString();
         }
      }

      private void choosenMethod_SelectedIndexChanged(object sender, EventArgs e)
      {
         amountOfProductButton.Enabled = true;
      }

      public bool check()
      {
         accuracyValue.BackColor = Color.White;
         lowerT1.BackColor = Color.White;
         highestT1.BackColor = Color.White;
         lowerT2.BackColor = Color.White;
         highestT2.BackColor=Color.White;
         mixtureCons.BackColor = Color.White;
         reactorPressure.BackColor = Color.White;
         rotationalSpeed.BackColor = Color.White;
         try
         {
            double accuracy = Convert.ToDouble(accuracyValue.Text);
            double val;
            if (!Double.TryParse(accuracyValue.Text, out val))
            {
               accuracyValue.BackColor = Color.Red;
               throw new Exception("Вы ввели текст!\nПрограмный комплекс принимает только числа!");
            }
            if (accuracy < 0.009)
            {
               accuracyValue.BackColor = Color.Red;
               throw new Exception("Слишком маленький шаг!");
            }
            else if (accuracy > 1)
            {
               accuracyValue.BackColor = Color.Red;
               throw new Exception("Слишком большой шаг!");
            }
            if (!Double.TryParse(lowerT1.Text, out val))
            {
               lowerT1.BackColor = Color.Red;
               throw new Exception("Вы ввели текст!\nПрограмный комплекс принимает только числа!");
            }
            if (!Double.TryParse(lowerT2.Text, out val))
            {
               lowerT2.BackColor = Color.Red;
               throw new Exception("Вы ввели текст!\nПрограмный комплекс принимает только числа!");
            }
            if (!Double.TryParse(highestT1.Text, out val))
            {
               highestT1.BackColor = Color.Red;
               throw new Exception("Вы ввели текст!\nПрограмный комплекс принимает только числа!");
            }
            if (!Double.TryParse(highestT2.Text, out val))
            {
               highestT2.BackColor = Color.Red;
               throw new Exception("Вы ввели текст!\nПрограмный комплекс принимает только числа!");
            }
            if (Convert.ToDouble(lowerT1.Text) > Convert.ToDouble(highestT1.Text))
            {
               lowerT1.BackColor = Color.Red;
               highestT1.BackColor = Color.Red;
               throw new Exception("Нижняя граница меньше верхней!");
            }
            if (Convert.ToDouble(lowerT2.Text) > Convert.ToDouble(highestT2.Text))
            {
               lowerT2.BackColor = Color.Red;
               highestT2.BackColor = Color.Red;
               throw new Exception("Нижняя граница меньше верхней!");
            }
            if (!Double.TryParse(mixtureCons.Text, out val))
            {
               mixtureCons.BackColor = Color.Red;
               throw new Exception("Вы ввели текст!\nПрограмный комплекс принимает только числа!");
            }
            if (Convert.ToDouble(mixtureCons.Text) <= 0)
            {
               mixtureCons.BackColor = Color.Red;
               throw new Exception("Значение должно быть больше 0!");
            }
            if (!Double.TryParse(reactorPressure.Text, out val))
            {
               reactorPressure.BackColor = Color.Red;
               throw new Exception("Вы ввели текст!\nПрограмный комплекс принимает только числа!");
            }
            if (Convert.ToDouble(reactorPressure.Text) <= 0)
            {
               reactorPressure.BackColor = Color.Red;
               throw new Exception("Значение должно быть больше 0!");
            }
            if (!Double.TryParse(rotationalSpeed.Text, out val))
            {
               rotationalSpeed.BackColor = Color.Red;
               throw new Exception("Вы ввели текст!\nПрограмный комплекс принимает только числа!");
            }
            if (Convert.ToDouble(rotationalSpeed.Text) <= 0)
            {
               rotationalSpeed.BackColor = Color.Red;
               throw new Exception("Значение должно быть больше 0!");
            }
            return true;
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
            return false;
         }
      }
   }
}
