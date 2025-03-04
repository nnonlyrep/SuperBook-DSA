namespace SuperBookFinalProj.GUI.PopUps
{
    partial class ppHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ppHome));
            roomBtn = new Button();
            equipBtn = new Button();
            label1 = new Label();
            label3 = new Label();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // roomBtn
            // 
            roomBtn.FlatAppearance.BorderSize = 0;
            roomBtn.FlatStyle = FlatStyle.Flat;
            roomBtn.Image = (Image)resources.GetObject("roomBtn.Image");
            roomBtn.Location = new Point(126, 84);
            roomBtn.Name = "roomBtn";
            roomBtn.Size = new Size(237, 258);
            roomBtn.TabIndex = 0;
            roomBtn.UseVisualStyleBackColor = true;
            roomBtn.Click += roomBtn_Click;
            // 
            // equipBtn
            // 
            equipBtn.BackgroundImageLayout = ImageLayout.None;
            equipBtn.FlatAppearance.BorderSize = 0;
            equipBtn.FlatStyle = FlatStyle.Flat;
            equipBtn.Image = Properties.Resources._82;
            equipBtn.Location = new Point(441, 84);
            equipBtn.Name = "equipBtn";
            equipBtn.Size = new Size(247, 258);
            equipBtn.TabIndex = 2;
            equipBtn.UseVisualStyleBackColor = true;
            equipBtn.Click += equipBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lazydog", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(204, 335);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 3;
            label1.Text = "ROOMS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lazydog", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(507, 335);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 5;
            label3.Text = "EQUIPMENTS";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(161, 181, 195);
            btnCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnCancel.Location = new Point(24, 21);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ppHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(827, 402);
            Controls.Add(btnCancel);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(equipBtn);
            Controls.Add(roomBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ppHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ppHome";
            Load += ppHome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button roomBtn;
        private Button equipBtn;
        private Label label1;
        private Label label3;
        private Button btnCancel;
    }
}