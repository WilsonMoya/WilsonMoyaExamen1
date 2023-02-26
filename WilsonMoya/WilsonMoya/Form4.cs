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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            numeros1en1();
        }

        private void numeros1en1()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    listBox1.Items.Add("Wilson Moya");

                }
                else if (i % 3 == 0)
                {
                    listBox1.Items.Add("Wilson");
                }
                else if (i % 5 == 0)
                {
                    listBox1.Items.Add("Moya");
                }
                else
                {
                    listBox1.Items.Add(i.ToString());
                }
            }
        }
    }
}
