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
    public partial class FrmGerer : Form
    {

        private PPE_MISSION3_entity mesDonnesEF;
        private int idMedecin = 0;
        private bool medecinRapport;
        private string departement;
        private string nom;

        //Constructeur
        public FrmGerer(PPE_MISSION3_entity mesDonnesEF)
        {
            InitializeComponent();
            medecinRapport = false;

            this.mesDonnesEF = mesDonnesEF;
            //Defini la source de données
            this.bdsGerer.DataSource = mesDonnesEF.medecins.Local;

            listView1.View = View.Details;

            //Definitions des champs dans la listViews
            //parametrage de la taille et l'alignement des éléments
            listView1.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listView1.Columns.Add("Nom", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Prenom", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Adresse", 300, HorizontalAlignment.Left);
            listView1.Columns.Add("DP", 35, HorizontalAlignment.Left);
            listView1.Columns.Add("Telephone", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Specialité", 125, HorizontalAlignment.Left);

            listView1.FullRowSelect = true;
            
            //Initialisation de la methode getLesMedecins
            //IL prend deux parametres de type string
            getLesMedecins("","");
        }

        //Accede à la fenetre du dernier Rapport
        private void button3_Click(object sender, EventArgs e)
        {
            if (medecinRapport)
            {
                FrmRapport f = new FrmRapport(this.mesDonnesEF, idMedecin);
                f.Show();
            }
        }


        //Affiche les Informations relatives aux medecins
        private void getLesMedecins(string nom, string departement)
        {
            //Renitialise la liste
            this.listView1.Items.Clear();
            //Onjet de type linQ spécifique au BDD
            IOrderedQueryable<medecin> reqLesMedecins;
            int dpMedecins;
            if(nom=="" && departement == "") 
            {
                reqLesMedecins = mesDonnesEF.medecins
                                    .OrderBy(medecin => medecin.nom).ThenBy(medecin => medecin.id);
            }
            else if(nom=="")
            {
                dpMedecins = Convert.ToInt32(departement);
                reqLesMedecins = mesDonnesEF.medecins
                                    .Where(medecin => medecin.departement.Equals(dpMedecins))
                                    .OrderBy(medecin => medecin.nom).ThenBy(medecin => medecin.id)
                                    ;

            }
            else if(departement=="")
            {

                reqLesMedecins = mesDonnesEF.medecins
                                     .Where(medecin => medecin.nom.StartsWith(nom))
                                    .OrderBy(medecin => medecin.nom).ThenBy(medecin => medecin.id);

            }

            else
            {
                //nom et departement
                dpMedecins = Convert.ToInt32(departement);
                reqLesMedecins = mesDonnesEF.medecins
                                    .Where(medecin => medecin.nom.StartsWith(nom))
                                    .Where(medecin => medecin.departement.Equals(dpMedecins))
                                    .OrderBy(medecin => medecin.nom).ThenBy(medecin => medecin.id);
            }

            //var reqLesMedecins = mesDonnesEF.medecins
            //                        .OrderBy(medecin => medecin.nom).ThenBy(medecin => medecin.id);
        

            //Parcours les médecins
            foreach(var leMedecin in reqLesMedecins)
            {
                //Initialisation
                string speComp = " ";
                if (leMedecin.specialiteComplementaire != null)
                    speComp = leMedecin.specialiteComplementaire;

                //Tableau contenant les données extrait de la BDD
                string[] row = {
                    leMedecin.id.ToString(),
                    leMedecin.nom,
                    leMedecin.prenom,
                    leMedecin.adresse,
                    leMedecin.departement.ToString(),
                    leMedecin.tel,
                    speComp
                };
                //Affectation des articles dans la liste
                ListViewItem lvi = new ListViewItem(row);
                this.listView1.Items.Add(lvi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FrmModifier f = new FrmModifier(this.mesDonnesEF);
            //f.Show();
        }

        //Operations de recherche d'un medecin par rapport a son nom
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Affectation  du nom au textbox nom
            //Affectation  du departement au textbox departement
            nom = txtNom.Text;
            departement = txtDepartement.Text;
            getLesMedecins(nom, departement);
             
        }

        //Operation de recherche d'un medecin par rapport a son departement
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Affectation  du nom au textbox nom
            //Affectation  du departement au textbox departement
            nom = txtNom.Text;
            departement = txtDepartement.Text;
            getLesMedecins(nom, departement);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            FrmModifier m = new FrmModifier(mesDonnesEF, idMedecin);
            m.Show();
        }

        private void btnRapport_Click(object sender, EventArgs e)
        {
            if(this.idMedecin != 0)
            {
                FrmRapport r = new FrmRapport(mesDonnesEF, this.idMedecin);
                r.Show();
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem listViewItem in listView1.SelectedItems)
            {
                this.idMedecin = Convert.ToInt32(listViewItem.SubItems[0].Text);
            }
        }
    }
}
