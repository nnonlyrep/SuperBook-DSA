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
            pBoxSearch = new PictureBox();
            txtSearchRoom = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClassRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxSearch).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 0;
            label1.Text = "ROOMS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 48, 64);
            panel1.Controls.Add(dataGridClassRooms);
            panel1.Location = new Point(29, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 311);
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
            dataGridClassRooms.RowHeadersWidth = 51;
            dataGridClassRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClassRooms.Size = new Size(751, 274);
            dataGridClassRooms.TabIndex = 1;
            // dataGridClassRooms.CellContentClick += dataGridClassRooms_CellContentClick;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(161, 181, 195);
            btnNext.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(721, 376);
            btnNext.Margin = new Padding(3, 2, 3, 2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 32);
            btnNext.TabIndex = 14;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += rsrvBtn_Click;
            // 
            // cncButton
            // 
            cncButton.BackColor = Color.FromArgb(161, 181, 195);
            cncButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cncButton.Location = new Point(612, 376);
            cncButton.Name = "cncButton";
            cncButton.Size = new Size(104, 32);
            cncButton.TabIndex = 15;
            cncButton.Text = "Cancel";
            cncButton.UseVisualStyleBackColor = false;
            cncButton.Click += cncButton_Click;
            // 
            // pBoxSearch
            // 
            pBoxSearch.Image = Properties.Resources.icons8_search_64;
            pBoxSearch.Location = new Point(123, 27);
            pBoxSearch.Margin = new Padding(3, 2, 3, 2);
            pBoxSearch.Name = "pBoxSearch";
            pBoxSearch.Size = new Size(22, 21);
            pBoxSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxSearch.TabIndex = 69;
            pBoxSearch.TabStop = false;
            // 
            // txtSearchRoom
            // 
            txtSearchRoom.Location = new Point(151, 27);
            txtSearchRoom.Margin = new Padding(3, 2, 3, 2);
            txtSearchRoom.Name = "txtSearchRoom";
            txtSearchRoom.Size = new Size(159, 23);
            txtSearchRoom.TabIndex = 68;
            txtSearchRoom.TextChanged += txtSearchRoom_TextChanged;
            // 
            // frmClassroom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(850, 450);
            Controls.Add(pBoxSearch);
            Controls.Add(txtSearchRoom);
            Controls.Add(cncButton);
            Controls.Add(btnNext);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmClassroom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmClassroom";
            Load += frmClassroom_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridClassRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnNext;
        private DataGridView dataGridClassRooms;
        private Button cncButton;
        private PictureBox pBoxSearch;
        private TextBox txtSearchRoom;
    }
}