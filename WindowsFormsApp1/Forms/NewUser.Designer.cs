namespace WindowsFormsApp1.Forms
{
   partial class NewUser
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
         this.minimizeButton = new Guna.UI.WinForms.GunaButton();
         this.closeButton = new Guna.UI.WinForms.GunaButton();
         this.AddUser = new Guna.UI.WinForms.GunaButton();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.Password = new System.Windows.Forms.TextBox();
         this.Login = new System.Windows.Forms.TextBox();
         this.id = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.UserRole = new System.Windows.Forms.ComboBox();
         this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
         this.SuspendLayout();
         // 
         // minimizeButton
         // 
         this.minimizeButton.AnimationHoverSpeed = 0.07F;
         this.minimizeButton.AnimationSpeed = 0.03F;
         this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
         this.minimizeButton.BaseColor = System.Drawing.Color.Transparent;
         this.minimizeButton.BorderColor = System.Drawing.Color.Black;
         this.minimizeButton.DialogResult = System.Windows.Forms.DialogResult.None;
         this.minimizeButton.FocusedColor = System.Drawing.Color.Empty;
         this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
         this.minimizeButton.ForeColor = System.Drawing.Color.White;
         this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
         this.minimizeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.minimizeButton.ImageSize = new System.Drawing.Size(15, 15);
         this.minimizeButton.Location = new System.Drawing.Point(118, -2);
         this.minimizeButton.Name = "minimizeButton";
         this.minimizeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.minimizeButton.OnHoverBorderColor = System.Drawing.Color.Black;
         this.minimizeButton.OnHoverForeColor = System.Drawing.Color.White;
         this.minimizeButton.OnHoverImage = null;
         this.minimizeButton.OnPressedColor = System.Drawing.Color.Black;
         this.minimizeButton.Size = new System.Drawing.Size(30, 30);
         this.minimizeButton.TabIndex = 12;
         this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
         // 
         // closeButton
         // 
         this.closeButton.AnimationHoverSpeed = 0.07F;
         this.closeButton.AnimationSpeed = 0.03F;
         this.closeButton.BackColor = System.Drawing.Color.Transparent;
         this.closeButton.BaseColor = System.Drawing.Color.Transparent;
         this.closeButton.BorderColor = System.Drawing.Color.Black;
         this.closeButton.DialogResult = System.Windows.Forms.DialogResult.None;
         this.closeButton.FocusedColor = System.Drawing.Color.Empty;
         this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
         this.closeButton.ForeColor = System.Drawing.Color.White;
         this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
         this.closeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.closeButton.ImageSize = new System.Drawing.Size(15, 15);
         this.closeButton.Location = new System.Drawing.Point(150, -2);
         this.closeButton.Name = "closeButton";
         this.closeButton.OnHoverBaseColor = System.Drawing.Color.Red;
         this.closeButton.OnHoverBorderColor = System.Drawing.Color.Black;
         this.closeButton.OnHoverForeColor = System.Drawing.Color.White;
         this.closeButton.OnHoverImage = null;
         this.closeButton.OnPressedColor = System.Drawing.Color.Black;
         this.closeButton.Size = new System.Drawing.Size(30, 30);
         this.closeButton.TabIndex = 11;
         this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
         // 
         // AddUser
         // 
         this.AddUser.AnimationHoverSpeed = 0.07F;
         this.AddUser.AnimationSpeed = 0.03F;
         this.AddUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
         this.AddUser.BorderColor = System.Drawing.Color.Black;
         this.AddUser.DialogResult = System.Windows.Forms.DialogResult.None;
         this.AddUser.FocusedColor = System.Drawing.Color.Empty;
         this.AddUser.Font = new System.Drawing.Font("Segoe UI", 9F);
         this.AddUser.ForeColor = System.Drawing.Color.White;
         this.AddUser.Image = null;
         this.AddUser.ImageSize = new System.Drawing.Size(20, 20);
         this.AddUser.Location = new System.Drawing.Point(75, 141);
         this.AddUser.Name = "AddUser";
         this.AddUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
         this.AddUser.OnHoverBorderColor = System.Drawing.Color.Black;
         this.AddUser.OnHoverForeColor = System.Drawing.Color.White;
         this.AddUser.OnHoverImage = null;
         this.AddUser.OnPressedColor = System.Drawing.Color.Black;
         this.AddUser.Size = new System.Drawing.Size(96, 25);
         this.AddUser.TabIndex = 13;
         this.AddUser.Text = "Добавить";
         this.AddUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label1.Location = new System.Drawing.Point(12, 34);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(19, 16);
         this.label1.TabIndex = 14;
         this.label1.Text = "id";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.Transparent;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label2.Location = new System.Drawing.Point(12, 62);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(47, 16);
         this.label2.TabIndex = 15;
         this.label2.Text = "Логин";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.BackColor = System.Drawing.Color.Transparent;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label3.Location = new System.Drawing.Point(12, 91);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(57, 16);
         this.label3.TabIndex = 16;
         this.label3.Text = "Пароль";
         // 
         // Password
         // 
         this.Password.Location = new System.Drawing.Point(75, 87);
         this.Password.Name = "Password";
         this.Password.Size = new System.Drawing.Size(96, 20);
         this.Password.TabIndex = 17;
         // 
         // Login
         // 
         this.Login.Location = new System.Drawing.Point(75, 58);
         this.Login.Name = "Login";
         this.Login.Size = new System.Drawing.Size(96, 20);
         this.Login.TabIndex = 18;
         // 
         // id
         // 
         this.id.Location = new System.Drawing.Point(75, 32);
         this.id.Name = "id";
         this.id.Size = new System.Drawing.Size(96, 20);
         this.id.TabIndex = 19;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.BackColor = System.Drawing.Color.Transparent;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label4.Location = new System.Drawing.Point(12, 118);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(40, 16);
         this.label4.TabIndex = 20;
         this.label4.Text = "Роль";
         // 
         // UserRole
         // 
         this.UserRole.FormattingEnabled = true;
         this.UserRole.Items.AddRange(new object[] {
            "Администратор",
            "Исследователь"});
         this.UserRole.Location = new System.Drawing.Point(75, 114);
         this.UserRole.Name = "UserRole";
         this.UserRole.Size = new System.Drawing.Size(96, 21);
         this.UserRole.TabIndex = 21;
         // 
         // gunaDragControl1
         // 
         this.gunaDragControl1.TargetControl = this;
         // 
         // NewUser
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.background;
         this.ClientSize = new System.Drawing.Size(179, 178);
         this.Controls.Add(this.UserRole);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.id);
         this.Controls.Add(this.Login);
         this.Controls.Add(this.Password);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.AddUser);
         this.Controls.Add(this.minimizeButton);
         this.Controls.Add(this.closeButton);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "NewUser";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "NewUser";
         this.Load += new System.EventHandler(this.NewUser_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private Guna.UI.WinForms.GunaButton minimizeButton;
      private Guna.UI.WinForms.GunaButton closeButton;
      private Guna.UI.WinForms.GunaButton AddUser;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox Password;
      private System.Windows.Forms.TextBox Login;
      private System.Windows.Forms.TextBox id;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.ComboBox UserRole;
      private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
   }
}