using System;
using System.Collections.Generic;
using System.Linq;
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
        private List<Room> _filteredRooms; // Store filtered results

        public frmClassroom()
        {
            InitializeComponent();
            _roomRepository = new RoomRepository();
            _allRooms = new List<Room>();
            _filteredRooms = new List<Room>();
        }

        private async void frmClassroom_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            await LoadRoomsAsync(); // Load rooms when form loads
        }

        private async Task LoadRoomsAsync()
        {
            try
            {
                Console.WriteLine("🔄 Fetching Rooms...");
                _allRooms = await _roomRepository.GetAllAsync(); // Fetch rooms from DB
                _filteredRooms = new List<Room>(_allRooms); // Copy for filtering

                BindDataToGrid();

                Console.WriteLine($"✅ Loaded {_allRooms.Count} rooms.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rooms: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindDataToGrid()
        {
            dataGridClassRooms.DataSource = null; // Reset before binding
            dataGridClassRooms.DataSource = _filteredRooms;
            dataGridClassRooms.Refresh();

            // Hide the 'id' column
            if (dataGridClassRooms.Columns["Id"] != null)
            {
                dataGridClassRooms.Columns["Id"].Visible = false;
            }

            // Hide row headers to remove empty column
            dataGridClassRooms.RowHeadersVisible = false;
        }

        private void rsrvBtn_Click(object sender, EventArgs e)
        {
            if (dataGridClassRooms.SelectedRows.Count > 0) // Ensure a room is selected
            {
                // Retrieve the selected room object
                Room selectedRoom = dataGridClassRooms.SelectedRows[0].DataBoundItem as Room;

                if (selectedRoom != null)
                {
                    // Pass room details to ppClassroom
                    ppClassroom classroom = new ppClassroom(selectedRoom);
                    classroom.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid selection. Please select a valid room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a room before proceeding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ✅ Search Function (Filters room list dynamically)
        private void txtSearchRoom_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchRoom.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _filteredRooms = new List<Room>(_allRooms); // Reset to original list
            }
            else
            {
                _filteredRooms = _allRooms
                    .Where(room => room.room_number.ToLower().Contains(searchText) ||
                                   room.room_type.ToLower().Contains(searchText)) // Include Type in search
                    .ToList();
            }

            BindDataToGrid();
        }

        private void cncButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
