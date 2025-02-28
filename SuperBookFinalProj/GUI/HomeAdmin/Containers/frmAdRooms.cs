using SuperBookFinalProj.GUI.PopUps.AdminPP;
using SuperBookFinalProj.Models;
using SuperBookFinalProj.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperBookFinalProj.GUI.HomeAdmin.Containers
{
    public partial class frmAdRooms : Form
    {
        private readonly RoomRepository _roomRepository;
        public frmAdRooms()
        {
            InitializeComponent();
            _roomRepository = new RoomRepository();
            LoadRoomsAsync();
        }
        // Load rooms into DataGridView
        private async Task LoadRoomsAsync()
        {
            try
            {
                Console.WriteLine("🔄 Refreshing DataGridView...");
                List<Room> rooms = await _roomRepository.GetAllAsync();

                dataGridRooms.DataSource = null; // 🔥 Reset first
                dataGridRooms.DataSource = rooms; // ✅ Load new data
                dataGridRooms.Refresh(); // ✅ Force UI update

                Console.WriteLine($"✅ Data loaded. Total rooms: {rooms.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rooms: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnAddRoom_Click(object sender, EventArgs e)
        {
            using (ppAddRoom addRoomForm = new ppAddRoom())
            {
                addRoomForm.ShowDialog();
                await LoadRoomsAsync(); // Refresh data after adding a room
            }
        }

        private void dataGridRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnEditRoom_Click(object sender, EventArgs e)
        {
            if (dataGridRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Room selectedRoom = (Room)dataGridRooms.SelectedRows[0].DataBoundItem;

            using (ppEditRoom editRoomForm = new ppEditRoom(selectedRoom))
            {
                editRoomForm.RoomUpdated += async () =>
                {
                    Console.WriteLine("🔄 RoomUpdated event triggered. Refreshing DataGridView...");
                    await LoadRoomsAsync();
                };

                editRoomForm.ShowDialog();
            }
        }


        private void frmAdRooms_Load(object sender, EventArgs e)
        {

        }
    }
}
