using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Supabase.Postgrest.Exceptions;
using SuperBookFinalProj.Models;
using SuperBookFinalProj.Repositories; // Import the repository

namespace SuperBookFinalProj.GUI.PopUps
{
    public partial class ppClassroom : Form
    {
       

        public ppClassroom(string roomNumber)
        {
            InitializeComponent();
        }

        private async void reserveBtn_Click(object sender, EventArgs e)
        {
           

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ppClassroom_Load(object sender, EventArgs e)
        {
        }
    }
}
