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
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM student", conn);
            DataSet ds = new DataSet();
            mySqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
