
namespace SuperBookFinalProj.GUI.PopUps.AdminPP
{
    partial class ppAddRoom
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
            lblAddRoom = new Label();
            lblRoomNum = new Label();
            textBox1 = new TextBox();
            txtRoomType = new TextBox();
            label1 = new Label();
            txtCapacity = new TextBox();
            label2 = new Label();
            txtLoc = new TextBox();
            lblLoc = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblAddRoom
            // 
            lblAddRoom.AutoSize = true;
            lblAddRoom.Font = new Font("Lazydog", 15.7499981F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAddRoom.ForeColor = SystemColors.ButtonFace;
            lblAddRoom.Location = new Point(12, 9);
            lblAddRoom.Name = "lblAddRoom";
            lblAddRoom.Size = new Size(112, 28);
            lblAddRoom.TabIndex = 0;
            lblAddRoom.Text = "Add Room";
            // 
            // lblRoomNum
            // 
            lblRoomNum.AutoSize = true;
            lblRoomNum.Font = new Font("Work Sans", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRoomNum.ForeColor = SystemColors.ButtonFace;
            lblRoomNum.Location = new Point(12, 54);
            lblRoomNum.Name = "lblRoomNum";
            lblRoomNum.Size = new Size(119, 22);
            lblRoomNum.TabIndex = 1;
            lblRoomNum.Text = "Room Number:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 48, 64);
            textBox1.Location = new Point(12, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 2;
            // 
            // txtRoomType
            // 
            txtRoomType.BackColor = Color.FromArgb(30, 48, 64);
            txtRoomType.Location = new Point(12, 163);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.Size = new Size(167, 23);
            txtRoomType.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Work Sans", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 128);
            label1.Name = "label1";
            label1.Size = new Size(96, 22);
            label1.TabIndex = 3;
            label1.Text = "Room Type:";
            // 
            // txtCapacity
            // 
            txtCapacity.BackColor = Color.FromArgb(30, 48, 64);
            txtCapacity.Location = new Point(12, 239);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(167, 23);
            txtCapacity.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Work Sans", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 204);
            label2.Name = "label2";
            label2.Size = new Size(80, 22);
            label2.TabIndex = 5;
            label2.Text = "Capacity:";
            // 
            // txtLoc
            // 
            txtLoc.BackColor = Color.FromArgb(30, 48, 64);
            txtLoc.Location = new Point(263, 89);
            txtLoc.Name = "txtLoc";
            txtLoc.Size = new Size(167, 23);
            txtLoc.TabIndex = 8;
            // 
            // lblLoc
            // 
            lblLoc.AutoSize = true;
            lblLoc.Font = new Font("Work Sans", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLoc.ForeColor = SystemColors.ButtonFace;
            lblLoc.Location = new Point(263, 54);
            lblLoc.Name = "lblLoc";
            lblLoc.Size = new Size(80, 22);
            lblLoc.TabIndex = 7;
            lblLoc.Text = "Location:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(161, 181, 195);
            btnAdd.Location = new Point(381, 240);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(161, 181, 195);
            btnCancel.Location = new Point(293, 239);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ppAddRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(544, 329);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtLoc);
            Controls.Add(lblLoc);
            Controls.Add(txtCapacity);
            Controls.Add(label2);
            Controls.Add(txtRoomType);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(lblRoomNum);
            Controls.Add(lblAddRoom);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ppAddRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ppAddRoom";
            Load += ppAddRoom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Label lblAddRoom;
        private Label lblRoomNum;
        private TextBox textBox1;
        private TextBox txtRoomType;
        private Label label1;
        private TextBox txtCapacity;
        private Label label2;
        private TextBox txtLoc;
        private Label lblLoc;
        private Button btnAdd;
        private Button btnCancel;
    }
}