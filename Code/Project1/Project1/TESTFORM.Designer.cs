namespace Project1
{
    partial class TESTFORM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_FitGridView = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_fillComBox = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_FillListBox = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fillTextBox = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_FitGridView
            // 
            this.btn_FitGridView.Location = new System.Drawing.Point(660, 235);
            this.btn_FitGridView.Name = "btn_FitGridView";
            this.btn_FitGridView.Size = new System.Drawing.Size(128, 38);
            this.btn_FitGridView.TabIndex = 0;
            this.btn_FitGridView.Text = "Fit GridView";
            this.btn_FitGridView.UseVisualStyleBackColor = true;
            this.btn_FitGridView.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 12);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 29;
            this.DataGridView.Size = new System.Drawing.Size(776, 217);
            this.DataGridView.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // btn_fillComBox
            // 
            this.btn_fillComBox.Location = new System.Drawing.Point(169, 241);
            this.btn_fillComBox.Name = "btn_fillComBox";
            this.btn_fillComBox.Size = new System.Drawing.Size(127, 29);
            this.btn_fillComBox.TabIndex = 3;
            this.btn_fillComBox.Text = "Fill ComboBox";
            this.btn_fillComBox.UseVisualStyleBackColor = true;
            this.btn_fillComBox.Click += new System.EventHandler(this.btn_fillComBox_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(302, 241);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 184);
            this.listBox1.TabIndex = 4;
            // 
            // btn_FillListBox
            // 
            this.btn_FillListBox.Location = new System.Drawing.Point(520, 244);
            this.btn_FillListBox.Name = "btn_FillListBox";
            this.btn_FillListBox.Size = new System.Drawing.Size(127, 29);
            this.btn_FillListBox.TabIndex = 5;
            this.btn_FillListBox.Text = "Fill ListBox";
            this.btn_FillListBox.UseVisualStyleBackColor = true;
            this.btn_FillListBox.Click += new System.EventHandler(this.btn_FillListBox_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(660, 333);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên đầu tiên";
            // 
            // btn_fillTextBox
            // 
            this.btn_fillTextBox.Location = new System.Drawing.Point(660, 366);
            this.btn_fillTextBox.Name = "btn_fillTextBox";
            this.btn_fillTextBox.Size = new System.Drawing.Size(127, 29);
            this.btn_fillTextBox.TabIndex = 8;
            this.btn_fillTextBox.Text = "Fill TextBox";
            this.btn_fillTextBox.UseVisualStyleBackColor = true;
            this.btn_fillTextBox.Click += new System.EventHandler(this.btn_fillTextBox_Click);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(12, 344);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(125, 27);
            this.tb_username.TabIndex = 9;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(12, 377);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '♥';
            this.tb_password.Size = new System.Drawing.Size(125, 27);
            this.tb_password.TabIndex = 10;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 409);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 29);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.btn_fillTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_FillListBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_fillComBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.btn_FitGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_FitGridView;
        private DataGridView DataGridView;
        private ComboBox comboBox1;
        private Button btn_fillComBox;
        private ListBox listBox1;
        private Button btn_FillListBox;
        private TextBox textBox1;
        private Label label1;
        private Button btn_fillTextBox;
        private TextBox tb_username;
        private TextBox tb_password;
        private Button btnConnect;
    }
}