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

namespace AdminUI
{
    public partial class login : Form
    {
        ConnectionString str = new ConnectionString();

        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            str.setConStr(tb_name.Text, tb_pass.Text);
            OracleConnection con = new OracleConnection(new ConnectionString().getString());

            try
            {
                con.Open();
                con.Close();

                role_management obj = new role_management();
                obj.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Invalid name or password.");
            }
        }
    }
}
