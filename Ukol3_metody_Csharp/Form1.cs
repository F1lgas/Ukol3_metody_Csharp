using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol3_metody_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void JeAlfanum (string vstup)
        {
            bool alfanum = true;
            int mpismena = 0;
            int vpismena = 0;
            int cisla = 0;
            int jznaky = 0;

            for (int i = 0; i <= vstup.Length - 1; i++)
            {
                if (vstup[i] >=  '0' && vstup[i] <= '9')
                {
                    cisla++;
                }

                if (vstup[i] >= 'a' && vstup[i] <= 'z')
                {
                    mpismena++;
                }

                if (vstup[i] >= 'A' && vstup[i] <= 'Z')
                {
                    vpismena++;
                }

                if (vstup[i] < '0' || vstup[i] > '9' && vstup[i] < 'A' || vstup[i] > 'Z' && vstup[i] < 'a' || vstup[i] > 'z')
                {
                    jznaky++;
                    alfanum = false;
                }
            }

            if (alfanum == true)
            {
                MessageBox.Show("Řetězec je alfanumerický" + Environment.NewLine + "a obsahuje " + mpismena + " malých písmen, " + vpismena + " velkých písmen a " + cisla + " čísel.", "Výsledek");
            }
            else
            {
                MessageBox.Show("Řetězec není alfanumerický" + Environment.NewLine + "a obsahuje " + mpismena + " malých písmen, " + vpismena + " velkých písmen, " + cisla + " čísel a " + jznaky + " jiných znaků.", "Výsledek");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JeAlfanum(vstup.Text);
        }
    }
}