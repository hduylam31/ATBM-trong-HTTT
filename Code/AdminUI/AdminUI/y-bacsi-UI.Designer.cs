namespace AdminUI
{
    partial class y_bacsi_UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_DV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_timHS = new System.Windows.Forms.Button();
            this.dgv_HSBA = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_HSBA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_timBN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_BN = new System.Windows.Forms.DataGridView();
            this.tb_BN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HSBA)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hồ sơ bệnh án điều trị";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.dgv_DV);
            this.panel2.Location = new System.Drawing.Point(12, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 266);
            this.panel2.TabIndex = 1;
            // 
            // dgv_DV
            // 
            this.dgv_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DV.Location = new System.Drawing.Point(12, 15);
            this.dgv_DV.Name = "dgv_DV";
            this.dgv_DV.RowHeadersWidth = 51;
            this.dgv_DV.RowTemplate.Height = 29;
            this.dgv_DV.Size = new System.Drawing.Size(480, 238);
            this.dgv_DV.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_timHS);
            this.panel1.Controls.Add(this.dgv_HSBA);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_HSBA);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 269);
            this.panel1.TabIndex = 0;
            // 
            // btn_timHS
            // 
            this.btn_timHS.Location = new System.Drawing.Point(219, 5);
            this.btn_timHS.Name = "btn_timHS";
            this.btn_timHS.Size = new System.Drawing.Size(94, 29);
            this.btn_timHS.TabIndex = 3;
            this.btn_timHS.Text = "tìm kiếm";
            this.btn_timHS.UseVisualStyleBackColor = true;
            this.btn_timHS.Click += new System.EventHandler(this.btn_searchHSBA_Click);
            // 
            // dgv_HSBA
            // 
            this.dgv_HSBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HSBA.Location = new System.Drawing.Point(12, 40);
            this.dgv_HSBA.Name = "dgv_HSBA";
            this.dgv_HSBA.RowHeadersWidth = 51;
            this.dgv_HSBA.RowTemplate.Height = 29;
            this.dgv_HSBA.Size = new System.Drawing.Size(1011, 217);
            this.dgv_HSBA.TabIndex = 2;
            this.dgv_HSBA.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HSBA_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hồ sơ:";
            // 
            // tb_HSBA
            // 
            this.tb_HSBA.Location = new System.Drawing.Point(88, 7);
            this.tb_HSBA.Name = "tb_HSBA";
            this.tb_HSBA.Size = new System.Drawing.Size(125, 27);
            this.tb_HSBA.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kết quả dịch vụ của hồ sơ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btn_timBN);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dgv_BN);
            this.panel3.Controls.Add(this.tb_BN);
            this.panel3.Location = new System.Drawing.Point(532, 395);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(518, 266);
            this.panel3.TabIndex = 4;
            // 
            // btn_timBN
            // 
            this.btn_timBN.Location = new System.Drawing.Point(224, 6);
            this.btn_timBN.Name = "btn_timBN";
            this.btn_timBN.Size = new System.Drawing.Size(94, 29);
            this.btn_timBN.TabIndex = 4;
            this.btn_timBN.Text = "tìm kiếm";
            this.btn_timBN.UseVisualStyleBackColor = true;
            this.btn_timBN.Click += new System.EventHandler(this.btn_timBN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tìm kiếm:";
            // 
            // dgv_BN
            // 
            this.dgv_BN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BN.Location = new System.Drawing.Point(14, 40);
            this.dgv_BN.Name = "dgv_BN";
            this.dgv_BN.RowHeadersWidth = 51;
            this.dgv_BN.RowTemplate.Height = 29;
            this.dgv_BN.Size = new System.Drawing.Size(494, 213);
            this.dgv_BN.TabIndex = 1;
            // 
            // tb_BN
            // 
            this.tb_BN.Location = new System.Drawing.Point(93, 7);
            this.tb_BN.Name = "tb_BN";
            this.tb_BN.Size = new System.Drawing.Size(125, 27);
            this.tb_BN.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(532, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tìm kiếm thông tin bệnh nhân";
            // 
            // y_bacsi_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "y_bacsi_UI";
            this.Text = "Giao dien Y/Bác sĩ";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HSBA)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Panel panel2;
        private DataGridView dgv_DV;
        private Panel panel1;
        private DataGridView dgv_HSBA;
        private Label label2;
        private TextBox tb_HSBA;
        private Label label3;
        private Panel panel3;
        private Label label5;
        private DataGridView dgv_BN;
        private TextBox tb_BN;
        private Label label4;
        private Button btn_timHS;
        private Button btn_timBN;
    }
}