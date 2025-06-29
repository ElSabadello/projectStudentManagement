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

namespace projectStudentManagement
{
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        


        private void Save_bt_Click(object sender, EventArgs e)
        {
            const string query = "INSERT INTO student(RegNo, Student, Address) VALUES(@regno, @student, @address)";

            try
            {
                using var conn = DbConnection.GetConnection();
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@regno", RegNo_tx.Text);
                cmd.Parameters.AddWithValue("@student", Name_tx.Text);
                cmd.Parameters.AddWithValue("@address", Address_tx.Text);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student CREATED Successfully!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Student NOT CREATED");
                    Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
