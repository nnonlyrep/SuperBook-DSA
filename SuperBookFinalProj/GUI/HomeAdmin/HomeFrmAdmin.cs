using SuperBookFinalProj.GUI.Home;
using SuperBookFinalProj.GUI.Home.Containers;
using SuperBookFinalProj;
using SuperBookFinalProj.GUI.LogIn_SignUp;
using SuperBookFinalProj.GUI.HomeAdmin.Containers;

namespace SuperBookFinalProj
{
    public partial class HomeFrmAdmin : Form
    {
        frmAdHome home;
        frmAdReserved reserved;
        frmAdEquip equipments;
        frmAdRooms rooms;
        frmAdAudi audi;
        frmAdAccounts accounts;
        frmAbout about;
        public HomeFrmAdmin()
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
                home = new frmAdHome();
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
                if (reserveContainer.Height >= 222)
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
                    pnlEdEquipments.Width = flpSidebar.Width;
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
                    pnlEdEquipments.Width = flpSidebar.Width;
                    reserveContainer.Width = flpSidebar.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        // equipments
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (equipments == null)
            {
                equipments = new frmAdEquip();
                equipments.FormClosed += Equipments_FormClosed;
                equipments.MdiParent = this;
                equipments.Dock = DockStyle.Fill;
                equipments.Show();
            }
            else
            {
                equipments.Activate();
            }
        }

        private void Equipments_FormClosed(object? sender, FormClosedEventArgs e)
        {
            equipments = null;
        }

        private void btnClassRoom_Click(object sender, EventArgs e)
        {
          
        }
        private void btnAudi_Click(object sender, EventArgs e)
        {
            if (reserved == null)
            {
                reserved = new frmAdReserved();
                reserved.FormClosed += Reserved_FormClosed;
                reserved.MdiParent = this;
                reserved.Dock = DockStyle.Fill;
                reserved.Show();
            }
            else
            {
                reserved.Activate();
            }
        }

        private void Reserved_FormClosed(object? sender, FormClosedEventArgs e)
        {
            reserved = null;
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

        private void HomeFrmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void btnEdRoom_Click(object sender, EventArgs e)
        {
            if (rooms == null)
            {
                rooms = new frmAdRooms();
                rooms.FormClosed += Rooms_FormClosed;
                rooms.MdiParent = this;
                rooms.Dock = DockStyle.Fill;
                rooms.Show();
            }
            else
            {
                about.Activate();
            }
        }

        private void Rooms_FormClosed(object? sender, FormClosedEventArgs e)
        {
            rooms = null;
        }

        private void btnEdAudi_Click(object sender, EventArgs e)
        {
            if (audi == null)
            {
                audi = new frmAdAudi();
                audi.FormClosed += Audi_FormClosed;
                audi.MdiParent = this;
                audi.Dock = DockStyle.Fill;
                audi.Show();
            }
            else
            {
                audi.Activate();
            }
        }

        private void Audi_FormClosed(object? sender, FormClosedEventArgs e)
        {
            audi = null;
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            if (accounts == null)
            {
                accounts = new frmAdAccounts();
                accounts.FormClosed += Accounts_FormClosed;
                accounts.MdiParent = this;
                accounts.Dock = DockStyle.Fill;
                accounts.Show();
            }
            else
            {
                accounts.Activate();
            }
        }

        private void Accounts_FormClosed(object? sender, FormClosedEventArgs e)
        {
            accounts = null;
        }
    }
}
