namespace SuperBookFinalProj.GUI.HomeAdmin.Containers
{
    partial class frmAdAudi
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
            btnEditRoom = new Button();
            btnAddRoom = new Button();
            panel1 = new Panel();
            label2 = new Label();
            dgvAudiRooms = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAudiRooms).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteRoom
            // 
            btnDeleteRoom.BackColor = Color.FromArgb(161, 181, 195);
            btnDeleteRoom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDeleteRoom.Location = new Point(520, 398);
            btnDeleteRoom.Margin = new Padding(3, 2, 3, 2);
            btnDeleteRoom.Name = "btnDeleteRoom";
            btnDeleteRoom.Size = new Size(94, 29);
            btnDeleteRoom.TabIndex = 51;
            btnDeleteRoom.Text = "Delete Room";
            btnDeleteRoom.UseVisualStyleBackColor = false;
            // 
            // btnEditRoom
            // 
            btnEditRoom.BackColor = Color.FromArgb(161, 181, 195);
            btnEditRoom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnEditRoom.Location = new Point(629, 398);
            btnEditRoom.Margin = new Padding(3, 2, 3, 2);
            btnEditRoom.Name = "btnEditRoom";
            btnEditRoom.Size = new Size(94, 29);
            btnEditRoom.TabIndex = 50;
            btnEditRoom.Text = "Edit Room";
            btnEditRoom.UseVisualStyleBackColor = false;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.FromArgb(161, 181, 195);
            btnAddRoom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnAddRoom.Location = new Point(740, 398);
            btnAddRoom.Margin = new Padding(3, 2, 3, 2);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(94, 29);
            btnAddRoom.TabIndex = 49;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 48, 64);
            panel1.Controls.Add(dgvAudiRooms);
            panel1.Location = new Point(37, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 292);
            panel1.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(37, 44);
            label2.Name = "label2";
            label2.Size = new Size(136, 24);
            label2.TabIndex = 47;
            label2.Text = "AUDITORIUM";
            // 
            // dgvAudiRooms
            // 
            dgvAudiRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAudiRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAudiRooms.Location = new Point(18, 21);
            dgvAudiRooms.MultiSelect = false;
            dgvAudiRooms.Name = "dgvAudiRooms";
            dgvAudiRooms.ReadOnly = true;
            dgvAudiRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAudiRooms.Size = new Size(751, 251);
            dgvAudiRooms.TabIndex = 1;
            // 
            // frmAdAudi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(871, 450);
            Controls.Add(btnDeleteRoom);
            Controls.Add(btnEditRoom);
            Controls.Add(btnAddRoom);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdAudi";
            Text = "frmAdAudi";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAudiRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteRoom;
        private Button btnEditRoom;
        private Button btnAddRoom;
        private Panel panel1;
        private Label label2;
        private DataGridView dgvAudiRooms;
    }
}