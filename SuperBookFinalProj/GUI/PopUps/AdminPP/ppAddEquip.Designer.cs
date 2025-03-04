namespace SuperBookFinalProj.GUI.PopUps
{
    partial class ppAddEquip
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
            btnCancel = new Button();
            btnAdd = new Button();
            txtQuantity = new TextBox();
            label2 = new Label();
            txtEquipmentType = new TextBox();
            label1 = new Label();
            txtEquipmentName = new TextBox();
            lblRoomNum = new Label();
            lblEditEq = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(161, 181, 195);
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(457, 363);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 38;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(161, 181, 195);
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(558, 363);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 37;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnEdit_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(30, 48, 64);
            txtQuantity.ForeColor = SystemColors.Menu;
            txtQuantity.Location = new Point(149, 365);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(190, 27);
            txtQuantity.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(149, 317);
            label2.Name = "label2";
            label2.Size = new Size(92, 24);
            label2.TabIndex = 35;
            label2.Text = "Quantity:";
            // 
            // txtEquipmentType
            // 
            txtEquipmentType.BackColor = Color.FromArgb(30, 48, 64);
            txtEquipmentType.ForeColor = SystemColors.Menu;
            txtEquipmentType.Location = new Point(149, 263);
            txtEquipmentType.Margin = new Padding(3, 4, 3, 4);
            txtEquipmentType.Name = "txtEquipmentType";
            txtEquipmentType.Size = new Size(190, 27);
            txtEquipmentType.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(149, 217);
            label1.Name = "label1";
            label1.Size = new Size(170, 24);
            label1.TabIndex = 33;
            label1.Text = "Equipment Type:";
            // 
            // txtEquipmentName
            // 
            txtEquipmentName.BackColor = Color.FromArgb(30, 48, 64);
            txtEquipmentName.ForeColor = SystemColors.Menu;
            txtEquipmentName.Location = new Point(149, 165);
            txtEquipmentName.Margin = new Padding(3, 4, 3, 4);
            txtEquipmentName.Name = "txtEquipmentName";
            txtEquipmentName.Size = new Size(190, 27);
            txtEquipmentName.TabIndex = 32;
            // 
            // lblRoomNum
            // 
            lblRoomNum.AutoSize = true;
            lblRoomNum.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRoomNum.ForeColor = SystemColors.ButtonFace;
            lblRoomNum.Location = new Point(149, 117);
            lblRoomNum.Name = "lblRoomNum";
            lblRoomNum.Size = new Size(178, 24);
            lblRoomNum.TabIndex = 31;
            lblRoomNum.Text = "Equipment Name:";
            // 
            // lblEditEq
            // 
            lblEditEq.AutoSize = true;
            lblEditEq.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEditEq.ForeColor = SystemColors.ButtonFace;
            lblEditEq.Location = new Point(149, 59);
            lblEditEq.Name = "lblEditEq";
            lblEditEq.Size = new Size(198, 31);
            lblEditEq.TabIndex = 30;
            lblEditEq.Text = "Add Equipment";
            // 
            // ppAddEquip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(800, 451);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(label2);
            Controls.Add(txtEquipmentType);
            Controls.Add(label1);
            Controls.Add(txtEquipmentName);
            Controls.Add(lblRoomNum);
            Controls.Add(lblEditEq);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ppAddEquip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ppAddEquip";
            Load += ppAddEquip_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAdd;
        private TextBox txtQuantity;
        private Label label2;
        private TextBox txtEquipmentType;
        private Label label1;
        private TextBox txtEquipmentName;
        private Label lblRoomNum;
        private Label lblEditEq;
    }
}