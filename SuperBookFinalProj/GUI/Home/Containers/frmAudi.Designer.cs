namespace SuperBookFinalProj.GUI.Home.Containers
{
    partial class frmAudi
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            BackBtn = new Button();
            label1 = new Label();
            NextBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 48, 61);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(26, 53);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 295);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(24, 17);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(744, 206);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.FromArgb(161, 181, 195);
            BackBtn.Location = new Point(37, 395);
            BackBtn.Margin = new Padding(3, 2, 3, 2);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(92, 31);
            BackBtn.TabIndex = 16;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += CncBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(26, 20);
            label1.Name = "label1";
            label1.Size = new Size(136, 24);
            label1.TabIndex = 18;
            label1.Text = "AUDITORIUM";
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.FromArgb(161, 181, 195);
            NextBtn.Location = new Point(724, 395);
            NextBtn.Margin = new Padding(3, 2, 3, 2);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(83, 31);
            NextBtn.TabIndex = 17;
            NextBtn.Text = "Next";
            NextBtn.UseVisualStyleBackColor = false;
            NextBtn.Click += ResBtn_Click;
            // 
            // frmAudi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(850, 450);
            Controls.Add(label1);
            Controls.Add(BackBtn);
            Controls.Add(NextBtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAudi";
            Text = "frmAudi";
            Load += frmAudi_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button BackBtn;
        private Label label1;
        private Button NextBtn;
    }
}