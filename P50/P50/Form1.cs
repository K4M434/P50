using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace P50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btcalcola_Click(object sender, EventArgs e)
        {
            float K, Somma, N;

            Somma = 0;
            N = Convert.ToSingle(Interaction.InputBox("Introdurre il numero"));
            K = Convert.ToSingle(txtk.Text);

            while (N !=0)
            {
                if (N > K)
                {
                    Somma = Somma + N;
                }
                N = Convert.ToSingle(Interaction.InputBox("Introdurre il numero"));
            }
            txtOut.Text = Convert.ToString(Somma);
        }
    }
}
