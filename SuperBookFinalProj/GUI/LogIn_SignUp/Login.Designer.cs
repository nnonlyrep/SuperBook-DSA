namespace SuperBookFinalProj.GUI.LogIn_SignUp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            pictureBox1 = new PictureBox();
            pwordTxt = new TextBox();
            unameTxt = new TextBox();
            emailAddLbl = new Label();
            usrnLbl = new Label();
            LoginBtn = new Button();
            Lblsignup = new Label();
            showBtn = new Button();
            hideBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 48, 64);
            panel1.Controls.Add(nightControlBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1089, 48);
            panel1.TabIndex = 0;
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
            nightControlBox1.Location = new Point(950, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pa_reserve_daw_teh_;
            pictureBox1.Location = new Point(145, -25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(811, 579);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pwordTxt
            // 
            pwordTxt.BackColor = Color.FromArgb(30, 48, 64);
            pwordTxt.Font = new Font("Segoe UI", 10F);
            pwordTxt.ForeColor = Color.White;
            pwordTxt.Location = new Point(425, 545);
            pwordTxt.Name = "pwordTxt";
            pwordTxt.PasswordChar = '*';
            pwordTxt.Size = new Size(251, 30);
            pwordTxt.TabIndex = 14;
            // 
            // unameTxt
            // 
            unameTxt.BackColor = Color.FromArgb(30, 48, 64);
            unameTxt.Font = new Font("Segoe UI", 10F);
            unameTxt.ForeColor = Color.White;
            unameTxt.Location = new Point(426, 475);
            unameTxt.Name = "unameTxt";
            unameTxt.Size = new Size(251, 30);
            unameTxt.TabIndex = 13;
            unameTxt.TextChanged += unameTxt_TextChanged;
            // 
            // emailAddLbl
            // 
            emailAddLbl.AutoSize = true;
            emailAddLbl.ForeColor = SystemColors.ControlLightLight;
            emailAddLbl.Location = new Point(518, 520);
            emailAddLbl.Name = "emailAddLbl";
            emailAddLbl.Size = new Size(70, 20);
            emailAddLbl.TabIndex = 12;
            emailAddLbl.Text = "Password";
            // 
            // usrnLbl
            // 
            usrnLbl.AutoSize = true;
            usrnLbl.ForeColor = SystemColors.ControlLightLight;
            usrnLbl.Location = new Point(515, 447);
            usrnLbl.Name = "usrnLbl";
            usrnLbl.Size = new Size(75, 20);
            usrnLbl.TabIndex = 11;
            usrnLbl.Text = "Username";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(161, 181, 195);
            LoginBtn.Location = new Point(506, 596);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(94, 29);
            LoginBtn.TabIndex = 15;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // Lblsignup
            // 
            Lblsignup.AutoSize = true;
            Lblsignup.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Lblsignup.ForeColor = SystemColors.ControlLightLight;
            Lblsignup.Location = new Point(527, 629);
            Lblsignup.Name = "Lblsignup";
            Lblsignup.Size = new Size(59, 20);
            Lblsignup.TabIndex = 16;
            Lblsignup.Text = "Sign up";
            Lblsignup.Click += Lblsignup_Click;
            // 
            // showBtn
            // 
            showBtn.FlatStyle = FlatStyle.Flat;
            showBtn.Image = (Image)resources.GetObject("showBtn.Image");
            showBtn.Location = new Point(682, 540);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(34, 29);
            showBtn.TabIndex = 17;
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // hideBtn
            // 
            hideBtn.FlatStyle = FlatStyle.Flat;
            hideBtn.Image = (Image)resources.GetObject("hideBtn.Image");
            hideBtn.Location = new Point(682, 542);
            hideBtn.Name = "hideBtn";
            hideBtn.Size = new Size(34, 29);
            hideBtn.TabIndex = 18;
            hideBtn.UseVisualStyleBackColor = true;
            hideBtn.Click += hideBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(1089, 687);
            Controls.Add(showBtn);
            Controls.Add(Lblsignup);
            Controls.Add(LoginBtn);
            Controls.Add(pwordTxt);
            Controls.Add(unameTxt);
            Controls.Add(emailAddLbl);
            Controls.Add(usrnLbl);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(hideBtn);
            ForeColor = Color.FromArgb(21, 31, 40);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private PictureBox pictureBox1;
        private TextBox pwordTxt;
        private TextBox unameTxt;
        private Label emailAddLbl;
        private Label usrnLbl;
        private Button LoginBtn;
        private Label Lblsignup;
        private Button showBtn;
        private Button hideBtn;
    }
}