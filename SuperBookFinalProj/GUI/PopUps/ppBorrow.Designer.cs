namespace SuperBookFinalProj.GUI.PopUps
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
            dtBox = new ReaLTaiizor.Controls.PoisonDateTime();
            label2 = new Label();
            txtPurpose = new TextBox();
            btnBorrow = new Button();
            btnCancel = new Button();
            label3 = new Label();
            cboTime = new ComboBox();
            txtQuantity = new TextBox();
            label4 = new Label();
            lblEquipment = new Label();
            lblQuantity = new Label();
            SuspendLayout();
            // 
            // lblBorrow
            // 
            lblBorrow.AutoSize = true;
            lblBorrow.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBorrow.ForeColor = SystemColors.ButtonFace;
            lblBorrow.Location = new Point(59, 9);
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
            label1.Location = new Point(59, 98);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Date:";
            // 
            // dtBox
            // 
            dtBox.Location = new Point(59, 118);
            dtBox.MinimumSize = new Size(0, 29);
            dtBox.Name = "dtBox";
            dtBox.Size = new Size(200, 29);
            dtBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(59, 164);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Purpose:";
            // 
            // txtPurpose
            // 
            txtPurpose.BackColor = Color.FromArgb(30, 48, 64);
            txtPurpose.ForeColor = SystemColors.Window;
            txtPurpose.Location = new Point(59, 184);
            txtPurpose.Name = "txtPurpose";
            txtPurpose.Size = new Size(200, 23);
            txtPurpose.TabIndex = 4;
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = Color.FromArgb(161, 181, 195);
            btnBorrow.Location = new Point(433, 241);
            btnBorrow.Margin = new Padding(3, 2, 3, 2);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(82, 22);
            btnBorrow.TabIndex = 16;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += btnBorrow_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(161, 181, 195);
            btnCancel.Location = new Point(345, 241);
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
            label3.Location = new Point(298, 98);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 38;
            label3.Text = "Time:";
            // 
            // cboTime
            // 
            cboTime.FormattingEnabled = true;
            cboTime.Items.AddRange(new object[] { "7:00AM - 9:00AM", "10:00AM - 12:00PM", "1:00PM - 3:00PM", "4:00PM - 6:00PM" });
            cboTime.Location = new Point(298, 125);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(144, 23);
            cboTime.TabIndex = 39;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(30, 48, 64);
            txtQuantity.ForeColor = SystemColors.Window;
            txtQuantity.Location = new Point(298, 184);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(144, 23);
            txtQuantity.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(298, 166);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 41;
            label4.Text = "Quantity:";
            // 
            // lblEquipment
            // 
            lblEquipment.AutoSize = true;
            lblEquipment.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipment.ForeColor = SystemColors.ButtonFace;
            lblEquipment.Location = new Point(59, 46);
            lblEquipment.Name = "lblEquipment";
            lblEquipment.Size = new Size(80, 15);
            lblEquipment.TabIndex = 42;
            lblEquipment.Text = "Equipment:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = SystemColors.ButtonFace;
            lblQuantity.Location = new Point(59, 72);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(69, 15);
            lblQuantity.TabIndex = 43;
            lblQuantity.Text = "Available:";
            // 
            // ppBorrow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(609, 315);
            Controls.Add(lblQuantity);
            Controls.Add(lblEquipment);
            Controls.Add(label4);
            Controls.Add(txtQuantity);
            Controls.Add(cboTime);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnBorrow);
            Controls.Add(txtPurpose);
            Controls.Add(label2);
            Controls.Add(dtBox);
            Controls.Add(label1);
            Controls.Add(lblBorrow);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ppBorrow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "w";
            Load += ppBorrow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBorrow;
        private Label label1;
        private ReaLTaiizor.Controls.PoisonDateTime dtBox;
        private Label label2;
        private TextBox txtPurpose;
        private Button btnBorrow;
        private Button btnCancel;
        private Label label3;
        private ComboBox cboTime;
        private TextBox txtQuantity;
        private Label label4;
        private Label lblEquipment;
        private Label lblQuantity;
    }
}