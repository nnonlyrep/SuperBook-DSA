﻿
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
            lblAddRoom.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAddRoom.ForeColor = SystemColors.ButtonFace;
            lblAddRoom.Location = new Point(14, 12);
            lblAddRoom.Name = "lblAddRoom";
            lblAddRoom.Size = new Size(141, 31);
            lblAddRoom.TabIndex = 0;
            lblAddRoom.Text = "Add Room";
            // 
            // lblRoomNum
            // 
            lblRoomNum.AutoSize = true;
            lblRoomNum.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRoomNum.ForeColor = SystemColors.ButtonFace;
            lblRoomNum.Location = new Point(14, 72);
            lblRoomNum.Name = "lblRoomNum";
            lblRoomNum.Size = new Size(152, 24);
            lblRoomNum.TabIndex = 1;
            lblRoomNum.Text = "Room Number:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 48, 64);
            textBox1.ForeColor = SystemColors.Menu;
            textBox1.Location = new Point(14, 119);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 2;
            // 
            // txtRoomType
            // 
            txtRoomType.BackColor = Color.FromArgb(30, 48, 64);
            txtRoomType.ForeColor = SystemColors.Menu;
            txtRoomType.Location = new Point(14, 217);
            txtRoomType.Margin = new Padding(3, 4, 3, 4);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.Size = new Size(190, 27);
            txtRoomType.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(14, 171);
            label1.Name = "label1";
            label1.Size = new Size(124, 24);
            label1.TabIndex = 3;
            label1.Text = "Room Type:";
            // 
            // txtCapacity
            // 
            txtCapacity.BackColor = Color.FromArgb(30, 48, 64);
            txtCapacity.ForeColor = SystemColors.Menu;
            txtCapacity.Location = new Point(14, 319);
            txtCapacity.Margin = new Padding(3, 4, 3, 4);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(190, 27);
            txtCapacity.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(14, 272);
            label2.Name = "label2";
            label2.Size = new Size(95, 24);
            label2.TabIndex = 5;
            label2.Text = "Capacity:";
            // 
            // txtLoc
            // 
            txtLoc.BackColor = Color.FromArgb(30, 48, 64);
            txtLoc.ForeColor = SystemColors.Menu;
            txtLoc.Location = new Point(301, 119);
            txtLoc.Margin = new Padding(3, 4, 3, 4);
            txtLoc.Name = "txtLoc";
            txtLoc.Size = new Size(190, 27);
            txtLoc.TabIndex = 8;
            // 
            // lblLoc
            // 
            lblLoc.AutoSize = true;
            lblLoc.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLoc.ForeColor = SystemColors.ButtonFace;
            lblLoc.Location = new Point(301, 72);
            lblLoc.Name = "lblLoc";
            lblLoc.Size = new Size(95, 24);
            lblLoc.TabIndex = 7;
            lblLoc.Text = "Location:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(161, 181, 195);
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(435, 320);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(161, 181, 195);
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(335, 319);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ppAddRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(622, 439);
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
            Margin = new Padding(3, 4, 3, 4);
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