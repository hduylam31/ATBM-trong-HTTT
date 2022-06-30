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
    public partial class thanh_tra_UI : Form
    {
        OracleConnection con = new OracleConnection(new ConnectionString().getString());

        public thanh_tra_UI()
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
