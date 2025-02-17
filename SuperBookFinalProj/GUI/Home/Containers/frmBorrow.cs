using SuperBookFinalProj.GUI.PopUps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperBookFinalProj.GUI.Home.Containers
{
    public partial class frmBorrow : Form
    {
        public frmBorrow()
        {
            InitializeComponent();
        }

        private void frmBorrow_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            ppBorrow borrow = new ppBorrow();
            borrow.ShowDialog();
        }
    }
}
