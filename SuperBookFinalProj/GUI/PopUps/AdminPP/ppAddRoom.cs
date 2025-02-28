using System;
using System.Windows.Forms;
using SuperBookFinalProj.Models;
using SuperBookFinalProj.Repositories;

namespace SuperBookFinalProj.GUI.PopUps.AdminPP
{
    public partial class ppAddRoom : Form
    {
        private readonly RoomRepository _roomRepository;

        public ppAddRoom()
        {
            InitializeComponent();
            _roomRepository = new RoomRepository(); // Initialize the repository
            btnAdd.Click += BtnAdd_Click; // Attach event to button
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
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

                Room newRoom = new Room
                {
                    room_number = textBox1.Text,
                    room_type = txtRoomType.Text,
                    capacity = capacity,
                    location = txtLoc.Text
                };

                int roomId = await _roomRepository.CreateAsync(newRoom);

                if (roomId > 0)
                {
                    MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the form after adding the room
                }
                else
                {
                    MessageBox.Show("Failed to add room!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
