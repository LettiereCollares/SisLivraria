using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace WinFormsApp1
{
    public partial class Addlivros : Form
    {
        public Addlivros()
        {
            InitializeComponent();
        }

        private void Addlivros_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string livroNome = txt_livro.Text;
            string livroAutor = txt_autor.Text;
            string livroGenero = box_categoria.Text;
            string faixaEtaria = box_faixa.Text;
            string plataforma = box_plataforma.Text;
            string anoLanc = txt_ano.Text;
            string sinopse = txt_sinopse.Text;

            string connectionString = "server=localhost;port=3306;user=root;password=1234;database=db_biblioteca_virtual;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO bvLivro (LivroNome, LivroAutor, LivroGenero, FaixaEtaria, Plataforma, AnoLanc, Sinopse) " +
                                   "VALUES (@LivroNome, @LivroAutor, @LivroGenero, @FaixaEtaria, @Plataforma, @AnoLanc, @Sinopse)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LivroNome", livroNome);
                        command.Parameters.AddWithValue("@LivroAutor", livroAutor);
                        command.Parameters.AddWithValue("@LivroGenero", livroGenero);
                        command.Parameters.AddWithValue("@FaixaEtaria", faixaEtaria);
                        command.Parameters.AddWithValue("@Plataforma", plataforma);
                        command.Parameters.AddWithValue("@AnoLanc", anoLanc);
                        command.Parameters.AddWithValue("@Sinopse", sinopse);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Dados do livro foram inseridos com sucesso!");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
            }
        }
    }
}