namespace SuperBookFinalProj.GUI.PopUps
{
    partial class ppClassroom
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
            dateTxt = new Label();
            purposeLbl = new Label();
            dateTimePicker = new ReaLTaiizor.Controls.PoisonDateTime();
            purposeTxt = new TextBox();
            reserveBtn = new Button();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            txtOccupants = new TextBox();
            cboTime = new ComboBox();
            lblRoomName = new Label();
            lblRoomCapacity = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(337, 39);
            label1.Name = "label1";
            label1.Size = new Size(109, 29);
            label1.TabIndex = 1;
            label1.Text = "ROOMS";
            // 
            // dateTxt
            // 
            dateTxt.AutoSize = true;
            dateTxt.BackColor = Color.FromArgb(21, 31, 40);
            dateTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTxt.ForeColor = SystemColors.Window;
            dateTxt.Location = new Point(109, 139);
            dateTxt.Name = "dateTxt";
            dateTxt.Size = new Size(62, 28);
            dateTxt.TabIndex = 2;
            dateTxt.Text = "Date:";
            // 
            // purposeLbl
            // 
            purposeLbl.AutoSize = true;
            purposeLbl.BackColor = Color.FromArgb(21, 31, 40);
            purposeLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            purposeLbl.ForeColor = SystemColors.Window;
            purposeLbl.Location = new Point(437, 145);
            purposeLbl.Name = "purposeLbl";
            purposeLbl.Size = new Size(187, 25);
            purposeLbl.TabIndex = 4;
            purposeLbl.Text = "Purpose/Program:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(109, 179);
            dateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker.MinimumSize = new Size(0, 30);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(228, 30);
            dateTimePicker.TabIndex = 10;
            // 
            // purposeTxt
            // 
            purposeTxt.BackColor = Color.FromArgb(30, 48, 64);
            purposeTxt.BorderStyle = BorderStyle.None;
            purposeTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            purposeTxt.ForeColor = Color.White;
            purposeTxt.Location = new Point(437, 183);
            purposeTxt.Name = "purposeTxt";
            purposeTxt.Size = new Size(294, 23);
            purposeTxt.TabIndex = 18;
            purposeTxt.TextChanged += purposeTxt_TextChanged;
            // 
            // reserveBtn
            // 
            reserveBtn.BackColor = Color.FromArgb(161, 181, 195);
            reserveBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reserveBtn.Location = new Point(637, 337);
            reserveBtn.Name = "reserveBtn";
            reserveBtn.Size = new Size(94, 43);
            reserveBtn.TabIndex = 23;
            reserveBtn.Text = "Reserve";
            reserveBtn.UseVisualStyleBackColor = false;
            reserveBtn.Click += reserveBtn_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(161, 181, 195);
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(106, 337);
            button1.Name = "button1";
            button1.Size = new Size(94, 43);
            button1.TabIndex = 24;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(21, 31, 40);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(106, 243);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 26;
            label2.Text = "Time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(21, 31, 40);
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(437, 224);
            label3.Name = "label3";
            label3.Size = new Size(228, 25);
            label3.TabIndex = 28;
            label3.Text = "Number of Occupants:";
            // 
            // txtOccupants
            // 
            txtOccupants.BackColor = Color.FromArgb(30, 48, 64);
            txtOccupants.BorderStyle = BorderStyle.None;
            txtOccupants.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            txtOccupants.ForeColor = Color.White;
            txtOccupants.Location = new Point(437, 268);
            txtOccupants.Name = "txtOccupants";
            txtOccupants.Size = new Size(294, 23);
            txtOccupants.TabIndex = 29;
            // 
            // cboTime
            // 
            cboTime.FormattingEnabled = true;
            cboTime.Items.AddRange(new object[] { "7:00AM - 9:00AM", "10:00AM - 12:00PM", "1:00PM - 3:00PM", "4:00PM - 6:00PM" });
            cboTime.Location = new Point(173, 243);
            cboTime.Margin = new Padding(3, 4, 3, 4);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(164, 28);
            cboTime.TabIndex = 40;
            // 
            // lblRoomName
            // 
            lblRoomName.AutoSize = true;
            lblRoomName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomName.ForeColor = SystemColors.ButtonHighlight;
            lblRoomName.Location = new Point(120, 71);
            lblRoomName.Name = "lblRoomName";
            lblRoomName.Size = new Size(71, 24);
            lblRoomName.TabIndex = 41;
            lblRoomName.Text = "Room:";
            // 
            // lblRoomCapacity
            // 
            lblRoomCapacity.AutoSize = true;
            lblRoomCapacity.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomCapacity.ForeColor = SystemColors.ButtonHighlight;
            lblRoomCapacity.Location = new Point(119, 108);
            lblRoomCapacity.Name = "lblRoomCapacity";
            lblRoomCapacity.Size = new Size(101, 24);
            lblRoomCapacity.TabIndex = 42;
            lblRoomCapacity.Text = "Capacity: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(51, 115);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 43;
            label5.Text = "Capacity: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(51, 76);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 44;
            label6.Text = "Room:";
            // 
            // ppClassroom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(863, 516);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblRoomCapacity);
            Controls.Add(lblRoomName);
            Controls.Add(cboTime);
            Controls.Add(txtOccupants);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(reserveBtn);
            Controls.Add(purposeTxt);
            Controls.Add(dateTimePicker);
            Controls.Add(purposeLbl);
            Controls.Add(dateTxt);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ppClassroom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ppClassroom";
            Load += ppClassroom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label dateTxt;
        private Label purposeLbl;
        private ReaLTaiizor.Controls.PoisonDateTime dateTimePicker;
        private TextBox purposeTxt;
        private Button reserveBtn;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox txtOccupants;
        private ComboBox cboTime;
        private Label lblRoomName;
        private Label lblRoomCapacity;
        private Label label5;
        private Label label6;
    }
}