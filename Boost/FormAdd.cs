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
    public partial class FormAdd : Form
    {
        SqlConnection conn;
        Form1 form1;
        public object SelectedItem { get; set; }
        public FormAdd()
        {
            InitializeComponent();
            form1 = new Form1();
            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Djenidi\Documents\PROJET\c#\Boost\Boost\Database1.mdf;Integrated Security=True");
        }

        private void labelNom_Click(object sender, EventArgs e)
        {

        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            form1.loadDataGridView(dataGridView);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
            dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int id = 0, age = 0;
            string nom = "", prenom = "", adress = "";
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    sb.Append("Row: ");
                    sb.Append(dataGridView.SelectedRows[i].Index.ToString());
                    id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                    nom = (string) dataGridView.SelectedRows[0].Cells[1].Value;
                    prenom = (string)dataGridView.SelectedRows[0].Cells[2].Value;
                    age = (int)dataGridView.SelectedRows[0].Cells[3].Value;
                    adress = (string)dataGridView.SelectedRows[0].Cells[4].Value;
                    
                    sb.Append(Environment.NewLine);
                }

                sb.Append("Total: " + selectedRowCount.ToString());
                textId.Text = id + "";
                textBoxName.Text = nom;
                textBoxFirstName.Text = prenom;
                numericUpDownAge.Value = age;
                textBoxAdress.Text = adress;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textId.Text);
            conn.Open();
            string query = "update personne set nom = '" + textBoxName.Text + "', prenom = '" + textBoxFirstName.Text + "', age = " + numericUpDownAge.Value + ", adress = '" + textBoxAdress.Text + "'  where id = " + id;
            using (SqlCommand cmd = new SqlCommand(query, conn)) {
                cmd.ExecuteNonQuery();
            }
            conn.Close();
            MessageBox.Show("Modification reussite!");
            form1.loadDataGridView(dataGridView);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.TryParse(textId.Text, out id) ? id : 0;
            if (id > 0)
            {
                conn.Open();
                string query = "delete from personne where id = " + id;
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show("Suppression reussite!");
            }
            else {
                MessageBox.Show("Aucun donnee n'a ete selectionner!");
            }
            form1.loadDataGridView(dataGridView);
        }
    }
}
