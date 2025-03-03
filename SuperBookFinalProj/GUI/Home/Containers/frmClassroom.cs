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
using SuperBookFinalProj.Models;
using SuperBookFinalProj.Repositories;

namespace SuperBookFinalProj.GUI.Home.Containers
{
    public partial class frmClassroom : Form
    {
        private readonly RoomRepository _roomRepository;
        private List<Room> _allRooms;
        public frmClassroom()
        {
            InitializeComponent();
            _roomRepository = new RoomRepository();
            _allRooms = new List<Room>();
        }

        private async void frmClassroom_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            await LoadRoomsAsync();
        }
        private async Task LoadRoomsAsync()
        {
            try
            {
                Console.WriteLine("🔄 Fetching Rooms...");
                _allRooms = await _roomRepository.GetAllAsync(); // Fetch rooms from DB

                dataGridClassRooms.DataSource = null; // Reset before binding
                dataGridClassRooms.DataSource = _allRooms;
                dataGridClassRooms.Refresh();

                Console.WriteLine($"✅ Loaded {_allRooms.Count} rooms.");

                // Hide the 'id' column
                if (dataGridClassRooms.Columns["id"] != null)
                {
                    dataGridClassRooms.Columns["id"].Visible = false;
                }

                // Hide row headers to remove empty column
                dataGridClassRooms.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rooms: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rsrvBtn_Click(object sender, EventArgs e)
        {
            if (dataGridClassRooms.SelectedRows.Count > 0)
            {
                string selectedRoomNumber = dataGridClassRooms.SelectedRows[0].Cells["room_number"].Value.ToString();

                // Open the reservation form and pass the selected room number
                ppClassroom reservationForm = new ppClassroom(selectedRoomNumber);
                reservationForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a room before proceeding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cncBtn_Click(object sender, EventArgs e)
        {
   

        }
    }
}
