using MySql.Data.MySqlClient;
using System.Data;



namespace projectStudentManagement
{
    public partial class Form1 : Form
    {

        //Connection string
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=student_information;UID=root;");
        public Form1()
        {
            InitializeComponent();
        }

        private void ViewGrid_bt_Click(object sender, EventArgs e)
        {
            viewDataGrid();
        }

        void viewDataGrid()
        {
            try
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM student", conn);
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegNo_tx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insert_bt_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("INSERT INTO student(RegNo, Student, Address) VALUES(" + RegNo_tx.Text + ",'" + Name_tx.Text + "','" + Address_tx.Text + "')", conn);
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds);
                viewDataGrid();
                MessageBox.Show("Student Inserted Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void Update_bt_Click(object sender, EventArgs e)
        {

            try
            {
                string update_query = "UPDATE student SET RegNo = @regno, Student = @name, Address = @address WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(update_query, conn);
                cmd.Parameters.AddWithValue("@regno", RegNo_tx.Text);
                cmd.Parameters.AddWithValue("@name", Name_tx.Text);
                cmd.Parameters.AddWithValue("@address", Address_tx.Text);
                cmd.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells[0].Value);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                viewDataGrid();
                MessageBox.Show("Student Updated Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }
    }
}
