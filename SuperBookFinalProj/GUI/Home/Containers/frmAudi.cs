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
    public partial class frmAudi : Form
    {
        public frmAudi()
        {
            InitializeComponent();
        }

        private void frmAudi_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            frmAudi audi = new frmAudi();
        }
    }
}
