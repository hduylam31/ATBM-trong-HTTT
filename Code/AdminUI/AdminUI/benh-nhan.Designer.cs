namespace AdminUI
{
    partial class benh_nhan
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
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ttcn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttcn)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(12, 212);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(94, 29);
            this.btn_capnhat.TabIndex = 17;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(75, 159);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(125, 27);
            this.tb_ten.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thông tin bệnh nhân:";
            // 
            // dgv_ttcn
            // 
            this.dgv_ttcn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ttcn.Location = new System.Drawing.Point(12, 36);
            this.dgv_ttcn.Name = "dgv_ttcn";
            this.dgv_ttcn.RowHeadersWidth = 51;
            this.dgv_ttcn.RowTemplate.Height = 29;
            this.dgv_ttcn.Size = new System.Drawing.Size(1038, 87);
            this.dgv_ttcn.TabIndex = 9;
            // 
            // benh_nhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_ttcn);
            this.Name = "benh_nhan";
            this.Text = "benh_nhan";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttcn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_capnhat;
        private TextBox tb_ten;
        private Label label2;
        private Label label1;
        private DataGridView dgv_ttcn;
    }
}