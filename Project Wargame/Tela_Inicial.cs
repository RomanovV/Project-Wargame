using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace Project_Wargame
{
    public partial class Tela_Inicial : Form
    {
        Body_Systems player = new Body_Systems();

        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lblHeart.Text = player.body.internal_limb_list.Find(item => item.name == "Heart").limb_PV.ToString("");
            lblLeftHand.Text = player.body.external_limb.Find(item => item.name == "Left Hand").limb_PV.ToString("");
            lblCirc.Text = player.cardiac_PV.ToString("");
        }

        private void damageHeart_Click(object sender, EventArgs e)
        {
            player.body.damage_internal_limb(player.body.internal_limb_list.Find(item => item.name == "Heart"), "Burning", 0.3);
            player.body.damage_external_limbs(player.body.external_limb.Find(item => item.name == "Left Hand"), "Necrosis", 0.4);
        }

        private void damageHeart2_Click(object sender, EventArgs e)
        {
            player.body.damage_internal_limb(player.body.internal_limb_list.Find(item => item.name == "Heart"), "Burning", 0.1);
        }

        private void lblHeart_Click(object sender, EventArgs e)
        {

        }

        private void lblLeftHand_Click(object sender, EventArgs e)
        {

        }
    }
}
