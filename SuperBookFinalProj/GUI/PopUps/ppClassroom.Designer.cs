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
            poisonDateTime1 = new ReaLTaiizor.Controls.PoisonDateTime();
            purposeTxt = new TextBox();
            reserveBtn = new Button();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            cboTime = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(295, 29);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 1;
            label1.Text = "ROOMS";
            // 
            // dateTxt
            // 
            dateTxt.AutoSize = true;
            dateTxt.BackColor = Color.FromArgb(21, 31, 40);
            dateTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTxt.ForeColor = SystemColors.Window;
            dateTxt.Location = new Point(95, 104);
            dateTxt.Name = "dateTxt";
            dateTxt.Size = new Size(50, 21);
            dateTxt.TabIndex = 2;
            dateTxt.Text = "Date:";
            // 
            // purposeLbl
            // 
            purposeLbl.AutoSize = true;
            purposeLbl.BackColor = Color.FromArgb(21, 31, 40);
            purposeLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            purposeLbl.ForeColor = SystemColors.Window;
            purposeLbl.Location = new Point(382, 109);
            purposeLbl.Name = "purposeLbl";
            purposeLbl.Size = new Size(152, 20);
            purposeLbl.TabIndex = 4;
            purposeLbl.Text = "Purpose/Program:";
            // 
            // poisonDateTime1
            // 
            poisonDateTime1.Location = new Point(95, 134);
            poisonDateTime1.MinimumSize = new Size(0, 29);
            poisonDateTime1.Name = "poisonDateTime1";
            poisonDateTime1.Size = new Size(200, 29);
            poisonDateTime1.TabIndex = 10;
            // 
            // purposeTxt
            // 
            purposeTxt.BackColor = Color.FromArgb(30, 48, 64);
            purposeTxt.BorderStyle = BorderStyle.None;
            purposeTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            purposeTxt.ForeColor = Color.White;
            purposeTxt.Location = new Point(382, 137);
            purposeTxt.Margin = new Padding(3, 2, 3, 2);
            purposeTxt.Name = "purposeTxt";
            purposeTxt.Size = new Size(257, 19);
            purposeTxt.TabIndex = 18;
            purposeTxt.TextChanged += purposeTxt_TextChanged;
            // 
            // reserveBtn
            // 
            reserveBtn.BackColor = Color.FromArgb(161, 181, 195);
            reserveBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reserveBtn.Location = new Point(557, 253);
            reserveBtn.Margin = new Padding(3, 2, 3, 2);
            reserveBtn.Name = "reserveBtn";
            reserveBtn.Size = new Size(82, 32);
            reserveBtn.TabIndex = 23;
            reserveBtn.Text = "Reserve";
            reserveBtn.UseVisualStyleBackColor = false;
            reserveBtn.Click += reserveBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(161, 181, 195);
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(93, 253);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 32);
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
            label2.Location = new Point(93, 182);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 26;
            label2.Text = "Time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(21, 31, 40);
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(382, 168);
            label3.Name = "label3";
            label3.Size = new Size(188, 20);
            label3.TabIndex = 28;
            label3.Text = "Number of Occupants:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 48, 64);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(382, 201);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 19);
            textBox1.TabIndex = 29;
            // 
            // cboTime
            // 
            cboTime.FormattingEnabled = true;
            cboTime.Items.AddRange(new object[] { "7:00AM - 9:00AM", "10:00AM - 12:00PM", "1:00PM - 3:00PM", "4:00PM - 6:00PM" });
            cboTime.Location = new Point(151, 182);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(144, 23);
            cboTime.TabIndex = 40;
            // 
            // ppClassroom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(755, 387);
            Controls.Add(cboTime);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(reserveBtn);
            Controls.Add(purposeTxt);
            Controls.Add(poisonDateTime1);
            Controls.Add(purposeLbl);
            Controls.Add(dateTxt);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ppClassroom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ppClassroom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label dateTxt;
        private Label purposeLbl;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime1;
        private TextBox purposeTxt;
        private Button reserveBtn;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private ComboBox cboTime;
    }
}