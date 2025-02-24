namespace SuperBookFinalProj.GUI.HomeAdmin.Containers
{
    partial class frmAdEquip
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
            btnDeleteRoom = new Button();
            btnEditEq = new Button();
            btnAddEq = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteRoom
            // 
            btnDeleteRoom.BackColor = Color.FromArgb(161, 181, 195);
            btnDeleteRoom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDeleteRoom.Location = new Point(442, 389);
            btnDeleteRoom.Margin = new Padding(3, 2, 3, 2);
            btnDeleteRoom.Name = "btnDeleteRoom";
            btnDeleteRoom.Size = new Size(135, 29);
            btnDeleteRoom.TabIndex = 56;
            btnDeleteRoom.Text = "Delete Equipment";
            btnDeleteRoom.UseVisualStyleBackColor = false;
            // 
            // btnEditEq
            // 
            btnEditEq.BackColor = Color.FromArgb(161, 181, 195);
            btnEditEq.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnEditEq.Location = new Point(582, 389);
            btnEditEq.Margin = new Padding(3, 2, 3, 2);
            btnEditEq.Name = "btnEditEq";
            btnEditEq.Size = new Size(138, 29);
            btnEditEq.TabIndex = 55;
            btnEditEq.Text = "Edit Equipment";
            btnEditEq.UseVisualStyleBackColor = false;
            // 
            // btnAddEq
            // 
            btnAddEq.BackColor = Color.FromArgb(161, 181, 195);
            btnAddEq.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnAddEq.Location = new Point(725, 389);
            btnAddEq.Margin = new Padding(3, 2, 3, 2);
            btnAddEq.Name = "btnAddEq";
            btnAddEq.Size = new Size(136, 29);
            btnAddEq.TabIndex = 54;
            btnAddEq.Text = "Add Equipment ";
            btnAddEq.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 48, 64);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(68, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 292);
            panel1.TabIndex = 53;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(21, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(751, 251);
            dataGridView1.TabIndex = 0;
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
            // Column6
            // 
            Column6.HeaderText = "Column6";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(68, 35);
            label2.Name = "label2";
            label2.Size = new Size(144, 24);
            label2.TabIndex = 52;
            label2.Text = "EQUIPMENTS";
            // 
            // frmAdEquip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(934, 454);
            Controls.Add(btnDeleteRoom);
            Controls.Add(btnEditEq);
            Controls.Add(btnAddEq);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdEquip";
            Text = "frmAdEquip";
            Load += frmAdEquip_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private TextBox purposeTxt;
        private TextBox roomNumtxt;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime1;
        private Label purposeLbl;
        private Label roomNumLbl;
        private Label dateTxt;
        private Button btnDeleteRoom;
        private Button btnEditEq;
        private Button btnAddEq;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}