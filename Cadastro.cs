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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, email, number, date;
        



            name = this.txtName.Text;

            date = this.mksDate.Text;

            email = this.txtEmail.Text;

            number = this.txtNumber.Text;

            this.lblName.Text = name;

            this.lblEmail.Text = email;

            this.lblNumber.Text = number;

            this.lblData.Text = date;


        }

        private void button2_Click(object sender, EventArgs e)
        {

            string name, email, number, date;

            txtName.Clear();

            txtEmail.Clear();

            txtNumber.Clear();

            mksDate.Clear();
        }
    }
}
