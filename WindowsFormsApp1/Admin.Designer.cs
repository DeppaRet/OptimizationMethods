namespace WindowsFormsApp1
{
   partial class Admin
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
         this.closeButton = new Guna.UI.WinForms.GunaButton();
         this.minimizeButton = new Guna.UI.WinForms.GunaButton();
         this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
         this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
         this.sqlCommand = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.dataTable = new System.Windows.Forms.DataGridView();
         this.makeRequest = new Guna.UI.WinForms.GunaButton();
         this.currentDatabase = new Guna.UI.WinForms.GunaComboBox();
         this.label2 = new System.Windows.Forms.Label();
         this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
         this.researchMode = new Guna.UI.WinForms.GunaButton();
         ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
         this.SuspendLayout();
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
         this.closeButton.Location = new System.Drawing.Point(1030, 0);
         this.closeButton.Name = "closeButton";
         this.closeButton.OnHoverBaseColor = System.Drawing.Color.Red;
         this.closeButton.OnHoverBorderColor = System.Drawing.Color.Black;
         this.closeButton.OnHoverForeColor = System.Drawing.Color.White;
         this.closeButton.OnHoverImage = null;
         this.closeButton.OnPressedColor = System.Drawing.Color.Black;
         this.closeButton.Size = new System.Drawing.Size(30, 30);
         this.closeButton.TabIndex = 0;
         this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
         this.minimizeButton.Location = new System.Drawing.Point(994, 0);
         this.minimizeButton.Name = "minimizeButton";
         this.minimizeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.minimizeButton.OnHoverBorderColor = System.Drawing.Color.Black;
         this.minimizeButton.OnHoverForeColor = System.Drawing.Color.White;
         this.minimizeButton.OnHoverImage = null;
         this.minimizeButton.OnPressedColor = System.Drawing.Color.Black;
         this.minimizeButton.Size = new System.Drawing.Size(30, 30);
         this.minimizeButton.TabIndex = 1;
         this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
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
         this.gunaButton2.Location = new System.Drawing.Point(840, 0);
         this.gunaButton2.Name = "gunaButton2";
         this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
         this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
         this.gunaButton2.OnHoverImage = null;
         this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
         this.gunaButton2.Size = new System.Drawing.Size(30, 30);
         this.gunaButton2.TabIndex = 10;
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
         this.gunaButton1.Location = new System.Drawing.Point(876, 0);
         this.gunaButton1.Name = "gunaButton1";
         this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Red;
         this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
         this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
         this.gunaButton1.OnHoverImage = null;
         this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
         this.gunaButton1.Size = new System.Drawing.Size(30, 30);
         this.gunaButton1.TabIndex = 9;
         this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
         // 
         // sqlCommand
         // 
         this.sqlCommand.Location = new System.Drawing.Point(472, 94);
         this.sqlCommand.Name = "sqlCommand";
         this.sqlCommand.Size = new System.Drawing.Size(421, 20);
         this.sqlCommand.TabIndex = 11;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label1.Location = new System.Drawing.Point(468, 71);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(100, 20);
         this.label1.TabIndex = 12;
         this.label1.Text = "SQL Запрос";
         // 
         // dataTable
         // 
         this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataTable.Location = new System.Drawing.Point(9, 71);
         this.dataTable.Name = "dataTable";
         this.dataTable.Size = new System.Drawing.Size(457, 432);
         this.dataTable.TabIndex = 13;
         // 
         // makeRequest
         // 
         this.makeRequest.AnimationHoverSpeed = 0.07F;
         this.makeRequest.AnimationSpeed = 0.03F;
         this.makeRequest.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
         this.makeRequest.BorderColor = System.Drawing.Color.Black;
         this.makeRequest.DialogResult = System.Windows.Forms.DialogResult.None;
         this.makeRequest.Enabled = false;
         this.makeRequest.FocusedColor = System.Drawing.Color.Empty;
         this.makeRequest.Font = new System.Drawing.Font("Segoe UI", 9F);
         this.makeRequest.ForeColor = System.Drawing.Color.White;
         this.makeRequest.Image = null;
         this.makeRequest.ImageSize = new System.Drawing.Size(20, 20);
         this.makeRequest.Location = new System.Drawing.Point(769, 120);
         this.makeRequest.Name = "makeRequest";
         this.makeRequest.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
         this.makeRequest.OnHoverBorderColor = System.Drawing.Color.Black;
         this.makeRequest.OnHoverForeColor = System.Drawing.Color.White;
         this.makeRequest.OnHoverImage = null;
         this.makeRequest.OnPressedColor = System.Drawing.Color.Black;
         this.makeRequest.Size = new System.Drawing.Size(124, 22);
         this.makeRequest.TabIndex = 14;
         this.makeRequest.Text = "Выполнить";
         this.makeRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.makeRequest.Click += new System.EventHandler(this.makeRequest_Click);
         // 
         // currentDatabase
         // 
         this.currentDatabase.BackColor = System.Drawing.Color.Transparent;
         this.currentDatabase.BaseColor = System.Drawing.Color.White;
         this.currentDatabase.BorderColor = System.Drawing.Color.Silver;
         this.currentDatabase.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
         this.currentDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.currentDatabase.FocusedColor = System.Drawing.Color.Empty;
         this.currentDatabase.Font = new System.Drawing.Font("Segoe UI", 10F);
         this.currentDatabase.ForeColor = System.Drawing.Color.Black;
         this.currentDatabase.FormattingEnabled = true;
         this.currentDatabase.Items.AddRange(new object[] {
            "Пользователи",
            "Задачи",
            "Методы"});
         this.currentDatabase.Location = new System.Drawing.Point(9, 39);
         this.currentDatabase.Name = "currentDatabase";
         this.currentDatabase.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
         this.currentDatabase.OnHoverItemForeColor = System.Drawing.Color.White;
         this.currentDatabase.Size = new System.Drawing.Size(151, 26);
         this.currentDatabase.TabIndex = 15;
         this.currentDatabase.SelectedIndexChanged += new System.EventHandler(this.currentDatabase_SelectedIndexChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.Transparent;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label2.Location = new System.Drawing.Point(5, 16);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(110, 20);
         this.label2.TabIndex = 16;
         this.label2.Text = "База данных:";
         // 
         // gunaDragControl1
         // 
         this.gunaDragControl1.TargetControl = this;
         // 
         // researchMode
         // 
         this.researchMode.AnimationHoverSpeed = 0.07F;
         this.researchMode.AnimationSpeed = 0.03F;
         this.researchMode.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
         this.researchMode.BorderColor = System.Drawing.Color.Black;
         this.researchMode.DialogResult = System.Windows.Forms.DialogResult.None;
         this.researchMode.FocusedColor = System.Drawing.Color.Empty;
         this.researchMode.Font = new System.Drawing.Font("Segoe UI", 9F);
         this.researchMode.ForeColor = System.Drawing.Color.White;
         this.researchMode.Image = null;
         this.researchMode.ImageSize = new System.Drawing.Size(20, 20);
         this.researchMode.Location = new System.Drawing.Point(760, 479);
         this.researchMode.Name = "researchMode";
         this.researchMode.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
         this.researchMode.OnHoverBorderColor = System.Drawing.Color.Black;
         this.researchMode.OnHoverForeColor = System.Drawing.Color.White;
         this.researchMode.OnHoverImage = null;
         this.researchMode.OnPressedColor = System.Drawing.Color.Black;
         this.researchMode.Size = new System.Drawing.Size(133, 24);
         this.researchMode.TabIndex = 17;
         this.researchMode.Text = "Режим исследователя";
         this.researchMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.researchMode.Click += new System.EventHandler(this.researchMode_Click);
         // 
         // Admin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.background;
         this.ClientSize = new System.Drawing.Size(905, 515);
         this.Controls.Add(this.researchMode);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.currentDatabase);
         this.Controls.Add(this.makeRequest);
         this.Controls.Add(this.dataTable);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.sqlCommand);
         this.Controls.Add(this.gunaButton2);
         this.Controls.Add(this.gunaButton1);
         this.Controls.Add(this.minimizeButton);
         this.Controls.Add(this.closeButton);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "Admin";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Admin";
         ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private Guna.UI.WinForms.GunaButton closeButton;
      private Guna.UI.WinForms.GunaButton minimizeButton;
      private Guna.UI.WinForms.GunaButton gunaButton2;
      private Guna.UI.WinForms.GunaButton gunaButton1;
      private System.Windows.Forms.TextBox sqlCommand;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.DataGridView dataTable;
      private Guna.UI.WinForms.GunaButton makeRequest;
      private Guna.UI.WinForms.GunaComboBox currentDatabase;
      private System.Windows.Forms.Label label2;
      private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
      private Guna.UI.WinForms.GunaButton researchMode;
   }
}