using SuperBookFinalProj.GUI.PopUps;
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

namespace SuperBookFinalProj.GUI.Home.Containers
{
    public partial class frmBorrow : Form
    {
        private readonly EquipmentsRepository _equipmentRepository;
        private List<Equipments> _allEquipments;
        public frmBorrow()
        {
            InitializeComponent();
            _equipmentRepository = new EquipmentsRepository();
            _allEquipments = new List<Equipments>();
        }

        private async void frmBorrow_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            await LoadEquipmentsAsync(); // Load equipment when form loads
        }
        private async Task LoadEquipmentsAsync()
        {
            try
            {
                Console.WriteLine("🔄 Fetching Equipments...");
                _allEquipments = await _equipmentRepository.GetAllAsync(); // Fetch equipment from DB

                dataGridEq.DataSource = null; // Reset before binding
                dataGridEq.DataSource = _allEquipments;
                dataGridEq.Refresh();

                Console.WriteLine($"✅ Loaded {_allEquipments.Count} equipments.");

                // Hide the 'id' column
                if (dataGridEq.Columns["id"] != null)
                {
                    dataGridEq.Columns["id"].Visible = false;
                }

                // Hide row headers to remove empty column
                dataGridEq.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading equipments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            if (dataGridEq.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridEq.SelectedRows[0];

                int equipmentId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string equipmentName = selectedRow.Cells["Name"].Value.ToString();
                int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);

                // ✅ Retrieve consumer details (assuming user is logged in)
                int consumerId = SessionManager.LoggedInUser.id;
                string consumerName = SessionManager.LoggedInUser.full_name;

                // ✅ Open borrow popup and listen for `OnBorrowSuccess` event
                ppBorrow borrowPopup = new ppBorrow(consumerId, consumerName, equipmentId, equipmentName, quantity);
                borrowPopup.OnBorrowSuccess += RefreshDataGrid; // Register event
                borrowPopup.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an equipment before borrowing.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public async void RefreshDataGrid()
        {
            try
            {
                Console.WriteLine("🔄 Refreshing DataGridView...");
                _allEquipments = await _equipmentRepository.GetAllAsync(); // Fetch latest data

                dataGridEq.DataSource = null; // Reset before binding
                dataGridEq.DataSource = _allEquipments;
                dataGridEq.Refresh();

                Console.WriteLine("✅ DataGridView refreshed with updated quantities!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cncButton_Click(object sender, EventArgs e)
        {   
            this.Close();
        }

    }
}
