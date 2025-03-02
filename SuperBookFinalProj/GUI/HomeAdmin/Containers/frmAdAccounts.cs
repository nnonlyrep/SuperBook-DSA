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
    public partial class frmAdAccounts : Form
    {
        private List<Consumer> _allConsumers;
        public frmAdAccounts()
        {
            InitializeComponent();
            _allConsumers = new List<Consumer>();
            LoadConsumers();
        }

        private void ClassroomLbl_Click(object sender, EventArgs e)
        {

        }

        private void dataGridAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private async void LoadConsumers()
        {
            try
            {
                ConsumerRepository repo = new ConsumerRepository();
                _allConsumers = await repo.GetAllAsync(); // Store full data

                FilterConsumers(txtSearchAcc.Text); // Apply filtering

                // Hide the 'id' column
                if (dataGridAcc.Columns["id"] != null)
                {
                    dataGridAcc.Columns["id"].Visible = false;
                }

                // Hide the empty row header column
                dataGridAcc.RowHeadersVisible = false;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void FilterConsumers(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                dataGridAcc.DataSource = _allConsumers;
            }
            else
            {
                var filteredList = _allConsumers
                    .Where(consumer => consumer.user_name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                       consumer.email_add.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                       consumer.full_name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

                dataGridAcc.DataSource = filteredList;
            }

            dataGridAcc.Refresh();
        }

        private async void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dataGridAcc.SelectedRows.Count == 0)
            {
                MessageBox.Show("❌ Please select an account to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve selected user's ID
            int selectedUserId = Convert.ToInt32(dataGridAcc.SelectedRows[0].Cells["id"].Value);
            string selectedUserName = dataGridAcc.SelectedRows[0].Cells["user_name"].Value.ToString();

            // Confirm deletion
            var confirmDelete = MessageBox.Show($"Are you sure you want to delete '{selectedUserName}'?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmDelete == DialogResult.Yes)
            {
                try
                {
                    ConsumerRepository repo = new ConsumerRepository();
                    bool isDeleted = await repo.DeleteAsync(selectedUserId);

                    if (isDeleted)
                    {
                        MessageBox.Show($"✅ User '{selectedUserName}' deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadConsumers(); // Refresh the table after deletion
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"❌ Error: {ex.Message}", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearchEq_TextChanged(object sender, EventArgs e)
        {
            FilterConsumers(txtSearchAcc.Text);
        }
    }
}
