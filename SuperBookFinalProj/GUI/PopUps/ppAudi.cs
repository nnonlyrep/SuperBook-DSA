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
    public partial class ppAudi : Form
    {
        public ppAudi()
        {
            InitializeComponent();
        }

        private void firstNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CncBtn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResBtn_Click(object sender, EventArgs e)
        {
            ppAudi Audi = new ppAudi();
            Audi.ShowDialog();
            this.Close();
        }
    }
}
