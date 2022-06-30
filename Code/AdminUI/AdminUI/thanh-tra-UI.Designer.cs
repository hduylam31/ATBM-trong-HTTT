namespace AdminUI
{
    partial class thanh_tra_UI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_bang = new System.Windows.Forms.TextBox();
            this.btn_bang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 616);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng:";
            // 
            // tb_bang
            // 
            this.tb_bang.Location = new System.Drawing.Point(64, 12);
            this.tb_bang.Name = "tb_bang";
            this.tb_bang.Size = new System.Drawing.Size(125, 27);
            this.tb_bang.TabIndex = 2;
            // 
            // btn_bang
            // 
            this.btn_bang.Location = new System.Drawing.Point(195, 12);
            this.btn_bang.Name = "btn_bang";
            this.btn_bang.Size = new System.Drawing.Size(94, 29);
            this.btn_bang.TabIndex = 3;
            this.btn_bang.Text = "Xem";
            this.btn_bang.UseVisualStyleBackColor = true;
            this.btn_bang.Click += new System.EventHandler(this.btn_bang_Click);
            // 
            // thanh_tra_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.btn_bang);
            this.Controls.Add(this.tb_bang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "thanh_tra_UI";
            this.Text = "thanh_tra_UI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox tb_bang;
        private Button btn_bang;
    }
}