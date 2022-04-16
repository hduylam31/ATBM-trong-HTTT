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

namespace BenhVien
{
    public partial class Form1 : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
       

        DataTable dt;
        OracleDataAdapter adpt;
        OracleCommand cmd;
        OracleDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        public void display1()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new OracleDataAdapter("select * from dba_tab_privs", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            display1();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            con.Open();
            cmd = new OracleCommand("Grant_Privs_toUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("User_Name", OracleDbType.Varchar2).Value = textBox5.Text;
            cmd.Parameters.Add("Privs_name", OracleDbType.Varchar2).Value = comboBox2.Text;
            cmd.Parameters.Add("Table_Name", OracleDbType.Varchar2).Value = textBox4.Text;
            cmd.Parameters.Add("grant_option", OracleDbType.Varchar2).Value = comboBox3.Text;
            adpt = new OracleDataAdapter(cmd);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("Grant Success");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dt = new DataTable();
            con.Open();           
            cmd = new OracleCommand("Revoke_Object_Privs_User", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("User_Name", OracleDbType.Varchar2).Value = textBox1.Text;
            cmd.Parameters.Add("priv", OracleDbType.Varchar2).Value = comboBox1.Text;
            cmd.Parameters.Add("a_object", OracleDbType.Varchar2).Value = textBox2.Text;
            adpt = new OracleDataAdapter(cmd);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("Revoke Success");        
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dt = new DataTable();
            con.Open();
            adpt = new OracleDataAdapter("select * from dba_tab_privs where grantee ='" + textBox3.Text + "'", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
