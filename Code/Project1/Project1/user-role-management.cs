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

namespace Project1
{
    public partial class role_management : Form
    {
        OracleConnection con = new OracleConnection(new ConnectionString().getString());

        public role_management()
        {
            InitializeComponent();
            clearRoleInput();
            clearUserInput();
            display_users();
            display_roles();
        }

        private void clearUserInput()
        {
            tb_userName.Text = "";
            tb_userPass.Text = "";

            btn_dropUser.Enabled = false;
            btn_alterUser.Enabled = false;
        }

        private void clearRoleInput()
        {
            tb_roleName.Text = "";
            tb_rolePass.Text = "";

            btn_alterRole.Enabled = false;
            btn_dropRole.Enabled = false;
        }

        private void display_users()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("select username from dba_users", con);
                adpt.Fill(dt);
                dgv_user.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void display_roles()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("select role from dba_roles", con);
                adpt.Fill(dt);
                dgv_role.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_createUser_Click(object sender, EventArgs e)
        {
            string name = tb_userName.Text;
            string password = tb_userPass.Text;

            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand("BEGIN\nGrant_NewUser(:name, :pass);\nEND;", con);
                cmd.Parameters.Add(new OracleParameter("name", name));
                cmd.Parameters.Add(new OracleParameter("pass", password));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Create user successfully.");
                clearUserInput();
                display_users();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_dropUser_Click(object sender, EventArgs e)
        {
            string name = tb_userName.Text;

            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand("BEGIN\nDrop_User(:name);\nEND;", con);
                cmd.Parameters.Add(new OracleParameter("name", name));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete user successfully.");
                display_users();
                clearUserInput();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_alterUser_Click(object sender, EventArgs e)
        {
            string name = tb_userName.Text;
            string password = tb_userPass.Text;

            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand("BEGIN\nAlter_User(:name, :pass);\nEND;", con);
                cmd.Parameters.Add(new OracleParameter("name", name));
                cmd.Parameters.Add(new OracleParameter("pass", password));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Change user's password successfully.");
                display_users();
                clearUserInput();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_createRole_Click(object sender, EventArgs e)
        {
            string name = tb_roleName.Text;
            string password = tb_rolePass.Text;

            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand("BEGIN\nGrant_NewRole(:name, :pass);\nEND;", con);
                cmd.Parameters.Add(new OracleParameter("name", name));
                cmd.Parameters.Add(new OracleParameter("pass", password));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Create role successfully.");
                display_roles();
                clearRoleInput();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_dropRole_Click(object sender, EventArgs e)
        {
            string name = tb_roleName.Text;
            string password = tb_rolePass.Text;

            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand("BEGIN\nDrop_Role(:name);\nEND;", con);
                cmd.Parameters.Add(new OracleParameter("name", name));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete role successfully.");
                display_roles();
                clearRoleInput();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_alterRole_Click(object sender, EventArgs e)
        {
            string name = tb_roleName.Text;
            string password = tb_rolePass.Text;

            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand("BEGIN\nAlter_Role(:name, :pass);\nEND;", con);
                cmd.Parameters.Add(new OracleParameter("name", name));
                cmd.Parameters.Add(new OracleParameter("pass", password));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Change role's password successfully.");
                display_roles();
                clearRoleInput();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_searchRole_TextChanged(object sender, EventArgs e)
        {
            string role = tb_searchRole.Text;
            try
            {
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("Select role From dba_roles Where upper(role) like '%" + role.ToUpper() + "%'", con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dgv_role.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_searchUser_TextChanged(object sender, EventArgs e)
        {
            string user  = tb_searchUser.Text;
            try
            {
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("Select username From dba_users Where upper(username) like '%" + user.ToUpper() + "%'", con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dgv_user.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgv_user_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_userName.Text = dgv_user.Rows[e.RowIndex].Cells[0].Value.ToString();

            btn_dropUser.Enabled = true;
            btn_alterUser.Enabled = true;
        }

        private void dgv_role_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_roleName.Text = dgv_role.Rows[e.RowIndex].Cells[0].Value.ToString();

            btn_dropRole.Enabled = true;
            btn_alterRole.Enabled = true;
        }
    }
}
