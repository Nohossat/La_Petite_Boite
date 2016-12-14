using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Ressources;

namespace La_petite_boite
{
    public partial class Charger : Form
    {
        SpecialLabel Selection = new SpecialLabel();
        SpecialLabel annonce = new SpecialLabel();
        LittleButton charger = new LittleButton(450);
        LittleButton retour = new LittleButton(450);
        ComboBox listeDossierSauvegarde = new ComboBox();
        ListBox joueursPossibles = new ListBox();
        Panel chargerJoueur = new Panel();
        Boolean trouve = false;

        public Charger()
        {
            InitializeComponent();
            
        }
        
        private void Charger_Load(object sender, EventArgs e)
        {
            //design
            
            //panel chargerJoueur

            //charger une partie
            chargerJoueur.BackgroundImage = items.accueil;
            chargerJoueur.Width = 640;
            chargerJoueur.Height = 558;
            chargerJoueur.Left = 0;
            chargerJoueur.BorderStyle = BorderStyle.FixedSingle;

            //label Selection

            Selection.Text = "Selectionne un dossier de sauvegarde";
            Selection.Top = 50;
            Selection.Left = 0;
            Selection.Width = 640;
            Selection.Height = 40;
            Selection.ForeColor = Color.White;
            Selection.BackColor = Color.Transparent;
            Selection.Font = new Font(Form1.privateFontCollection.Families[0], 20);
            
            
            //liste de dossiers de sauvegarde

            listeDossierSauvegarde.Font = new Font("Segoe UI Symbol", 13, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            listeDossierSauvegarde.Width = 200;
            listeDossierSauvegarde.Height = 35;
            listeDossierSauvegarde.Top = 100;
            listeDossierSauvegarde.Left = 220;
            listeDossierSauvegarde.SelectedIndexChanged += new EventHandler(afficherJoueursPossibles);
            
            //ComboBox

            for (int i = 0; i < Form1.listeSauvegarde.Count(); i++)
            {
                listeDossierSauvegarde.Items.Add(Form1.listeSauvegarde[i]);
            }

            //annonce

            annonce.Text = ""; 
            annonce.Font = new Font(Form1.privateFontCollection.Families[0], 20);
            annonce.ForeColor = Color.White;
            annonce.BackColor = Color.Transparent;
            annonce.Width = 640;
            annonce.Height = 35;
            annonce.Top = 150;
            annonce.Left = 0;

            //liste joueurs Possibles

            joueursPossibles.Top = 200;
            joueursPossibles.Width = 200;
            joueursPossibles.Left = 220;
            joueursPossibles.Height = 200;
            joueursPossibles.Font = new System.Drawing.Font("Segoe UI Symbol", 13, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //BUTTONS

            //retour
            retour.Text = "Retour";
            retour.Left = 350;
            retour.Font = new Font(Form1.privateFontCollection.Families[0], 20);
            retour.Click += new EventHandler(retourButton);

            //charger
            charger.Text = "Charger";
            charger.Left = 150;
            charger.Font = new Font(Form1.privateFontCollection.Families[0], 20);
            charger.Click += new EventHandler(chargerMethod);

            
            chargerJoueur.Controls.Add(listeDossierSauvegarde);
            chargerJoueur.Controls.Add(Selection);

            this.Controls.Add(chargerJoueur);
        }

        private void retourButton(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void chargerMethod(object sender, EventArgs e)
        {
            charger_button();

            if (trouve == true)
            {
                Form1.chargementReussi = true;
            }

            //on referme la form
            this.Close();
            this.Dispose();

        }

        private void afficherJoueursPossibles(object sender, EventArgs e)
        {
            //fonction qui sert a afficher la liste des joueurs possibles 
            //selon le dossier selectionne dans le panneau chargement

            String[] ligne;
            String dossier = Convert.ToString(listeDossierSauvegarde.SelectedItem);

            if (dossier != "")
            {
                if (joueursPossibles.Items != null)
                {
                    joueursPossibles.Items.Clear();
                }

                for (int i = 0; i < Form1.joueursFichier.Count(); i++)
                {
                    if (Form1.joueursFichier[i].Contains(dossier))
                    {
                        ligne = Form1.joueursFichier[i].Split('-');
                        joueursPossibles.Items.Add(ligne[0]);
                    }
                }

                //on affiche la liste que s-il y a des elements dans la liste joueurs possibles
                joueursPossibles.Visible = false;
                chargerJoueur.Controls.Add(joueursPossibles);
                chargerJoueur.Controls.Add(annonce);

                if (joueursPossibles.Items.Count > 0)
                {
                    joueursPossibles.Visible = true;
                    annonce.Text = "Choisir parmi la liste de personnages";
                    charger.Enabled = true;
                }
                else
                {
                    annonce.Text = "Il n'y a pas de joueurs dans ce dossier !";
                    charger.Enabled = false;
                }
                
                chargerJoueur.Controls.Add(charger);
                chargerJoueur.Controls.Add(retour);
            }
        }

        private void charger_button()
        {

            String nomJoueur = Convert.ToString(joueursPossibles.SelectedItem);
            string[] splitjoueurFichier;
            
            try
            {
                //on boucle sur le tableau joueursFichier pour voir quelle ligne contient le nom du joueur
                for (int i = 0; i < Form1.joueursFichier.Count(); i++)
                {
                    if (Form1.joueursFichier[i].Contains(nomJoueur) && nomJoueur != "")
                    {
                       
                        //on split la chaine
                        splitjoueurFichier = Form1.joueursFichier[i].Split('-');

                        //on enregistre les donnees du joueur pour cr'eer l-instance dans la form1 
                        Form1.nom = splitjoueurFichier[0];
                        Form1.age = Convert.ToInt16(splitjoueurFichier[1]);
                        Form1.avatar = Convert.ToInt16(splitjoueurFichier[2]);
                        Form1.lieuTemporaire = splitjoueurFichier[3];
                        Form1.score = Convert.ToInt16(splitjoueurFichier[4]);
                        Form1.dos = splitjoueurFichier[5];
                        Form1.epreuvesEmportees[0] = Convert.ToInt16(splitjoueurFichier[6]);
                        Form1.epreuvesEmportees[1] = Convert.ToInt16(splitjoueurFichier[7]);
                        Form1.epreuvesEmportees[2] = Convert.ToInt16(splitjoueurFichier[8]);
                        Form1.epreuvesEmportees[3] = Convert.ToInt16(splitjoueurFichier[9]);
                        trouve = true;
                    }
                }

                if (nomJoueur == "")
                {
                    String message = "Il faut selectionner une valeur dans la liste";
                    String titre = "Erreur";
                    MessageBox.Show(message, titre, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //une erreur est toujours possible
                if (trouve == false && nomJoueur != "")
                {
                    String message = "Le joueur" + nomJoueur + " n'a pas ete retrouve.";
                    String titre = "Erreur";
                    MessageBox.Show(message, titre, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception er)
            {
                Console.WriteLine("Une erreur s'est produite : '{0}'", er);
            }

        }
    }
}
