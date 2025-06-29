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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
            viewGrid();
        }

        private void viewGrid()
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

        private void Save_bt_Click(object sender, EventArgs e)
        {
            using var conn = DbConnection.GetConnection();
            const string query = "UPDATE student SET RegNo = @regno, Student = @name, Address = @address WHERE id = @id";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@regno", RegNo_tx.Text);
                cmd.Parameters.AddWithValue("@name", Name_tx.Text);
                cmd.Parameters.AddWithValue("@address", Address_tx.Text);
                cmd.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells["id"].Value);
                cmd.ExecuteNonQuery();
                viewGrid();
                MessageBox.Show("Student Updated Successfully!");
                Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
