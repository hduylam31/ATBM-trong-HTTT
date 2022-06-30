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
    public partial class benh_nhan : Form
    {
        OracleConnection con = new OracleConnection(new ConnectionString().getString());

        public benh_nhan()
        {
            InitializeComponent();
            Display();
        }
        private void Display()
        {
            try
            {
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT * FROM C##Admin_BenhVien.BENHNHAN", con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dgv_ttcn.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            string ten = tb_ten.Text;

            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand("UPDATE C##Admin_BenhVien.BENHNHAN SET TENBN = :ten", con);
                cmd.Parameters.Add(new OracleParameter("ten", ten));
                cmd.ExecuteNonQuery();
                con.Close();
                Display();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
