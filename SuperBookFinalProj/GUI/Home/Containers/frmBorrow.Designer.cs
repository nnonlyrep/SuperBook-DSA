namespace SuperBookFinalProj.GUI.Home.Containers
{
    partial class frmBorrow
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
            dataGridEq = new DataGridView();
            Borrow = new Button();
            cncButton = new Button();
            label1 = new Label();
            pBoxSearch = new PictureBox();
            txtSearchBor = new TextBox();

            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEq).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxSearch).BeginInit();
            SuspendLayout();

            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 48, 64);
            panel1.Controls.Add(dataGridEq);
            panel1.Location = new Point(56, 64);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 455);
            panel1.TabIndex = 1;

            // 
            // dataGridEq
            // 
            dataGridEq.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridEq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEq.Location = new Point(26, 23);
            dataGridEq.Margin = new Padding(3, 4, 3, 4);
            dataGridEq.MultiSelect = false;
            dataGridEq.Name = "dataGridEq";
            dataGridEq.ReadOnly = true;
            dataGridEq.RowHeadersWidth = 51;
            dataGridEq.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridEq.Size = new Size(808, 409);
            dataGridEq.TabIndex = 1;

            // 
            // Borrow
            // 
            Borrow.BackColor = Color.FromArgb(161, 181, 195);
            Borrow.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Borrow.Location = new Point(792, 527);
            Borrow.Margin = new Padding(3, 4, 3, 4);
            Borrow.Name = "Borrow";
            Borrow.Size = new Size(122, 43);
            Borrow.TabIndex = 14;
            Borrow.Text = "Borrow";
            Borrow.UseVisualStyleBackColor = false;
            Borrow.Click += Borrow_Click;

            // 
            // cncButton
            // 
            cncButton.BackColor = Color.FromArgb(161, 181, 195);
            cncButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cncButton.Location = new Point(667, 527);
            cncButton.Margin = new Padding(3, 4, 3, 4);
            cncButton.Name = "cncButton";
            cncButton.Size = new Size(119, 43);
            cncButton.TabIndex = 3;
            cncButton.Text = "Cancel";
            cncButton.UseVisualStyleBackColor = false;
            cncButton.Click += cncButton_Click;

            // 
            // pBoxSearch
            // 
            pBoxSearch.Image = Properties.Resources.icons8_search_64;
            pBoxSearch.Location = new Point(79, 19);
            pBoxSearch.Name = "pBoxSearch";
            pBoxSearch.Size = new Size(25, 23);
            pBoxSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxSearch.TabIndex = 67;
            pBoxSearch.TabStop = false;

            // 
            // txtSearchBor
            // 
            txtSearchBor.Location = new Point(110, 19);
            txtSearchBor.Name = "txtSearchBor";
            txtSearchBor.Size = new Size(181, 23);
            txtSearchBor.TabIndex = 66;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(56, 20);
            label1.Name = "label1";
            label1.Size = new Size(183, 29);
            label1.TabIndex = 15;
            label1.Text = "EQUIPMENTS";
            label1.Click += label1_Click;

            // 
            // frmBorrow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(979, 606);
            Controls.Add(label1);
            Controls.Add(cncButton);
            Controls.Add(Borrow);
            Controls.Add(panel1);
            Controls.Add(pBoxSearch);
            Controls.Add(txtSearchBor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmBorrow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBorrow";
            Load += frmBorrow_Load;

            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridEq).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button Borrow;
        private DataGridView dataGridEq;
        private PictureBox pBoxSearch;
        private TextBox txtSearchBor;
        private Button cncButton;
        private Label label1;
    }
}
