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
            txtSearchEq = new TextBox();
            pBoxSearch = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEquipments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxSearch).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteEquipment
            // 
            btnDeleteEquipment.BackColor = Color.FromArgb(161, 181, 195);
            btnDeleteEquipment.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteEquipment.Location = new Point(485, 523);
            btnDeleteEquipment.Margin = new Padding(3, 4, 3, 4);
            btnDeleteEquipment.Name = "btnDeleteEquipment";
            btnDeleteEquipment.Size = new Size(176, 44);
            btnDeleteEquipment.TabIndex = 56;
            btnDeleteEquipment.Text = "Delete Equipment";
            btnDeleteEquipment.UseVisualStyleBackColor = false;
            btnDeleteEquipment.Click += btnDeleteEq_Click;
            // 
            // btnEditEq
            // 
            btnEditEq.BackColor = Color.FromArgb(161, 181, 195);
            btnEditEq.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditEq.Location = new Point(668, 523);
            btnEditEq.Margin = new Padding(3, 4, 3, 4);
            btnEditEq.Name = "btnEditEq";
            btnEditEq.Size = new Size(158, 44);
            btnEditEq.TabIndex = 55;
            btnEditEq.Text = "Edit Equipment";
            btnEditEq.UseVisualStyleBackColor = false;
            btnEditEq.Click += btnEditEq_Click;
            // 
            // btnAddEq
            // 
            btnAddEq.BackColor = Color.FromArgb(161, 181, 195);
            btnAddEq.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEq.Location = new Point(832, 523);
            btnAddEq.Margin = new Padding(3, 4, 3, 4);
            btnAddEq.Name = "btnAddEq";
            btnAddEq.Size = new Size(155, 44);
            btnAddEq.TabIndex = 54;
            btnAddEq.Text = "Add Equipment";
            btnAddEq.UseVisualStyleBackColor = false;
            btnAddEq.Click += btnAddEq_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 48, 64);
            panel1.Controls.Add(dataGridEquipments);
            panel1.Location = new Point(89, 121);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 389);
            panel1.TabIndex = 53;
            // 
            // dataGridEquipments
            // 
            dataGridEquipments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridEquipments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEquipments.Location = new Point(24, 37);
            dataGridEquipments.Margin = new Padding(3, 4, 3, 4);
            dataGridEquipments.MultiSelect = false;
            dataGridEquipments.Name = "dataGridEquipments";
            dataGridEquipments.ReadOnly = true;
            dataGridEquipments.RowHeadersWidth = 51;
            dataGridEquipments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridEquipments.Size = new Size(858, 335);
            dataGridEquipments.TabIndex = 1;
            dataGridEquipments.CellContentClick += dataGridEquipments_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(78, 47);
            label2.Name = "label2";
            label2.Size = new Size(183, 29);
            label2.TabIndex = 52;
            label2.Text = "EQUIPMENTS";
            // 
            // txtSearchEq
            // 
            txtSearchEq.Location = new Point(149, 83);
            txtSearchEq.Margin = new Padding(3, 4, 3, 4);
            txtSearchEq.Name = "txtSearchEq";
            txtSearchEq.Size = new Size(206, 27);
            txtSearchEq.TabIndex = 57;
            txtSearchEq.TextChanged += txtSearchEq_TextChanged;
            // 
            // pBoxSearch
            // 
            pBoxSearch.Image = Properties.Resources.icons8_search_64;
            pBoxSearch.Location = new Point(113, 83);
            pBoxSearch.Margin = new Padding(3, 4, 3, 4);
            pBoxSearch.Name = "pBoxSearch";
            pBoxSearch.Size = new Size(29, 31);
            pBoxSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxSearch.TabIndex = 58;
            pBoxSearch.TabStop = false;
            // 
            // frmAdEquip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(1120, 687);
            Controls.Add(pBoxSearch);
            Controls.Add(txtSearchEq);
            Controls.Add(btnDeleteEquipment);
            Controls.Add(btnEditEq);
            Controls.Add(btnAddEq);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAdEquip";
            Text = "frmAdEquip";
            Load += frmAdEquip_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridEquipments).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label2;
        private Button btnDeleteEquipment;
        private Button btnEditEq;
        private Button btnAddEq;
        private Panel panel1;
        private DataGridView dataGridEquipments;
        private TextBox txtSearchEq;
        private PictureBox pBoxSearch;
    }
}
