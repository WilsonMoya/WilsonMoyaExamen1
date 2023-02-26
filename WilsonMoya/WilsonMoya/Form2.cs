using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WilsonMoya
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                double capital = 200000.00;
                double Interes = 0.015;
                double interes2;
                double Acum = capital;
                
                InteresesTotal.Items.Clear();
                string[] vector = { "2023 Enero Recibio", "2023 Febrero  Recibio", "2023 Marzo Recibio", "2023 Abril Recibio", "2023 Mayo Recibio", "2023 junio Recibio", "2023 julio Recibio", "2023 agosto Recibio", "2023 septiembre Recibio", "2023 ocubre Recibio", "2023 noviembre Recibio", "2023 diciembre Fin de año Recibio" };
                for (int i = 0; i < vector.Length; i++)
                {
                    interes2 = Acum * Interes;
                    Acum += interes2;
                    InteresesTotal.Items.Add(vector[i] + " " + (interes2) + " Lps de Intereses");
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            Close();
        }
    }
}
