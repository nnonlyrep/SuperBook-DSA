namespace SuperBookFinalProj.GUI.Home.Containers
{
    partial class frmClassroom
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
            dataGridClassRooms = new DataGridView();
            cncBtn = new Button();
            NextBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClassRooms).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Work Sans Black", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 0;
            label1.Text = "ROOMS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 48, 64);
            panel1.Controls.Add(dataGridClassRooms);
            panel1.Location = new Point(29, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 292);
            panel1.TabIndex = 1;
            // 
            // dataGridClassRooms
            // 
            dataGridClassRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridClassRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClassRooms.Location = new Point(18, 21);
            dataGridClassRooms.MultiSelect = false;
            dataGridClassRooms.Name = "dataGridClassRooms";
            dataGridClassRooms.ReadOnly = true;
            dataGridClassRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClassRooms.Size = new Size(751, 251);
            dataGridClassRooms.TabIndex = 1;
            // 
            // cncBtn
            // 
            cncBtn.BackColor = Color.FromArgb(161, 181, 195);
            cncBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            cncBtn.Location = new Point(545, 401);
            cncBtn.Margin = new Padding(3, 2, 3, 2);
            cncBtn.Name = "cncBtn";
            cncBtn.RightToLeft = RightToLeft.No;
            cncBtn.Size = new Size(106, 29);
            cncBtn.TabIndex = 13;
            cncBtn.Text = "Cancel";
            cncBtn.UseVisualStyleBackColor = false;
            cncBtn.Click += cncBtn_Click;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.FromArgb(161, 181, 195);
            NextBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            NextBtn.Location = new Point(721, 401);
            NextBtn.Margin = new Padding(3, 2, 3, 2);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(94, 29);
            NextBtn.TabIndex = 14;
            NextBtn.Text = "Next";
            NextBtn.UseVisualStyleBackColor = false;
            NextBtn.Click += rsrvBtn_Click;
            // 
            // frmClassroom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(850, 450);
            Controls.Add(NextBtn);
            Controls.Add(cncBtn);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmClassroom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmClassroom";
            Load += frmClassroom_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridClassRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button cncBtn;
        private Button NextBtn;
        private DataGridView dataGridClassRooms;
    }
}