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
        private List<Room> _allRooms;
        public frmAdRooms()
        {
            InitializeComponent();
            _roomRepository = new RoomRepository();
            _allRooms = new List<Room>();
            LoadRoomsAsync();
        }
        // Load rooms into DataGridView
        private async Task LoadRoomsAsync()
        {
            try
            {
                Console.WriteLine("🔄 Refreshing DataGridView...");
                _allRooms = await _roomRepository.GetAllAsync(); // Store full data

                FilterRooms(txtSearchRoom.Text); // Apply filtering

                Console.WriteLine($"✅ Data loaded. Total rooms: {_allRooms.Count}");

                // Hide the 'id' column if it exists
                if (dataGridRooms.Columns["id"] != null)
                {
                    dataGridRooms.Columns["id"].Visible = false;
                }

                // Hide the empty row header column
                dataGridRooms.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rooms: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FilterRooms(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                dataGridRooms.DataSource = _allRooms;
            }
            else
            {
                var filteredList = _allRooms
                    .Where(room => room.room_number.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                   room.room_type.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0) // Include Room Type in search
                    .ToList();

                dataGridRooms.DataSource = filteredList;
            }

            dataGridRooms.Refresh();
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

        private void txtSearchRoom_TextChanged(object sender, EventArgs e)
        {
            FilterRooms(txtSearchRoom.Text);
        }

        private async void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dataGridRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Room selectedRoom = (Room)dataGridRooms.SelectedRows[0].DataBoundItem;

            var confirmResult = MessageBox.Show(
                $"Are you sure you want to delete room {selectedRoom.room_number}? All associated reservations will also be deleted.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    bool deleted = await _roomRepository.DeleteAsync(selectedRoom.id);

                    if (deleted)
                    {
                        MessageBox.Show("Room and associated reservations deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadRoomsAsync(); // Refresh DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}

