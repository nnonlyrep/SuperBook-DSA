using SuperBookFinalProj.GUI.PopUps;
using SuperBookFinalProj.GUI.PopUps.AdminPP;
using SuperBookFinalProj.Models;
using SuperBookFinalProj.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperBookFinalProj.GUI.HomeAdmin.Containers
{
    public partial class frmAdEquip : Form
    {
        private readonly EquipmentsRepository _equipmentRepository;
        private List<Equipments> _allEquipments;
        private List<Equipments> _filteredEquipments; // Store filtered results

        public frmAdEquip()
        {
            InitializeComponent();
            _equipmentRepository = new EquipmentsRepository();
            _allEquipments = new List<Equipments>();
            _filteredEquipments = new List<Equipments>();
            LoadEquipmentsAsync();
        }

        private async Task LoadEquipmentsAsync()
        {
            try
            {
                Console.WriteLine("🔄 Fetching Equipment...");
                _allEquipments = await _equipmentRepository.GetAllAsync();
                _filteredEquipments = new List<Equipments>(_allEquipments); // Copy for filtering

                BindDataToGrid();

                Console.WriteLine($"✅ Loaded {_allEquipments.Count} equipments.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading equipment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindDataToGrid()
        {
            dataGridEquipments.DataSource = null; // Reset before binding
            dataGridEquipments.DataSource = _filteredEquipments;
            dataGridEquipments.Refresh();

            // Hide the 'Id' column
            if (dataGridEquipments.Columns["Id"] != null)
            {
                dataGridEquipments.Columns["Id"].Visible = false;
            }

            // Hide row headers to remove empty column
            dataGridEquipments.RowHeadersVisible = false;
        }

        // ✅ Fixed Search Function (Filters by Equipment Name and Type)
        private void txtSearchEq_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchEq.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _filteredEquipments = new List<Equipments>(_allEquipments); // Reset to original list
            }
            else
            {
                _filteredEquipments = _allEquipments
                    .Where(eq => eq.Name.ToLower().Contains(searchText) ||
                                 eq.Type.ToLower().Contains(searchText)) // Include Type in search
                    .ToList();
            }

            BindDataToGrid();
        }

        private async Task btnDeleteEq_ClickAsync(object sender, EventArgs e)
        {
            if (dataGridEquipments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an equipment to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Equipments selectedEquipment = dataGridEquipments.SelectedRows[0].DataBoundItem as Equipments;

            if (selectedEquipment == null)
            {
                MessageBox.Show("Error: Unable to retrieve selected equipment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete '{selectedEquipment.Name}'?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
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
    }
}
