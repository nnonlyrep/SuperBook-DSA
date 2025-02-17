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
    public partial class frmClassroom : Form
    {
        public frmClassroom()
        {
            InitializeComponent();
        }

        private void frmClassroom_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void rsrvBtn_Click(object sender, EventArgs e)
        {
            ppClassroom classroom = new ppClassroom();
            classroom.ShowDialog();
    
        }

        private void cncBtn_Click(object sender, EventArgs e)
        {
   

        }
    }
}
