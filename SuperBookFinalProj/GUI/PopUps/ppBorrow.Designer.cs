﻿namespace SuperBookFinalProj.GUI.PopUps
{
    partial class ppBorrow
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
            lblBorrow = new Label();
            label1 = new Label();
            poisonDateTime1 = new ReaLTaiizor.Controls.PoisonDateTime();
            label2 = new Label();
            textBox1 = new TextBox();
            btnBorrow = new Button();
            btnCancel = new Button();
            label3 = new Label();
            cboTime = new ComboBox();
            btnQuantity = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblBorrow
            // 
            lblBorrow.AutoSize = true;
            lblBorrow.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBorrow.ForeColor = SystemColors.ButtonFace;
            lblBorrow.Location = new Point(170, 9);
            lblBorrow.Name = "lblBorrow";
            lblBorrow.Size = new Size(89, 20);
            lblBorrow.TabIndex = 0;
            lblBorrow.Text = "BORROW";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Date:";
            // 
            // poisonDateTime1
            // 
            poisonDateTime1.Location = new Point(12, 76);
            poisonDateTime1.MinimumSize = new Size(0, 29);
            poisonDateTime1.Name = "poisonDateTime1";
            poisonDateTime1.Size = new Size(200, 30);
            poisonDateTime1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Purpose:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 48, 64);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(12, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 4;
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = Color.FromArgb(161, 181, 195);
            btnBorrow.Location = new Point(412, 198);
            btnBorrow.Margin = new Padding(3, 2, 3, 2);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(82, 22);
            btnBorrow.TabIndex = 16;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(161, 181, 195);
            btnCancel.Location = new Point(324, 198);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(21, 31, 40);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(251, 56);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 38;
            label3.Text = "Time:";
            // 
            // cboTime
            // 
            cboTime.FormattingEnabled = true;
            cboTime.Location = new Point(251, 83);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(144, 23);
            cboTime.TabIndex = 39;
            // 
            // btnQuantity
            // 
            btnQuantity.BackColor = Color.FromArgb(30, 48, 64);
            btnQuantity.ForeColor = SystemColors.Window;
            btnQuantity.Location = new Point(251, 142);
            btnQuantity.Name = "btnQuantity";
            btnQuantity.Size = new Size(144, 23);
            btnQuantity.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(251, 124);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 41;
            label4.Text = "Quantity:";
            // 
            // ppBorrow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(506, 231);
            Controls.Add(label4);
            Controls.Add(btnQuantity);
            Controls.Add(cboTime);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnBorrow);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(poisonDateTime1);
            Controls.Add(label1);
            Controls.Add(lblBorrow);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ppBorrow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "w";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBorrow;
        private Label label1;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime1;
        private Label label2;
        private TextBox textBox1;
        private Button btnBorrow;
        private Button btnCancel;
        private Label label3;
        private ComboBox cboTime;
        private TextBox btnQuantity;
        private Label label4;
    }
}