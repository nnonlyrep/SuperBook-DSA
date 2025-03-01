using SuperBookFinalProj.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperBookFinalProj.GUI.PopUps
{
    public partial class ppEditEquip : Form
    {
        private Equipments selectedEquipment;

        public ppEditEquip()
        {
            InitializeComponent();
        }

        public ppEditEquip(Equipments selectedEquipment)
        {
            this.selectedEquipment = selectedEquipment;
        }

        public Action<object, EventArgs> EquipmentUpdated { get; internal set; }

        private void ppEditEquip_Load(object sender, EventArgs e)
        {

        }
    }
}
