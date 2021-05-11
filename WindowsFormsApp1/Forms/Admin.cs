using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
   public partial class Admin : Form
   {
      DataTable table = new DataTable();
      static DataSet ds = new DataSet();
      static SQLiteDataAdapter adapter = new SQLiteDataAdapter();
      static string choosenDB = "";
      public Admin()
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

      private void gunaButton1_Click(object sender, EventArgs e) //close
      {
         this.Close();
      }

      private void gunaButton2_Click(object sender, EventArgs e) //minimize
      {
         this.WindowState = FormWindowState.Minimized;
      }

      private void makeRequest_Click(object sender, EventArgs e)
      {
         try
         {
            string command = sqlCommand.Text;
            requestAnswer(command);
            command = "SELECT * FROM users"; //нужна текущая таблица 
            openDatabase(command);
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void currentDatabase_SelectedIndexChanged(object sender, EventArgs e)
      {
         makeRequest.Enabled = true;
         string command = " ";
         if (currentDatabase.Text == "Пользователи")
         {
            AddUser.Visible = true;
            AddUser.Enabled = true;
            try
            {
               command = "SELECT * FROM users";
               choosenDB = "users.db";
               openDatabase(command);
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
         }
         else
         {
            AddUser.Visible = false;
            AddUser.Enabled = false;
         }
      }

      public void openDatabase(string cmd)
      {
         using (SQLiteConnection Connect = new SQLiteConnection("Data Source = users.db")) 
         {
            ds = requestAnswer(cmd);
            dataTable.DataSource = ds.Tables[0];
            dataTable.Columns["id"].ReadOnly = true;
         }
      }

      public static DataSet requestAnswer(string cmd)
      {
         using (SQLiteConnection Connect = new SQLiteConnection("Data Source ="+ choosenDB)) 
         {
            Connect.Open();
            adapter = new SQLiteDataAdapter(cmd, Connect);
            Connect.Close();
            ds = new DataSet();
            adapter.Fill(ds);
            return ds;
         }
      }

      private void researchMode_Click(object sender, EventArgs e)
      {
         Researcher researcher = new Researcher();
         researcher.Show();
      }

      private void AddUser_Click(object sender, EventArgs e)
      {
        NewUser newUser = new NewUser();
        newUser.Show();
      }
   }
}
