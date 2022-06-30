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
    public partial class nghien_cuu : Form
    {
        OracleConnection con = new OracleConnection(new ConnectionString().getString());

        public nghien_cuu()
        {
            InitializeComponent();
        }

        private void btn_hsba_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT * FROM SYS.V_NGHIENCUU_HSBA", con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_dv_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT * FROM SYS.V_NGHIENCUU_HSBA_DV", con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
