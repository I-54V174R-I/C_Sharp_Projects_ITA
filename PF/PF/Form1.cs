using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CONSULTA_1 F2 = new CONSULTA_1();
            Form1 F1 = new Form1();
            F2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CONSULTA_2 F2 = new CONSULTA_2();
            F2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            INSERTAR F3 = new INSERTAR();
            F3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EDICION F4 = new EDICION();
            F4.Show();
        }
    }
}
