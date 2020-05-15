using System;
using System.Windows.Forms;

namespace Miscelaneous_Calculations
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCalcFibo_Click(object sender, EventArgs e)
        {
            FiboNumbers.Text = String.Empty;
            long[] Fibonacci = new long[50];
            Fibonacci[0] = 0;
            Fibonacci[1] = 1;
            int i;

            for (i = 2; i < Fibonacci.Length; i++)
            {
                Fibonacci[i] = Fibonacci[i - 1] + Fibonacci[i - 2];
            }

            i = 0;
            if(Convert.ToInt32(CifrasFibo.Text)> 50)
            {
                MessageBox.Show("Número menor a 50","Número inválido", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                while (i < Convert.ToInt32(CifrasFibo.Text))
                {
                    FiboNumbers.Text += Fibonacci[i];
                    FiboNumbers.Text += " ";
                    i++;
                }
            }
            
        }
        public bool IsFibonacci(int numero)
        {
            int [] Fibonacci = new int[50];
            Fibonacci[0] = 0;
            Fibonacci[1] = 1;
            int i;
            bool respuesta = false;

            for (i = 2; i < Fibonacci.Length; i++)
            {
                Fibonacci[i] = Fibonacci[i - 1] + Fibonacci[i - 2];
                if (Fibonacci[i] == numero)
                {
                    respuesta = true;
                    break;
                }
                else
                {
                    continue;
                }
            }

            return respuesta;
        }

        protected void BtnIsFibo_Click(object sender, EventArgs e)
        {
            if(IsFibonacci(Convert.ToInt32(TxtNumberIsFibo.Text)) == true)
            {
                AnswerIsFibo.Text = "Yes it is!";
            }
            else
            {
                AnswerIsFibo.Text = "No, it is not...";
            }
                
        }

        protected void BtnNOfPi_Click(object sender, EventArgs e)
        {
            const double pi = 3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679;
            int localizacion = pi.ToString().IndexOf(TxtNPi.Text);
            PiLbl.Text = "The number " + TxtNPi.Text + " is first located in the position " + localizacion + " of Pi.";
            BtnNextIndexPi.Visible = true;
        }

        protected void BtnNextIndexPi_Click(object sender, EventArgs e)
        {
            string pi = "3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679";
            TxtBoxAllResults.Visible = true;
            char[] numeroPi = pi.ToCharArray();
            int i = 0;
            //PiLbl.Text = String.Empty;

            for(i = 0; i < numeroPi.Length; i++)
            {
                //PiLbl.Text += numeroPi[i];

                if (numeroPi[i] == Convert.ToChar(TxtNPi.Text))
                {
                    TxtBoxAllResults.Text += "The number " + TxtNPi.Text + " is next located in the position " + i + " of Pi." + Environment.NewLine;
                }
                else
                {
                    continue;
                }
            }            
                
        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBoxAllResults.Text = String.Empty;
        }
    }
}