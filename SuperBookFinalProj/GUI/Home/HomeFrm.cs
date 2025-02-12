namespace SuperBookFinalProj
{
    public partial class HomeFrm : Form
    {
        public HomeFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        bool reserveExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (reserveExpand == false)
            {
                reserveContainer.Height += 10;
                if (reserveContainer.Height >= 166)
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
    }
}
