﻿namespace SuperBookFinalProj.GUI.HomeAdmin.Containers
{
    partial class frmAdAccounts
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
            btnDeleteAcc = new Button();
            panel1 = new Panel();
            dataGridAcc = new DataGridView();
            label2 = new Label();
            pBoxSearch = new PictureBox();
            txtSearchAcc = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAcc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxSearch).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteAcc
            // 
            btnDeleteAcc.BackColor = Color.FromArgb(161, 181, 195);
            btnDeleteAcc.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDeleteAcc.Location = new Point(736, 399);
            btnDeleteAcc.Margin = new Padding(3, 2, 3, 2);
            btnDeleteAcc.Name = "btnDeleteAcc";
            btnDeleteAcc.Size = new Size(118, 29);
            btnDeleteAcc.TabIndex = 37;
            btnDeleteAcc.Text = "Delete Account";
            btnDeleteAcc.UseVisualStyleBackColor = false;
            btnDeleteAcc.Click += btnDeleteAcc_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 48, 64);
            panel1.Controls.Add(dataGridAcc);
            panel1.Location = new Point(68, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 292);
            panel1.TabIndex = 34;
            // 
            // dataGridAcc
            // 
            dataGridAcc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAcc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAcc.Location = new Point(21, 17);
            dataGridAcc.MultiSelect = false;
            dataGridAcc.Name = "dataGridAcc";
            dataGridAcc.ReadOnly = true;
            dataGridAcc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAcc.Size = new Size(751, 251);
            dataGridAcc.TabIndex = 0;
            dataGridAcc.CellContentClick += dataGridAcc_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Work Sans Black", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(41, 18);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 33;
            label2.Text = "ACCOUNTS";
            // 
            // pBoxSearch
            // 
            pBoxSearch.Image = Properties.Resources.icons8_search_64;
            pBoxSearch.Location = new Point(82, 49);
            pBoxSearch.Name = "pBoxSearch";
            pBoxSearch.Size = new Size(25, 23);
            pBoxSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxSearch.TabIndex = 60;
            pBoxSearch.TabStop = false;
            // 
            // txtSearchAcc
            // 
            txtSearchAcc.Location = new Point(113, 49);
            txtSearchAcc.Name = "txtSearchAcc";
            txtSearchAcc.Size = new Size(181, 23);
            txtSearchAcc.TabIndex = 59;
            txtSearchAcc.TextChanged += txtSearchEq_TextChanged;
            // 
            // frmAdAccounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(934, 454);
            Controls.Add(pBoxSearch);
            Controls.Add(txtSearchAcc);
            Controls.Add(btnDeleteAcc);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdAccounts";
            Text = "frmAdAccounts";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridAcc).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteAcc;
        private Panel panel1;
        private DataGridView dataGridAcc;
        private Label label2;
        private PictureBox pBoxSearch;
        private TextBox txtSearchAcc;
    }
}