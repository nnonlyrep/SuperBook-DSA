using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperBookFinalProj.Models;
using SuperBookFinalProj.Repositories;

namespace SuperBookFinalProj.GUI.HomeAdmin.Containers
{
    public partial class frmAdReserved : Form
    {
        private readonly ReservationRepository _reservationRepo;
        private List<ReservationView> _allReservations; // Store all reservations for searching

        public frmAdReserved()
        {
            InitializeComponent();
            _reservationRepo = new ReservationRepository();
        }

        private async void frmAdReserved_Load(object sender, EventArgs e)
        {
            await LoadReservationsAsync();
        }

        private async Task LoadReservationsAsync()
        {
            try
            {
                _allReservations = await _reservationRepo.GetAllReservationsWithDetailsAsync();

                if (_allReservations.Count == 0)
                {
                    MessageBox.Show("No reservations found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Bind data to DataGridView
                dgvReserved.DataSource = null;
                dgvReserved.DataSource = _allReservations;

                // Hide ID column if necessary
                if (dgvReserved.Columns["id"] != null)
                    dgvReserved.Columns["id"].Visible = false;

                // Rename headers for better readability
                dgvReserved.Columns["full_name"].HeaderText = "Reserved By";
                dgvReserved.Columns["room_number"].HeaderText = "Room Number";
                dgvReserved.Columns["date"].HeaderText = "Reservation Date";
                dgvReserved.Columns["time_slot"].HeaderText = "Time Slot";
                dgvReserved.Columns["purpose"].HeaderText = "Purpose/Program";
                dgvReserved.Columns["occupants"].HeaderText = "Number of Occupants";

                // ✅ Remove the first empty column (Row Headers)
                dgvReserved.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error loading reservations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Search Function (Filters by Name, Room Number, and Purpose)
        private void txtSearchEq_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchEq.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                dgvReserved.DataSource = _allReservations; // Reset to all reservations if search is empty
                return;
            }

            var filteredReservations = _allReservations.Where(res =>
                res.full_name.ToLower().Contains(searchText) ||
                res.room_number.ToLower().Contains(searchText) ||
                res.purpose.ToLower().Contains(searchText)
            ).ToList();

            dgvReserved.DataSource = filteredReservations;
        }

        // ✅ Cancel Reservation Function
        private async void CnclResBtn_Click(object sender, EventArgs e)
        {
            if (dgvReserved.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to cancel.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected reservation's ID
            int reservationId = Convert.ToInt32(dgvReserved.SelectedRows[0].Cells["id"].Value);
            string reservedBy = dgvReserved.SelectedRows[0].Cells["full_name"].Value.ToString();
            string roomNumber = dgvReserved.SelectedRows[0].Cells["room_number"].Value.ToString();

            DialogResult confirmCancel = MessageBox.Show(
                $"Are you sure you want to cancel this reservation?\n\n" +
                $"Reserved By: {reservedBy}\nRoom: {roomNumber}",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmCancel == DialogResult.Yes)
            {
                try
                {
                    bool isDeleted = await _reservationRepo.DeleteAsync(reservationId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Reservation successfully canceled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadReservationsAsync(); // Refresh the data
                    }
                    else
                    {
                        MessageBox.Show("Failed to cancel reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"❌ Error canceling reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
