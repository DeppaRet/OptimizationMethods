namespace WindowsFormsApp1
{
   partial class Researcher
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Researcher));
         this.minimizeButton = new Guna.UI.WinForms.GunaButton();
         this.closeButton = new Guna.UI.WinForms.GunaButton();
         this.task = new Guna.UI.WinForms.GunaComboBox();
         this.label1 = new System.Windows.Forms.Label();
         this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.muText = new System.Windows.Forms.TextBox();
         this.label7 = new System.Windows.Forms.Label();
         this.betaText = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.alphaText = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.rotationalSpeed = new System.Windows.Forms.TextBox();
         this.label9 = new System.Windows.Forms.Label();
         this.reactorPressure = new System.Windows.Forms.TextBox();
         this.mixtureCons = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.amountOfProductButton = new Guna.UI.WinForms.GunaButton();
         this.label11 = new System.Windows.Forms.Label();
         this.calculatedAmount = new System.Windows.Forms.TextBox();
         this.totalCost = new System.Windows.Forms.TextBox();
         this.label12 = new System.Windows.Forms.Label();
         this.costOnePiece = new System.Windows.Forms.TextBox();
         this.label13 = new System.Windows.Forms.Label();
         this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
         this.choosenTask = new System.Windows.Forms.RichTextBox();
         this.label18 = new System.Windows.Forms.Label();
         this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
         this.groupBox4 = new System.Windows.Forms.GroupBox();
         this.label19 = new System.Windows.Forms.Label();
         this.highestT2 = new System.Windows.Forms.TextBox();
         this.lowerT2 = new System.Windows.Forms.TextBox();
         this.label21 = new System.Windows.Forms.Label();
         this.highestT1 = new System.Windows.Forms.TextBox();
         this.lowerT1 = new System.Windows.Forms.TextBox();
         this.label20 = new System.Windows.Forms.Label();
         this.groupBox5 = new System.Windows.Forms.GroupBox();
         this.secondLimitation = new System.Windows.Forms.TextBox();
         this.label16 = new System.Windows.Forms.Label();
         this.accuracyValue = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.groupBox2.SuspendLayout();
         this.groupBox3.SuspendLayout();
         this.groupBox4.SuspendLayout();
         this.groupBox5.SuspendLayout();
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
         this.minimizeButton.Location = new System.Drawing.Point(975, -1);
         this.minimizeButton.Name = "minimizeButton";
         this.minimizeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.minimizeButton.OnHoverBorderColor = System.Drawing.Color.Black;
         this.minimizeButton.OnHoverForeColor = System.Drawing.Color.White;
         this.minimizeButton.OnHoverImage = null;
         this.minimizeButton.OnPressedColor = System.Drawing.Color.Black;
         this.minimizeButton.Size = new System.Drawing.Size(30, 30);
         this.minimizeButton.TabIndex = 3;
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
         this.closeButton.Location = new System.Drawing.Point(1011, -1);
         this.closeButton.Name = "closeButton";
         this.closeButton.OnHoverBaseColor = System.Drawing.Color.Red;
         this.closeButton.OnHoverBorderColor = System.Drawing.Color.Black;
         this.closeButton.OnHoverForeColor = System.Drawing.Color.White;
         this.closeButton.OnHoverImage = null;
         this.closeButton.OnPressedColor = System.Drawing.Color.Black;
         this.closeButton.Size = new System.Drawing.Size(30, 30);
         this.closeButton.TabIndex = 2;
         this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
         // 
         // task
         // 
         this.task.BackColor = System.Drawing.Color.Transparent;
         this.task.BaseColor = System.Drawing.Color.White;
         this.task.BorderColor = System.Drawing.Color.Silver;
         this.task.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
         this.task.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.task.FocusedColor = System.Drawing.Color.Empty;
         this.task.Font = new System.Drawing.Font("Segoe UI", 10F);
         this.task.ForeColor = System.Drawing.Color.Black;
         this.task.FormattingEnabled = true;
         this.task.Location = new System.Drawing.Point(12, 57);
         this.task.Name = "task";
         this.task.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
         this.task.OnHoverItemForeColor = System.Drawing.Color.White;
         this.task.Size = new System.Drawing.Size(193, 26);
         this.task.TabIndex = 4;
         this.task.SelectedIndexChanged += new System.EventHandler(this.task_SelectedIndexChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label1.Location = new System.Drawing.Point(8, 34);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(197, 20);
         this.label1.TabIndex = 5;
         this.label1.Text = "Список доступных задач";
         // 
         // gunaDragControl1
         // 
         this.gunaDragControl1.TargetControl = this;
         // 
         // groupBox2
         // 
         this.groupBox2.BackColor = System.Drawing.Color.Transparent;
         this.groupBox2.Controls.Add(this.muText);
         this.groupBox2.Controls.Add(this.label7);
         this.groupBox2.Controls.Add(this.betaText);
         this.groupBox2.Controls.Add(this.label6);
         this.groupBox2.Controls.Add(this.alphaText);
         this.groupBox2.Controls.Add(this.label5);
         this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.groupBox2.Location = new System.Drawing.Point(453, 139);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(232, 66);
         this.groupBox2.TabIndex = 7;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Нормирующие множители";
         // 
         // muText
         // 
         this.muText.Location = new System.Drawing.Point(174, 27);
         this.muText.Name = "muText";
         this.muText.ReadOnly = true;
         this.muText.Size = new System.Drawing.Size(43, 26);
         this.muText.TabIndex = 13;
         this.muText.Text = "1";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.BackColor = System.Drawing.Color.Transparent;
         this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label7.Location = new System.Drawing.Point(152, 30);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(17, 20);
         this.label7.TabIndex = 12;
         this.label7.Text = "µ";
         // 
         // betaText
         // 
         this.betaText.Location = new System.Drawing.Point(100, 27);
         this.betaText.Name = "betaText";
         this.betaText.ReadOnly = true;
         this.betaText.Size = new System.Drawing.Size(43, 26);
         this.betaText.TabIndex = 11;
         this.betaText.Text = "1";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.BackColor = System.Drawing.Color.Transparent;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label6.Location = new System.Drawing.Point(78, 30);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(18, 20);
         this.label6.TabIndex = 10;
         this.label6.Text = "β";
         // 
         // alphaText
         // 
         this.alphaText.Location = new System.Drawing.Point(27, 27);
         this.alphaText.Name = "alphaText";
         this.alphaText.ReadOnly = true;
         this.alphaText.Size = new System.Drawing.Size(43, 26);
         this.alphaText.TabIndex = 8;
         this.alphaText.Text = "1";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.BackColor = System.Drawing.Color.Transparent;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label5.Location = new System.Drawing.Point(5, 30);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(18, 20);
         this.label5.TabIndex = 6;
         this.label5.Text = "α";
         // 
         // groupBox3
         // 
         this.groupBox3.BackColor = System.Drawing.Color.Transparent;
         this.groupBox3.Controls.Add(this.rotationalSpeed);
         this.groupBox3.Controls.Add(this.label9);
         this.groupBox3.Controls.Add(this.reactorPressure);
         this.groupBox3.Controls.Add(this.mixtureCons);
         this.groupBox3.Controls.Add(this.label4);
         this.groupBox3.Controls.Add(this.label8);
         this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.groupBox3.Location = new System.Drawing.Point(694, 112);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(343, 135);
         this.groupBox3.TabIndex = 8;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "Условия процесса";
         // 
         // rotationalSpeed
         // 
         this.rotationalSpeed.Location = new System.Drawing.Point(262, 93);
         this.rotationalSpeed.Name = "rotationalSpeed";
         this.rotationalSpeed.Size = new System.Drawing.Size(75, 26);
         this.rotationalSpeed.TabIndex = 11;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.BackColor = System.Drawing.Color.Transparent;
         this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label9.Location = new System.Drawing.Point(6, 99);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(255, 16);
         this.label9.TabIndex = 10;
         this.label9.Text = "Скорость вращения мешалки (об/с) (N)\r\n";
         // 
         // reactorPressure
         // 
         this.reactorPressure.Location = new System.Drawing.Point(262, 61);
         this.reactorPressure.Name = "reactorPressure";
         this.reactorPressure.Size = new System.Drawing.Size(75, 26);
         this.reactorPressure.TabIndex = 9;
         // 
         // mixtureCons
         // 
         this.mixtureCons.Location = new System.Drawing.Point(262, 27);
         this.mixtureCons.Name = "mixtureCons";
         this.mixtureCons.Size = new System.Drawing.Size(75, 26);
         this.mixtureCons.TabIndex = 8;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.BackColor = System.Drawing.Color.Transparent;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label4.Location = new System.Drawing.Point(6, 67);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(206, 16);
         this.label4.TabIndex = 7;
         this.label4.Text = "Давление в реакторе (КПа) (A)";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.BackColor = System.Drawing.Color.Transparent;
         this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label8.Location = new System.Drawing.Point(6, 33);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(243, 16);
         this.label8.TabIndex = 6;
         this.label8.Text = "Расход реакционной смеси (кг/ч) (G)";
         // 
         // amountOfProductButton
         // 
         this.amountOfProductButton.AnimationHoverSpeed = 0.07F;
         this.amountOfProductButton.AnimationSpeed = 0.03F;
         this.amountOfProductButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
         this.amountOfProductButton.BorderColor = System.Drawing.Color.Black;
         this.amountOfProductButton.DialogResult = System.Windows.Forms.DialogResult.None;
         this.amountOfProductButton.Enabled = false;
         this.amountOfProductButton.FocusedColor = System.Drawing.Color.Empty;
         this.amountOfProductButton.Font = new System.Drawing.Font("Segoe UI", 9F);
         this.amountOfProductButton.ForeColor = System.Drawing.Color.White;
         this.amountOfProductButton.Image = null;
         this.amountOfProductButton.ImageSize = new System.Drawing.Size(20, 20);
         this.amountOfProductButton.Location = new System.Drawing.Point(870, 505);
         this.amountOfProductButton.Name = "amountOfProductButton";
         this.amountOfProductButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
         this.amountOfProductButton.OnHoverBorderColor = System.Drawing.Color.Black;
         this.amountOfProductButton.OnHoverForeColor = System.Drawing.Color.White;
         this.amountOfProductButton.OnHoverImage = null;
         this.amountOfProductButton.OnPressedColor = System.Drawing.Color.Black;
         this.amountOfProductButton.Size = new System.Drawing.Size(160, 31);
         this.amountOfProductButton.TabIndex = 10;
         this.amountOfProductButton.Text = "Расчитать кол-во продукта";
         this.amountOfProductButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.amountOfProductButton.Click += new System.EventHandler(this.amountOfProductButton_Click);
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.BackColor = System.Drawing.Color.Transparent;
         this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
         this.label11.Location = new System.Drawing.Point(634, 445);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(306, 20);
         this.label11.TabIndex = 11;
         this.label11.Text = "Количество получаемого продукта (кг)\r\n";
         // 
         // calculatedAmount
         // 
         this.calculatedAmount.Location = new System.Drawing.Point(946, 446);
         this.calculatedAmount.Name = "calculatedAmount";
         this.calculatedAmount.Size = new System.Drawing.Size(85, 20);
         this.calculatedAmount.TabIndex = 12;
         // 
         // totalCost
         // 
         this.totalCost.Location = new System.Drawing.Point(946, 478);
         this.totalCost.Name = "totalCost";
         this.totalCost.Size = new System.Drawing.Size(85, 20);
         this.totalCost.TabIndex = 14;
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.BackColor = System.Drawing.Color.Transparent;
         this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
         this.label12.Location = new System.Drawing.Point(634, 477);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(308, 20);
         this.label12.TabIndex = 13;
         this.label12.Text = "Стоимость полученной продукции (у.е.)\r\n";
         // 
         // costOnePiece
         // 
         this.costOnePiece.Location = new System.Drawing.Point(946, 416);
         this.costOnePiece.Name = "costOnePiece";
         this.costOnePiece.ReadOnly = true;
         this.costOnePiece.Size = new System.Drawing.Size(85, 20);
         this.costOnePiece.TabIndex = 15;
         // 
         // label13
         // 
         this.label13.AutoSize = true;
         this.label13.BackColor = System.Drawing.Color.Transparent;
         this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label13.Location = new System.Drawing.Point(634, 417);
         this.label13.Name = "label13";
         this.label13.Size = new System.Drawing.Size(200, 20);
         this.label13.TabIndex = 14;
         this.label13.Text = "Стоимость 1 кг продукта";
         // 
         // choosenTask
         // 
         this.choosenTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.choosenTask.Location = new System.Drawing.Point(12, 96);
         this.choosenTask.Name = "choosenTask";
         this.choosenTask.Size = new System.Drawing.Size(435, 416);
         this.choosenTask.TabIndex = 25;
         this.choosenTask.Text = "";
         // 
         // label18
         // 
         this.label18.AutoSize = true;
         this.label18.BackColor = System.Drawing.Color.Transparent;
         this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label18.Location = new System.Drawing.Point(284, 34);
         this.label18.Name = "label18";
         this.label18.Size = new System.Drawing.Size(131, 20);
         this.label18.TabIndex = 27;
         this.label18.Text = "Метод решения";
         // 
         // gunaComboBox1
         // 
         this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
         this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
         this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
         this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
         this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
         this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
         this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
         this.gunaComboBox1.FormattingEnabled = true;
         this.gunaComboBox1.Items.AddRange(new object[] {
            "Метод сканирования",
            "Метод Бокса"});
         this.gunaComboBox1.Location = new System.Drawing.Point(288, 57);
         this.gunaComboBox1.Name = "gunaComboBox1";
         this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
         this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
         this.gunaComboBox1.Size = new System.Drawing.Size(157, 26);
         this.gunaComboBox1.TabIndex = 26;
         // 
         // groupBox4
         // 
         this.groupBox4.BackColor = System.Drawing.Color.Transparent;
         this.groupBox4.Controls.Add(this.label19);
         this.groupBox4.Controls.Add(this.highestT2);
         this.groupBox4.Controls.Add(this.lowerT2);
         this.groupBox4.Controls.Add(this.label21);
         this.groupBox4.Controls.Add(this.highestT1);
         this.groupBox4.Controls.Add(this.lowerT1);
         this.groupBox4.Controls.Add(this.label20);
         this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.groupBox4.Location = new System.Drawing.Point(453, 35);
         this.groupBox4.Name = "groupBox4";
         this.groupBox4.Size = new System.Drawing.Size(235, 98);
         this.groupBox4.TabIndex = 28;
         this.groupBox4.TabStop = false;
         this.groupBox4.Text = "Ограничения первого рода";
         // 
         // label19
         // 
         this.label19.AutoSize = true;
         this.label19.BackColor = System.Drawing.Color.Transparent;
         this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
         this.label19.Location = new System.Drawing.Point(85, 62);
         this.label19.Name = "label19";
         this.label19.Size = new System.Drawing.Size(68, 20);
         this.label19.TabIndex = 28;
         this.label19.Text = "<=T2<=\r\n";
         // 
         // highestT2
         // 
         this.highestT2.Location = new System.Drawing.Point(159, 61);
         this.highestT2.Name = "highestT2";
         this.highestT2.Size = new System.Drawing.Size(44, 26);
         this.highestT2.TabIndex = 27;
         // 
         // lowerT2
         // 
         this.lowerT2.Location = new System.Drawing.Point(35, 62);
         this.lowerT2.Name = "lowerT2";
         this.lowerT2.Size = new System.Drawing.Size(44, 26);
         this.lowerT2.TabIndex = 26;
         // 
         // label21
         // 
         this.label21.AutoSize = true;
         this.label21.BackColor = System.Drawing.Color.Transparent;
         this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
         this.label21.Location = new System.Drawing.Point(85, 29);
         this.label21.Name = "label21";
         this.label21.Size = new System.Drawing.Size(68, 20);
         this.label21.TabIndex = 25;
         this.label21.Text = "<=T1<=\r\n";
         // 
         // highestT1
         // 
         this.highestT1.Location = new System.Drawing.Point(159, 28);
         this.highestT1.Name = "highestT1";
         this.highestT1.Size = new System.Drawing.Size(44, 26);
         this.highestT1.TabIndex = 24;
         // 
         // lowerT1
         // 
         this.lowerT1.Location = new System.Drawing.Point(35, 29);
         this.lowerT1.Name = "lowerT1";
         this.lowerT1.Size = new System.Drawing.Size(44, 26);
         this.lowerT1.TabIndex = 23;
         // 
         // label20
         // 
         this.label20.AutoSize = true;
         this.label20.BackColor = System.Drawing.Color.Transparent;
         this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label20.Location = new System.Drawing.Point(6, 33);
         this.label20.Name = "label20";
         this.label20.Size = new System.Drawing.Size(0, 16);
         this.label20.TabIndex = 6;
         // 
         // groupBox5
         // 
         this.groupBox5.BackColor = System.Drawing.Color.Transparent;
         this.groupBox5.Controls.Add(this.secondLimitation);
         this.groupBox5.Controls.Add(this.label16);
         this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.groupBox5.Location = new System.Drawing.Point(694, 35);
         this.groupBox5.Name = "groupBox5";
         this.groupBox5.Size = new System.Drawing.Size(235, 69);
         this.groupBox5.TabIndex = 29;
         this.groupBox5.TabStop = false;
         this.groupBox5.Text = "Ограничения второго рода";
         // 
         // secondLimitation
         // 
         this.secondLimitation.Location = new System.Drawing.Point(9, 27);
         this.secondLimitation.Name = "secondLimitation";
         this.secondLimitation.Size = new System.Drawing.Size(220, 26);
         this.secondLimitation.TabIndex = 26;
         // 
         // label16
         // 
         this.label16.AutoSize = true;
         this.label16.BackColor = System.Drawing.Color.Transparent;
         this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label16.Location = new System.Drawing.Point(6, 33);
         this.label16.Name = "label16";
         this.label16.Size = new System.Drawing.Size(0, 16);
         this.label16.TabIndex = 6;
         // 
         // accuracyValue
         // 
         this.accuracyValue.Location = new System.Drawing.Point(608, 211);
         this.accuracyValue.Name = "accuracyValue";
         this.accuracyValue.Size = new System.Drawing.Size(75, 20);
         this.accuracyValue.TabIndex = 30;
         this.accuracyValue.Text = "0,01";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.Transparent;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label2.Location = new System.Drawing.Point(451, 211);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(151, 20);
         this.label2.TabIndex = 31;
         this.label2.Text = "Точность решения";
         // 
         // Researcher
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.background;
         this.ClientSize = new System.Drawing.Size(1042, 548);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.accuracyValue);
         this.Controls.Add(this.groupBox5);
         this.Controls.Add(this.groupBox4);
         this.Controls.Add(this.label18);
         this.Controls.Add(this.gunaComboBox1);
         this.Controls.Add(this.choosenTask);
         this.Controls.Add(this.costOnePiece);
         this.Controls.Add(this.label13);
         this.Controls.Add(this.totalCost);
         this.Controls.Add(this.label12);
         this.Controls.Add(this.calculatedAmount);
         this.Controls.Add(this.label11);
         this.Controls.Add(this.amountOfProductButton);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.task);
         this.Controls.Add(this.minimizeButton);
         this.Controls.Add(this.closeButton);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "Researcher";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Researcher";
         this.Load += new System.EventHandler(this.Researcher_Load);
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.groupBox3.ResumeLayout(false);
         this.groupBox3.PerformLayout();
         this.groupBox4.ResumeLayout(false);
         this.groupBox4.PerformLayout();
         this.groupBox5.ResumeLayout(false);
         this.groupBox5.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private Guna.UI.WinForms.GunaButton minimizeButton;
      private Guna.UI.WinForms.GunaButton closeButton;
      private Guna.UI.WinForms.GunaComboBox task;
      private System.Windows.Forms.Label label1;
      private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.TextBox muText;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TextBox betaText;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.TextBox alphaText;
      private System.Windows.Forms.Label label5;
      private Guna.UI.WinForms.GunaButton amountOfProductButton;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.TextBox rotationalSpeed;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.TextBox reactorPressure;
      private System.Windows.Forms.TextBox mixtureCons;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.TextBox calculatedAmount;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.TextBox costOnePiece;
      private System.Windows.Forms.Label label13;
      private System.Windows.Forms.TextBox totalCost;
      private System.Windows.Forms.Label label12;
      private System.ComponentModel.BackgroundWorker backgroundWorker1;
      private System.Windows.Forms.Label label18;
      private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
      private System.Windows.Forms.RichTextBox choosenTask;
      private System.Windows.Forms.GroupBox groupBox5;
      private System.Windows.Forms.TextBox secondLimitation;
      private System.Windows.Forms.Label label16;
      private System.Windows.Forms.GroupBox groupBox4;
      private System.Windows.Forms.Label label19;
      private System.Windows.Forms.TextBox highestT2;
      private System.Windows.Forms.TextBox lowerT2;
      private System.Windows.Forms.Label label21;
      private System.Windows.Forms.TextBox highestT1;
      private System.Windows.Forms.TextBox lowerT1;
      private System.Windows.Forms.Label label20;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox accuracyValue;
   }
}