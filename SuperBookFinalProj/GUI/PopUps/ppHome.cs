using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperBookFinalProj.GUI.Home.Containers;

namespace SuperBookFinalProj.GUI.PopUps
{
    public partial class ppHome : Form
    {
        public ppHome()
        {
            InitializeComponent();
        }

        private void ppHome_Load(object sender, EventArgs e)
        {

        }

        private void roomBtn_Click(object sender, EventArgs e)
        {
            frmClassroom frmClassroom = new frmClassroom();
            frmClassroom.ShowDialog();
            this.Hide();

        }

        private void equipBtn_Click(object sender, EventArgs e)
        {
            frmBorrow frmBorrow = new frmBorrow();
            frmBorrow.ShowDialog();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.ShowDialog();
            this.Hide();
        }
    }
}
