using System;
using System.Windows.Forms;
using SuperBookFinalProj.Models;

namespace SuperBookFinalProj.GUI.PopUps
{
    public partial class frmReceipt : Form
    {
        private readonly Reservation _reservation;
        private readonly Consumer _consumer;
        private readonly Room _room;

        public frmReceipt(Reservation reservation, Consumer consumer, Room room)
        {
            InitializeComponent();

            _reservation = reservation;
            _consumer = consumer;
            _room = room;


        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("📌 frmReceipt_Load: Updating UI labels...");

            // 🔹 Confirm Labels Exist
            if (lblConsumerName == null || lblRoomNumber == null || lblRoomCapacity == null ||
                lblDate == null || lblTime == null || lblPurpose == null || lblOccupants == null)
            {
                System.Diagnostics.Debug.WriteLine("❌ Error: Some labels are NULL!");
                return;
            }

            // 🔹 Set Label Texts
            lblConsumerName.Text = $"Consumer: {_consumer?.full_name ?? "[Data Not Found]"}";
            lblRoomNumber.Text = $"Room: {_room?.room_number ?? "[Data Not Found]"}";
            lblRoomCapacity.Text = $"Capacity: {_room?.capacity.ToString() ?? "[Data Not Found]"}";
            lblDate.Text = $"Date: {_reservation?.date.ToString("dd/MM/yyyy") ?? "[Data Not Found]"}";
            lblTime.Text = $"Time: {_reservation?.time ?? "[Data Not Found]"}";
            lblPurpose.Text = $"Purpose: {_reservation?.purpose ?? "[Data Not Found]"}";
            lblOccupants.Text = $"Occupants: {_reservation?.occupants.ToString() ?? "[Data Not Found]"}";

            // 🔹 Debug: Print UI Changes
            System.Diagnostics.Debug.WriteLine($"✅ UI Labels Updated:");
            System.Diagnostics.Debug.WriteLine(lblConsumerName.Text);
            System.Diagnostics.Debug.WriteLine(lblRoomNumber.Text);
            System.Diagnostics.Debug.WriteLine(lblRoomCapacity.Text);
            System.Diagnostics.Debug.WriteLine(lblDate.Text);
            System.Diagnostics.Debug.WriteLine(lblTime.Text);
            System.Diagnostics.Debug.WriteLine(lblPurpose.Text);
            System.Diagnostics.Debug.WriteLine(lblOccupants.Text);

            // 🔹 Force UI Refresh
            this.Refresh();
            lblConsumerName.Invalidate();
            lblRoomNumber.Invalidate();
            lblRoomCapacity.Invalidate();
            lblDate.Invalidate();
            lblTime.Invalidate();
            lblPurpose.Invalidate();
            lblOccupants.Invalidate();
        }











        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReceipt_Load_1(object sender, EventArgs e)
        {

        }

        private void lblRoomCapacity_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}
