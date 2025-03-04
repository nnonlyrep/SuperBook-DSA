using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SuperBookFinalProj.Models;
using SuperBookFinalProj.Repositories;

namespace SuperBookFinalProj.GUI.PopUps
{
    public partial class ppBorrow : Form
    {
        public event Action OnBorrowSuccess;
        private Borrow _borrowDetails;
        private int _availableQuantity;  // Store available quantity
        private readonly EquipmentsRepository _equipmentRepo; // Repository for updating quantity

        public ppBorrow(int consumerId, string consumerName, int equipmentId, string equipmentName, int quantity)
        {
            InitializeComponent();
            _availableQuantity = quantity; // Store available quantity for validation
            _equipmentRepo = new EquipmentsRepository(); // Initialize repository

            _borrowDetails = new Borrow
            {
                ConsumerId = consumerId,
                EquipmentId = equipmentId,
                EquipmentName = equipmentName,
                BorrowDate = DateTime.Now,
                time = "", // Default empty, user must select
                Purpose = "",
                Quantity = 0, // Set later after validation
                Status = "Borrowed"
            };

            lblEquipment.Text = $"Equipment: {equipmentName}";
            lblQuantity.Text = $"Available: {quantity}";
        }

        private async void btnBorrow_Click(object sender, EventArgs e)
        {
            // ✅ Validate Purpose
            string purpose = txtPurpose.Text.Trim();
            if (string.IsNullOrWhiteSpace(purpose) || purpose.Length < 3)
            {
                MessageBox.Show("Purpose must be at least 3 characters long.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Validate Quantity
            if (!int.TryParse(txtQuantity.Text, out int requestedQuantity) || requestedQuantity <= 0)
            {
                MessageBox.Show("Quantity must be a positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (requestedQuantity > _availableQuantity)
            {
                MessageBox.Show($"Not enough stock available. Maximum available: {_availableQuantity}", "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Validate Date and Time
            DateTime selectedDate = dtBox.Value.Date;
            if (selectedDate < DateTime.Now.Date)
            {
                MessageBox.Show("Borrow date must be today or in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboTime.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid time slot.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedTimeSlot = cboTime.SelectedItem.ToString();

            // ✅ Ensure User is Logged In
            if (SessionManager.LoggedInUser == null)
            {
                MessageBox.Show("You must be logged in to borrow equipment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int consumerId = SessionManager.LoggedInUser.id;

            // ✅ Check for Duplicate Borrow Requests
            BorrowRepository borrowRepo = new BorrowRepository();
            List<Borrow> existingBorrows = await borrowRepo.GetAllAsync();

            bool duplicateBorrow = existingBorrows.Any(b =>
                b.ConsumerId == consumerId &&
                b.EquipmentId == _borrowDetails.EquipmentId &&
                b.Status == "Borrowed");

            if (duplicateBorrow)
            {
                MessageBox.Show("You already have this equipment borrowed. Please return it before borrowing again.",
                                "Duplicate Borrow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Store Valid Borrow Details
            _borrowDetails.Purpose = purpose;
            _borrowDetails.Quantity = requestedQuantity;
            _borrowDetails.BorrowDate = selectedDate;
            _borrowDetails.time = selectedTimeSlot;

            // ✅ Subtract borrowed quantity from stock
            int newQuantity = _availableQuantity - requestedQuantity;

            try
            {
                await borrowRepo.CreateAsync(_borrowDetails);
                await _equipmentRepo.UpdateQuantityAsync(_borrowDetails.EquipmentId, newQuantity);

                MessageBox.Show("Equipment successfully borrowed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ Notify `frmBorrow.cs` to refresh DataGridView
                OnBorrowSuccess?.Invoke();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error borrowing equipment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ppBorrow_Load(object sender, EventArgs e)
        {
            btnBorrow.Click += btnBorrow_Click;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBorrow_Click_1(object sender, EventArgs e)
        {

        }

    }
}
