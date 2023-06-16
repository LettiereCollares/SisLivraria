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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class devolucao : Form
    {
        private string connectionString = "server=localhost;port=3306;user=root;password=1234;database=db_biblioteca_virtual;";
        public devolucao()
        {
            InitializeComponent();
        }

        private void devolucao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int livroID;
                if (!int.TryParse(textBox1.Text, out livroID))
                {
                    MessageBox.Show("Digite um ID de livro válido.");
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM bvemprestimos WHERE LivroID = @LivroID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@LivroID", livroID);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Livro devolvido com sucesso.");
                        // Restante do código após a devolução do livro.
                    }
                    else
                    {
                        MessageBox.Show("Nenhum livro encontrado para devolução com o ID especificado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a devolução: " + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}