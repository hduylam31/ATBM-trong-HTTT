namespace AdminUI
{
    partial class role_management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.tb_userPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_createUser = new System.Windows.Forms.Button();
            this.btn_dropUser = new System.Windows.Forms.Button();
            this.btn_alterUser = new System.Windows.Forms.Button();
            this.btn_createRole = new System.Windows.Forms.Button();
            this.btn_dropRole = new System.Windows.Forms.Button();
            this.btn_alterRole = new System.Windows.Forms.Button();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.dgv_role = new System.Windows.Forms.DataGridView();
            this.tb_rolePass = new System.Windows.Forms.TextBox();
            this.tb_roleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_searchUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_searchRole = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_userPriv = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_rolePriv = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_bang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_role)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_userName
            // 
            this.tb_userName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_userName.Location = new System.Drawing.Point(257, 153);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(202, 32);
            this.tb_userName.TabIndex = 0;
            // 
            // tb_userPass
            // 
            this.tb_userPass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_userPass.Location = new System.Drawing.Point(257, 216);
            this.tb_userPass.Name = "tb_userPass";
            this.tb_userPass.Size = new System.Drawing.Size(202, 32);
            this.tb_userPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(257, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "User name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(257, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // btn_createUser
            // 
            this.btn_createUser.BackColor = System.Drawing.Color.White;
            this.btn_createUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_createUser.Location = new System.Drawing.Point(272, 281);
            this.btn_createUser.Name = "btn_createUser";
            this.btn_createUser.Size = new System.Drawing.Size(171, 36);
            this.btn_createUser.TabIndex = 4;
            this.btn_createUser.Text = "Create user";
            this.btn_createUser.UseVisualStyleBackColor = false;
            this.btn_createUser.Click += new System.EventHandler(this.btn_createUser_Click);
            // 
            // btn_dropUser
            // 
            this.btn_dropUser.BackColor = System.Drawing.Color.White;
            this.btn_dropUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dropUser.Location = new System.Drawing.Point(272, 349);
            this.btn_dropUser.Name = "btn_dropUser";
            this.btn_dropUser.Size = new System.Drawing.Size(171, 36);
            this.btn_dropUser.TabIndex = 5;
            this.btn_dropUser.Text = "Delete user";
            this.btn_dropUser.UseVisualStyleBackColor = false;
            this.btn_dropUser.Click += new System.EventHandler(this.btn_dropUser_Click);
            // 
            // btn_alterUser
            // 
            this.btn_alterUser.BackColor = System.Drawing.Color.White;
            this.btn_alterUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_alterUser.Location = new System.Drawing.Point(272, 415);
            this.btn_alterUser.Name = "btn_alterUser";
            this.btn_alterUser.Size = new System.Drawing.Size(171, 36);
            this.btn_alterUser.TabIndex = 6;
            this.btn_alterUser.Text = "Change password";
            this.btn_alterUser.UseVisualStyleBackColor = false;
            this.btn_alterUser.Click += new System.EventHandler(this.btn_alterUser_Click);
            // 
            // btn_createRole
            // 
            this.btn_createRole.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_createRole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_createRole.Location = new System.Drawing.Point(275, 281);
            this.btn_createRole.Name = "btn_createRole";
            this.btn_createRole.Size = new System.Drawing.Size(171, 36);
            this.btn_createRole.TabIndex = 7;
            this.btn_createRole.Text = "Create role";
            this.btn_createRole.UseVisualStyleBackColor = false;
            this.btn_createRole.Click += new System.EventHandler(this.btn_createRole_Click);
            // 
            // btn_dropRole
            // 
            this.btn_dropRole.BackColor = System.Drawing.Color.White;
            this.btn_dropRole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dropRole.Location = new System.Drawing.Point(275, 349);
            this.btn_dropRole.Name = "btn_dropRole";
            this.btn_dropRole.Size = new System.Drawing.Size(171, 36);
            this.btn_dropRole.TabIndex = 8;
            this.btn_dropRole.Text = "Delete role";
            this.btn_dropRole.UseVisualStyleBackColor = false;
            this.btn_dropRole.Click += new System.EventHandler(this.btn_dropRole_Click);
            // 
            // btn_alterRole
            // 
            this.btn_alterRole.BackColor = System.Drawing.Color.White;
            this.btn_alterRole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_alterRole.Location = new System.Drawing.Point(275, 415);
            this.btn_alterRole.Name = "btn_alterRole";
            this.btn_alterRole.Size = new System.Drawing.Size(171, 36);
            this.btn_alterRole.TabIndex = 9;
            this.btn_alterRole.Text = "Change password";
            this.btn_alterRole.UseVisualStyleBackColor = false;
            this.btn_alterRole.Click += new System.EventHandler(this.btn_alterRole_Click);
            // 
            // dgv_user
            // 
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Location = new System.Drawing.Point(29, 234);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.RowHeadersWidth = 51;
            this.dgv_user.RowTemplate.Height = 29;
            this.dgv_user.Size = new System.Drawing.Size(200, 403);
            this.dgv_user.TabIndex = 10;
            this.dgv_user.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_user_CellDoubleClick);
            // 
            // dgv_role
            // 
            this.dgv_role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_role.Location = new System.Drawing.Point(14, 125);
            this.dgv_role.Name = "dgv_role";
            this.dgv_role.RowHeadersWidth = 51;
            this.dgv_role.RowTemplate.Height = 29;
            this.dgv_role.Size = new System.Drawing.Size(200, 403);
            this.dgv_role.TabIndex = 11;
            this.dgv_role.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_role_CellDoubleClick);
            // 
            // tb_rolePass
            // 
            this.tb_rolePass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_rolePass.Location = new System.Drawing.Point(255, 216);
            this.tb_rolePass.Name = "tb_rolePass";
            this.tb_rolePass.Size = new System.Drawing.Size(206, 32);
            this.tb_rolePass.TabIndex = 13;
            // 
            // tb_roleName
            // 
            this.tb_roleName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_roleName.Location = new System.Drawing.Point(255, 153);
            this.tb_roleName.Name = "tb_roleName";
            this.tb_roleName.Size = new System.Drawing.Size(206, 32);
            this.tb_roleName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(255, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Role name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(255, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password:";
            // 
            // tb_searchUser
            // 
            this.tb_searchUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_searchUser.Location = new System.Drawing.Point(17, 87);
            this.tb_searchUser.Name = "tb_searchUser";
            this.tb_searchUser.Size = new System.Drawing.Size(200, 32);
            this.tb_searchUser.TabIndex = 16;
            this.tb_searchUser.TextChanged += new System.EventHandler(this.tb_searchUser_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Find by name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Find by name:";
            // 
            // tb_searchRole
            // 
            this.tb_searchRole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_searchRole.Location = new System.Drawing.Point(14, 87);
            this.tb_searchRole.Name = "tb_searchRole";
            this.tb_searchRole.Size = new System.Drawing.Size(183, 32);
            this.tb_searchRole.TabIndex = 18;
            this.tb_searchRole.TextChanged += new System.EventHandler(this.tb_searchRole_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_userPriv);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tb_searchUser);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_alterUser);
            this.panel1.Controls.Add(this.btn_dropUser);
            this.panel1.Controls.Add(this.btn_createUser);
            this.panel1.Controls.Add(this.tb_userPass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_userName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 552);
            this.panel1.TabIndex = 20;
            this.panel1.Tag = "";
            // 
            // btn_userPriv
            // 
            this.btn_userPriv.BackColor = System.Drawing.Color.White;
            this.btn_userPriv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_userPriv.Location = new System.Drawing.Point(272, 482);
            this.btn_userPriv.Name = "btn_userPriv";
            this.btn_userPriv.Size = new System.Drawing.Size(171, 36);
            this.btn_userPriv.TabIndex = 19;
            this.btn_userPriv.Text = "Users\' privileges";
            this.btn_userPriv.UseVisualStyleBackColor = false;
            this.btn_userPriv.Click += new System.EventHandler(this.btn_userPriv_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(198, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 41);
            this.label8.TabIndex = 18;
            this.label8.Text = "USERS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btn_rolePriv);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tb_searchRole);
            this.panel2.Controls.Add(this.btn_createRole);
            this.panel2.Controls.Add(this.dgv_role);
            this.panel2.Controls.Add(this.tb_rolePass);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tb_roleName);
            this.panel2.Controls.Add(this.btn_dropRole);
            this.panel2.Controls.Add(this.btn_alterRole);
            this.panel2.Location = new System.Drawing.Point(545, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 552);
            this.panel2.TabIndex = 21;
            // 
            // btn_rolePriv
            // 
            this.btn_rolePriv.BackColor = System.Drawing.Color.White;
            this.btn_rolePriv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_rolePriv.Location = new System.Drawing.Point(275, 482);
            this.btn_rolePriv.Name = "btn_rolePriv";
            this.btn_rolePriv.Size = new System.Drawing.Size(171, 36);
            this.btn_rolePriv.TabIndex = 20;
            this.btn_rolePriv.Text = "Roles\' privileges";
            this.btn_rolePriv.UseVisualStyleBackColor = false;
            this.btn_rolePriv.Click += new System.EventHandler(this.btn_rolePriv_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(231, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 41);
            this.label9.TabIndex = 19;
            this.label9.Text = "ROLES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(911, 81);
            this.label7.TabIndex = 22;
            this.label7.Text = "Users and Roles Management";
            // 
            // btn_bang
            // 
            this.btn_bang.Location = new System.Drawing.Point(956, 12);
            this.btn_bang.Name = "btn_bang";
            this.btn_bang.Size = new System.Drawing.Size(94, 29);
            this.btn_bang.TabIndex = 23;
            this.btn_bang.Text = "Xem bảng";
            this.btn_bang.UseVisualStyleBackColor = true;
            this.btn_bang.Click += new System.EventHandler(this.btn_bang_Click);
            // 
            // role_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.btn_bang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_user);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "role_management";
            this.Text = "User and Role management";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_role)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_userName;
        private TextBox tb_userPass;
        private Label label1;
        private Label label2;
        private Button btn_createUser;
        private Button btn_dropUser;
        private Button btn_alterUser;
        private Button btn_createRole;
        private Button btn_dropRole;
        private Button btn_alterRole;
        private DataGridView dgv_user;
        private DataGridView dgv_role;
        private TextBox tb_rolePass;
        private TextBox tb_roleName;
        private Label label3;
        private Label label4;
        private TextBox tb_searchUser;
        private Label label5;
        private Label label6;
        private TextBox tb_searchRole;
        private Panel panel1;
        private Panel panel2;
        private Label label8;
        private Label label9;
        private Label label7;
        private Button btn_userPriv;
        private Button btn_rolePriv;
        private Button btn_bang;
    }
}