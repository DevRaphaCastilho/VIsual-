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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Cadastro form = new Cadastro();
                form.MdiParent = this;
                form.Show();
            }
            
        }

        private void calculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculo form = new Calculo();
            form.MdiParent = this;
            form.Show();
        }
    }
}
