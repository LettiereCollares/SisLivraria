using MySql.Data.MySqlClient;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;
using MySqlException = MySql.Data.MySqlClient.MySqlException;
using System.ComponentModel.DataAnnotations;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string senha = txt_senha.Text;

            string connectionString = "server=localhost;port=3306;user=root;password=1234;database=db_biblioteca_virtual;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM bvaluno WHERE EmailAluno = @Email AND SenhaAluno = @Senha";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Senha", senha);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Bem-vindo ao sistema");
                                sisAluno Sisaluno = new sisAluno();
                                Sisaluno.Show();
                                this.Hide();
                            }
                            else
                            {
                                // Verificar se é professor
                                query = "SELECT * FROM bvprofessor WHERE EmailProf = @Email AND SenhaProf = @Senha";
                                command.CommandText = query;
                                reader.Close();
                                reader.Dispose();

                                using (MySqlDataReader professorReader = command.ExecuteReader())
                                {
                                    if (professorReader.Read())
                                    {
                                        MessageBox.Show("Bem-vindo ao sistema");
                                        sisProf Sisprof = new sisProf();
                                        Sisprof.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        // Verificar se é bibliotecário
                                        query = "SELECT * FROM bvbibliotecario WHERE EmailBibli = @Email AND SenhaBibli = @Senha";
                                        command.CommandText = query;
                                        professorReader.Close();
                                        professorReader.Dispose();

                                        using (MySqlDataReader bibliotecarioReader = command.ExecuteReader())
                                        {
                                            if (bibliotecarioReader.Read())
                                            {
                                                MessageBox.Show("Bem-vindo ao sistema");
                                                sisBibliotecario Sisbiliotecario = new sisBibliotecario();
                                                Sisbiliotecario.Show();
                                                this.Hide();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Login ou senha inválidos");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkcadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formcadastro Formcadastro = new formcadastro();
            Formcadastro.Show();
            this.Hide();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_senha.UseSystemPasswordChar = false;
            }
            else
            {
                txt_senha.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
