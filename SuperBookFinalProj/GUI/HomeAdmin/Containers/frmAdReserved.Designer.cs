namespace SuperBookFinalProj.GUI.HomeAdmin.Containers
{
    partial class frmAdReserved
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
            dgvReserved = new DataGridView();
            lblReserved = new Label();
            btnCancel = new Button();
            pBoxSearch = new PictureBox();
            txtSearchEq = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReserved).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxSearch).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 48, 64);
            panel1.Controls.Add(dgvReserved);
            panel1.Location = new Point(39, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 404);
            panel1.TabIndex = 0;
            // 
            // dgvReserved
            // 
            dgvReserved.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReserved.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReserved.Location = new Point(67, 35);
            dgvReserved.Margin = new Padding(3, 4, 3, 4);
            dgvReserved.MultiSelect = false;
            dgvReserved.Name = "dgvReserved";
            dgvReserved.ReadOnly = true;
            dgvReserved.RowHeadersWidth = 51;
            dgvReserved.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReserved.Size = new Size(858, 335);
            dgvReserved.TabIndex = 1;
            // 
            // lblReserved
            // 
            lblReserved.AutoSize = true;
            lblReserved.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReserved.ForeColor = SystemColors.ButtonFace;
            lblReserved.Location = new Point(39, 51);
            lblReserved.Name = "lblReserved";
            lblReserved.Size = new Size(151, 29);
            lblReserved.TabIndex = 19;
            lblReserved.Text = "RESERVED";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(161, 181, 195);
            btnCancel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(851, 532);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(181, 49);
            btnCancel.TabIndex = 50;
            btnCancel.Text = "Cancel Borrow";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += CnclResBtn_Click;
            // 
            // pBoxSearch
            // 
            pBoxSearch.Image = Properties.Resources.icons8_search_64;
            pBoxSearch.Location = new Point(71, 85);
            pBoxSearch.Margin = new Padding(3, 4, 3, 4);
            pBoxSearch.Name = "pBoxSearch";
            pBoxSearch.Size = new Size(29, 31);
            pBoxSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxSearch.TabIndex = 60;
            pBoxSearch.TabStop = false;
            // 
            // txtSearchEq
            // 
            txtSearchEq.Location = new Point(106, 85);
            txtSearchEq.Margin = new Padding(3, 4, 3, 4);
            txtSearchEq.Name = "txtSearchEq";
            txtSearchEq.Size = new Size(206, 27);
            txtSearchEq.TabIndex = 59;
            txtSearchEq.TextChanged += txtSearchEq_TextChanged;
            // 
            // frmAdReserved
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(1067, 605);
            Controls.Add(pBoxSearch);
            Controls.Add(txtSearchEq);
            Controls.Add(btnCancel);
            Controls.Add(lblReserved);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAdReserved";
            Text = "frmAdReserved";
            Load += frmAdReserved_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReserved).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblReserved;
        private Button btnCancel;
        private DataGridView dgvReserved;
        private PictureBox pBoxSearch;
        private TextBox txtSearchEq;
    }
}