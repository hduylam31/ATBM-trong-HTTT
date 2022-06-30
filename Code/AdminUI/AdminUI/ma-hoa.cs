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
    public partial class ma_hoa : Form
    {
        OracleConnection con = new OracleConnection(new ConnectionString().getString());

        public ma_hoa()
        {
            InitializeComponent();
        }

        private void btn_bang_Click(object sender, EventArgs e)
        {
            string bang = tb_bang.Text;
            try
            {
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT * FROM SYS." + bang, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dvg_bang.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            role_management r = new role_management();
            r.Show();
            this.Hide();
        }
    }
}
