using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   public partial class Researcher : Form
   {
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
         double alpha = Convert.ToDouble(alphaText.Text);
         double beta = Convert.ToDouble(betaText.Text);
         double mu = Convert.ToDouble(muText.Text);
         double pressure = Convert.ToDouble(reactorPressure.Text); //A
         double speed = Convert.ToDouble(rotationalSpeed.Text);    //N
         double consumption = Convert.ToDouble(mixtureCons.Text);  //G
         double temperature_1 = Convert.ToDouble(temperature1.Text); //T1
         double temperature_2 = Convert.ToDouble(temperature2.Text); //T2

         double S = alpha * (consumption * mu * (Math.Pow((temperature_2 - temperature_1), speed) +
                                                 Math.Pow((beta * pressure - temperature_1), speed)));
         calculatedAmount.Text = S.ToString();
         totalCost.Text = (S * Convert.ToDouble(costOnePiece.Text)).ToString();
         double[,] borders = new double[2,2] {{Convert.ToDouble(lowerT1.Text), Convert.ToDouble(highestT1.Text)}, {Convert.ToDouble(lowerT2.Text), Convert.ToDouble(highestT2.Text)}};
         double[,] boxPoints = new double[2,4];
         //boxPoints = Box.startPoints(2,borders,1,-1,-3);
      }
   }
}
