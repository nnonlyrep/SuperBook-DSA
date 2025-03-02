namespace SuperBookFinalProj.GUI.HomeAdmin.Containers
{
    partial class frmAdRooms
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
            dataGridRooms = new DataGridView();
            label2 = new Label();
            btnAddRoom = new Button();
            btnEditRoom = new Button();
            btnDeleteRoom = new Button();
            pBoxSearch = new PictureBox();
            txtSearchRoom = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxSearch).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 48, 64);
            panel1.Controls.Add(dataGridRooms);
            panel1.Location = new Point(74, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 292);
            panel1.TabIndex = 29;
            // 
            // dataGridRooms
            // 
            dataGridRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRooms.Location = new Point(18, 21);
            dataGridRooms.MultiSelect = false;
            dataGridRooms.Name = "dataGridRooms";
            dataGridRooms.ReadOnly = true;
            dataGridRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridRooms.Size = new Size(751, 251);
            dataGridRooms.TabIndex = 1;
            dataGridRooms.CellContentClick += dataGridRooms_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(74, 19);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 28;
            label2.Text = "ROOMS";
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.FromArgb(161, 181, 195);
            btnAddRoom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnAddRoom.Location = new Point(778, 400);
            btnAddRoom.Margin = new Padding(3, 2, 3, 2);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(94, 29);
            btnAddRoom.TabIndex = 30;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // btnEditRoom
            // 
            btnEditRoom.BackColor = Color.FromArgb(161, 181, 195);
            btnEditRoom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnEditRoom.Location = new Point(667, 400);
            btnEditRoom.Margin = new Padding(3, 2, 3, 2);
            btnEditRoom.Name = "btnEditRoom";
            btnEditRoom.Size = new Size(94, 29);
            btnEditRoom.TabIndex = 31;
            btnEditRoom.Text = "Edit Room";
            btnEditRoom.UseVisualStyleBackColor = false;
            btnEditRoom.Click += btnEditRoom_Click;
            // 
            // btnDeleteRoom
            // 
            btnDeleteRoom.BackColor = Color.FromArgb(161, 181, 195);
            btnDeleteRoom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDeleteRoom.Location = new Point(557, 400);
            btnDeleteRoom.Margin = new Padding(3, 2, 3, 2);
            btnDeleteRoom.Name = "btnDeleteRoom";
            btnDeleteRoom.Size = new Size(94, 29);
            btnDeleteRoom.TabIndex = 32;
            btnDeleteRoom.Text = "Delete Room";
            btnDeleteRoom.UseVisualStyleBackColor = false;
            // 
            // pBoxSearch
            // 
            pBoxSearch.Image = Properties.Resources.icons8_search_64;
            pBoxSearch.Location = new Point(89, 46);
            pBoxSearch.Name = "pBoxSearch";
            pBoxSearch.Size = new Size(25, 23);
            pBoxSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxSearch.TabIndex = 60;
            pBoxSearch.TabStop = false;
            // 
            // txtSearchRoom
            // 
            txtSearchRoom.Location = new Point(120, 46);
            txtSearchRoom.Name = "txtSearchRoom";
            txtSearchRoom.Size = new Size(181, 23);
            txtSearchRoom.TabIndex = 59;
            txtSearchRoom.TextChanged += txtSearchRoom_TextChanged;
            // 
            // frmAdRooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(934, 454);
            Controls.Add(pBoxSearch);
            Controls.Add(txtSearchRoom);
            Controls.Add(btnDeleteRoom);
            Controls.Add(btnEditRoom);
            Controls.Add(btnAddRoom);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdRooms";
            Text = "frmAdRooms";
            Load += frmAdRooms_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button btnAddRoom;
        private Button btnEditRoom;
        private Button btnDeleteRoom;
        private DataGridView dataGridRooms;
        private PictureBox pBoxSearch;
        private TextBox txtSearchRoom;
    }
}