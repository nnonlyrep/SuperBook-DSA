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

        public frmAdEquip()
        {
            InitializeComponent();
            _equipmentRepository = new EquipmentsRepository();
            LoadEquipmentsAsync();
        }
        private async Task LoadEquipmentsAsync()
        {
            try
            {
                Console.WriteLine("🔄 Refreshing DataGridView...");
                List<Equipments> equipments = await _equipmentRepository.GetAllAsync();

                dataGridEquipments.DataSource = null;
                dataGridEquipments.DataSource = equipments;
                dataGridEquipments.Refresh();

                Console.WriteLine($"✅ Data loaded. Total equipment: {equipments.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading equipment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnEditEq_Click(object sender, EventArgs e)
        {
            if (dataGridEquipments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select equipment to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Equipments selectedEquipment = (Equipments)dataGridEquipments.SelectedRows[0].DataBoundItem;

            using (ppEditEquip editEquipForm = new ppEditEquip(selectedEquipment))
            {
                // Unsubscribe to avoid multiple event bindings
                editEquipForm.EquipmentUpdated -= OnEquipmentUpdated;
                editEquipForm.EquipmentUpdated += OnEquipmentUpdated;

                editEquipForm.ShowDialog();
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

        private void btnAddEq_Click(object sender, EventArgs e)
        {

        }
    }
}
