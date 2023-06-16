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
    public partial class sisBibliotecario : Form
    {
        public sisBibliotecario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Addlivros addLivrosForm = new Addlivros();
            addLivrosForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button1_Click(object sender, EventArgs e)
        {
            acervo Acervo = new acervo();
            Acervo.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            formcadastro Formcadastro = new formcadastro();
            Formcadastro.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            emprestimo Emprestimo = new emprestimo();
            Emprestimo.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            devolucao Devolucao = new devolucao();
            Devolucao.Show();
        }
    }
}
