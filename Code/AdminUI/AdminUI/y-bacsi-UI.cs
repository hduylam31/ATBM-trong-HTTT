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
    public partial class y_bacsi_UI : Form
    {
        OracleConnection con = new OracleConnection(new ConnectionString().getString());

        public y_bacsi_UI()
        {
            InitializeComponent();
            display();
        }

        private void display()
        {
            try
            {
                con.Open();
<<<<<<< HEAD
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT DISTINCT MAHSBA, MABN, NGAY, CHANDOAN, MABS, MAKHOA, MACSYT, KETLUAN FROM C##Admin_BenhVien.V_HSBA_KQDV", con);
=======
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT DISTINCT MAHSBA, MABN, NGAY, CHANDOAN, MABS, MAKHOA, MACSYT, KETLUAN FROM V_HSBA_KQDV", con);
>>>>>>> 8667402447bf2047a5f9023cc42626f5989ff35e
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dgv_HSBA.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_searchHSBA_Click(object sender, EventArgs e)
        {
            string MAHS = tb_HSBA.Text;
            try
            {
                con.Open();
<<<<<<< HEAD
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT DISTINCT MAHSBA, MABN, NGAY, CHANDOAN, MABS, MAKHOA, MACSYT, KETLUAN FROM C##Admin_BenhVien.V_HSBA_KQDV WHERE MAHSBA = " + MAHS, con);
=======
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT DISTINCT MAHSBA, MABN, NGAY, CHANDOAN, MABS, MAKHOA, MACSYT, KETLUAN FROM V_HSBA_KQDV WHERE MAHSBA = " + MAHS, con);
>>>>>>> 8667402447bf2047a5f9023cc42626f5989ff35e
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dgv_HSBA.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_timBN_Click(object sender, EventArgs e)
        {
            string BN = tb_BN.Text;
            try
            {
                con.Open();
<<<<<<< HEAD
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT * FROM C##Admin_BenhVien.BENHNHAN WHERE MABN = " + BN + " OR CMND = " + BN, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dgv_BN.DataSource = dt;
=======
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT * FROM BENHNHAN WHERE MABN = " + BN + " OR CMND = " + BN, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dgv_HSBA.DataSource = dt;
>>>>>>> 8667402447bf2047a5f9023cc42626f5989ff35e
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgv_HSBA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int MAHS = (int)dgv_HSBA.Rows[e.RowIndex].Cells[0].Value;
            try
            {
                con.Open();
<<<<<<< HEAD
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT MADV, NGAYDV, KETQUA FROM C##Admin_BenhVien.V_HSBA_KQDV WHERE MAHSBA = " + MAHS, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dgv_DV.DataSource = dt;
=======
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT MADV, NGAYDV, KETQUA FROM SYS.V_HSBA_KQDV WHERE MAHSBA = " + MAHS, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dgv_HSBA.DataSource = dt;
>>>>>>> 8667402447bf2047a5f9023cc42626f5989ff35e
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
