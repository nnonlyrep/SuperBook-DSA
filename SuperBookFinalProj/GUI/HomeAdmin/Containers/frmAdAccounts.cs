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
        public frmAdAccounts()
        {
            InitializeComponent();
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
                List<Consumer> consumers = await repo.GetAllAsync();

                // ✅ Bind the list to the DataGridView
                dataGridAcc.DataSource = consumers;
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

    }
}
