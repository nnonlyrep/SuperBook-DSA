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
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            BckBtn = new Button();
            UpdtBtn = new Button();
            roomNumtxt = new TextBox();
            poisonDateTime1 = new ReaLTaiizor.Controls.PoisonDateTime();
            roomNumLbl = new Label();
            dateTxt = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(21, 31, 40);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(134, 261);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 45;
            label2.Text = "Time:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(201, 261);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(164, 27);
            dateTimePicker1.TabIndex = 44;
            // 
            // BckBtn
            // 
            BckBtn.BackColor = Color.FromArgb(161, 181, 195);
            BckBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BckBtn.Location = new Point(57, 515);
            BckBtn.Name = "BckBtn";
            BckBtn.Size = new Size(94, 43);
            BckBtn.TabIndex = 43;
            BckBtn.Text = "Back";
            BckBtn.UseVisualStyleBackColor = false;
            // 
            // UpdtBtn
            // 
            UpdtBtn.BackColor = Color.FromArgb(161, 181, 195);
            UpdtBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdtBtn.Location = new Point(764, 515);
            UpdtBtn.Name = "UpdtBtn";
            UpdtBtn.Size = new Size(94, 43);
            UpdtBtn.TabIndex = 42;
            UpdtBtn.Text = "Update";
            UpdtBtn.UseVisualStyleBackColor = false;
            // 
            // roomNumtxt
            // 
            roomNumtxt.BackColor = Color.FromArgb(30, 48, 64);
            roomNumtxt.BorderStyle = BorderStyle.None;
            roomNumtxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            roomNumtxt.ForeColor = Color.White;
            roomNumtxt.Location = new Point(137, 359);
            roomNumtxt.Name = "roomNumtxt";
            roomNumtxt.Size = new Size(170, 23);
            roomNumtxt.TabIndex = 36;
            // 
            // poisonDateTime1
            // 
            poisonDateTime1.Location = new Point(137, 197);
            poisonDateTime1.Margin = new Padding(3, 4, 3, 4);
            poisonDateTime1.MinimumSize = new Size(0, 30);
            poisonDateTime1.Name = "poisonDateTime1";
            poisonDateTime1.Size = new Size(228, 30);
            poisonDateTime1.TabIndex = 35;
            // 
            // roomNumLbl
            // 
            roomNumLbl.AutoSize = true;
            roomNumLbl.BackColor = Color.FromArgb(21, 31, 40);
            roomNumLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            roomNumLbl.ForeColor = SystemColors.Window;
            roomNumLbl.Location = new Point(134, 326);
            roomNumLbl.Name = "roomNumLbl";
            roomNumLbl.Size = new Size(155, 25);
            roomNumLbl.TabIndex = 29;
            roomNumLbl.Text = "Room Number:";
            // 
            // dateTxt
            // 
            dateTxt.AutoSize = true;
            dateTxt.BackColor = Color.FromArgb(21, 31, 40);
            dateTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTxt.ForeColor = SystemColors.Window;
            dateTxt.Location = new Point(137, 157);
            dateTxt.Name = "dateTxt";
            dateTxt.Size = new Size(62, 28);
            dateTxt.TabIndex = 28;
            dateTxt.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(373, 43);
            label1.Name = "label1";
            label1.Size = new Size(174, 29);
            label1.TabIndex = 27;
            label1.Text = "CLASSROOM";
            // 
            // frmAdRooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(914, 600);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(BckBtn);
            Controls.Add(UpdtBtn);
            Controls.Add(roomNumtxt);
            Controls.Add(poisonDateTime1);
            Controls.Add(roomNumLbl);
            Controls.Add(dateTxt);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAdRooms";
            Text = "frmAdRooms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Button BckBtn;
        private Button UpdtBtn;
        private TextBox roomNumtxt;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime1;
        private Label roomNumLbl;
        private Label dateTxt;
        private Label label1;
    }
}