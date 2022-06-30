namespace AdminUI
{
    partial class nghien_cuu
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
            this.btn_hsba = new System.Windows.Forms.Button();
            this.btn_dv = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hsba
            // 
            this.btn_hsba.Location = new System.Drawing.Point(12, 12);
            this.btn_hsba.Name = "btn_hsba";
            this.btn_hsba.Size = new System.Drawing.Size(137, 29);
            this.btn_hsba.TabIndex = 0;
            this.btn_hsba.Text = "Hồ sơ bệnh án";
            this.btn_hsba.UseVisualStyleBackColor = true;
            this.btn_hsba.Click += new System.EventHandler(this.btn_hsba_Click);
            // 
            // btn_dv
            // 
            this.btn_dv.Location = new System.Drawing.Point(203, 12);
            this.btn_dv.Name = "btn_dv";
            this.btn_dv.Size = new System.Drawing.Size(94, 29);
            this.btn_dv.TabIndex = 1;
            this.btn_dv.Text = "Dịch vụ";
            this.btn_dv.UseVisualStyleBackColor = true;
            this.btn_dv.Click += new System.EventHandler(this.btn_dv_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 614);
            this.dataGridView1.TabIndex = 2;
            // 
            // nghien_cuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_dv);
            this.Controls.Add(this.btn_hsba);
            this.Name = "nghien_cuu";
            this.Text = "nghien_cuu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_hsba;
        private Button btn_dv;
        private DataGridView dataGridView1;
    }
}