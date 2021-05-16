namespace WindowsFormsApp1.Forms
{
   partial class Simulation
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulation));
         System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
         System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
         System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
         this.minimizeButton = new Guna.UI.WinForms.GunaButton();
         this.closeButton = new Guna.UI.WinForms.GunaButton();
         this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.temperature2 = new System.Windows.Forms.TextBox();
         this.temperature1 = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.totalCost = new System.Windows.Forms.TextBox();
         this.label12 = new System.Windows.Forms.Label();
         this.calculatedAmount = new System.Windows.Forms.TextBox();
         this.label11 = new System.Windows.Forms.Label();
         this.resultText = new System.Windows.Forms.RichTextBox();
         ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
         this.groupBox1.SuspendLayout();
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
         this.minimizeButton.Location = new System.Drawing.Point(807, -1);
         this.minimizeButton.Name = "minimizeButton";
         this.minimizeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.minimizeButton.OnHoverBorderColor = System.Drawing.Color.Black;
         this.minimizeButton.OnHoverForeColor = System.Drawing.Color.White;
         this.minimizeButton.OnHoverImage = null;
         this.minimizeButton.OnPressedColor = System.Drawing.Color.Black;
         this.minimizeButton.Size = new System.Drawing.Size(30, 30);
         this.minimizeButton.TabIndex = 5;
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
         this.closeButton.Location = new System.Drawing.Point(843, -1);
         this.closeButton.Name = "closeButton";
         this.closeButton.OnHoverBaseColor = System.Drawing.Color.Red;
         this.closeButton.OnHoverBorderColor = System.Drawing.Color.Black;
         this.closeButton.OnHoverForeColor = System.Drawing.Color.White;
         this.closeButton.OnHoverImage = null;
         this.closeButton.OnPressedColor = System.Drawing.Color.Black;
         this.closeButton.Size = new System.Drawing.Size(30, 30);
         this.closeButton.TabIndex = 4;
         this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
         // 
         // chart1
         // 
         chartArea1.Name = "ChartArea1";
         this.chart1.ChartAreas.Add(chartArea1);
         legend1.Name = "Legend1";
         this.chart1.Legends.Add(legend1);
         this.chart1.Location = new System.Drawing.Point(12, 33);
         this.chart1.Name = "chart1";
         series1.ChartArea = "ChartArea1";
         series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;
         series1.Legend = "Legend1";
         series1.Name = "Series1";
         series1.YValuesPerPoint = 2;
         this.chart1.Series.Add(series1);
         this.chart1.Size = new System.Drawing.Size(543, 405);
         this.chart1.TabIndex = 6;
         this.chart1.Text = "chart1";
         // 
         // groupBox1
         // 
         this.groupBox1.BackColor = System.Drawing.Color.Transparent;
         this.groupBox1.Controls.Add(this.temperature2);
         this.groupBox1.Controls.Add(this.temperature1);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.groupBox1.Location = new System.Drawing.Point(561, 35);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(302, 98);
         this.groupBox1.TabIndex = 7;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Управляющие воздействия";
         // 
         // temperature2
         // 
         this.temperature2.Location = new System.Drawing.Point(231, 61);
         this.temperature2.Name = "temperature2";
         this.temperature2.Size = new System.Drawing.Size(58, 26);
         this.temperature2.TabIndex = 9;
         // 
         // temperature1
         // 
         this.temperature1.Location = new System.Drawing.Point(231, 27);
         this.temperature1.Name = "temperature1";
         this.temperature1.Size = new System.Drawing.Size(58, 26);
         this.temperature1.TabIndex = 8;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.BackColor = System.Drawing.Color.Transparent;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label3.Location = new System.Drawing.Point(6, 67);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(218, 16);
         this.label3.TabIndex = 7;
         this.label3.Text = "Температура в рубашке (°C) (T2)";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.Transparent;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label2.Location = new System.Drawing.Point(6, 33);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(226, 16);
         this.label2.TabIndex = 6;
         this.label2.Text = "Температура в змеевике (°C) (T1)";
         // 
         // totalCost
         // 
         this.totalCost.Location = new System.Drawing.Point(320, 484);
         this.totalCost.Name = "totalCost";
         this.totalCost.Size = new System.Drawing.Size(85, 20);
         this.totalCost.TabIndex = 19;
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.BackColor = System.Drawing.Color.Transparent;
         this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
         this.label12.Location = new System.Drawing.Point(8, 483);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(308, 20);
         this.label12.TabIndex = 18;
         this.label12.Text = "Стоимость полученной продукции (у.е.)\r\n";
         // 
         // calculatedAmount
         // 
         this.calculatedAmount.Location = new System.Drawing.Point(320, 452);
         this.calculatedAmount.Name = "calculatedAmount";
         this.calculatedAmount.Size = new System.Drawing.Size(85, 20);
         this.calculatedAmount.TabIndex = 17;
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.BackColor = System.Drawing.Color.Transparent;
         this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
         this.label11.Location = new System.Drawing.Point(8, 451);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(306, 20);
         this.label11.TabIndex = 16;
         this.label11.Text = "Количество получаемого продукта (кг)\r\n";
         // 
         // resultText
         // 
         this.resultText.Location = new System.Drawing.Point(571, 270);
         this.resultText.Name = "resultText";
         this.resultText.Size = new System.Drawing.Size(291, 167);
         this.resultText.TabIndex = 20;
         this.resultText.Text = "";
         // 
         // Simulation
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.background;
         this.ClientSize = new System.Drawing.Size(875, 512);
         this.Controls.Add(this.resultText);
         this.Controls.Add(this.totalCost);
         this.Controls.Add(this.label12);
         this.Controls.Add(this.calculatedAmount);
         this.Controls.Add(this.label11);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.chart1);
         this.Controls.Add(this.minimizeButton);
         this.Controls.Add(this.closeButton);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "Simulation";
         this.Text = "Simulation";
         ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private Guna.UI.WinForms.GunaButton minimizeButton;
      private Guna.UI.WinForms.GunaButton closeButton;
      private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox temperature2;
      private System.Windows.Forms.TextBox temperature1;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox totalCost;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.TextBox calculatedAmount;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.RichTextBox resultText;
   }
}