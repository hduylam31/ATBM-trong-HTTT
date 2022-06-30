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
    public partial class audit : Form
    {
        OracleConnection con = new OracleConnection(new ConnectionString().getString());

        public audit()
        {
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            try
            {
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT DBUSERNAME ,ACTION_NAME, OBJECT_SCHEMA, OBJECT_NAME, EVENT_TIMESTAMP, SQL_TEXT FROM unified_audit_trail", con);
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

        private void audit_Load(object sender, EventArgs e)
        {

        }
    }
}
