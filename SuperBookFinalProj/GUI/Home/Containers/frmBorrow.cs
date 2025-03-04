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
            ppBorrow borrow = new ppBorrow();
            borrow.ShowDialog();
        }

        private void cncButton_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.ShowDialog();
            this.Hide();
        }
    }
}
