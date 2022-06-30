namespace AdminUI
{
    partial class nhan_vien_UI
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
            this.dgv_ttcn = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_dt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_que = new System.Windows.Forms.TextBox();
            this.btn_capnhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttcn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ttcn
            // 
            this.dgv_ttcn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ttcn.Location = new System.Drawing.Point(12, 32);
            this.dgv_ttcn.Name = "dgv_ttcn";
            this.dgv_ttcn.RowHeadersWidth = 51;
            this.dgv_ttcn.RowTemplate.Height = 29;
            this.dgv_ttcn.Size = new System.Drawing.Size(1038, 87);
            this.dgv_ttcn.TabIndex = 0;
            this.dgv_ttcn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ttcn_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin nhân viên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(75, 155);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(125, 27);
            this.tb_ten.TabIndex = 3;
            this.tb_ten.TextChanged += new System.EventHandler(this.tb_ten_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_dt
            // 
            this.tb_dt.Location = new System.Drawing.Point(118, 208);
            this.tb_dt.Name = "tb_dt";
            this.tb_dt.Size = new System.Drawing.Size(125, 27);
            this.tb_dt.TabIndex = 5;
            this.tb_dt.TextChanged += new System.EventHandler(this.tb_dt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quê quán:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_que
            // 
            this.tb_que.Location = new System.Drawing.Point(94, 259);
            this.tb_que.Name = "tb_que";
            this.tb_que.Size = new System.Drawing.Size(125, 27);
            this.tb_que.TabIndex = 7;
            this.tb_que.TextChanged += new System.EventHandler(this.tb_que_TextChanged);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(12, 312);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(94, 29);
            this.btn_capnhat.TabIndex = 8;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // nhan_vien_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.tb_que);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_dt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_ttcn);
            this.Name = "nhan_vien_UI";
            this.Text = "nhan_vien_UI";
            this.Load += new System.EventHandler(this.nhan_vien_UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttcn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_ttcn;
        private Label label1;
        private Label label2;
        private TextBox tb_ten;
        private Label label3;
        private TextBox tb_dt;
        private Label label4;
        private TextBox tb_que;
        private Button btn_capnhat;
    }
}