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

namespace SuperBookFinalProj.GUI.PopUps
{
    public partial class ppClassroom : Form
    {
        private Room _room;

        public ppClassroom(Room room)
        {
            InitializeComponent();
            _room = room;
            LoadRoomDetails();
        }

        private void LoadRoomDetails()
        {
            lblRoomName.Text = _room.room_number;  // Assuming you have a label for the room name
            lblRoomCapacity.Text = _room.capacity.ToString(); // Assuming the room has a capacity property
                                                              // Set other room details accordingly
        }

        private void firstNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private async void ReserveBtn_Click(object sender, EventArgs e)
        {
            // 🔹 Ensure all fields are filled
            if (string.IsNullOrWhiteSpace(purposeTxt.Text) ||
                string.IsNullOrWhiteSpace(txtOccupants.Text) ||
                dateTimePicker.Value == null ||
                cboTime.SelectedItem == null)
            {
                MessageBox.Show("Please complete all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔹 Ensure Purpose is meaningful
            string purpose = purposeTxt.Text.Trim();
            if (purpose.Length < 3)
            {
                MessageBox.Show("Purpose/Program must be at least 3 characters long.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔹 Ensure Occupants is a valid number and within room capacity
            int occupants;
            if (!int.TryParse(txtOccupants.Text, out occupants) || occupants <= 0)
            {
                MessageBox.Show("Number of occupants must be a positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (occupants > _room.capacity)
            {
                MessageBox.Show($"The selected room has a capacity of {_room.capacity}. Reduce the number of occupants.",
                    "Capacity Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔹 Ensure a valid time slot is selected
            if (cboTime.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid time slot.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedTimeSlot = cboTime.SelectedItem.ToString();

            // 🔹 Ensure the date is not in the past
            DateTime selectedDate = dateTimePicker.Value.Date;
            DateTime today = DateTime.Now.Date;
            if (selectedDate < today)
            {
                MessageBox.Show("You cannot reserve for a past date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔹 Ensure time is still available (Check if the time slot is already past for today)
            if (selectedDate == today)
            {
                // Convert selected time slot (e.g., "10:00 AM - 12:00 PM") into a DateTime for validation
                string[] timeParts = selectedTimeSlot.Split('-');
                if (timeParts.Length == 2)
                {
                    DateTime startTime;
                    if (DateTime.TryParse(timeParts[0].Trim(), out startTime))
                    {
                        DateTime now = DateTime.Now;

                        // Compare the selected start time with the current time
                        if (startTime < now)
                        {
                            MessageBox.Show("The selected time slot has already passed. Please choose a future time.",
                                "Invalid Time Slot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }

            // 🔹 Check if a user is logged in
            if (SessionManager.LoggedInUser == null)
            {
                MessageBox.Show("You must be logged in to make a reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int consumerId = SessionManager.LoggedInUser.id;
            int roomId = _room.id;

            // 🔹 Check if this reservation already exists
            ReservationRepository reservationRepo = new ReservationRepository();
            List<ReservationView> existingReservations = await reservationRepo.GetAllReservationsWithDetailsAsync();

            bool duplicateReservation = existingReservations.Any(r =>
                r.room_number == _room.room_number &&
                r.date == selectedDate &&
                r.time_slot == selectedTimeSlot
            );

            if (duplicateReservation)
            {
                MessageBox.Show("This room is already reserved for the selected date and time.", "Reservation Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Create the reservation
            Reservation newReservation = new Reservation
            {
                consumer_id = consumerId,
                room_id = roomId,
                date = selectedDate,
                time = selectedTimeSlot,
                purpose = purpose,
                occupants = occupants
            };

            int reservationId = await reservationRepo.CreateAsync(newReservation);

            if (reservationId > 0)
            {
                MessageBox.Show("Reservation successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ Debugging to ensure data is passed correctly
                System.Diagnostics.Debug.WriteLine("📌 Passing Reservation to Receipt...");
                System.Diagnostics.Debug.WriteLine($"📌 Consumer: {SessionManager.LoggedInUser.full_name}");
                System.Diagnostics.Debug.WriteLine($"📌 Room Number: {_room.room_number}");
                System.Diagnostics.Debug.WriteLine($"📌 Room Capacity: {_room.capacity}");
                System.Diagnostics.Debug.WriteLine($"📌 Date: {newReservation.date}");
                System.Diagnostics.Debug.WriteLine($"📌 Time: {newReservation.time}");
                System.Diagnostics.Debug.WriteLine($"📌 Purpose: {newReservation.purpose}");
                System.Diagnostics.Debug.WriteLine($"📌 Occupants: {newReservation.occupants}");

                frmReceipt receipt = new frmReceipt(newReservation, SessionManager.LoggedInUser, _room);
                receipt.ShowDialog();

                this.Close(); // Close the reservation form
            }



        }






        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void purposeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ppClassroom_Load(object sender, EventArgs e)
        {
                reserveBtn.Click += ReserveBtn_Click; // Ensure the event is linked
        }

        private void reserveBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
