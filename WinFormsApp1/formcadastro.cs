using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;
using MySqlException = MySql.Data.MySqlClient.MySqlException;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1
{
    public partial class formcadastro : Form
    {
        public static MySqlConnection Form1_Load { get; private set; }

        public formcadastro()
        {
            InitializeComponent();
        }
        public class bvaluno
        {
            [Key]
            public int AlunoID { get; set; }
            public string AlunoNome { get; set; }
            public string EmailAluno { get; set; }
            public int CelAluno { get; set; }
            public int MatriAluno { get; set; }
            public int SenhaAluno { get; set; }
            public string Endereco { get; set; }
        }
        public class bvprofessor
        {
            [Key]
            public string ProfID { get; set; }
            public string ProfNome { get; set; }
            public string EmailProf { get; set; }
            public int CelProf { get; set; }
            public int MatriProf { get; set; }
            public string Endereco { get; set; }
        }
        public class bvbibliotecario
        {
            [Key]
            public string BibliID { get; set; }
            public string BibliNome { get; set; }
            public string EmailBibli { get; set; }
            public int CelBibli { get; set; }
            public int MatriBibli { get; set; }
            public string Endereco { get; set; }
        }
        private void formcadastro_Load(object sender, EventArgs e)
        { }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSenha.Checked)
            {
                text_senha.UseSystemPasswordChar = false;
                text_senha2.UseSystemPasswordChar = false;
            }
            else
            {
                text_senha.UseSystemPasswordChar = true;
                text_senha2.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(f => string.IsNullOrEmpty(f.Text)))
            {
                MessageBox.Show("É necessário preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string connectionString = "server=localhost;port=3306;user=root;password=1234;database=db_biblioteca_virtual;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        if (comboBox1.SelectedItem.ToString() == "Professor"){ 
                        string query = "INSERT INTO bvprofessor (ProfNome, EmailProf, CelProf, MatriProf, SenhaProf, Endereco) VALUES (@ProfNome, @EmailProf, @CelProf, @MatriProf, @SenhaProf, @Endereco)";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ProfNome", text_nome.Text);
                                command.Parameters.AddWithValue("@EmailProf", text_email.Text);
                                command.Parameters.AddWithValue("@CelProf", txt_cel.Text);
                                command.Parameters.AddWithValue("@MatriProf", text_matri.Text);
                                command.Parameters.AddWithValue("@SenhaProf", text_senha.Text);
                                command.Parameters.AddWithValue("@Endereco", txt_address.Text);
                                command.ExecuteNonQuery();
                            }
                        }
                        else if (comboBox1.SelectedItem.ToString() == "Aluno")
                        {
                            string query = "INSERT INTO bvaluno (AlunoNome, EmailAluno, CelAluno, MatriAluno, SenhaAluno, Endereco) VALUES (@AlunoNome, @EmailAluno, @CelAluno, @MatriAluno, @SenhaAluno, @Endereco)";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@AlunoNome", text_nome.Text);
                                command.Parameters.AddWithValue("@EmailAluno", text_email.Text);
                                command.Parameters.AddWithValue("@CelAluno", txt_cel.Text);
                                command.Parameters.AddWithValue("@MatriAluno", text_matri.Text);
                                command.Parameters.AddWithValue("@SenhaAluno", text_senha.Text);
                                command.Parameters.AddWithValue("@Endereco", txt_address.Text);
                                command.ExecuteNonQuery();
                            }
                        }
                        else if (comboBox1.SelectedItem.ToString() == "Bibliotecario")
                        {
                            string query = "INSERT INTO bvbibliotecario (BibliNome, EmailBibli, CelBibli, MatriBibli, SenhaBibli, Endereco) VALUES (@BibliNome, @EmailBibli, @CelBibli, @MatriBibli, @SenhaBibli, @Endereco)";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@BibliNome", text_nome.Text);
                                command.Parameters.AddWithValue("@EmailBibli", text_email.Text);
                                command.Parameters.AddWithValue("@CelBibli", txt_cel.Text);
                                command.Parameters.AddWithValue("@MatriBibli", text_matri.Text);
                                command.Parameters.AddWithValue("@SenhaBibli", text_senha.Text);
                                command.Parameters.AddWithValue("@Endereco", txt_address.Text);
                                command.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Agora que suas informações foram salvas, faça o login");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                    }
                }
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
