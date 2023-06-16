using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class emprestimo : Form
    {
        private string connectionString = "server=localhost;port=3306;user=root;password=1234;database=db_biblioteca_virtual;";

        public emprestimo()
        {
            InitializeComponent();
        }

        private void emprestimo_Load(object sender, EventArgs e)
        {
            LoadLivrosDisponiveis();
        }

        private void LoadLivrosDisponiveis()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT LivroID, LivroNome FROM bvlivro";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    connection.Open();

                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());

                    comboBoxLivros.DisplayMember = "LivroNome";
                    comboBoxLivros.ValueMember = "LivroID";
                    comboBoxLivros.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os livros disponíveis: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ID_Emp;
                if (!int.TryParse(textBox1.Text, out ID_Emp))
                {
                    MessageBox.Show("Digite um ID de aluno válido.");
                    return;
                }
                string livroid = comboBoxLivros.SelectedValue.ToString();

                string livroNome = comboBoxLivros.Text.ToString();
                if (string.IsNullOrEmpty(livroNome))
                {
                    MessageBox.Show("Selecione um livro válido.");
                    return;
                }
                DateTime dataEmprestimo = dateTimePicker1.Value;
                DateTime dataDevolucao = dateTimePicker2.Value;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO bvemprestimos (ID_Emp, LivroID, LivroNome, Data_Emp, Data_Devolucao) " +
                                   "VALUES (@ID_Emp, @LivroID, @LivroNome, @Data_Emp, @Data_Devolucao)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_Emp", ID_Emp);
                    command.Parameters.AddWithValue("@LivroID", livroid);
                    command.Parameters.AddWithValue("@LivroNome", livroNome);
                    command.Parameters.AddWithValue("@Data_Emp", dataEmprestimo);
                    command.Parameters.AddWithValue("@Data_Devolucao", dataDevolucao);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Empréstimo registrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar o empréstimo: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}