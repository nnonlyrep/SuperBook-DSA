using SuperBookFinalProj.Models;
using SuperBookFinalProj.Repositories;
using System;
using System.Windows.Forms;

namespace SuperBookFinalProj.GUI.PopUps
{
    public partial class ppEditEquip : Form
    {
        private readonly EquipmentsRepository _equipmentRepository;
        private readonly Equipments _existingEquipment; // Store selected equipment

        public ppEditEquip(Equipments selectedEquipment)
        {
            InitializeComponent();
            _equipmentRepository = new EquipmentsRepository();

            // Ensure selectedEquipment is not null
            if (selectedEquipment == null)
            {
                MessageBox.Show("Error: No equipment selected for editing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the form to prevent further issues
                return;
            }

            _existingEquipment = selectedEquipment; // Store selected equipment

            // Pre-fill the form with existing data
            txtEquipmentName.Text = _existingEquipment.Name;
            txtEquipmentType.Text = _existingEquipment.Type;
            txtQuantity.Text = _existingEquipment.Quantity.ToString();
        }

        public Action<object, EventArgs> EquipmentUpdated { get; internal set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEquipmentName.Text) ||
                string.IsNullOrWhiteSpace(txtEquipmentType.Text) ||
                !int.TryParse(txtQuantity.Text, out int quantity) || quantity < 1)
            {
                MessageBox.Show("Please enter valid equipment details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2️⃣ Create Updated Equipment Object
            Equipments updatedEquipment = new Equipments
            {
                Id = _existingEquipment.Id, // Keep the same ID
                Name = txtEquipmentName.Text.Trim(),
                Type = txtEquipmentType.Text.Trim(),
                Quantity = quantity
            };

            // 3️⃣ Update the Equipment in Database
            try
            {
                bool isUpdated = await _equipmentRepository.UpdateAsync(updatedEquipment);

                if (isUpdated)
                {
                    MessageBox.Show("Equipment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Notify parent form
                    this.Close(); // Close pop-up
                }
                else
                {
                    MessageBox.Show("Failed to update equipment. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
