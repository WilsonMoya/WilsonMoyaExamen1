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
                double tasaInteresMensual = 0.015;
                double interesMensual;
                double capitalAcumulado = capital;

                Intereses.Items.Clear();
                for (int mes = 1; mes <= 12; mes++)
                {
                    interesMensual = capitalAcumulado * tasaInteresMensual;
                    capitalAcumulado += interesMensual;
                    Intereses.Items.Add(string.Format("Mes {0}: L {1:0.00}", mes, interesMensual));
                }

            }
        }
    }
}
