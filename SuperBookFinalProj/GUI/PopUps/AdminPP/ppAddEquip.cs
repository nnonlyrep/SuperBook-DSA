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

    public partial class ppAddEquip : Form
    {
        private readonly EquipmentsRepository _equipmentRepository;
        public ppAddEquip()
        {
            InitializeComponent();
            _equipmentRepository = new EquipmentsRepository();
        }

        private void ppAddEquip_Load(object sender, EventArgs e)
        {

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

            // 2️⃣ Create Equipment Object
            Equipments newEquipment = new Equipments
            {
                Name = txtEquipmentName.Text.Trim(),
                Type = txtEquipmentType.Text.Trim(),
                Quantity = quantity
            };

            // 3️⃣ Save to Database
            try
            {
                int newId = await _equipmentRepository.CreateAsync(newEquipment);
                if (newId > 0)
                {
                    MessageBox.Show("Equipment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Notify parent form
                    this.Close(); // Close pop-up
                    
                }
                else
                {
                    MessageBox.Show("Failed to add equipment. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
