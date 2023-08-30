using System.Data;
using MySql.Data.MySqlClient;

namespace Number2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Fetch_Click(object sender, EventArgs e)
        {
            try

            {

                String str = "Server=localhost;Database=users;User=root;Password=letodluhar;Port=3306";


                MySqlConnection con = new MySqlConnection(str);
                con.Open();

                String query = "select * from userprofile";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                con.Close();

            }

            catch (Exception es)

            {
                MessageBox.Show(es.Message);
            }

        }
    }
}