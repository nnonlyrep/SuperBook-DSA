
using SuperBookFinalProj.Models;

namespace SuperBookFinalProj.GUI.PopUps
{
    partial class ppEditEquip
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
            btnEdit = new Button();
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
            btnCancel.Location = new Point(457, 363);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(161, 181, 195);
            btnEdit.Location = new Point(558, 363);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 28;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(30, 48, 64);
            txtQuantity.Location = new Point(149, 365);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(190, 27);
            txtQuantity.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(149, 317);
            label2.Name = "label2";
            label2.Size = new Size(92, 24);
            label2.TabIndex = 24;
            label2.Text = "Quantity:";
            // 
            // txtEquipmentType
            // 
            txtEquipmentType.BackColor = Color.FromArgb(30, 48, 64);
            txtEquipmentType.Location = new Point(149, 263);
            txtEquipmentType.Margin = new Padding(3, 4, 3, 4);
            txtEquipmentType.Name = "txtEquipmentType";
            txtEquipmentType.Size = new Size(190, 27);
            txtEquipmentType.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(149, 217);
            label1.Name = "label1";
            label1.Size = new Size(170, 24);
            label1.TabIndex = 22;
            label1.Text = "Equipment Type:";
            // 
            // txtEquipmentName
            // 
            txtEquipmentName.BackColor = Color.FromArgb(30, 48, 64);
            txtEquipmentName.Location = new Point(149, 165);
            txtEquipmentName.Margin = new Padding(3, 4, 3, 4);
            txtEquipmentName.Name = "txtEquipmentName";
            txtEquipmentName.Size = new Size(190, 27);
            txtEquipmentName.TabIndex = 21;
            // 
            // lblRoomNum
            // 
            lblRoomNum.AutoSize = true;
            lblRoomNum.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRoomNum.ForeColor = SystemColors.ButtonFace;
            lblRoomNum.Location = new Point(149, 117);
            lblRoomNum.Name = "lblRoomNum";
            lblRoomNum.Size = new Size(178, 24);
            lblRoomNum.TabIndex = 20;
            lblRoomNum.Text = "Equipment Name:";
            // 
            // lblEditEq
            // 
            lblEditEq.AutoSize = true;
            lblEditEq.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEditEq.ForeColor = SystemColors.ButtonFace;
            lblEditEq.Location = new Point(149, 59);
            lblEditEq.Name = "lblEditEq";
            lblEditEq.Size = new Size(197, 31);
            lblEditEq.TabIndex = 19;
            lblEditEq.Text = "Edit Equipment";
            // 
            // ppEditEquip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 31, 40);
            ClientSize = new Size(800, 451);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(txtQuantity);
            Controls.Add(label2);
            Controls.Add(txtEquipmentType);
            Controls.Add(label1);
            Controls.Add(txtEquipmentName);
            Controls.Add(lblRoomNum);
            Controls.Add(lblEditEq);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ppEditEquip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ppEditEquip";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btnCancel;
        private Button btnEdit;
        private TextBox txtQuantity;
        private TextBox txtLoc;
        private Label lblLoc;
        private TextBox txtCapacity;
        private Label label2;
        private TextBox txtEquipmentType;
        private TextBox txtRoomType;
        private Label label1;
        private TextBox txtEquipmentName;
        private Label lblRoomNum;
        private Label lblEditEq;
    }
}