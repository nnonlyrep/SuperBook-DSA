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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblConsumerName = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblRoomCapacity = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblOccupants = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(60, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reservation Receipt";

            // 
            // Labels Configuration
            // 
            ConfigureLabel(lblConsumerName, "Consumer:", new System.Drawing.Point(20, 60));
            ConfigureLabel(lblRoomNumber, "Room:", new System.Drawing.Point(20, 90));
            ConfigureLabel(lblRoomCapacity, "Capacity:", new System.Drawing.Point(20, 120));
            ConfigureLabel(lblDate, "Date:", new System.Drawing.Point(20, 150));
            ConfigureLabel(lblTime, "Time:", new System.Drawing.Point(20, 180));
            ConfigureLabel(lblPurpose, "Purpose:", new System.Drawing.Point(20, 210));
            ConfigureLabel(lblOccupants, "Occupants:", new System.Drawing.Point(20, 240));

            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(100, 280);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 350);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblConsumerName);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.lblRoomCapacity);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.lblOccupants);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation Receipt";
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
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
