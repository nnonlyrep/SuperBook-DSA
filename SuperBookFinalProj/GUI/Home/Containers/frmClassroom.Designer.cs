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
            btnNext = new Button();
            cncButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClassRooms).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(33, 36);
            label1.Name = "label1";
            label1.Size = new Size(109, 29);
            label1.TabIndex = 0;
            label1.Text = "ROOMS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 48, 64);
            panel1.Controls.Add(dataGridClassRooms);
            panel1.Location = new Point(33, 79);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 415);
            panel1.TabIndex = 1;
            // 
            // dataGridClassRooms
            // 
            dataGridClassRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridClassRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClassRooms.Location = new Point(21, 28);
            dataGridClassRooms.Margin = new Padding(3, 4, 3, 4);
            dataGridClassRooms.MultiSelect = false;
            dataGridClassRooms.Name = "dataGridClassRooms";
            dataGridClassRooms.ReadOnly = true;
            dataGridClassRooms.RowHeadersWidth = 51;
            dataGridClassRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClassRooms.Size = new Size(858, 365);
            dataGridClassRooms.TabIndex = 1;
            dataGridClassRooms.CellContentClick += dataGridClassRooms_CellContentClick;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(161, 181, 195);
            btnNext.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(824, 502);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(107, 43);
            btnNext.TabIndex = 14;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += rsrvBtn_Click;
            // 
            // cncButton
            // 
            cncButton.BackColor = Color.FromArgb(161, 181, 195);
            cncButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cncButton.Location = new Point(699, 502);
            cncButton.Margin = new Padding(3, 4, 3, 4);
            cncButton.Name = "cncButton";
            cncButton.Size = new Size(119, 43);
            cncButton.TabIndex = 15;
            cncButton.Text = "Cancel";
            cncButton.UseVisualStyleBackColor = false;
            cncButton.Click += cncButton_Click;
            // 
            // frmClassroom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(971, 600);
            Controls.Add(cncButton);
            Controls.Add(btnNext);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnNext;
        private DataGridView dataGridClassRooms;
        private Button cncButton;
    }
}