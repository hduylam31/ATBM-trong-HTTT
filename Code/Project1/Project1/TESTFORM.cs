using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Project1
{
    public partial class TESTFORM : Form
    {
        ConnectionString conStr = new ConnectionString();
        OracleConnection con = new OracleConnection();
        OracleCommand cmd;
        OracleDataAdapter adpt;
        DataTable dt;
        OracleDataReader dr;

        public TESTFORM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adpt = new OracleDataAdapter("Select * from NhanVien", con);
            dt = new DataTable();
            adpt.Fill(dt);
            DataGridView.DataSource = dt;

        }

        private void btn_fillComBox_Click(object sender, EventArgs e)
        {
            
            cmd = new OracleCommand("Select HOTEN From NhanVien", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string hoTen = dr["HOTEN"].ToString();
                comboBox1.Items.Add(hoTen);
            }
            con.Close();
        }

        private void btn_FillListBox_Click(object sender, EventArgs e)
        {
            cmd = new OracleCommand("Select HOTEN From NhanVien", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string hoTen = dr["HOTEN"].ToString();
                listBox1.Items.Add(hoTen);
            }
            con.Close();
        }

        private void btn_fillTextBox_Click(object sender, EventArgs e)
        {
            cmd = new OracleCommand("Select HOTEN From NhanVien", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string hoTen = dr["HOTEN"].ToString();
                textBox1.Text = hoTen;
            }
            con.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string name = tb_username.Text.ToString();
            string pass = tb_password.Text.ToString();

            conStr.setConStr(name, pass);

            con.ConnectionString = conStr.getString();
            MessageBox.Show("Connected!");
        }
    }
}