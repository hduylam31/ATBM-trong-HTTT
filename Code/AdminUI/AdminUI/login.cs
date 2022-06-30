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
        string username;
        string password;

        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            str.setConStr(tb_name.Text, tb_pass.Text);
            OracleConnection con = new OracleConnection(new ConnectionString().getString());
            username = str.getUser();
            password = str.getPass();

            try
            {
                con.Open();
                con.Close();


                if (username.Substring(0, 3) == "YBS")
                {
                    y_bacsi_UI ybs = new y_bacsi_UI();
                    ybs.Show();
                    this.Hide();
                    return;
                }
                if(username.Substring(0,2) == "TT")
                {
                    thanh_tra_UI tt = new thanh_tra_UI();
                    tt.Show();
                    this.Hide();
                    return;
                }
                if(username.Substring(0,2) == "NC")
                {
                    nghien_cuu nc = new nghien_cuu();
                    nc.Show();
                    this.Hide();
                    return;
                }
                if(username.Substring(0,5) == "C##NV")
                {
                    nhan_vien_UI nv = new nhan_vien_UI();
                    nv.Show();
                    this.Hide();
                    return;
                }
                if (username.Substring(0, 5) == "C##BN")
                {
                    benh_nhan nv = new benh_nhan();
                    nv.Show();
                    this.Hide();
                    return;
                }
                if (username.Substring(0,5) == "C##Ad")
                {
                    audit a = new audit();
                    a.Show();
                    this.Hide();
                    return;
                }

                role_management rm = new role_management();
                rm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                con.Close();
                //MessageBox.Show("Invalid name or password.");
                MessageBox.Show(ex.ToString());
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
