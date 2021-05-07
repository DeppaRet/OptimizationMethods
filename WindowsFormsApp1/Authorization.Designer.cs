namespace WindowsFormsApp1
{
   partial class Authorization
   {
      /// <summary>
      /// Обязательная переменная конструктора.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Освободить все используемые ресурсы.
      /// </summary>
      /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Код, автоматически созданный конструктором форм Windows

      /// <summary>
      /// Требуемый метод для поддержки конструктора — не изменяйте 
      /// содержимое этого метода с помощью редактора кода.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
         this.name = new System.Windows.Forms.TextBox();
         this.password = new System.Windows.Forms.TextBox();
         this.loginButton = new Guna.UI.WinForms.GunaCircleButton();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
         this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
         this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // name
         // 
         this.name.Location = new System.Drawing.Point(183, 63);
         this.name.Name = "name";
         this.name.Size = new System.Drawing.Size(167, 20);
         this.name.TabIndex = 1;
         // 
         // password
         // 
         this.password.Location = new System.Drawing.Point(183, 111);
         this.password.Name = "password";
         this.password.Size = new System.Drawing.Size(167, 20);
         this.password.TabIndex = 2;
         // 
         // loginButton
         // 
         this.loginButton.AnimationHoverSpeed = 0.07F;
         this.loginButton.AnimationSpeed = 0.03F;
         this.loginButton.BackColor = System.Drawing.Color.Transparent;
         this.loginButton.BaseColor = System.Drawing.Color.MediumPurple;
         this.loginButton.BorderColor = System.Drawing.Color.Black;
         this.loginButton.DialogResult = System.Windows.Forms.DialogResult.None;
         this.loginButton.FocusedColor = System.Drawing.Color.Empty;
         this.loginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
         this.loginButton.ForeColor = System.Drawing.Color.White;
         this.loginButton.Image = null;
         this.loginButton.ImageSize = new System.Drawing.Size(52, 52);
         this.loginButton.Location = new System.Drawing.Point(230, 142);
         this.loginButton.Name = "loginButton";
         this.loginButton.OnHoverBaseColor = System.Drawing.Color.Lime;
         this.loginButton.OnHoverBorderColor = System.Drawing.Color.Black;
         this.loginButton.OnHoverForeColor = System.Drawing.Color.White;
         this.loginButton.OnHoverImage = null;
         this.loginButton.OnPressedColor = System.Drawing.Color.Black;
         this.loginButton.Size = new System.Drawing.Size(120, 36);
         this.loginButton.TabIndex = 3;
         this.loginButton.Text = "Войти";
         this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(12, 30);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(150, 150);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 4;
         this.pictureBox1.TabStop = false;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label1.Location = new System.Drawing.Point(183, 40);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(59, 20);
         this.label1.TabIndex = 5;
         this.label1.Text = "Логин:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.Transparent;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label2.Location = new System.Drawing.Point(183, 88);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(71, 20);
         this.label2.TabIndex = 6;
         this.label2.Text = "Пароль:";
         // 
         // gunaButton2
         // 
         this.gunaButton2.AnimationHoverSpeed = 0.07F;
         this.gunaButton2.AnimationSpeed = 0.03F;
         this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
         this.gunaButton2.BaseColor = System.Drawing.Color.Transparent;
         this.gunaButton2.BorderColor = System.Drawing.Color.Black;
         this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
         this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
         this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
         this.gunaButton2.ForeColor = System.Drawing.Color.White;
         this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
         this.gunaButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.gunaButton2.ImageSize = new System.Drawing.Size(15, 15);
         this.gunaButton2.Location = new System.Drawing.Point(296, 0);
         this.gunaButton2.Name = "gunaButton2";
         this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
         this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
         this.gunaButton2.OnHoverImage = null;
         this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
         this.gunaButton2.Size = new System.Drawing.Size(30, 30);
         this.gunaButton2.TabIndex = 8;
         this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
         // 
         // gunaButton1
         // 
         this.gunaButton1.AnimationHoverSpeed = 0.07F;
         this.gunaButton1.AnimationSpeed = 0.03F;
         this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
         this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
         this.gunaButton1.BorderColor = System.Drawing.Color.Black;
         this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
         this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
         this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
         this.gunaButton1.ForeColor = System.Drawing.Color.White;
         this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
         this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.gunaButton1.ImageSize = new System.Drawing.Size(15, 15);
         this.gunaButton1.Location = new System.Drawing.Point(329, 0);
         this.gunaButton1.Name = "gunaButton1";
         this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Red;
         this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
         this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
         this.gunaButton1.OnHoverImage = null;
         this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
         this.gunaButton1.Size = new System.Drawing.Size(30, 30);
         this.gunaButton1.TabIndex = 7;
         this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
         // 
         // gunaDragControl1
         // 
         this.gunaDragControl1.TargetControl = this;
         // 
         // Authorization
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
         this.ClientSize = new System.Drawing.Size(358, 192);
         this.Controls.Add(this.gunaButton2);
         this.Controls.Add(this.gunaButton1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.loginButton);
         this.Controls.Add(this.password);
         this.Controls.Add(this.name);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "Authorization";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Авторизация";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.TextBox name;
      private System.Windows.Forms.TextBox password;
      private Guna.UI.WinForms.GunaCircleButton loginButton;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private Guna.UI.WinForms.GunaButton gunaButton2;
      private Guna.UI.WinForms.GunaButton gunaButton1;
      private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
   }
}

