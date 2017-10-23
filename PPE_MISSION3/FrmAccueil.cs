using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_MISSION3
{
    public partial class FrmAccueil : Form
    {
        private PPE_MISSION3_entity mesDonnesEF;
        public FrmAccueil()
        {
            InitializeComponent();
            mesDonnesEF = new PPE_MISSION3_entity();
        }

        private void MenuMedecinGerer_Click(object sender, EventArgs e)
        {
            FrmGerer f = new FrmGerer(this.mesDonnesEF);
            f.Show();
        }

       /* */
    }
}
