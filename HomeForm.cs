using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectStudentManagement
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            viewGrid();
        }

        private void Add_bt_Click(object sender, EventArgs e)
        {
            InsertForm insertForm = new InsertForm();
            insertForm.ShowDialog();
        }

        public void viewGrid()
        {
            const string query = "SELECT * FROM student";

            try
            {
                using var conn = DbConnection.GetConnection();
                using var adapter = new MySqlDataAdapter(query, conn);
                var ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il caricamento dei dati: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            viewGrid();
        }

        private void Update_bt_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.ShowDialog();
        }

        private void Delete_bt_Click(object sender, EventArgs e)
        {
            using var conn = DbConnection.GetConnection();
            const string query = "DELETE from student WHERE id = @id";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells["id"].Value);
                cmd.ExecuteNonQuery();
                viewGrid();
                MessageBox.Show("Student deleted Successfully!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Failed to delete {ex.Message}");
            }
        }
    }
}
