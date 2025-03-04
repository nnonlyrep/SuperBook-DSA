using SuperBookFinalProj.GUI.Home.Containers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void BckHomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roomBtn_Click(object sender, EventArgs e)
        {
            frmClassroom Room = new frmClassroom();
            Room.ShowDialog();
            this.Close();
        }

        private void equipBtn_Click(object sender, EventArgs e)
        {
            frmBorrow Equips = new frmBorrow(); 
            Equips.ShowDialog();
            this.Close();
        }
    }
}
