using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Ressources;
using System.Collections.Generic;

namespace La_petite_boite
{
    public partial class Charger : FormSpecial
    {
        SpecialLabel Selection = new SpecialLabel();
        SpecialLabel annonce = new SpecialLabel();
        LittleButton charger = new LittleButton(500);
        LittleButton retour = new LittleButton(250);
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
            Selection.Top = 120;
            Selection.Left = 0;
            Selection.Width = 640;
            Selection.Height = 40;
            Selection.ForeColor = Color.White;
            Selection.BackColor = Color.Transparent;
            Selection.Font = new Font(petiteBoite.privateFontCollection.Families[0], 20);
            
            
            //liste de dossiers de sauvegarde

            listeDossierSauvegarde.Font = new Font("Segoe UI Symbol", 13, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            listeDossierSauvegarde.Width = 200;
            listeDossierSauvegarde.Height = 35;
            listeDossierSauvegarde.Top = 170;
            listeDossierSauvegarde.Left = 220;
            listeDossierSauvegarde.SelectedIndexChanged += new EventHandler(afficherJoueursPossibles);
            
            //ComboBox

            for (int i = 0; i < petiteBoite.listeSauvegarde.Count(); i++)
            {
                listeDossierSauvegarde.Items.Add(petiteBoite.listeSauvegarde[i]);
            }

            //annonce

            annonce.Text = ""; 
            annonce.Font = new Font(petiteBoite.privateFontCollection.Families[0], 20);
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
            retour.Left = 245;
            retour.Font = new Font(petiteBoite.privateFontCollection.Families[0], 25);
            retour.Click += new EventHandler(retourButton);

            //charger
            charger.Text = "Charger";
            charger.Left = 140;
            charger.Font = new Font(petiteBoite.privateFontCollection.Families[0], 25);
            charger.Click += new EventHandler(chargerMethod);

            
            chargerJoueur.Controls.Add(listeDossierSauvegarde);
            chargerJoueur.Controls.Add(Selection);
            chargerJoueur.Controls.Add(retour);

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
                petiteBoite.chargementReussi = true;
            }

            //on referme la form
            this.Close();
            this.Dispose();

        }

        private void afficherJoueursPossibles(object sender, EventArgs e)
        {
            //fonction qui sert a afficher la liste des joueurs possibles 
            //selon le dossier selectionne dans le panneau chargement
            retour.Top = 500;
            retour.Left = 350;
            Selection.Top = 50;
            listeDossierSauvegarde.Top = 100;
            String[] ligne;
            String dossier = Convert.ToString(listeDossierSauvegarde.SelectedItem);

            if (dossier != "")
            {
                if (joueursPossibles.Items != null)
                {
                    joueursPossibles.Items.Clear();
                }

                for (int i = 0; i < petiteBoite.joueursFichier.Count(); i++)
                {
                    if (petiteBoite.joueursFichier[i].Contains(dossier))
                    {
                        ligne = petiteBoite.joueursFichier[i].Split('-');
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
                
            }
        }

        private void charger_button()
        {

            String nomJoueur = Convert.ToString(joueursPossibles.SelectedItem);
            string[] splitjoueurFichier;
            
            try
            {
                //on boucle sur le tableau joueursFichier pour voir quelle ligne contient le nom du joueur
                for (int i = 0; i < petiteBoite.joueursFichier.Count(); i++)
                {
                    if (petiteBoite.joueursFichier[i].Contains(nomJoueur) && nomJoueur != "")
                    {
                       
                        //on split la chaine
                        splitjoueurFichier = petiteBoite.joueursFichier[i].Split('-');

                        //on enregistre les donnees du joueur pour cr'eer l-instance dans la form1 
                        petiteBoite.nom = splitjoueurFichier[0];
                        petiteBoite.age = Convert.ToInt16(splitjoueurFichier[1]);
                        petiteBoite.avatar = Convert.ToInt16(splitjoueurFichier[2]);
                        petiteBoite.lieuTemporaire = splitjoueurFichier[3];
                        petiteBoite.score = Convert.ToInt16(splitjoueurFichier[4]);
                        petiteBoite.dos = splitjoueurFichier[5];
                        petiteBoite.epreuvesEmportees[0] = Convert.ToInt16(splitjoueurFichier[6]);
                        petiteBoite.epreuvesEmportees[1] = Convert.ToInt16(splitjoueurFichier[7]);
                        petiteBoite.epreuvesEmportees[2] = Convert.ToInt16(splitjoueurFichier[8]);
                        petiteBoite.epreuvesEmportees[3] = Convert.ToInt16(splitjoueurFichier[9]);
                        trouve = true;
                    }
                }

                //ici pop up spe
                List<String> nomsButtons = new List<string>();
                List<int> refEvents = new List<int>();
                nomsButtons.Add("Retour");
                refEvents.Add(0);
                
                if (nomJoueur == "")
                {
                    String message = "Il faut choisir un personnage";
                    var Popup = new PopUp(ColorTranslator.FromHtml("#f39200"), items.guide, 1, message, nomsButtons, refEvents);
                    Popup.ShowDialog();
                }

                //une erreur est toujours possible
                if (trouve == false && nomJoueur != "")
                {
                    String message = "Le joueur" + nomJoueur + " n'a pas ete retrouve.";
                    var Popup = new PopUp(ColorTranslator.FromHtml("#f39200"), items.guide, 1, message, nomsButtons, refEvents);
                    Popup.ShowDialog();
                }
            }
            catch (Exception er)
            {
                Console.WriteLine("Une erreur s'est produite : '{0}'", er);
            }
        }
    }
}
