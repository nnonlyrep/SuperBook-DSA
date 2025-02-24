namespace SuperBookFinalProj.GUI.HomeAdmin.Containers
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
            btnEditAcc = new Button();
            panel1 = new Panel();
            dataGridAcc = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAcc).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteAcc
            // 
            btnDeleteAcc.BackColor = Color.FromArgb(161, 181, 195);
            btnDeleteAcc.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDeleteAcc.Location = new Point(616, 400);
            btnDeleteAcc.Margin = new Padding(3, 2, 3, 2);
            btnDeleteAcc.Name = "btnDeleteAcc";
            btnDeleteAcc.Size = new Size(118, 29);
            btnDeleteAcc.TabIndex = 37;
            btnDeleteAcc.Text = "Delete Account";
            btnDeleteAcc.UseVisualStyleBackColor = false;
            // 
            // btnEditAcc
            // 
            btnEditAcc.BackColor = Color.FromArgb(161, 181, 195);
            btnEditAcc.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnEditAcc.Location = new Point(751, 400);
            btnEditAcc.Margin = new Padding(3, 2, 3, 2);
            btnEditAcc.Name = "btnEditAcc";
            btnEditAcc.Size = new Size(103, 29);
            btnEditAcc.TabIndex = 36;
            btnEditAcc.Text = "Edit Account";
            btnEditAcc.UseVisualStyleBackColor = false;
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
            dataGridAcc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAcc.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridAcc.Location = new Point(21, 17);
            dataGridAcc.Name = "dataGridAcc";
            dataGridAcc.Size = new Size(751, 251);
            dataGridAcc.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Column6";
            Column6.Name = "Column6";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Work Sans Black", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(68, 26);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 33;
            label2.Text = "ACCOUNTS";
            // 
            // frmAdAccounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(934, 454);
            Controls.Add(btnDeleteAcc);
            Controls.Add(btnEditAcc);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdAccounts";
            Text = "frmAdAccounts";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridAcc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteAcc;
        private Button btnEditAcc;
        private Panel panel1;
        private DataGridView dataGridAcc;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label label2;
    }
}