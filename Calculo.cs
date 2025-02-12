using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AULA1
{
    public partial class Calculo : Form
    {
        public Calculo()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string N1, N2, N3, N4, N5, N6, N7, N8;

           

            N1 = this.txt01.Text;

            N2 = this.txt02.Text;

            N3 = this.txt03.Text;

            N4 = this.txt04.Text;

            N5 = this.txt05.Text;

            N6 = this.txt06.Text;

            N7 = this.txt07.Text;

            N8 = this.txt08.Text;

            int adi = Convert.ToInt32(N1) + Convert.ToInt32(N2);

            int sub = Convert.ToInt32(N3) - Convert.ToInt32(N4);

            int mult = Convert.ToInt32(N5) * Convert.ToInt32(N6);

            int divi = Convert.ToInt32(N7) / Convert.ToInt32(N8);

            this.lblResult1.Text = Convert.ToString(adi);

            this.lblResult2.Text = Convert.ToString(sub);

            this.lblResult3.Text = Convert.ToString(mult);

            this.lblResult4.Text = Convert.ToString(divi);








        }
    }
}
