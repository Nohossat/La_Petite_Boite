using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_petite_boite
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void enregistrer(object sender, EventArgs e)
        {
            //on sauvegarde dans le fichier dossiers_Sauvegarde

            System.IO.File.AppendAllText("../../Resources/dossiers_sauvegarde.txt", Environment.NewLine);
            System.IO.File.AppendAllText("../../Resources/dossiers_sauvegarde.txt", nouveauNom.Text);

            //on enregistre la valeur saisie dans une variable globale
            Form1.dossier = nouveauNom.Text;

            //on referme la form
            this.Close();
            this.Dispose();
        }
        
    }
}
