using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PPE_MISSION3
{
    public partial class FrmRapport : Form
    {
        //Champs privé
        private PPEMISSION3Entities mesDonnesEF;
        private int idMedecin;

        //Constructeur
        public FrmRapport(PPEMISSION3Entities mesDonnesEF, int idMedecin)
        {
            this.idMedecin = idMedecin;

            InitializeComponent();
            this.mesDonnesEF = mesDonnesEF;
            this.BdsRapports.DataSource = mesDonnesEF.rapport.Local;

            //Affectation de la methode getRapport dans un objet rapport
            rapport dernierRapport = getDernierRap(this.idMedecin);

            //Chaque champs est affecté a une variable de type form
            this.DateTB.Text = dernierRapport.date.ToString().Substring(0, 8);
            this.MotifTB.Text = dernierRapport.motif.ToString();
            this.BilanTB.Text = dernierRapport.bilan.ToString();
            this.IDVisiteurTB.Text = dernierRapport.idVisiteur.ToString();
            this.IDMedecinTB.Text = dernierRapport.idMedecin.ToString();
        }

        //Retourne le derniere Rapport d'un Medecin
        private rapport getDernierRap(int idMedecin)
        {
            var reqDernierRapp = (from rapport in this.mesDonnesEF.rapport
                                  where rapport.idMedecin == idMedecin
                                  orderby rapport.id
                                  select rapport);
            rapport dernierRap = reqDernierRapp.First();
            return dernierRap ;
        }

        private void DownloadBouton_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Parse("<?xml-stylesheet type=\"text/xsl\" href=\"dco.xsl\"?><S><B></B></S>");
            
            Console.ReadKey();
        }

        private void BdsRapports_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
