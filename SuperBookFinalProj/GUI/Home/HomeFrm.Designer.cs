namespace SuperBookFinalProj
{
    partial class HomeFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            lblTitle = new Label();
            btnHam = new PictureBox();
            flpSidebar = new FlowLayoutPanel();
            pnlHome = new Panel();
            btnHome = new Button();
            reserveContainer = new FlowLayoutPanel();
            pnlReserve = new Panel();
            btnReserve = new Button();
            panel2 = new Panel();
            btnClassRoom = new Button();
            panel3 = new Panel();
            btnAudi = new Button();
            pnlBorrow = new Panel();
            btnBorrow = new Button();
            pnlAbout = new Panel();
            btnAbout = new Button();
            pnlLogOut = new Panel();
            btnLogOut = new Button();
            reserveTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            flpSidebar.SuspendLayout();
            pnlHome.SuspendLayout();
            reserveContainer.SuspendLayout();
            pnlReserve.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            pnlBorrow.SuspendLayout();
            pnlAbout.SuspendLayout();
            pnlLogOut.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 48, 64);
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnHam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(969, 34);
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
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Work Sans Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(50, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(83, 17);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "SUPERBOOK";
            // 
            // btnHam
            // 
            btnHam.Image = Properties.Resources.icons8_menu_24;
            btnHam.Location = new Point(3, 3);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(30, 28);
            btnHam.SizeMode = PictureBoxSizeMode.CenterImage;
            btnHam.TabIndex = 0;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
            // 
            // flpSidebar
            // 
            flpSidebar.BackColor = Color.FromArgb(30, 48, 64);
            flpSidebar.Controls.Add(pnlHome);
            flpSidebar.Controls.Add(reserveContainer);
            flpSidebar.Controls.Add(pnlBorrow);
            flpSidebar.Controls.Add(pnlAbout);
            flpSidebar.Controls.Add(pnlLogOut);
            flpSidebar.Dock = DockStyle.Left;
            flpSidebar.FlowDirection = FlowDirection.TopDown;
            flpSidebar.Location = new Point(0, 34);
            flpSidebar.Margin = new Padding(0);
            flpSidebar.Name = "flpSidebar";
            flpSidebar.Size = new Size(236, 506);
            flpSidebar.TabIndex = 1;
            // 
            // pnlHome
            // 
            pnlHome.Controls.Add(btnHome);
            pnlHome.Location = new Point(3, 3);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(236, 50);
            pnlHome.TabIndex = 3;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(30, 48, 64);
            btnHome.Font = new Font("Work Sans Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.ButtonFace;
            btnHome.Image = Properties.Resources.icons8_home_24;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(-7, -19);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 0, 0);
            btnHome.Size = new Size(266, 88);
            btnHome.TabIndex = 2;
            btnHome.Text = "            Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += button1_Click;
            // 
            // reserveContainer
            // 
            reserveContainer.BackColor = Color.FromArgb(30, 48, 64);
            reserveContainer.Controls.Add(pnlReserve);
            reserveContainer.Controls.Add(panel2);
            reserveContainer.Controls.Add(panel3);
            reserveContainer.Location = new Point(0, 56);
            reserveContainer.Margin = new Padding(0);
            reserveContainer.Name = "reserveContainer";
            reserveContainer.Size = new Size(236, 50);
            reserveContainer.TabIndex = 3;
            // 
            // pnlReserve
            // 
            pnlReserve.Controls.Add(btnReserve);
            pnlReserve.Location = new Point(3, 3);
            pnlReserve.Name = "pnlReserve";
            pnlReserve.Size = new Size(236, 50);
            pnlReserve.TabIndex = 4;
            // 
            // btnReserve
            // 
            btnReserve.BackColor = Color.FromArgb(30, 48, 64);
            btnReserve.Font = new Font("Work Sans Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReserve.ForeColor = SystemColors.ButtonFace;
            btnReserve.Image = Properties.Resources.icons8_reservation_24;
            btnReserve.ImageAlign = ContentAlignment.MiddleLeft;
            btnReserve.Location = new Point(-7, -19);
            btnReserve.Margin = new Padding(0);
            btnReserve.Name = "btnReserve";
            btnReserve.Padding = new Padding(10, 0, 0, 0);
            btnReserve.Size = new Size(266, 88);
            btnReserve.TabIndex = 2;
            btnReserve.Text = "            Reserve";
            btnReserve.TextAlign = ContentAlignment.MiddleLeft;
            btnReserve.UseVisualStyleBackColor = false;
            btnReserve.Click += btnReserve_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClassRoom);
            panel2.Location = new Point(3, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 50);
            panel2.TabIndex = 5;
            // 
            // btnClassRoom
            // 
            btnClassRoom.BackColor = Color.FromArgb(30, 48, 64);
            btnClassRoom.Font = new Font("Work Sans Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClassRoom.ForeColor = SystemColors.ButtonFace;
            btnClassRoom.Image = Properties.Resources.icons8_classroom_24;
            btnClassRoom.ImageAlign = ContentAlignment.MiddleLeft;
            btnClassRoom.Location = new Point(-7, -19);
            btnClassRoom.Margin = new Padding(0);
            btnClassRoom.Name = "btnClassRoom";
            btnClassRoom.Padding = new Padding(10, 0, 0, 0);
            btnClassRoom.Size = new Size(266, 88);
            btnClassRoom.TabIndex = 2;
            btnClassRoom.Text = "            Class Room";
            btnClassRoom.TextAlign = ContentAlignment.MiddleLeft;
            btnClassRoom.UseVisualStyleBackColor = false;
            btnClassRoom.Click += btnClassRoom_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAudi);
            panel3.Location = new Point(3, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 50);
            panel3.TabIndex = 6;
            // 
            // btnAudi
            // 
            btnAudi.BackColor = Color.FromArgb(30, 48, 64);
            btnAudi.Font = new Font("Work Sans Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAudi.ForeColor = SystemColors.ButtonFace;
            btnAudi.Image = Properties.Resources.icons8_auditorium_24;
            btnAudi.ImageAlign = ContentAlignment.MiddleLeft;
            btnAudi.Location = new Point(-7, -19);
            btnAudi.Margin = new Padding(0);
            btnAudi.Name = "btnAudi";
            btnAudi.Padding = new Padding(10, 0, 0, 0);
            btnAudi.Size = new Size(266, 88);
            btnAudi.TabIndex = 2;
            btnAudi.Text = "            Auditorium";
            btnAudi.TextAlign = ContentAlignment.MiddleLeft;
            btnAudi.UseVisualStyleBackColor = false;
            btnAudi.Click += btnAudi_Click;
            // 
            // pnlBorrow
            // 
            pnlBorrow.Controls.Add(btnBorrow);
            pnlBorrow.Location = new Point(3, 109);
            pnlBorrow.Name = "pnlBorrow";
            pnlBorrow.Size = new Size(236, 50);
            pnlBorrow.TabIndex = 6;
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = Color.FromArgb(30, 48, 64);
            btnBorrow.Font = new Font("Work Sans Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrow.ForeColor = SystemColors.ButtonFace;
            btnBorrow.Image = Properties.Resources.icons8_equipment_24__1_;
            btnBorrow.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrow.Location = new Point(-7, -19);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Padding = new Padding(10, 0, 0, 0);
            btnBorrow.Size = new Size(266, 88);
            btnBorrow.TabIndex = 2;
            btnBorrow.Text = "            Borrow Equipments";
            btnBorrow.TextAlign = ContentAlignment.MiddleLeft;
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += button1_Click_1;
            // 
            // pnlAbout
            // 
            pnlAbout.Controls.Add(btnAbout);
            pnlAbout.Location = new Point(3, 165);
            pnlAbout.Name = "pnlAbout";
            pnlAbout.Size = new Size(236, 50);
            pnlAbout.TabIndex = 4;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.FromArgb(30, 48, 64);
            btnAbout.Font = new Font("Work Sans Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbout.ForeColor = SystemColors.ButtonFace;
            btnAbout.Image = Properties.Resources.icons8_about_24;
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(-7, -19);
            btnAbout.Name = "btnAbout";
            btnAbout.Padding = new Padding(10, 0, 0, 0);
            btnAbout.Size = new Size(266, 88);
            btnAbout.TabIndex = 2;
            btnAbout.Text = "            About";
            btnAbout.TextAlign = ContentAlignment.MiddleLeft;
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // pnlLogOut
            // 
            pnlLogOut.Controls.Add(btnLogOut);
            pnlLogOut.Location = new Point(3, 221);
            pnlLogOut.Name = "pnlLogOut";
            pnlLogOut.Size = new Size(236, 50);
            pnlLogOut.TabIndex = 5;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(30, 48, 64);
            btnLogOut.Font = new Font("Work Sans Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = SystemColors.ButtonFace;
            btnLogOut.Image = Properties.Resources.icons8_logout_241;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(-7, -19);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(10, 0, 0, 0);
            btnLogOut.Size = new Size(266, 88);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "            Logout";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // reserveTransition
            // 
            reserveTransition.Interval = 10;
            reserveTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // HomeFrm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(969, 540);
            Controls.Add(flpSidebar);
            Controls.Add(panel1);
            Font = new Font("Work Sans", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "HomeFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += HomeFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            flpSidebar.ResumeLayout(false);
            pnlHome.ResumeLayout(false);
            reserveContainer.ResumeLayout(false);
            pnlReserve.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pnlBorrow.ResumeLayout(false);
            pnlAbout.ResumeLayout(false);
            pnlLogOut.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHam;
        private Label lblTitle;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel flpSidebar;
        private Button btnHome;
        private Panel pnlHome;
        private Panel pnlAbout;
        private Button btnAbout;
        private Panel pnlLogOut;
        private Button btnLogOut;
        private FlowLayoutPanel reserveContainer;
        private Panel pnlReserve;
        private Button btnReserve;
        private Panel panel2;
        private Button btnClassRoom;
        private Panel panel3;
        private Button btnAudi;
        private Panel pnlBorrow;
        private Button btnBorrow;
        private System.Windows.Forms.Timer reserveTransition;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}
