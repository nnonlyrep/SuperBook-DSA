

namespace SuperBookFinalProj.GUI.LogIn_SignUp
{
    partial class SignUp
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
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            firstNameTxt = new TextBox();
            firstNameLbl = new Label();
            lastNameLbl = new Label();
            lastNameTxt = new TextBox();
            contactNoLbl = new Label();
            emailAddLbl = new Label();
            schoolIDLbl = new Label();
            contactNoTxt = new TextBox();
            emailAddTxt = new TextBox();
            schoolIDTxt = new TextBox();
            backBtn = new Button();
            SignUpBtn = new Button();
            lblpWord = new Label();
            txtpWord = new TextBox();
            pictureBox1 = new PictureBox();
            txtuName = new TextBox();
            lbluName = new Label();
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(969, 31);
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
            nightControlBox1.Location = new Point(830, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // firstNameTxt
            // 
            firstNameTxt.BackColor = Color.FromArgb(30, 48, 64);
            firstNameTxt.Font = new Font("Segoe UI", 10F);
            firstNameTxt.ForeColor = Color.White;
            firstNameTxt.Location = new Point(566, 123);
            firstNameTxt.Margin = new Padding(3, 2, 3, 2);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(122, 25);
            firstNameTxt.TabIndex = 2;
            // 
            // firstNameLbl
            // 
            firstNameLbl.AutoSize = true;
            firstNameLbl.ForeColor = SystemColors.ControlLightLight;
            firstNameLbl.Location = new Point(566, 102);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(67, 15);
            firstNameLbl.TabIndex = 3;
            firstNameLbl.Text = "First Name:";
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.ForeColor = SystemColors.ControlLightLight;
            lastNameLbl.Location = new Point(694, 102);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(66, 15);
            lastNameLbl.TabIndex = 4;
            lastNameLbl.Text = "Last Name:";
            lastNameLbl.Click += label2_Click;
            // 
            // lastNameTxt
            // 
            lastNameTxt.BackColor = Color.FromArgb(30, 48, 64);
            lastNameTxt.Font = new Font("Segoe UI", 10F);
            lastNameTxt.ForeColor = Color.White;
            lastNameTxt.Location = new Point(694, 123);
            lastNameTxt.Margin = new Padding(3, 2, 3, 2);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(136, 25);
            lastNameTxt.TabIndex = 5;
            // 
            // contactNoLbl
            // 
            contactNoLbl.AutoSize = true;
            contactNoLbl.ForeColor = SystemColors.ControlLightLight;
            contactNoLbl.Location = new Point(566, 164);
            contactNoLbl.Name = "contactNoLbl";
            contactNoLbl.Size = new Size(99, 15);
            contactNoLbl.TabIndex = 6;
            contactNoLbl.Text = "Contact Number:";
            contactNoLbl.Click += contactNoLbl_Click;
            // 
            // emailAddLbl
            // 
            emailAddLbl.AutoSize = true;
            emailAddLbl.ForeColor = SystemColors.ControlLightLight;
            emailAddLbl.Location = new Point(566, 228);
            emailAddLbl.Name = "emailAddLbl";
            emailAddLbl.Size = new Size(84, 15);
            emailAddLbl.TabIndex = 7;
            emailAddLbl.Text = "Email Address:";
            // 
            // schoolIDLbl
            // 
            schoolIDLbl.AutoSize = true;
            schoolIDLbl.ForeColor = SystemColors.ControlLightLight;
            schoolIDLbl.Location = new Point(566, 296);
            schoolIDLbl.Name = "schoolIDLbl";
            schoolIDLbl.Size = new Size(60, 15);
            schoolIDLbl.TabIndex = 8;
            schoolIDLbl.Text = "School ID:";
            // 
            // contactNoTxt
            // 
            contactNoTxt.BackColor = Color.FromArgb(30, 48, 64);
            contactNoTxt.Font = new Font("Segoe UI", 10F);
            contactNoTxt.ForeColor = Color.White;
            contactNoTxt.Location = new Point(566, 185);
            contactNoTxt.Margin = new Padding(3, 2, 3, 2);
            contactNoTxt.Name = "contactNoTxt";
            contactNoTxt.Size = new Size(264, 25);
            contactNoTxt.TabIndex = 9;
            // 
            // emailAddTxt
            // 
            emailAddTxt.BackColor = Color.FromArgb(30, 48, 64);
            emailAddTxt.Font = new Font("Segoe UI", 10F);
            emailAddTxt.ForeColor = Color.White;
            emailAddTxt.Location = new Point(566, 249);
            emailAddTxt.Margin = new Padding(3, 2, 3, 2);
            emailAddTxt.Name = "emailAddTxt";
            emailAddTxt.Size = new Size(264, 25);
            emailAddTxt.TabIndex = 10;
            // 
            // schoolIDTxt
            // 
            schoolIDTxt.BackColor = Color.FromArgb(30, 48, 64);
            schoolIDTxt.Font = new Font("Segoe UI", 10F);
            schoolIDTxt.ForeColor = Color.White;
            schoolIDTxt.Location = new Point(566, 316);
            schoolIDTxt.Margin = new Padding(3, 2, 3, 2);
            schoolIDTxt.Name = "schoolIDTxt";
            schoolIDTxt.Size = new Size(264, 25);
            schoolIDTxt.TabIndex = 11;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(161, 181, 195);
            backBtn.Location = new Point(41, 488);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(82, 22);
            backBtn.TabIndex = 12;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.FromArgb(161, 181, 195);
            SignUpBtn.Location = new Point(847, 488);
            SignUpBtn.Margin = new Padding(3, 2, 3, 2);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(82, 22);
            SignUpBtn.TabIndex = 13;
            SignUpBtn.Text = "Sign Up";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // lblpWord
            // 
            lblpWord.AutoSize = true;
            lblpWord.ForeColor = SystemColors.ControlLightLight;
            lblpWord.Location = new Point(566, 362);
            lblpWord.Name = "lblpWord";
            lblpWord.Size = new Size(60, 15);
            lblpWord.TabIndex = 14;
            lblpWord.Text = "Password:";
            // 
            // txtpWord
            // 
            txtpWord.BackColor = Color.FromArgb(30, 48, 64);
            txtpWord.Font = new Font("Segoe UI", 10F);
            txtpWord.ForeColor = Color.White;
            txtpWord.Location = new Point(566, 383);
            txtpWord.Margin = new Padding(3, 2, 3, 2);
            txtpWord.Name = "txtpWord";
            txtpWord.Size = new Size(264, 25);
            txtpWord.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pa_reserve_daw_teh_;
            pictureBox1.Location = new Point(-49, 31);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(737, 479);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // txtuName
            // 
            txtuName.BackColor = Color.FromArgb(30, 48, 64);
            txtuName.Font = new Font("Segoe UI", 10F);
            txtuName.ForeColor = Color.White;
            txtuName.Location = new Point(566, 75);
            txtuName.Margin = new Padding(3, 2, 3, 2);
            txtuName.Name = "txtuName";
            txtuName.Size = new Size(264, 25);
            txtuName.TabIndex = 17;
            // 
            // lbluName
            // 
            lbluName.AutoSize = true;
            lbluName.ForeColor = SystemColors.ControlLightLight;
            lbluName.Location = new Point(566, 58);
            lbluName.Name = "lbluName";
            lbluName.Size = new Size(60, 15);
            lbluName.TabIndex = 18;
            lbluName.Text = "Username";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(969, 540);
            Controls.Add(lbluName);
            Controls.Add(txtuName);
            Controls.Add(txtpWord);
            Controls.Add(lblpWord);
            Controls.Add(SignUpBtn);
            Controls.Add(backBtn);
            Controls.Add(schoolIDTxt);
            Controls.Add(emailAddTxt);
            Controls.Add(contactNoTxt);
            Controls.Add(schoolIDLbl);
            Controls.Add(emailAddLbl);
            Controls.Add(contactNoLbl);
            Controls.Add(lastNameTxt);
            Controls.Add(lastNameLbl);
            Controls.Add(firstNameLbl);
            Controls.Add(firstNameTxt);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private TextBox firstNameTxt;
        private Label firstNameLbl;
        private Label lastNameLbl;
        private TextBox lastNameTxt;
        private Label contactNoLbl;
        private Label emailAddLbl;
        private Label schoolIDLbl;
        private TextBox contactNoTxt;
        private TextBox emailAddTxt;
        private TextBox schoolIDTxt;
        private Button backBtn;
        private Button SignUpBtn;
        private Label lblpWord;
        private TextBox txtpWord;
        private PictureBox pictureBox1;
        private TextBox txtuName;
        private Label lbluName;
    }
}