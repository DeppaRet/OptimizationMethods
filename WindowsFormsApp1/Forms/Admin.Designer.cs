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
         this.AddUser = new Guna.UI.WinForms.GunaButton();
         this.newTaskText = new System.Windows.Forms.RichTextBox();
         this.addTask = new Guna.UI.WinForms.GunaButton();
         this.label3 = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.label4 = new System.Windows.Forms.Label();
         this.taskName = new System.Windows.Forms.TextBox();
         this.label19 = new System.Windows.Forms.Label();
         this.highestT2 = new System.Windows.Forms.TextBox();
         this.lowerT2 = new System.Windows.Forms.TextBox();
         this.label21 = new System.Windows.Forms.Label();
         this.highestT1 = new System.Windows.Forms.TextBox();
         this.lowerT1 = new System.Windows.Forms.TextBox();
         this.secondLimitation = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.rotationalSpeed = new System.Windows.Forms.TextBox();
         this.label9 = new System.Windows.Forms.Label();
         this.reactorPressure = new System.Windows.Forms.TextBox();
         this.mixtureCons = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.costOnePiece = new System.Windows.Forms.TextBox();
         this.label7 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
         this.groupBox1.SuspendLayout();
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
         this.sqlCommand.Location = new System.Drawing.Point(417, 45);
         this.sqlCommand.Name = "sqlCommand";
         this.sqlCommand.Size = new System.Drawing.Size(476, 20);
         this.sqlCommand.TabIndex = 11;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label1.Location = new System.Drawing.Point(413, 22);
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
         this.dataTable.Size = new System.Drawing.Size(392, 432);
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
         this.makeRequest.Location = new System.Drawing.Point(769, 71);
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
            "Задачи"});
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
         this.researchMode.Location = new System.Drawing.Point(9, 509);
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
         // AddUser
         // 
         this.AddUser.AnimationHoverSpeed = 0.07F;
         this.AddUser.AnimationSpeed = 0.03F;
         this.AddUser.BackColor = System.Drawing.Color.Transparent;
         this.AddUser.BaseColor = System.Drawing.Color.Transparent;
         this.AddUser.BorderColor = System.Drawing.Color.Black;
         this.AddUser.DialogResult = System.Windows.Forms.DialogResult.None;
         this.AddUser.Enabled = false;
         this.AddUser.FocusedColor = System.Drawing.Color.Empty;
         this.AddUser.Font = new System.Drawing.Font("Segoe UI", 10F);
         this.AddUser.ForeColor = System.Drawing.Color.Black;
         this.AddUser.Image = ((System.Drawing.Image)(resources.GetObject("AddUser.Image")));
         this.AddUser.ImageSize = new System.Drawing.Size(20, 20);
         this.AddUser.Location = new System.Drawing.Point(163, 35);
         this.AddUser.Name = "AddUser";
         this.AddUser.OnHoverBaseColor = System.Drawing.Color.Silver;
         this.AddUser.OnHoverBorderColor = System.Drawing.Color.Black;
         this.AddUser.OnHoverForeColor = System.Drawing.Color.White;
         this.AddUser.OnHoverImage = null;
         this.AddUser.OnPressedColor = System.Drawing.Color.Black;
         this.AddUser.Size = new System.Drawing.Size(238, 30);
         this.AddUser.TabIndex = 18;
         this.AddUser.Text = "Добавить нового пользователя";
         this.AddUser.Visible = false;
         this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
         // 
         // newTaskText
         // 
         this.newTaskText.Location = new System.Drawing.Point(11, 247);
         this.newTaskText.Name = "newTaskText";
         this.newTaskText.Size = new System.Drawing.Size(469, 114);
         this.newTaskText.TabIndex = 19;
         this.newTaskText.Text = "";
         // 
         // addTask
         // 
         this.addTask.AnimationHoverSpeed = 0.07F;
         this.addTask.AnimationSpeed = 0.03F;
         this.addTask.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
         this.addTask.BorderColor = System.Drawing.Color.Black;
         this.addTask.DialogResult = System.Windows.Forms.DialogResult.None;
         this.addTask.FocusedColor = System.Drawing.Color.Empty;
         this.addTask.Font = new System.Drawing.Font("Segoe UI", 9F);
         this.addTask.ForeColor = System.Drawing.Color.White;
         this.addTask.Image = null;
         this.addTask.ImageSize = new System.Drawing.Size(20, 20);
         this.addTask.Location = new System.Drawing.Point(356, 367);
         this.addTask.Name = "addTask";
         this.addTask.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
         this.addTask.OnHoverBorderColor = System.Drawing.Color.Black;
         this.addTask.OnHoverForeColor = System.Drawing.Color.White;
         this.addTask.OnHoverImage = null;
         this.addTask.OnPressedColor = System.Drawing.Color.Black;
         this.addTask.Size = new System.Drawing.Size(124, 22);
         this.addTask.TabIndex = 20;
         this.addTask.Text = "Выполнить";
         this.addTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.addTask.Click += new System.EventHandler(this.addTask_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.BackColor = System.Drawing.Color.Transparent;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label3.Location = new System.Drawing.Point(8, 224);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(111, 20);
         this.label3.TabIndex = 21;
         this.label3.Text = "Текст задачи";
         // 
         // groupBox1
         // 
         this.groupBox1.BackColor = System.Drawing.Color.Transparent;
         this.groupBox1.Controls.Add(this.costOnePiece);
         this.groupBox1.Controls.Add(this.label7);
         this.groupBox1.Controls.Add(this.rotationalSpeed);
         this.groupBox1.Controls.Add(this.label9);
         this.groupBox1.Controls.Add(this.reactorPressure);
         this.groupBox1.Controls.Add(this.mixtureCons);
         this.groupBox1.Controls.Add(this.label6);
         this.groupBox1.Controls.Add(this.label8);
         this.groupBox1.Controls.Add(this.label5);
         this.groupBox1.Controls.Add(this.secondLimitation);
         this.groupBox1.Controls.Add(this.label19);
         this.groupBox1.Controls.Add(this.highestT2);
         this.groupBox1.Controls.Add(this.lowerT2);
         this.groupBox1.Controls.Add(this.label21);
         this.groupBox1.Controls.Add(this.highestT1);
         this.groupBox1.Controls.Add(this.lowerT1);
         this.groupBox1.Controls.Add(this.taskName);
         this.groupBox1.Controls.Add(this.label4);
         this.groupBox1.Controls.Add(this.addTask);
         this.groupBox1.Controls.Add(this.newTaskText);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.groupBox1.Location = new System.Drawing.Point(407, 108);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(486, 395);
         this.groupBox1.TabIndex = 22;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Добавить новую задачу";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.BackColor = System.Drawing.Color.Transparent;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label4.Location = new System.Drawing.Point(3, 26);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(83, 20);
         this.label4.TabIndex = 22;
         this.label4.Text = "Название";
         // 
         // taskName
         // 
         this.taskName.Location = new System.Drawing.Point(92, 23);
         this.taskName.Name = "taskName";
         this.taskName.Size = new System.Drawing.Size(122, 26);
         this.taskName.TabIndex = 23;
         // 
         // label19
         // 
         this.label19.AutoSize = true;
         this.label19.BackColor = System.Drawing.Color.Transparent;
         this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
         this.label19.Location = new System.Drawing.Point(59, 89);
         this.label19.Name = "label19";
         this.label19.Size = new System.Drawing.Size(68, 20);
         this.label19.TabIndex = 34;
         this.label19.Text = "<=T2<=\r\n";
         // 
         // highestT2
         // 
         this.highestT2.Location = new System.Drawing.Point(133, 88);
         this.highestT2.Name = "highestT2";
         this.highestT2.Size = new System.Drawing.Size(44, 26);
         this.highestT2.TabIndex = 33;
         this.highestT2.Text = "6";
         // 
         // lowerT2
         // 
         this.lowerT2.Location = new System.Drawing.Point(9, 89);
         this.lowerT2.Name = "lowerT2";
         this.lowerT2.Size = new System.Drawing.Size(44, 26);
         this.lowerT2.TabIndex = 32;
         this.lowerT2.Text = "-2";
         // 
         // label21
         // 
         this.label21.AutoSize = true;
         this.label21.BackColor = System.Drawing.Color.Transparent;
         this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
         this.label21.Location = new System.Drawing.Point(59, 56);
         this.label21.Name = "label21";
         this.label21.Size = new System.Drawing.Size(68, 20);
         this.label21.TabIndex = 31;
         this.label21.Text = "<=T1<=\r\n";
         // 
         // highestT1
         // 
         this.highestT1.Location = new System.Drawing.Point(133, 55);
         this.highestT1.Name = "highestT1";
         this.highestT1.Size = new System.Drawing.Size(44, 26);
         this.highestT1.TabIndex = 30;
         this.highestT1.Text = "3";
         // 
         // lowerT1
         // 
         this.lowerT1.Location = new System.Drawing.Point(9, 56);
         this.lowerT1.Name = "lowerT1";
         this.lowerT1.Size = new System.Drawing.Size(44, 26);
         this.lowerT1.TabIndex = 29;
         this.lowerT1.Text = "-3";
         // 
         // secondLimitation
         // 
         this.secondLimitation.Location = new System.Drawing.Point(243, 50);
         this.secondLimitation.Name = "secondLimitation";
         this.secondLimitation.Size = new System.Drawing.Size(220, 26);
         this.secondLimitation.TabIndex = 35;
         this.secondLimitation.Text = "T1 - T2 >= -3";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.BackColor = System.Drawing.Color.Transparent;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label5.Location = new System.Drawing.Point(239, 27);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(216, 20);
         this.label5.TabIndex = 36;
         this.label5.Text = "Ограничения второго рода";
         // 
         // rotationalSpeed
         // 
         this.rotationalSpeed.Location = new System.Drawing.Point(264, 200);
         this.rotationalSpeed.Name = "rotationalSpeed";
         this.rotationalSpeed.Size = new System.Drawing.Size(31, 26);
         this.rotationalSpeed.TabIndex = 42;
         this.rotationalSpeed.Text = "2";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.BackColor = System.Drawing.Color.Transparent;
         this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label9.Location = new System.Drawing.Point(8, 206);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(255, 16);
         this.label9.TabIndex = 41;
         this.label9.Text = "Скорость вращения мешалки (об/с) (N)\r\n";
         // 
         // reactorPressure
         // 
         this.reactorPressure.Location = new System.Drawing.Point(264, 168);
         this.reactorPressure.Name = "reactorPressure";
         this.reactorPressure.Size = new System.Drawing.Size(31, 26);
         this.reactorPressure.TabIndex = 40;
         this.reactorPressure.Text = "1";
         // 
         // mixtureCons
         // 
         this.mixtureCons.Location = new System.Drawing.Point(264, 134);
         this.mixtureCons.Name = "mixtureCons";
         this.mixtureCons.Size = new System.Drawing.Size(31, 26);
         this.mixtureCons.TabIndex = 39;
         this.mixtureCons.Text = "2";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.BackColor = System.Drawing.Color.Transparent;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label6.Location = new System.Drawing.Point(8, 174);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(206, 16);
         this.label6.TabIndex = 38;
         this.label6.Text = "Давление в реакторе (КПа) (A)";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.BackColor = System.Drawing.Color.Transparent;
         this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label8.Location = new System.Drawing.Point(8, 140);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(243, 16);
         this.label8.TabIndex = 37;
         this.label8.Text = "Расход реакционной смеси (кг/ч) (G)";
         // 
         // costOnePiece
         // 
         this.costOnePiece.Location = new System.Drawing.Point(411, 83);
         this.costOnePiece.Name = "costOnePiece";
         this.costOnePiece.Size = new System.Drawing.Size(52, 26);
         this.costOnePiece.TabIndex = 51;
         this.costOnePiece.Text = "100";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.BackColor = System.Drawing.Color.Transparent;
         this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.label7.Location = new System.Drawing.Point(240, 88);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(171, 17);
         this.label7.TabIndex = 50;
         this.label7.Text = "Стоимость 1 кг продукта";
         // 
         // Admin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.background;
         this.ClientSize = new System.Drawing.Size(905, 544);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.AddUser);
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
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
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
      private Guna.UI.WinForms.GunaButton AddUser;
      private System.Windows.Forms.Label label3;
      private Guna.UI.WinForms.GunaButton addTask;
      private System.Windows.Forms.RichTextBox newTaskText;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox taskName;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label19;
      private System.Windows.Forms.TextBox highestT2;
      private System.Windows.Forms.TextBox lowerT2;
      private System.Windows.Forms.Label label21;
      private System.Windows.Forms.TextBox highestT1;
      private System.Windows.Forms.TextBox lowerT1;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox secondLimitation;
      private System.Windows.Forms.TextBox rotationalSpeed;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.TextBox reactorPressure;
      private System.Windows.Forms.TextBox mixtureCons;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.TextBox costOnePiece;
      private System.Windows.Forms.Label label7;
   }
}