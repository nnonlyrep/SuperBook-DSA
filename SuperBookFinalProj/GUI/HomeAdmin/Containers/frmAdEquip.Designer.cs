namespace SuperBookFinalProj.GUI.HomeAdmin.Containers
{
    partial class frmAdEquip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDeleteEquipment = new Button();
            btnEditEq = new Button();
            btnAddEq = new Button();
            panel1 = new Panel();
            dataGridEquipments = new DataGridView();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEquipments).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteEquipment
            // 
            btnDeleteEquipment.BackColor = Color.FromArgb(161, 181, 195);
            btnDeleteEquipment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDeleteEquipment.Location = new Point(422, 389);
            btnDeleteEquipment.Name = "btnDeleteEquipment";
            btnDeleteEquipment.Size = new Size(154, 29);
            btnDeleteEquipment.TabIndex = 56;
            btnDeleteEquipment.Text = "Delete Equipment";
            btnDeleteEquipment.UseVisualStyleBackColor = false;
            btnDeleteEquipment.Click += btnDeleteEquipment_Click;
            // 
            // btnEditEq
            // 
            btnEditEq.BackColor = Color.FromArgb(161, 181, 195);
            btnEditEq.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnEditEq.Location = new Point(582, 389);
            btnEditEq.Name = "btnEditEq";
            btnEditEq.Size = new Size(138, 29);
            btnEditEq.TabIndex = 55;
            btnEditEq.Text = "Edit Equipment";
            btnEditEq.UseVisualStyleBackColor = false;
            btnEditEq.Click += btnEditEq_Click;
            // 
            // btnAddEq
            // 
            btnAddEq.BackColor = Color.FromArgb(161, 181, 195);
            btnAddEq.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnAddEq.Location = new Point(725, 389);
            btnAddEq.Name = "btnAddEq";
            btnAddEq.Size = new Size(136, 29);
            btnAddEq.TabIndex = 54;
            btnAddEq.Text = "Add Equipment";
            btnAddEq.UseVisualStyleBackColor = false;
            btnAddEq.Click += btnAddEq_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 48, 64);
            panel1.Controls.Add(dataGridEquipments);
            panel1.Location = new Point(78, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 292);
            panel1.TabIndex = 53;
            // 
            // dataGridEquipments
            // 
            dataGridEquipments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridEquipments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEquipments.Location = new Point(21, 28);
            dataGridEquipments.MultiSelect = false;
            dataGridEquipments.Name = "dataGridEquipments";
            dataGridEquipments.ReadOnly = true;
            dataGridEquipments.RowHeadersWidth = 51;
            dataGridEquipments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridEquipments.Size = new Size(751, 251);
            dataGridEquipments.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(68, 35);
            label2.Name = "label2";
            label2.Size = new Size(144, 24);
            label2.TabIndex = 52;
            label2.Text = "EQUIPMENTS";
            // 
            // frmAdEquip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(980, 515);
            Controls.Add(btnDeleteEquipment);
            Controls.Add(btnEditEq);
            Controls.Add(btnAddEq);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdEquip";
            Text = "frmAdEquip";
            Load += frmAdEquip_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridEquipments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label2;
        private Button btnDeleteEquipment;
        private Button btnEditEq;
        private Button btnAddEq;
        private Panel panel1;
        private DataGridView dataGridEquipments;
    }
}
