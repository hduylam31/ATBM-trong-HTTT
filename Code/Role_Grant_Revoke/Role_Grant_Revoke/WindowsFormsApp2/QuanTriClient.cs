using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace WindowsFormsApp2
{
    public partial class QuanTriClient : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        DataTable dt;
        OracleDataAdapter adpt;
        OracleCommand cmd;
        OracleDataReader dr;
        public QuanTriClient()
        {

            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open(); 
            DataSet data = new DataSet();
            String query = "SELECT * FROM role_tab_privs";
            OracleDataAdapter adp = new OracleDataAdapter(query, con);
            adp.Fill(data);
            dataGridView1.DataSource = data.Tables[0];

            DataSet data1 = new DataSet();
            String query1 = "SELECT * FROM dba_roles";
            OracleDataAdapter adp1= new OracleDataAdapter(query1, con);
            adp1.Fill(data1);
            dataGridView2.DataSource = data1.Tables[0];
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            con.Open();
            cmd = new OracleCommand("Grant_Privs_toRole", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Role_Name", OracleDbType.Varchar2).Value = textBox1.Text;
            cmd.Parameters.Add("Privs_name", OracleDbType.Varchar2).Value = comboBox1.Text;
            cmd.Parameters.Add("Table_Name", OracleDbType.Varchar2).Value = textBox2.Text;
            adpt = new OracleDataAdapter(cmd);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("Grant Success");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            con.Open();
            cmd = new OracleCommand("Revoke_Privs_toRole", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Role_Name", OracleDbType.Varchar2).Value = textBox1.Text;
            cmd.Parameters.Add("Privs_name", OracleDbType.Varchar2).Value = comboBox1.Text;
            cmd.Parameters.Add("Table_Name", OracleDbType.Varchar2).Value = textBox2.Text;
            adpt = new OracleDataAdapter(cmd);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("Revoke Success");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataSet data = new DataSet();
            String query = "SELECT * FROM role_tab_privs WHERE ROLE = " + "'" + textBox3.Text + "'";
            OracleDataAdapter adp = new OracleDataAdapter(query, con);
            adp.Fill(data);
            dataGridView1.DataSource = data.Tables[0];

            DataSet data1 = new DataSet();
            String query1 = "SELECT * FROM dba_roles WHERE ROLE = " + "'" + textBox3.Text + "'";
            OracleDataAdapter adp1 = new OracleDataAdapter(query1, con);
            adp1.Fill(data1);
            dataGridView2.DataSource = data1.Tables[0];
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            DataSet data = new DataSet();
            String query = "SELECT * FROM role_tab_privs ";
            OracleDataAdapter adp = new OracleDataAdapter(query, con);
            adp.Fill(data);
            dataGridView1.DataSource = data.Tables[0];

            DataSet data1 = new DataSet();
            String query1 = "SELECT * FROM dba_roles ";
            OracleDataAdapter adp1 = new OracleDataAdapter(query1, con);
            adp1.Fill(data1);
            dataGridView2.DataSource = data1.Tables[0];
            con.Close();
        }
    }
}
