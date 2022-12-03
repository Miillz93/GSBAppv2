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
        private PPEMISSION3Entities mesDonnesEF;
        public FrmAccueil()
        {
            InitializeComponent();
            mesDonnesEF = new PPEMISSION3Entities();
        }

        private void MenuMedecinGerer_Click(object sender, EventArgs e)
        {
            FrmGerer f = new FrmGerer(mesDonnesEF);
            f.Show();
        }

       /* */
    }
}
