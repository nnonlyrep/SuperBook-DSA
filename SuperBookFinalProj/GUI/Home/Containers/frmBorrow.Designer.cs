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
            label1 = new Label();
            panel1 = new Panel();
            dataGridEq = new DataGridView();
            Borrow = new Button();
            cncButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEq).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Work Sans Black", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 0;
            label1.Text = "BORROW";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 48, 64);
            panel1.Controls.Add(dataGridEq);
            panel1.Location = new Point(49, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(751, 341);
            panel1.TabIndex = 1;
            // 
            // dataGridEq
            // 
            dataGridEq.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridEq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEq.Location = new Point(23, 17);
            dataGridEq.MultiSelect = false;
            dataGridEq.Name = "dataGridEq";
            dataGridEq.ReadOnly = true;
            dataGridEq.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridEq.Size = new Size(707, 307);
            dataGridEq.TabIndex = 1;
            // 
            // Borrow
            // 
            Borrow.Location = new Point(719, 415);
            Borrow.Name = "Borrow";
            Borrow.Size = new Size(91, 23);
            Borrow.TabIndex = 2;
            Borrow.Text = "Borrow";
            Borrow.UseVisualStyleBackColor = true;
            Borrow.Click += Borrow_Click;
            // 
            // cncButton
            // 
            cncButton.Location = new Point(607, 415);
            cncButton.Name = "cncButton";
            cncButton.Size = new Size(91, 23);
            cncButton.TabIndex = 3;
            cncButton.Text = "Cancel";
            cncButton.UseVisualStyleBackColor = true;
            cncButton.Click += cncButton_Click;
            // 
            // frmBorrow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(850, 450);
            Controls.Add(cncButton);
            Controls.Add(Borrow);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBorrow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBorrow";
            Load += frmBorrow_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridEq).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button Borrow;
        private Button cncButton;
        private DataGridView dataGridEq;
    }
}