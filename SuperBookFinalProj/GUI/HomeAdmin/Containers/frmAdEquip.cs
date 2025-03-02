using SuperBookFinalProj.GUI.PopUps;
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
    public partial class frmAdEquip : Form
    {
        private readonly EquipmentsRepository _equipmentRepository;
        private List<Equipments> _allEquipments;
        public frmAdEquip()
        {
            InitializeComponent();
            _equipmentRepository = new EquipmentsRepository();
            _allEquipments = new List<Equipments>();
            LoadEquipmentsAsync();
        }
        private async Task LoadEquipmentsAsync()
        {
            try
            {
                Console.WriteLine("🔄 Refreshing DataGridView...");
                _allEquipments = await _equipmentRepository.GetAllAsync();

                FilterEquipments(txtSearchEq.Text); // Apply filtering if there's search input

                Console.WriteLine($"✅ Data loaded. Total equipment: {_allEquipments.Count}");
                dataGridEquipments.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading equipment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterEquipments(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                dataGridEquipments.DataSource = _allEquipments;
            }
            else
            {
                var filteredList = _allEquipments
                    .Where(eq => eq.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                 eq.Type.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0) // Include Type in search
                    .ToList();

                dataGridEquipments.DataSource = filteredList;
            }

            // Hide the 'Id' column
            if (dataGridEquipments.Columns["Id"] != null)
            {
                dataGridEquipments.Columns["Id"].Visible = false;
            }

            dataGridEquipments.Refresh();
        }


        private async Task btnDeleteRoom_ClickAsync(object sender, EventArgs e)
        {
            if (dataGridEquipments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select equipment to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Equipments selectedEquipment = (Equipments)dataGridEquipments.SelectedRows[0].DataBoundItem;
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectedEquipment.Name}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    await _equipmentRepository.DeleteAsync(selectedEquipment.Id);
                    MessageBox.Show("Equipment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadEquipmentsAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting equipment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task btnAddEq_ClickAsync(object sender, EventArgs e)
        {
            using (PopUps.ppAddEquip addEquipForm = new PopUps.ppAddEquip())
            {
                addEquipForm.ShowDialog();
                await LoadEquipmentsAsync();
            }
        }

        private async void btnEditEq_Click(object sender, EventArgs e)
        {
            if (dataGridEquipments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select equipment to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve the selected equipment from the DataGridView
            Equipments selectedEquipment = dataGridEquipments.SelectedRows[0].DataBoundItem as Equipments;

            if (selectedEquipment == null)
            {
                MessageBox.Show("Error: Unable to retrieve equipment data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pass the selectedEquipment to ppEditEquip
            using (ppEditEquip editEquipForm = new ppEditEquip(selectedEquipment))
            {
                var result = editEquipForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    await LoadEquipmentsAsync(); // Refresh DataGridView after editing
                }
            }
        }

        private async void OnEquipmentUpdated(object sender, EventArgs e)
        {
            Console.WriteLine("🛠 EquipmentUpdated event triggered. Refreshing DataGridView...");
            await LoadEquipmentsAsync();
        }
        private void frmAdEquip_Load(object sender, EventArgs e)
        {
        }

        private async void btnAddEq_Click(object sender, EventArgs e)
        {
            using (ppAddEquip addEquipForm = new ppAddEquip())
            {
                var result = addEquipForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    await LoadEquipmentsAsync();
                }
            }
        }

        private async void btnDeleteEq_Click(object sender, EventArgs e)
        {
            if (dataGridEquipments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an equipment to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve selected equipment
            Equipments selectedEquipment = dataGridEquipments.SelectedRows[0].DataBoundItem as Equipments;

            if (selectedEquipment == null)
            {
                MessageBox.Show("Error: Unable to retrieve selected equipment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show($"Are you sure you want to delete '{selectedEquipment.Name}'?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Check if the EquipmentRepository is correctly initialized
                    if (_equipmentRepository == null)
                    {
                        MessageBox.Show("Error: Equipment repository is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Call the delete function
                    bool isDeleted = await _equipmentRepository.DeleteAsync(selectedEquipment.Id);

                    if (isDeleted)
                    {
                        MessageBox.Show("Equipment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadEquipmentsAsync(); // Refresh DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete equipment from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting equipment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridEquipments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchEq_TextChanged(object sender, EventArgs e)
        {
            FilterEquipments(txtSearchEq.Text);
        }
    }

}

