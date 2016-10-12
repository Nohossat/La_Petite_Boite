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
    public partial class Charger : Form
    {
        Label Selection = new Label();
        Button charger = new Button();
        Button retour = new Button();
        String[] listeSauvegarde;
        ComboBox listeDossierSauvegarde = new ComboBox();
        ListBox joueursPossibles = new ListBox();
        Label annonce = new Label();
        Panel chargerJoueur = new Panel();
        Boolean trouve = false;

        public Charger()
        {
            InitializeComponent();
            
        }

        private void Charger_Load(object sender, EventArgs e)
        {
            //chargement fichier dossiers de sauvegarde

            listeSauvegarde = System.IO.File.ReadAllLines("dossiers_sauvegarde.txt");


            //design

            //panel chargerJoueur

            //charger une partie
            chargerJoueur.Width = 689;
            chargerJoueur.Height = 558;
            chargerJoueur.BackgroundImage = Properties.Resources.accueil;
            chargerJoueur.BorderStyle = BorderStyle.FixedSingle;

            //label Selection

            Selection.Text = "Selectionne un dossier de sauvegarde";
            Selection.Top = 50;
            Selection.Left = 170;
            Selection.Width = 400;
            Selection.Height = 40;
            Selection.ForeColor = Color.White;
            Selection.BackColor = Color.Transparent;
            Selection.Font = new Font(Selection.Font.FontFamily, 15);

           

            //liste de dossiers de sauvegarde

            listeDossierSauvegarde.Font = new Font(Selection.Font.FontFamily, 14);
            listeDossierSauvegarde.Width = 200;
            listeDossierSauvegarde.Height = 35;
            listeDossierSauvegarde.Top = 100;
            listeDossierSauvegarde.Left = 220;
            listeDossierSauvegarde.SelectedIndexChanged += new EventHandler(afficherJoueursPossibles);
            
            //ComboBox

            for (int i = 0; i < listeSauvegarde.Length; i++)
            {
                listeDossierSauvegarde.Items.Add(listeSauvegarde[i]);
            }

            //annonce

            annonce.Text = ""; 
            annonce.Font = new Font(annonce.Font.FontFamily, 14);
            annonce.ForeColor = Color.White;
            annonce.BackColor = Color.Transparent;
            annonce.Width = 400;
            annonce.Height = 35;
            annonce.Top = 150;
            annonce.Left = 170;

            //joueurs Possibles

            joueursPossibles.Top = 200;
            joueursPossibles.Width = 200;
            joueursPossibles.Left = 220;
            joueursPossibles.Height = 200;
            joueursPossibles.Font = new Font(Selection.Font.FontFamily, 14);


            //retour
            retour.Text = "Retour";
            retour.Top = 450;
            retour.Left = 350;
            retour.Width = 150;
            retour.Height = 35;
            retour.FlatAppearance.BorderSize = 0;
            retour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            retour.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            retour.BackColor = Color.Transparent;
            retour.Click += new EventHandler(retourButton);

            //charger
            charger.Text = "Charger";
            charger.Top = 450;
            charger.Left = 150;
            charger.Width = 150;
            charger.Height = 35;
            charger.FlatAppearance.BorderSize = 0;
            charger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            charger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            charger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            charger.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            charger.BackColor = Color.Transparent;
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

                for (int i = 0; i < Form1.joueursFichier.Length; i++)
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
                for (int i = 0; i < Form1.joueursFichier.Length; i++)
                {
                    if (Form1.joueursFichier[i].Contains(nomJoueur) && nomJoueur != "")
                    {
                       
                        //on split la chaine
                        splitjoueurFichier = Form1.joueursFichier[i].Split('-');

                        //on enregistre les donnees du joueur pour cr'eer l-instance dans la form1 
                        Form1.nom = splitjoueurFichier[0];
                        Form1.age = Convert.ToInt16(splitjoueurFichier[1]);
                        Form1.avatar = splitjoueurFichier[2];
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
