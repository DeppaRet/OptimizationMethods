using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
   public partial class NewUser : Form
   {
      static DataSet ds = new DataSet();
      static SQLiteDataAdapter adapter = new SQLiteDataAdapter();
      public NewUser()
      {
         InitializeComponent();
      }

      private void NewUser_Load(object sender, EventArgs e)
      {

      }

      private void AddUser_Click(object sender, EventArgs e)
      {
         string loginUser = Login.Text;
         string passwordUser = Password.Text;
         string choosenRole = UserRole.Text;
         if (choosenRole == "Администратор")
         {
            choosenRole = "admin";
         }
         else
         {
            choosenRole = "research";
         }
         string cmd = "Insert into users (login, password, role) values ('" + loginUser + "','" + passwordUser + "','"+ choosenRole +"')";
         openDatabase(cmd);
         MessageBox.Show("Пользователь добавлен!","Успех", MessageBoxButtons.OK);
      }

      public void openDatabase(string cmd)
      {
         try
         {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source = users.db"))
            {
               ds = requestAnswer(cmd);
            }
         }
         catch (Exception e)
         {
            MessageBox.Show(e.Message);
            throw;
         }
      }

      public static DataSet requestAnswer(string cmd)
      {
         using (SQLiteConnection Connect = new SQLiteConnection("Data Source = users.db"))
         {
            Connect.Open();
            adapter = new SQLiteDataAdapter(cmd, Connect);
            Connect.Close();
            ds = new DataSet();
            adapter.Fill(ds);
            return ds;
         }
      }

      private void closeButton_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void minimizeButton_Click(object sender, EventArgs e)
      {
         this.WindowState = FormWindowState.Minimized;
      }
   }
}
