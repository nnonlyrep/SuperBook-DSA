namespace SuperBookFinalProj.GUI.HomeAdmin.Containers
{
    partial class frmAdBorrowed
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
            pBoxSearch = new PictureBox();
            txtSearchBor = new TextBox();
            btnCancel = new Button();
            lblBorrowed = new Label();
            panel1 = new Panel();
            dgvBorrowed = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pBoxSearch).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowed).BeginInit();
            SuspendLayout();
            // 
            // pBoxSearch
            // 
            pBoxSearch.Image = Properties.Resources.icons8_search_64;
            pBoxSearch.Location = new Point(61, 58);
            pBoxSearch.Name = "pBoxSearch";
            pBoxSearch.Size = new Size(25, 23);
            pBoxSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxSearch.TabIndex = 65;
            pBoxSearch.TabStop = false;
            // 
            // txtSearchBor
            // 
            txtSearchBor.Location = new Point(92, 58);
            txtSearchBor.Name = "txtSearchBor";
            txtSearchBor.Size = new Size(181, 23);
            txtSearchBor.TabIndex = 64;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(161, 181, 195);
            btnCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnCancel.Location = new Point(744, 393);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(158, 29);
            btnCancel.TabIndex = 63;
            btnCancel.Text = "Cancel Borrow";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblBorrowed
            // 
            lblBorrowed.AutoSize = true;
            lblBorrowed.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBorrowed.ForeColor = SystemColors.ButtonFace;
            lblBorrowed.Location = new Point(33, 32);
            lblBorrowed.Name = "lblBorrowed";
            lblBorrowed.Size = new Size(130, 24);
            lblBorrowed.TabIndex = 62;
            lblBorrowed.Text = "BORROWED";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 48, 64);
            panel1.Controls.Add(dgvBorrowed);
            panel1.Location = new Point(33, 86);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 303);
            panel1.TabIndex = 61;
            // 
            // dgvBorrowed
            // 
            dgvBorrowed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrowed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowed.Location = new Point(59, 26);
            dgvBorrowed.MultiSelect = false;
            dgvBorrowed.Name = "dgvBorrowed";
            dgvBorrowed.ReadOnly = true;
            dgvBorrowed.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowed.Size = new Size(751, 251);
            dgvBorrowed.TabIndex = 1;
            // 
            // frmAdBorrowed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(934, 454);
            Controls.Add(pBoxSearch);
            Controls.Add(txtSearchBor);
            Controls.Add(btnCancel);
            Controls.Add(lblBorrowed);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdBorrowed";
            Text = "frmAdBorrowed";
            ((System.ComponentModel.ISupportInitialize)pBoxSearch).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBorrowed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pBoxSearch;
        private TextBox txtSearchBor;
        private Button btnCancel;
        private Label lblBorrowed;
        private Panel panel1;
        private DataGridView dgvBorrowed;
    }
}