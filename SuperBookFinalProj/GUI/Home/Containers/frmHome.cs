using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperBookFinalProj.GUI.PopUps;

namespace SuperBookFinalProj.GUI.Home.Containers
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void bigLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bigLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void bigLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bigLabel6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ppHome ppHome = new ppHome();
            ppHome.ShowDialog();

        }
    }
}
