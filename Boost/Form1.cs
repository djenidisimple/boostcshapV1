using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boost
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Djenidi\Documents\PROJET\c#\Boost\Boost\Database1.mdf;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text;
            String firstName = textBoxAdress.Text;
            int year = (int)numericUpDownAge.Value;
            String adress = textBoxAdress.Text;

            conn.Open();

            string query = "INSERT INTO personne(nom, prenom, age, adress) values('" + name + "', '" + firstName + "', " + year + ", '" + adress + "')";

            using (SqlCommand cmd = new SqlCommand(query, conn)) {
                cmd.ExecuteNonQuery();
            }
            conn.Close();

            name = "";
            firstName = "";
            year = 0;
            adress = "";
            loadDataGridView(dataGridAffichage);
            MessageBox.Show("Enregistrement reussite!");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void loadDataGridView(DataGridView value) 
        {
            List<Personne> p = new List<Personne>();
            string query = "select * from personne;";
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(query, conn)) {
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        Personne prs = new Personne(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4));
                        p.Add(prs);
                    }
                }
            }
            conn.Close();
            value.DataSource = p;
        }

        private void btnWin_Click(object sender, EventArgs e)
        {
            

            FormAdd form2 = new FormAdd();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDataGridView(dataGridAffichage);
        }
    }
}
