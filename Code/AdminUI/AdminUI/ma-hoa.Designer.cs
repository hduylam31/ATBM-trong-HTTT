namespace AdminUI
{
    partial class ma_hoa
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
            this.dvg_bang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_bang = new System.Windows.Forms.TextBox();
            this.btn_bang = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_bang)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg_bang
            // 
            this.dvg_bang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_bang.Location = new System.Drawing.Point(12, 46);
            this.dvg_bang.Name = "dvg_bang";
            this.dvg_bang.RowHeadersWidth = 51;
            this.dvg_bang.RowTemplate.Height = 29;
            this.dvg_bang.Size = new System.Drawing.Size(1038, 615);
            this.dvg_bang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên bảng:";
            // 
            // tb_bang
            // 
            this.tb_bang.Location = new System.Drawing.Point(91, 12);
            this.tb_bang.Name = "tb_bang";
            this.tb_bang.Size = new System.Drawing.Size(125, 27);
            this.tb_bang.TabIndex = 2;
            // 
            // btn_bang
            // 
            this.btn_bang.Location = new System.Drawing.Point(222, 11);
            this.btn_bang.Name = "btn_bang";
            this.btn_bang.Size = new System.Drawing.Size(94, 29);
            this.btn_bang.TabIndex = 3;
            this.btn_bang.Text = "Xem";
            this.btn_bang.UseVisualStyleBackColor = true;
            this.btn_bang.Click += new System.EventHandler(this.btn_bang_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(956, 6);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(94, 29);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // ma_hoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_bang);
            this.Controls.Add(this.tb_bang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvg_bang);
            this.Name = "ma_hoa";
            this.Text = "ma_hoa";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_bang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dvg_bang;
        private Label label1;
        private TextBox tb_bang;
        private Button btn_bang;
        private Button btn_thoat;
    }
}