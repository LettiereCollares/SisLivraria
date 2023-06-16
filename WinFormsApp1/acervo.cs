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

namespace WinFormsApp1
{
    public partial class acervo : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;port=3306;user=root;password=1234;database=db_biblioteca_virtual;";

        public acervo()
        {
            InitializeComponent();
        }

        private void acervo_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                string query = "SELECT * FROM bvlivro";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewLivros.DataSource = dataTable;

                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }
    }
}