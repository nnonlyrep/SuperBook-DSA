using SuperBookFinalProj.GUI.Home;
using SuperBookFinalProj.GUI.Home.Containers;
using SuperBookFinalProj;
using SuperBookFinalProj.GUI.LogIn_SignUp;

namespace SuperBookFinalProj
{
    public partial class HomeFrm : Form
    {
        frmHome home;
        frmClassroom classroom;
        
        frmBorrow borrow;
        frmAbout about;
        public HomeFrm()
        {
            InitializeComponent();
            mdiProp();
        }
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(21, 31, 40);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (home == null)
            {
                home = new frmHome();
                home.FormClosed += Home_FormClosed;
                home.MdiParent = this;
                home.Dock = DockStyle.Fill;
                home.Show();
            }
            else
            {
                home.Activate();
            }
        }

        private void Home_FormClosed(object? sender, FormClosedEventArgs e)
        {
            home = null;
        }

        bool reserveExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (reserveExpand == false)
            {
                reserveContainer.Height += 10;
                if (reserveContainer.Height >= 117)
                {
                    reserveTransition.Stop();
                    reserveExpand = true;
                }

            }
            else
            {
                reserveContainer.Height -= 10;
                if (reserveContainer.Height <= 50)
                {
                    reserveTransition.Stop();
                    reserveExpand = false;
                }
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            reserveTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                flpSidebar.Width -= 5;
                if (flpSidebar.Width <= 42)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    pnlHome.Width = flpSidebar.Width;
                    pnlAbout.Width = flpSidebar.Width;
                    pnlLogOut.Width = flpSidebar.Width;
                    pnlBorrow.Width = flpSidebar.Width;
                    reserveContainer.Width = flpSidebar.Width;
                }
            }
            else
            {
                flpSidebar.Width += 5;
                if (flpSidebar.Width >= 236)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnlHome.Width = flpSidebar.Width;
                    pnlAbout.Width = flpSidebar.Width;
                    pnlLogOut.Width = flpSidebar.Width;
                    pnlBorrow.Width = flpSidebar.Width;
                    reserveContainer.Width = flpSidebar.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        // borrow 
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (borrow == null)
            {
                borrow = new frmBorrow();
                borrow.FormClosed += Borrow_FormClosed;
                borrow.MdiParent = this;
                borrow.Dock = DockStyle.Fill;
                borrow.Show();
            }
            else
            {
                borrow.Activate();
            }
        }

        private void Borrow_FormClosed(object? sender, FormClosedEventArgs e)
        {
            borrow = null;
        }

        private void btnClassRoom_Click(object sender, EventArgs e)
        {
            if (classroom == null)
            {
                classroom = new frmClassroom();
                classroom.FormClosed += Classroom_FormClosed;
                classroom.MdiParent = this;
                classroom.Dock = DockStyle.Fill;
                classroom.Show();
            }
            else
            {
                classroom.Activate();
            }
        }

        private void Classroom_FormClosed(object? sender, FormClosedEventArgs e)
        {
            classroom = null;
        }

      
        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (about == null)
            {
                about = new frmAbout();
                about.FormClosed += About_FormClosed;
                about.MdiParent = this;
                about.Dock = DockStyle.Fill;
                about.Show();
            }
            else
            {
                about.Activate();
            }
        }

        private void About_FormClosed(object? sender, FormClosedEventArgs e)
        {
            about = null;
        }

        private void HomeFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void reserveContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
