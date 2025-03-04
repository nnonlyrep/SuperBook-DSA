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
            lblBorrow.Location = new Point(194, 12);
            lblBorrow.Name = "lblBorrow";
            lblBorrow.Size = new Size(109, 25);
            lblBorrow.TabIndex = 0;
            lblBorrow.Text = "BORROW";

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(14, 75);
            label1.Name = "label1";
            label1.Size = new Size(48, 18);
            label1.TabIndex = 1;
            label1.Text = "Date:";

            // 
            // dtBox
            // 
            dtBox.Location = new Point(14, 101);
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
            label2.Location = new Point(14, 163);
            label2.Name = "label2";
            label2.Size = new Size(76, 18);
            label2.TabIndex = 3;
            label2.Text = "Purpose:";

            // 
            // txtPurpose
            // 
            txtPurpose.BackColor = Color.FromArgb(30, 48, 64);
            txtPurpose.ForeColor = SystemColors.Window;
            txtPurpose.Location = new Point(14, 189);
            txtPurpose.Name = "txtPurpose";
            txtPurpose.Size = new Size(228, 23);
            txtPurpose.TabIndex = 4;

            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = Color.FromArgb(161, 181, 195);
            btnBorrow.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrow.Location = new Point(471, 264);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(94, 29);
            btnBorrow.TabIndex = 16;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += btnBorrow_Click_1;

            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(161, 181, 195);
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(370, 264);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
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
            label3.Location = new Point(287, 75);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 38;
            label3.Text = "Time:";

            // 
            // cboTime
            // 
            cboTime.FormattingEnabled = true;
            cboTime.Items.AddRange(new object[] { "7:00AM - 9:00AM", "10:00AM - 12:00PM", "1:00PM - 3:00PM", "4:00PM - 6:00PM" });
            cboTime.Location = new Point(287, 111);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(164, 28);
            cboTime.TabIndex = 39;

            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(30, 48, 64);
            txtQuantity.ForeColor = SystemColors.Window;
            txtQuantity.Location = new Point(287, 189);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(164, 23);
            txtQuantity.TabIndex = 40;

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(287, 165);
            label4.Name = "label4";
            label4.Size = new Size(75, 18);
            label4.TabIndex = 41;
            label4.Text = "Quantity:";

            // 
            // ppBorrow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(578, 308);
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
