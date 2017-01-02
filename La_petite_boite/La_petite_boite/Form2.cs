using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ressources;

namespace La_petite_boite
{
    public partial class Form2 : Form 
    {
        
        private SpecialLabel label1 = new SpecialLabel(); 
        private ControlButton enregistre = new ControlButton("#000000", "#6d5622");
        private ControlButton retour = new ControlButton("#000000", "#6d5622");
        public List<String> liste = new List<String>();
        bool existe;

        public Form2()
        {
            InitializeComponent();
            this.label1.Font = new Font(petiteBoite.privateFontCollection.Families[0], 20);
            this.nouveauNom.Font = new Font(petiteBoite.privateFontCollection.Families[0], 20);

            enregistre.Text = petiteBoite.Textes[69];
            enregistre.Font = new Font(petiteBoite.privateFontCollection.Families[0], 18);
            enregistre.Location = new Point(110, 104);
            enregistre.Size = new Size(160, 38);
            enregistre.UseVisualStyleBackColor = true;
            enregistre.Click += new EventHandler(enregistrer);

            retour.Text = petiteBoite.Textes[26];
            retour.Font = new Font(petiteBoite.privateFontCollection.Families[0], 18);
            retour.Location = new Point(280, 104);
            retour.Size = new Size(160, 38);
            retour.UseVisualStyleBackColor = true;
            retour.Click += new EventHandler(retourForm);

            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = ColorTranslator.FromHtml("#000000");
            label1.Location = new Point(20, 47);
            label1.Size = new Size(180, 25);
            label1.Text = petiteBoite.Textes[70];
        }

        private void enregistrer(object sender, EventArgs e)
        {
            existe = false;
            //on verifie que le dossier n'existe pas au prealable
            petiteBoite.chargementTexte("dossiers_sauvegarde.txt", liste);

            for (int i = 0; i< liste.Count; i++)
            {
                if (liste[i].Contains(nouveauNom.Text))
                {
                    //le nom existe deja
                    existe = true;
                }
            }

            if (existe)
            {
                //creation du message d-erreur
                String message = "Le nom choisi existe deja. Veuillez en choisir un autre.";
                
                //Pop up affichage message
                List<String> nomsButtons = new List<string>();
                List<int> refEvents = new List<int>();
                nomsButtons.Add("Retour");
                refEvents.Add(0);

                var Popup = new PopUp(ColorTranslator.FromHtml("#be1621"), items.attention, 1, message, nomsButtons, refEvents);
                Popup.ShowDialog();
            }
            else
            {
                //on peut utiliser le nom de dossier
                //on sauvegarde dans le fichier dossiers_Sauvegarde

                try
                {
                    using (var writer = new StreamWriter("dossiers_sauvegarde.txt", true))
                    {
                        writer.WriteLine(nouveauNom.Text);
                    }
                }
                catch
                {
                    Console.Write("Erreur lors de l'ecriture du fichier");
                }

                //on enregistre la valeur saisie dans une variable globale
                petiteBoite.dossier = nouveauNom.Text;

                //on referme la form
                this.Close();
                this.Dispose();
            }
        }

        private void retourForm(object sender, EventArgs e)
        {
            //on referme la form sans enregistrer
            this.Close();
            this.Dispose();
        }
        
    }
}
