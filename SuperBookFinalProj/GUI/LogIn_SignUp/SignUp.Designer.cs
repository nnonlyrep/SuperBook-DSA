

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
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1107, 41);
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
            nightControlBox1.Location = new Point(968, 0);
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
            firstNameTxt.Location = new Point(647, 164);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(139, 30);
            firstNameTxt.TabIndex = 2;
            // 
            // firstNameLbl
            // 
            firstNameLbl.AutoSize = true;
            firstNameLbl.ForeColor = SystemColors.ControlLightLight;
            firstNameLbl.Location = new Point(647, 136);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(83, 20);
            firstNameLbl.TabIndex = 3;
            firstNameLbl.Text = "First Name:";
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.ForeColor = SystemColors.ControlLightLight;
            lastNameLbl.Location = new Point(793, 136);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(82, 20);
            lastNameLbl.TabIndex = 4;
            lastNameLbl.Text = "Last Name:";
            lastNameLbl.Click += label2_Click;
            // 
            // lastNameTxt
            // 
            lastNameTxt.BackColor = Color.FromArgb(30, 48, 64);
            lastNameTxt.Font = new Font("Segoe UI", 10F);
            lastNameTxt.ForeColor = Color.White;
            lastNameTxt.Location = new Point(793, 164);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(155, 30);
            lastNameTxt.TabIndex = 5;
            // 
            // contactNoLbl
            // 
            contactNoLbl.AutoSize = true;
            contactNoLbl.ForeColor = SystemColors.ControlLightLight;
            contactNoLbl.Location = new Point(647, 219);
            contactNoLbl.Name = "contactNoLbl";
            contactNoLbl.Size = new Size(121, 20);
            contactNoLbl.TabIndex = 6;
            contactNoLbl.Text = "Contact Number:";
            contactNoLbl.Click += contactNoLbl_Click;
            // 
            // emailAddLbl
            // 
            emailAddLbl.AutoSize = true;
            emailAddLbl.ForeColor = SystemColors.ControlLightLight;
            emailAddLbl.Location = new Point(647, 304);
            emailAddLbl.Name = "emailAddLbl";
            emailAddLbl.Size = new Size(106, 20);
            emailAddLbl.TabIndex = 7;
            emailAddLbl.Text = "Email Address:";
            // 
            // schoolIDLbl
            // 
            schoolIDLbl.AutoSize = true;
            schoolIDLbl.ForeColor = SystemColors.ControlLightLight;
            schoolIDLbl.Location = new Point(647, 395);
            schoolIDLbl.Name = "schoolIDLbl";
            schoolIDLbl.Size = new Size(76, 20);
            schoolIDLbl.TabIndex = 8;
            schoolIDLbl.Text = "School ID:";
            // 
            // contactNoTxt
            // 
            contactNoTxt.BackColor = Color.FromArgb(30, 48, 64);
            contactNoTxt.Font = new Font("Segoe UI", 10F);
            contactNoTxt.ForeColor = Color.White;
            contactNoTxt.Location = new Point(647, 247);
            contactNoTxt.Name = "contactNoTxt";
            contactNoTxt.Size = new Size(301, 30);
            contactNoTxt.TabIndex = 9;
            // 
            // emailAddTxt
            // 
            emailAddTxt.BackColor = Color.FromArgb(30, 48, 64);
            emailAddTxt.Font = new Font("Segoe UI", 10F);
            emailAddTxt.ForeColor = Color.White;
            emailAddTxt.Location = new Point(647, 332);
            emailAddTxt.Name = "emailAddTxt";
            emailAddTxt.Size = new Size(301, 30);
            emailAddTxt.TabIndex = 10;
            // 
            // schoolIDTxt
            // 
            schoolIDTxt.BackColor = Color.FromArgb(30, 48, 64);
            schoolIDTxt.Font = new Font("Segoe UI", 10F);
            schoolIDTxt.ForeColor = Color.White;
            schoolIDTxt.Location = new Point(647, 421);
            schoolIDTxt.Name = "schoolIDTxt";
            schoolIDTxt.Size = new Size(301, 30);
            schoolIDTxt.TabIndex = 11;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(161, 181, 195);
            backBtn.Location = new Point(47, 651);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 12;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.FromArgb(161, 181, 195);
            SignUpBtn.Location = new Point(968, 651);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(94, 29);
            SignUpBtn.TabIndex = 13;
            SignUpBtn.Text = "Sign Up";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(647, 483);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 14;
            label1.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 48, 64);
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(647, 511);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 30);
            textBox1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pa_reserve_daw_teh_;
            pictureBox1.Location = new Point(-56, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(842, 639);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(1107, 720);
            Controls.Add(textBox1);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}