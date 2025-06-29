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
                string query = "INSERT INTO student(RegNo, Student, Address) VALUES(@regno, @name, @address)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@regno", RegNo_tx.Text);
                cmd.Parameters.AddWithValue("@name", Name_tx.Text);
                cmd.Parameters.AddWithValue("@address", Address_tx.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void Delete_bt_Click(object sender, EventArgs e)
        {
            string query = "DELETE from student WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells["id"].Value);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            viewDataGrid();
            MessageBox.Show("Student deleted Successfully!");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Clear_bt_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void Open_bt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
