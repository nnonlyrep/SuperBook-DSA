using SuperBookFinalProj.GUI.LogIn_SignUp;
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

        }

        private void CncBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ResBtn_Click(object sender, EventArgs e)
        {
    
            ppAudi audi = new ppAudi();
            audi.ShowDialog();
           
        }
    }
}
