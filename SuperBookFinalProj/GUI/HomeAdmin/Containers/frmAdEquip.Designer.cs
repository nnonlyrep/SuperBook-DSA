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
            label2 = new Label();
            dataGridAcc = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAcc).BeginInit();
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
            panel1.Controls.Add(dataGridAcc);
            panel1.Location = new Point(68, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 292);
            panel1.TabIndex = 53;
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
            // dataGridAcc
            // 
            dataGridAcc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAcc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAcc.Location = new Point(18, 21);
            dataGridAcc.MultiSelect = false;
            dataGridAcc.Name = "dataGridAcc";
            dataGridAcc.ReadOnly = true;
            dataGridAcc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAcc.Size = new Size(751, 251);
            dataGridAcc.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)dataGridAcc).EndInit();
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
        private DataGridView dataGridAcc;
    }
}