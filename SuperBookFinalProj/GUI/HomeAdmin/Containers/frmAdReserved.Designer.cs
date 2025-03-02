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
            dataGridAcc = new DataGridView();
            label1 = new Label();
            CnclResBtn = new Button();
            pBoxSearch = new PictureBox();
            txtSearchEq = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAcc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxSearch).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 48, 64);
            panel1.Controls.Add(dataGridAcc);
            panel1.Location = new Point(34, 92);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 303);
            panel1.TabIndex = 0;
            // 
            // dataGridAcc
            // 
            dataGridAcc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAcc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAcc.Location = new Point(59, 26);
            dataGridAcc.MultiSelect = false;
            dataGridAcc.Name = "dataGridAcc";
            dataGridAcc.ReadOnly = true;
            dataGridAcc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAcc.Size = new Size(751, 251);
            dataGridAcc.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(34, 38);
            label1.Name = "label1";
            label1.Size = new Size(121, 24);
            label1.TabIndex = 19;
            label1.Text = "RESERVED";
            // 
            // CnclResBtn
            // 
            CnclResBtn.BackColor = Color.FromArgb(161, 181, 195);
            CnclResBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            CnclResBtn.Location = new Point(745, 399);
            CnclResBtn.Margin = new Padding(3, 2, 3, 2);
            CnclResBtn.Name = "CnclResBtn";
            CnclResBtn.Size = new Size(158, 29);
            CnclResBtn.TabIndex = 50;
            CnclResBtn.Text = "Cancel Reservation";
            CnclResBtn.UseVisualStyleBackColor = false;
            // 
            // pBoxSearch
            // 
            pBoxSearch.Image = Properties.Resources.icons8_search_64;
            pBoxSearch.Location = new Point(62, 64);
            pBoxSearch.Name = "pBoxSearch";
            pBoxSearch.Size = new Size(25, 23);
            pBoxSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxSearch.TabIndex = 60;
            pBoxSearch.TabStop = false;
            // 
            // txtSearchEq
            // 
            txtSearchEq.Location = new Point(93, 64);
            txtSearchEq.Name = "txtSearchEq";
            txtSearchEq.Size = new Size(181, 23);
            txtSearchEq.TabIndex = 59;
            // 
            // frmAdReserved
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(934, 454);
            Controls.Add(pBoxSearch);
            Controls.Add(txtSearchEq);
            Controls.Add(CnclResBtn);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdReserved";
            Text = "frmAdReserved";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridAcc).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button CnclResBtn;
        private DataGridView dataGridAcc;
        private PictureBox pBoxSearch;
        private TextBox txtSearchEq;
    }
}