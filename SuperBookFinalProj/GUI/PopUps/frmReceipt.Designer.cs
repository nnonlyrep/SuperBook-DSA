namespace SuperBookFinalProj.GUI.PopUps
{
    partial class frmReceipt
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
            lblTitle = new Label();
            lblConsumerName = new Label();
            lblRoomNumber = new Label();
            lblRoomCapacity = new Label();
            lblDate = new Label();
            lblTime = new Label();
            lblPurpose = new Label();
            lblOccupants = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(21, 31, 40);
            lblTitle.Location = new Point(60, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(187, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reservation Receipt";
            // 
            // lblConsumerName
            // 
            lblConsumerName.Location = new Point(34, 59);
            lblConsumerName.Name = "lblConsumerName";
            lblConsumerName.Size = new Size(138, 23);
            lblConsumerName.TabIndex = 1;
            lblConsumerName.Text = "wqwqw";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.Location = new Point(34, 128);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(138, 23);
            lblRoomNumber.TabIndex = 2;
            lblRoomNumber.Text = "qwqw";
            // 
            // lblRoomCapacity
            // 
            lblRoomCapacity.Location = new Point(34, 95);
            lblRoomCapacity.Name = "lblRoomCapacity";
            lblRoomCapacity.Size = new Size(138, 23);
            lblRoomCapacity.TabIndex = 3;
            lblRoomCapacity.Text = "qwqw";
            lblRoomCapacity.Click += lblRoomCapacity_Click;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(34, 163);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(138, 23);
            lblDate.TabIndex = 4;
            lblDate.Text = "qwqw";
            // 
            // lblTime
            // 
            lblTime.Location = new Point(34, 186);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(138, 23);
            lblTime.TabIndex = 5;
            lblTime.Text = "qwqwq";
            lblTime.Click += lblTime_Click;
            // 
            // lblPurpose
            // 
            lblPurpose.Location = new Point(34, 218);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(138, 23);
            lblPurpose.TabIndex = 6;
            lblPurpose.Text = "qwqw";
            // 
            // lblOccupants
            // 
            lblOccupants.Location = new Point(34, 241);
            lblOccupants.Name = "lblOccupants";
            lblOccupants.Size = new Size(100, 23);
            lblOccupants.TabIndex = 7;
            lblOccupants.Text = "qwq";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(21, 31, 40);
            btnClose.Location = new Point(100, 290);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 35);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(161, 181, 195);
            ClientSize = new Size(320, 350);
            Controls.Add(lblConsumerName);
            Controls.Add(lblTitle);
            Controls.Add(lblRoomNumber);
            Controls.Add(lblRoomCapacity);
            Controls.Add(lblDate);
            Controls.Add(lblTime);
            Controls.Add(lblPurpose);
            Controls.Add(lblOccupants);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmReceipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation Receipt";
            Load += frmReceipt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void ConfigureLabel(System.Windows.Forms.Label label, string text, System.Drawing.Point location)
        {
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Segoe UI", 10F);
            label.Location = location;
            label.Name = $"lbl{text.Replace(":", "").Replace(" ", "")}";
            label.Size = new System.Drawing.Size(250, 19);
            label.TabIndex = 1;
            label.Text = text;
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblConsumerName;
        public System.Windows.Forms.Label lblRoomNumber;
        public System.Windows.Forms.Label lblRoomCapacity;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.Label lblPurpose;
        public System.Windows.Forms.Label lblOccupants;
        private System.Windows.Forms.Button btnClose;
    }
}
