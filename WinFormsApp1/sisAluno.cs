using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class sisAluno : Form
    {
        public sisAluno()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acervo Acervo = new acervo();
            Acervo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            devolucao Devolucao = new devolucao();
            Devolucao.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            emprestimo Emprestimo = new emprestimo();
            Emprestimo.Show();
        }
    }
}
