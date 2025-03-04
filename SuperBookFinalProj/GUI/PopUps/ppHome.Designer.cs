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
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            BckHomeButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // roomBtn
            // 
            roomBtn.FlatAppearance.BorderSize = 0;
            roomBtn.FlatStyle = FlatStyle.Flat;
            roomBtn.Image = (Image)resources.GetObject("roomBtn.Image");
            roomBtn.Location = new Point(144, 112);
            roomBtn.Margin = new Padding(3, 4, 3, 4);
            roomBtn.Name = "roomBtn";
            roomBtn.Size = new Size(271, 344);
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
            equipBtn.Location = new Point(504, 112);
            equipBtn.Margin = new Padding(3, 4, 3, 4);
            equipBtn.Name = "equipBtn";
            equipBtn.Size = new Size(282, 344);
            equipBtn.TabIndex = 2;
            equipBtn.UseVisualStyleBackColor = true;
            equipBtn.Click += equipBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(233, 447);
            label1.Name = "label1";
            label1.Size = new Size(109, 29);
            label1.TabIndex = 3;
            label1.Text = "ROOMS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(579, 447);
            label3.Name = "label3";
            label3.Size = new Size(183, 29);
            label3.TabIndex = 5;
            label3.Text = "EQUIPMENTS";
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(30, 48, 64);
            panel1.Controls.Add(nightControlBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(969, 39);
            panel1.TabIndex = 6;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(830, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // BckHomeButton
            // 
            BckHomeButton.BackColor = Color.FromArgb(161, 181, 195);
            BckHomeButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BckHomeButton.Location = new Point(21, 563);
            BckHomeButton.Margin = new Padding(3, 4, 3, 4);
            BckHomeButton.Name = "BckHomeButton";
            BckHomeButton.Size = new Size(171, 43);
            BckHomeButton.TabIndex = 17;
            BckHomeButton.Text = "Back to Home";
            BckHomeButton.UseVisualStyleBackColor = false;
            BckHomeButton.Click += BckHomeButton_Click;
            // 
            // ppHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(969, 631);
            Controls.Add(BckHomeButton);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(equipBtn);
            Controls.Add(roomBtn);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ppHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ppHome";
            Load += ppHome_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button roomBtn;
        private Button equipBtn;
        private Label label1;
        private Label label3;
        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Button BckHomeButton;
    }
}