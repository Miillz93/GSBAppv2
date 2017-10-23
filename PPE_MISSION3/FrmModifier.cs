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
    public partial class FrmModifier : Form
    {
        private PPE_MISSION3_entity mesDonnesEF;
        private int idMedecin;

        public FrmModifier(PPE_MISSION3_entity mesDonnesEF, int idMedecin)
        {
            InitializeComponent();
            
            this.idMedecin = idMedecin;
            this.mesDonnesEF = mesDonnesEF;
            this.BdsModifier.DataSource = mesDonnesEF.rapports.Local;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmModifier_Load(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
