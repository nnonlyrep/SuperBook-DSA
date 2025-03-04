using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperBookFinalProj.Models;
using SuperBookFinalProj.Repositories;

namespace SuperBookFinalProj.GUI.HomeAdmin.Containers
{
    public partial class frmAdBorrowed : Form
    {
        private readonly BorrowRepository _borrowRepo;
        private readonly ConsumerRepository _consumerRepo;
        private List<BorrowView> _allBorrows;
        private List<BorrowView> _filteredBorrows; // Store filtered results

        public frmAdBorrowed()
        {
            InitializeComponent();
            _borrowRepo = new BorrowRepository();
            _consumerRepo = new ConsumerRepository();
        }

        private async void frmAdBorrowed_Load(object sender, EventArgs e)
        {
            await LoadBorrowedData();
            btnCancel.Click += btnCancelBorrow_Click;
        }

        private async Task LoadBorrowedData()
        {
            try
            {
                Console.WriteLine("🔄 Fetching Borrowed Records...");
                var borrows = await _borrowRepo.GetAllAsync();
                var consumers = await _consumerRepo.GetAllAsync();

                if (borrows.Count == 0)
                {
                    MessageBox.Show("No borrowed items found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                _allBorrows = borrows.Select(borrow => new BorrowView
                {
                    Id = borrow.Id,
                    BorrowedBy = consumers.FirstOrDefault(c => c.id == borrow.ConsumerId)?.full_name ?? "Unknown",
                    EquipmentName = borrow.EquipmentName,
                    EquipmentId = borrow.EquipmentId,
                    BorrowDate = borrow.BorrowDate,
                    TimeSlot = borrow.time,
                    Purpose = borrow.Purpose,
                    Quantity = borrow.Quantity
                }).ToList();

                _filteredBorrows = new List<BorrowView>(_allBorrows); // Copy for filtering

                BindDataToGrid();

                Console.WriteLine($"✅ Loaded {_allBorrows.Count} borrowed records.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error loading borrowed items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindDataToGrid()
        {
            dgvBorrowed.DataSource = null;
            dgvBorrowed.DataSource = _filteredBorrows;
            dgvBorrowed.Refresh();

            dgvBorrowed.RowHeadersVisible = false;
        }

        // ✅ Search Function (Filters by BorrowedBy, Equipment Name, and Purpose)
        private void txtSearchBor_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchBor.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _filteredBorrows = new List<BorrowView>(_allBorrows); // Reset to original list
            }
            else
            {
                _filteredBorrows = _allBorrows
                    .Where(borrow => borrow.BorrowedBy.ToLower().Contains(searchText) ||
                                     borrow.EquipmentName.ToLower().Contains(searchText) ||
                                     borrow.Purpose.ToLower().Contains(searchText))
                    .ToList();
            }

            BindDataToGrid();
        }

        private async Task RefreshBorrowedData()
        {
            Console.WriteLine("🔄 Refreshing borrowed records...");
            await LoadBorrowedData();
            BindDataToGrid();
        }

        private async void btnCancelBorrow_Click(object sender, EventArgs e)
        {
            if (dgvBorrowed.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a borrowed item to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int borrowId = Convert.ToInt32(dgvBorrowed.SelectedRows[0].Cells["Id"].Value);

            var borrowRecord = await _borrowRepo.GetByIdAsync(borrowId);
            if (borrowRecord == null)
            {
                MessageBox.Show("The borrow record no longer exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await RefreshBorrowedData();
                return;
            }

            DialogResult confirmDelete = MessageBox.Show(
                $"Are you sure you want to DELETE this borrow record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmDelete == DialogResult.Yes)
            {
                try
                {
                    bool isDeleted = await _borrowRepo.DeleteAsync(borrowId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Borrow record successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await RefreshBorrowedData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete borrow record. It may have already been removed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"❌ Error deleting borrow record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
