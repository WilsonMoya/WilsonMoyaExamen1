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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {


            double precioa = Convert.ToDouble(precio1textBox.Text);
            double preciob = Convert.ToDouble(precio2textBox2.Text);
            double cantidada = Convert.ToDouble(cantidad1textBox.Text);
            double cantidadb = Convert.ToDouble(cantidad2textBox.Text);
            double tottal = await totalAsync(precioa, preciob, cantidada, cantidadb);
            MessageBox.Show("El total a pagar es: " + tottal + " Lps");
        }

        private async Task<double> totalAsync(double p1, double p2, double c1, double c2)
        {
            double total = await Task.Run(() =>
            {
                double total1 = p1 * c1;
                double total2 = p2 * c2;
                double totalf = total1 + total2;
                double totalh = totalf * 0.15;
                double totalfin = totalf - totalh;
                return totalfin;

            });
            return total;
        }
    }
}
