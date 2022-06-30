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
    public partial class nhan_vien_UI : Form
    {
        OracleConnection con = new OracleConnection(new ConnectionString().getString());

        public nhan_vien_UI()
        {
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            try
            {
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT * FROM C##Admin_BenhVien.NHANVIEN", con);
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

        private void nhan_vien_UI_Load(object sender, EventArgs e)
        {

        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            string ten = tb_ten.Text;
            string sdt = tb_dt.Text;
            string que = tb_que.Text;
            //Int64 a = Int64.Parse(sdt);


            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand("UPDATE C##Admin_BenhVien.NHANVIEN SET HOTEN = :ten, SDT = TO_NUMBER(:sdt), QUEQUAN = :que", con);
                cmd.Parameters.Add(new OracleParameter("ten", ten));
                cmd.Parameters.Add(new OracleParameter("sdt", sdt));
                cmd.Parameters.Add(new OracleParameter("que", que));
                cmd.ExecuteNonQuery();
                //command.Connection.Open();
                //command.Connection.Close();
                con.Close();
                Display();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tb_dt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_que_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_ttcn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
