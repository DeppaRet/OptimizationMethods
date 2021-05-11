using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;



namespace WindowsFormsApp1
{
   public partial class Authorization : Form
   {
      static DataSet ds = new DataSet();
      DataTable table = new DataTable();
      static SQLiteDataAdapter adapter = new SQLiteDataAdapter();

      public Authorization()
      {
         InitializeComponent();
      }

      private void loginButton_Click(object sender, EventArgs e)
      {
         using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=users.db"))
         {
            connection.Open();
            string role = "";
            string login = name.Text;
            string password = this.password.Text;
            SQLiteCommand command = connection.CreateCommand();
            command.Connection = connection;
            command.CommandText =
               "Select role from users where login = '" + login + "' AND password = '" + password + "'";
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
               if (reader.HasRows) // если есть данные
               {
                  while (reader.Read())
                  {
                     var dbRole = reader.GetValue(0);
                     role = dbRole.ToString();
                     break;
                  }
               }
            }

            connection.Close();
            if (role == "admin")
            {
               Admin formAdmin = new Admin();
               formAdmin.Show();
            }
            else if (role == "research")
            {
               Researcher formResearcher = new Researcher();
               formResearcher.Show();
            }
            else
            {
               MessageBox.Show("Ошибка! Логин или пароль введен неверно!", "Ошибка", MessageBoxButtons.OK);
            }


         }
      }


      private void gunaButton1_Click(object sender, EventArgs e)
      {
        this.Close();
      }

      private void gunaButton2_Click(object sender, EventArgs e)
      {
         this.WindowState = FormWindowState.Minimized;
      }
   }
}

