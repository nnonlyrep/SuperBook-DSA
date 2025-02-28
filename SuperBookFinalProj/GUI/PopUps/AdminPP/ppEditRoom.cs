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

namespace SuperBookFinalProj.GUI.PopUps.AdminPP
{
    public partial class ppEditRoom : Form
    {
        private readonly RoomRepository _roomRepository;
        private Room _room;

        public ppEditRoom(Room room)
        {
            InitializeComponent();
            _roomRepository = new RoomRepository();
            _room = room;
            if (_room.id == 0)
            {
                MessageBox.Show("Error: Room ID is missing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            LoadRoomData();
            btnEdit.Click += BtnEdit_Click;
        }

        private void LoadRoomData()
        {
            txtRoomNumber.Text = _room.room_number;
            txtRoomType.Text = _room.room_type;
            txtCapacity.Text = _room.capacity.ToString();
            txtLoc.Text = _room.location;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event Action RoomUpdated; // Event to notify the main form

        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtRoomNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtRoomType.Text) ||
                    string.IsNullOrWhiteSpace(txtCapacity.Text) ||
                    string.IsNullOrWhiteSpace(txtLoc.Text))
                {
                    MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtCapacity.Text, out int capacity))
                {
                    MessageBox.Show("Capacity must be a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Ensure the room object is updated correctly
                _room.room_number = txtRoomNumber.Text;
                _room.room_type = txtRoomType.Text;
                _room.capacity = capacity;
                _room.location = txtLoc.Text;

                // ✅ Log the request data before updating
                Console.WriteLine($"Updating Room ID: {_room.id}");
                Console.WriteLine($"Room Number: {_room.room_number}");
                Console.WriteLine($"Room Type: {_room.room_type}");
                Console.WriteLine($"Capacity: {_room.capacity}");
                Console.WriteLine($"Location: {_room.location}");

                bool success = await _roomRepository.UpdateAsync(_room);

                if (success)
                {
                    MessageBox.Show("Room updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RoomUpdated?.Invoke(); // 🔥 Notify the main form to refresh DataGridView
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update room!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ppEditRoom_Load(object sender, EventArgs e)
        {
        }
    }
}
