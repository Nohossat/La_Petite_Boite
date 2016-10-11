﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using memory8Cartes;
using Chasse_aux_mots;
using Grand_ou_Petit;
using Que_fait_le_Roi;

//reste a faire:  design,

namespace La_petite_boite

    //il faut regler bug affichage images, ajouter les recompenses et diapo roi. il y a un bug sur deux mini jeux, facilement reglables je pense
{
    public partial class Form1 : Form
    {
        //creation des objets et variables globales
        public static Boolean chargementReussi = false;
        public static int age;
        public static int top;
        public static int left;
        public static int score = 0;
        public static int[] epreuvesEmportees = new int[4];
        static Joueur chevalier;
        public static Label obj = new Label();
        public static String resultatJeu;
        public static Panel objectif = new Panel();
        public static String[] joueursFichier;
        public static Panel chargerJoueur = new Panel();
        public static Panel ConteneurEtoile = new Panel();
        public static String dossier = "";
        public static String nom;
        public static String avatar;
        public static String dos;
        public int IndiceJeu = 0;
        public static Label titreJeu = new Label();
        Button nouvellePartie = new Button();
        Button chargerPartie = new Button();
        Button commencer = new Button();
        Button retour = new Button();
        Button quitter = new Button();
        Button AfficherCarte = new Button();
        Button suivant = new Button();
        Button precedent = new Button();
        Button Yes;
        Button No;
        ComboBox listeDossierSauvegarde = new ComboBox();
        Lieu Village = new Lieu(470, -38, 448, 270, Properties.Resources.villageIconeGris,new Point(605,186), "Memory");
        Lieu Chateau = new Lieu(190, 1005, 227, 263, Properties.Resources.chateauIconeGris, new Point(453, 1050), "Chateau");
        Lieu Cabane = new Lieu(370, 740, 140, 146, Properties.Resources.cabaneIconeGris, new Point(516, 810), "Chasse aux mots");
        Lieu Tronc = new Lieu(65, 625, 177, 196, Properties.Resources.troncIconeGris, new Point(261, 713), "Grand Ou Petit");
        Lieu Montagne = new Lieu(0, 0, 312, 196, Properties.Resources.montagneIconeGris, new Point(191, 156), "Que fait le Roi?");
        Label menuPrincipal = new Label();
        Label prenomLabel = new Label();
        Label ageLabel = new Label();
        Label dossierSauvegarde = new Label();
        Label prenomJoueur = new Label();
        Label textePresentationJeu = new Label();
        Label MessageRoi;
        ListBox joueursPossibles = new ListBox();
        Lieu[] listeLieux; 
        Lieu accueil = new Lieu();
        Panel nouveauJoueur = new Panel();
        Panel choixAvatar = new Panel();
        Panel saisirInfos = new Panel();
        Panel diaporamaHistoire = new Panel();
        Panel CarteJeu = new Panel();
        Panel Jeu = new Panel();
        Panel tabBord = new Panel();
        Panel miniJeu = new Panel();
        Panel arrivee;
        Panel CourRoi;
        Panel Recompense;
        PictureBox imgChevalier = new PictureBox();
        PictureBox imagePersonnage1 = new PictureBox();
        PictureBox imagePersonnage2 = new PictureBox();
        PictureBox imagePersonnage3 = new PictureBox();
        PictureBox imagePersonnage4 = new PictureBox();
        PictureBox guide = new PictureBox();
        PictureBox coffre = new PictureBox();
        PictureBox sauvegarde = new PictureBox();
        PictureBox quitterMiniJeu = new PictureBox();
        PictureBox GrosCoffre;
        PictureBox recompense1;
        PictureBox recompense2;
        PictureBox recompense3;
        PictureBox[] listeAvatars;
        String sauvegardeImgAvatar = null;
        String[] listeSauvegarde;
        String jeuEnCours = "";
        String message ="";
        TextBox prenomField = new TextBox();
        TextBox ageField = new TextBox();
        

        public Form1()
        {
            InitializeComponent();
            //generation des elements

            //--------------------FORM---------------------------//

            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            //---------------------PANELS------------------------//

            //chargement
            chargement.BackgroundImage = Properties.Resources.Chargement_LapetiteBoite1;
            //accueil
            accueil.Top = 0;
            accueil.Left = 3;
            accueil.Width = 1283;
            accueil.Height = 722;
            accueil.BackgroundImage = Properties.Resources.accueil;

            //ecran nouveau joueur
            nouveauJoueur.Width = 1283;
            nouveauJoueur.Height = 722;
            nouveauJoueur.Top = 0;
            nouveauJoueur.Left = 0;
            nouveauJoueur.BackgroundImage = Properties.Resources.menu1; 

            //mini-panel choix avatar
            choixAvatar.Width = 900;
            choixAvatar.Height = 200;
            choixAvatar.Top = 40;
            choixAvatar.Left = 191;
            choixAvatar.BackColor = Color.Transparent;

            //mini panel saisie informations personnelles
            saisirInfos.Width = 500;
            saisirInfos.Height = 200;
            saisirInfos.Top = 300;
            saisirInfos.Left = 391;
            saisirInfos.BackColor = Color.Transparent;
            saisirInfos.BorderStyle = BorderStyle.FixedSingle;

           
            //diaporamaHistoire
            diaporamaHistoire.Top = 0;
            diaporamaHistoire.Left = 0;
            diaporamaHistoire.Width = 1283;
            diaporamaHistoire.Height = 722;
            diaporamaHistoire.BackgroundImage = Properties.Resources.presentationJeu;

            //carteJeu
            CarteJeu.Top = 0;
            CarteJeu.Name = "Carte";
            CarteJeu.Left = 0;
            CarteJeu.Width = 1283;
            CarteJeu.Height = 722;
            CarteJeu.BackgroundImage = Properties.Resources.map; 

            //ecran mini-jeu
            Jeu.Top = 0;
            Jeu.Left = 0;
            Jeu.Width = 1280;
            Jeu.Height = 722;
            Jeu.Name = "Jeu";
            Jeu.BorderStyle = BorderStyle.FixedSingle;

            //tabBord

            tabBord.Width = 150;
            tabBord.Height = 50;
            tabBord.Top = 650;
            tabBord.Left = 1100;
            tabBord.BackColor = Color.Transparent;

            //Cour du roi
            CourRoi = new Panel();
            CourRoi.Width = 1283;
            CourRoi.Height = 722;
            CourRoi.Location = new Point(0, 0);
            CourRoi.BackgroundImage = Properties.Resources.presentationJeu;

            //on ajoute les boutons au tableau de bord

            tabBord.Controls.Add(sauvegarde);
            tabBord.Controls.Add(quitterMiniJeu);
            tabBord.Controls.Add(guide);

            sauvegarde.Top = 0;
            sauvegarde.Left = 0;

            quitterMiniJeu.Top = 0;
            quitterMiniJeu.Left = 60;

            guide.Top = 0;
            guide.Left = 100;

            //conteneurEtoile

            ConteneurEtoile.Top = 20;
            ConteneurEtoile.Left = 220;
            ConteneurEtoile.Width = 900;
            ConteneurEtoile.Height = 100;
            ConteneurEtoile.BackColor = Color.Transparent;

            //objectifs

            objectif.Width = 80;
            objectif.Height = 200;
            objectif.Top = 250;
            objectif.Left = 10;
            objectif.BackColor = Color.Transparent;

            //miniJeu
            miniJeu.Top = 90;
            miniJeu.Left = 120;
            miniJeu.Width = 1200;
            miniJeu.Height = 700;
            miniJeu.BackColor = Color.Transparent;

            //------------------------IMAGES-------------------------------//

            //avatars

            imagePersonnage1.Name = "images/roi2.png";
            imagePersonnage1.Image = Image.FromFile(@imagePersonnage1.Name);
            imagePersonnage1.Left = 100;

            imagePersonnage2.Name = "images/roi3.png";
            imagePersonnage2.Image = Image.FromFile(@imagePersonnage2.Name);
            imagePersonnage2.Left = 300;

            imagePersonnage3.Name = "images/roi4.png";
            imagePersonnage3.Image = Image.FromFile(@imagePersonnage3.Name);
            imagePersonnage3.Left = 500;

            imagePersonnage4.Name = "images/guide_roi.png";
            imagePersonnage4.Image = Image.FromFile(@imagePersonnage4.Name);
            imagePersonnage4.Left = 700;
            
            listeAvatars = new PictureBox[] { imagePersonnage1, imagePersonnage2, imagePersonnage3, imagePersonnage4 };
            //on ajoute les images au panel choixAvatar

            for (int i = 0; i < listeAvatars.Length; i++)
            {
                listeAvatars[i].Click += new EventHandler(clickAvatar);
                choixAvatar.Controls.Add(listeAvatars[i]);
                listeAvatars[i].SizeMode = PictureBoxSizeMode.StretchImage;
                listeAvatars[i].BackColor = Color.Transparent;
                listeAvatars[i].Top = 50;
                listeAvatars[i].Width = 100;
                listeAvatars[i].Height = 130;
            }

            //guide
            guide.Width = 50;
            guide.Height = 50;
            guide.Image = Properties.Resources.guide;
            guide.SizeMode = PictureBoxSizeMode.StretchImage;
            guide.Click += new EventHandler(AfficheMessage);

            //coffre
            coffre.Width = 100;
            coffre.Height = 90;
            coffre.Top = 20;
            coffre.Left = 1150;
            coffre.Image = Properties.Resources.coffre;
            coffre.SizeMode = PictureBoxSizeMode.StretchImage;
            coffre.BackColor = Color.Transparent;

            //gros coffre pour la fin du jeu

            GrosCoffre = new PictureBox();
            GrosCoffre.Image = Properties.Resources.coffre;
            GrosCoffre.Location = new Point(800, 300);
            GrosCoffre.Size = new Size(300, 300);
            GrosCoffre.SizeMode = PictureBoxSizeMode.StretchImage;
            GrosCoffre.BackColor = Color.Transparent;

            //sauvegarde
            sauvegarde.BackColor = Color.Green;
            sauvegarde.Width = 34;
            sauvegarde.Height = 34;
            sauvegarde.Image = Properties.Resources.disquette1;
            sauvegarde.SizeMode = PictureBoxSizeMode.StretchImage;
            sauvegarde.BackColor = Color.Transparent;
            sauvegarde.Click += new EventHandler(sauvegardeButton);

            //quitterMiniJeu
            quitterMiniJeu.Name = "quitterMiniJeu";
            quitterMiniJeu.Width = 34;
            quitterMiniJeu.Height = 34;
            quitterMiniJeu.Image = Properties.Resources.exit1;
            quitterMiniJeu.SizeMode = PictureBoxSizeMode.StretchImage;
            quitterMiniJeu.BackColor = Color.Transparent;
            quitterMiniJeu.Click += new EventHandler(retourTabBord);

            //recompenses

            recompense1 = new PictureBox();
            recompense1.Name = "";
            recompense1.BackColor = Color.Transparent;
            recompense1.Width = 100;
            recompense1.Height = 100;
            recompense1.Location = new Point(100,100);
            recompense1.SizeMode = PictureBoxSizeMode.StretchImage;
            recompense1.Image = Properties.Resources.cabaneIcone;
            //recompense1.Click

            recompense2 = new PictureBox();
            recompense2.Name = "";
            recompense2.BackColor = Color.Transparent;
            recompense2.Width = 100;
            recompense2.Height = 100;
            recompense1.Location = new Point(300, 100);
            recompense2.SizeMode = PictureBoxSizeMode.StretchImage;
            recompense1.Image = Properties.Resources.chateauIcone;
            //recompense2.Click

            recompense3 = new PictureBox();
            recompense3.Name = "";
            recompense3.BackColor = Color.Transparent;
            recompense3.Width = 100;
            recompense3.Height = 100;
            recompense1.Location = new Point(600, 100);
            recompense3.SizeMode = PictureBoxSizeMode.StretchImage;
            recompense1.Image = Properties.Resources.etoileGrise1;
            //recompense3.Click


            //fichiers : ici il faut un test au cas ou la lecture de fichiers ne se fait pas

            //---------------------------------FICHIERS-------------------------------------//

            //on lit le fichier Joueurs et on cree une nouvelle instance Joueur avec les donnees trouvees
            joueursFichier = System.IO.File.ReadAllLines("Joueurs.txt");

            //on lit le fichier Sauvegarde et on le met dans un tableau
            listeSauvegarde = System.IO.File.ReadAllLines("dossiers_sauvegarde.txt");

            //--------------------------------BOUTONS----------------------------------------//

            //nouvelle partie
            nouvellePartie.Text = "Nouvelle partie";
            nouvellePartie.Width = 250;
            nouvellePartie.Height = 60;
            nouvellePartie.Top = 200;
            nouvellePartie.Left = 550;
            nouvellePartie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            nouvellePartie.FlatAppearance.BorderSize = 0;
            nouvellePartie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            nouvellePartie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            nouvellePartie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nouvellePartie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nouvellePartie.BackColor = Color.Transparent;
            nouvellePartie.Click += new EventHandler(nouvelle_partie_button);

            //chargerPartie
            chargerPartie.Text = "Charger partie";
            chargerPartie.Font = new Font(chargerPartie.Font.FontFamily, 15);
            chargerPartie.Width = 250;
            chargerPartie.Height = 60;
            chargerPartie.Top = 300;
            chargerPartie.Left = 550;
            chargerPartie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chargerPartie.FlatAppearance.BorderSize = 0;
            chargerPartie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            chargerPartie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chargerPartie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chargerPartie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            chargerPartie.BackColor = Color.Transparent;
            chargerPartie.Click += new EventHandler(charger_partie_button);

            //commencer
            commencer.Text = "Commencer";
            commencer.Top = 600;
            commencer.Left = 466;
            commencer.Width = 150;
            commencer.Height = 70;
            commencer.FlatAppearance.BorderSize = 0;
            commencer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            commencer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            commencer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            commencer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            commencer.Font = new Font(commencer.Font.FontFamily, 15);
            commencer.BackColor = Color.Transparent;
            commencer.Click += new EventHandler(commencer_button);

            //retour
            retour.Text = "Retour";
            retour.Top = 600;
            retour.Left = 666;
            retour.Width = 150;
            retour.Height = 70;
            retour.FlatAppearance.BorderSize = 0;
            retour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            retour.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            retour.BackColor = Color.Transparent;
            retour.Click += new EventHandler(retourButton);
            

            //afficherCarte
            AfficherCarte.Text = "Commencer le Jeu";
            AfficherCarte.Height = 70;
            AfficherCarte.Width = 200;
            AfficherCarte.Top = 600;
            AfficherCarte.Left = 100;
            AfficherCarte.FlatAppearance.BorderSize = 0;
            AfficherCarte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            AfficherCarte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AfficherCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AfficherCarte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            AfficherCarte.BackColor = Color.Transparent;
            AfficherCarte.Click += new EventHandler(afficherCarte);

            //quitter
            quitter.Text = "Quitter";
            quitter.Font = new Font(quitter.Font.FontFamily, 15);
            quitter.Top = 400;
            quitter.Left = 550;
            quitter.Width = 250;
            quitter.Height = 60;
            quitter.FlatAppearance.BorderSize = 0;
            quitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quitter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            quitter.BackColor = Color.Transparent;
            quitter.Click += new EventHandler(quitterPartie);
            

            Yes = new Button();
            Yes.Text = "Oui";
            Yes.Name = "Oui";
            Yes.Location = new Point(250, 650);
            Yes.Width = 250;
            Yes.Height = 60;
            Yes.FlatAppearance.BorderSize = 0;
            Yes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Yes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            Yes.BackColor = Color.Transparent;
            Yes.Click += new EventHandler(resultat);

            No = new Button();
            No.Text = "Non";
            No.Name = "Non";
            No.Location = new Point(600, 650);
            No.Width = 250;
            No.Height = 60;
            No.FlatAppearance.BorderSize = 0;
            No.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            No.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            No.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            No.BackColor = Color.Transparent;
            No.Click += new EventHandler(resultat);

            //-------------------------------CHAMPS------------------------------//

            //menu principal

            menuPrincipal.Text = "Menu Principal";
            menuPrincipal.Font = new Font(menuPrincipal.Font.FontFamily, 25);
            menuPrincipal.Top = 100;
            menuPrincipal.Left = 550;
            menuPrincipal.Width = 300;
            menuPrincipal.Height = 70;
            menuPrincipal.BackColor = Color.Transparent;
            menuPrincipal.ForeColor = Color.White;

            //dossier de sauvegarde

            dossierSauvegarde.Text = "Dossier de sauvegarde";
            dossierSauvegarde.ForeColor = Color.White;
            dossierSauvegarde.Font = new Font(dossierSauvegarde.Font.FontFamily, 14);
            dossierSauvegarde.Top = 140;
            dossierSauvegarde.Left = 30;
            dossierSauvegarde.Width = 220;
            dossierSauvegarde.Height = 25;

            //combobox dossier sauvegarde
            listeDossierSauvegarde.Top = 140;
            listeDossierSauvegarde.Left = 251;
            listeDossierSauvegarde.Width = 200;
            listeDossierSauvegarde.Height = 25;
            listeDossierSauvegarde.Font = new Font(listeDossierSauvegarde.Font.FontFamily, 14);
            listeDossierSauvegarde.SelectedIndexChanged += new EventHandler(afficherJoueursPossibles);

            //on link le tableau listeSauvegarde avec le combobox via une boucle
           
                for (int i = 0; i < listeSauvegarde.Length; i++)
                {
                    listeDossierSauvegarde.Items.Add(listeSauvegarde[i]);
                }

            //liste joueurs possibles selon le dossier de sauvegarde choisi
            joueursPossibles.Top = 150;
            joueursPossibles.Width = 200;
            joueursPossibles.Left = 200;
            joueursPossibles.Height = 100;

            //prenom
            prenomLabel.Text = "Prenom";
            prenomLabel.ForeColor = Color.White;
            prenomLabel.Font = new Font(prenomLabel.Font.FontFamily, 14);
            prenomLabel.Width = 150;
            prenomLabel.Height = 25;
            prenomLabel.Top = 30;
            prenomLabel.Left = 30;

            prenomField.Font = new Font (prenomField.Font.FontFamily, 14);
            prenomField.Width = 150;
            prenomField.Height = 25;
            prenomField.Top = 30;
            prenomField.Left = 170;
            prenomField.Text = null;

            //affichePrenomJoueur

            prenomJoueur.Top = 65;
            prenomJoueur.Left = 140;
            prenomJoueur.Width = 150;
            prenomJoueur.Height = 35;
            prenomJoueur.ForeColor = Color.White;
            prenomJoueur.Font = new Font(prenomJoueur.Font.FontFamily, 16);

            //age
            ageLabel.Text = "Age";
            ageLabel.ForeColor = Color.White;
            ageLabel.Font = new Font(ageLabel.Font.FontFamily, 14);
            ageLabel.Width = 150;
            ageLabel.Height = 25;
            ageLabel.Top = 70;
            ageLabel.Left = 30;

            
            ageField.Width = 150;
            ageField.Font = new Font(ageField.Font.FontFamily, 14);
            ageField.Height = 25;
            ageField.Top = 70;
            ageField.Left = 170;
            ageField.Text = null;

            //texte pour le diaporama

            textePresentationJeu.Width = 300;
            textePresentationJeu.Height = 400;
            textePresentationJeu.Top = 100;
            textePresentationJeu.Left = 50;
            textePresentationJeu.Font = new Font(textePresentationJeu.Font.FontFamily, 13);
            textePresentationJeu.ForeColor = Color.White;
            textePresentationJeu.BackColor = Color.Transparent;
            textePresentationJeu.TextAlign = ContentAlignment.MiddleCenter;
         

            MessageRoi = new Label();
            MessageRoi.Location = new Point(100, 500);
            MessageRoi.Width = 500;
            MessageRoi.Height = 100;
            MessageRoi.BackColor = Color.Transparent;
            MessageRoi.ForeColor = Color.Silver;
            MessageRoi.Font = new Font(MessageRoi.Font.FontFamily, 13);
            MessageRoi.Text = "est-ce que tu as vraiment recolter toutes les etoiles?";

            //elements de la carte


            Village.Click += new EventHandler(declencheTimer);
            Village.CursorChanged += new EventHandler(LanceMiniJeu);
            Village.MouseEnter += new EventHandler(changementImageLieu);
            Village.MouseLeave += new EventHandler(changementImageLieuOrigine);

            Montagne.Click += new EventHandler(declencheTimer);
            Montagne.CursorChanged += new EventHandler(LanceMiniJeu);
            Montagne.MouseEnter += new EventHandler(changementImageLieu);
            Montagne.MouseLeave += new EventHandler(changementImageLieuOrigine);

            Chateau.Click += new EventHandler(declencheTimer);
            Chateau.CursorChanged += new EventHandler(LanceMiniJeu);
            Chateau.MouseEnter += new EventHandler(changementImageLieu);
            Chateau.MouseLeave += new EventHandler(changementImageLieuOrigine);

            Tronc.Click += new EventHandler(declencheTimer);
            Tronc.CursorChanged += new EventHandler(LanceMiniJeu);
            Tronc.MouseEnter += new EventHandler(changementImageLieu);
            Tronc.MouseLeave += new EventHandler(changementImageLieuOrigine);

            Cabane.Click += new EventHandler(declencheTimer);
            Cabane.CursorChanged += new EventHandler(LanceMiniJeu);
            Cabane.MouseEnter += new EventHandler(changementImageLieu);
            Cabane.MouseLeave += new EventHandler(changementImageLieuOrigine);
            
            listeLieux = new Lieu[5];
            listeLieux[0] = Village;
            listeLieux[1] = Cabane;
            listeLieux[2] = Tronc;
            listeLieux[3] = Montagne;
            listeLieux[4] = Chateau;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 2;
            }

            if (progressBar1.Value == 100)
            {
                //on remove l-ecran chargement du form
                this.Controls.Remove(chargement);
                this.Update();
                //on affiche l-accueil
                this.Controls.Add(accueil);

                //on affiche les boutons a l-ecran accueil
                accueil.Controls.Add(menuPrincipal);
                accueil.Controls.Add(nouvellePartie);
                accueil.Controls.Add(chargerPartie);
                accueil.Controls.Add(quitter);

                //on arrete le timer
                timer1.Enabled = false;
            }
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

                for (int i = 0; i < joueursFichier.Length; i++)
                {
                    if (joueursFichier[i].Contains(dossier))
                    {
                        ligne = joueursFichier[i].Split('-');
                        joueursPossibles.Items.Add(ligne[0]);
                    }
                }

                //on affiche la liste que s-il y a des elements dans la liste joueurs possibles
                joueursPossibles.Visible = false;
                chargerJoueur.Controls.Add(joueursPossibles);

                if (joueursPossibles.Items.Count > 0)
                {
                    joueursPossibles.Visible = true;
                }
            }
        }

        private void nouvelle_partie_button(object sender, EventArgs e)
        {
            Label Titre = new Label();
            Titre.Text = "Choix du chevalier";
            Titre.Top = 5;
            Titre.Left = 300;
            Titre.Width = 300;
            Titre.Height = 70;
            Titre.Font = new Font(prenomField.Font.FontFamily, 25);
            Titre.ForeColor = Color.ForestGreen;
            Titre.BackColor = Color.Transparent;
            //on cache l/accueil
            this.Controls.Remove(accueil);

            //on definit la nouvelle page
            this.Controls.Add(nouveauJoueur);

            //on ajoute choixAvatar et saisirInfos au panneau nouveauJoueur
            choixAvatar.Controls.Add(Titre);
            nouveauJoueur.Controls.Add(choixAvatar);
            nouveauJoueur.Controls.Add(saisirInfos);
            
            //on ajoute les elements prenom et age au panneau saisirInfos
            saisirInfos.Controls.Add(prenomField);
            saisirInfos.Controls.Add(prenomLabel);
            saisirInfos.Controls.Add(ageField);
            saisirInfos.Controls.Add(ageLabel);
            saisirInfos.Controls.Add(dossierSauvegarde);
            saisirInfos.Controls.Add(listeDossierSauvegarde);

            //on ajoute les boutons commencer et retour au panneau nouveauJoueur
            nouveauJoueur.Controls.Add(commencer);
            nouveauJoueur.Controls.Add(retour);
            
        }

        private DialogResult afficheMessageBox(String titre, String message)
        {
           return MessageBox.Show(message, titre, MessageBoxButtons.OKCancel, MessageBoxIcon.None);
        }

        private void afficheInputBox()
        {
            //creation d-une nouvelle form InputBox

            var InputBox = new Form2();
            InputBox.ShowDialog();
        }

        private void clickAvatar(object sender, EventArgs e)
        {
            //on recupere l-objet 
            PictureBox ImgTemporaire = (PictureBox)sender;
            //on recupere l-image de l-avatar
            sauvegardeImgAvatar = ImgTemporaire.Name;

            for (int i = 0; i < listeAvatars.Length; i++)
            {
                //listeAvatars[i].BorderStyle = BorderStyle.None;
                listeAvatars[i].BackColor = Color.Transparent;
            }

            //on change le contour de l-image selectionne
            //ImgTemporaire.BorderStyle = BorderStyle.FixedSingle;
            ImgTemporaire.BackColor = Color.White;
        }

        private void charger_partie_button(object sender, EventArgs e)
        {
            var ChargeBox = new Charger();
            ChargeBox.ShowDialog();

            if (chargementReussi == true)
            {
                chevalier = new Joueur(nom, age, avatar, top, left, score, dos, epreuvesEmportees);
                Console.Write(chevalier.getNiveau());
                afficherDiaporama();
            }
            else
            {
                MessageBox.Show("Erreur","Erreur");
            }
        }

        private void retourButton(object sender, EventArgs e)
        {
            this.Controls.Remove(retour.Parent);
            this.Controls.Add(accueil);
        }

        private void commencer_button(object sender, EventArgs e)
        {
            //il faut donner un nouveau nom de dossier, 
            //l -enregistrer dans la liste fichiersSauvegarde
            //l-attribuer au perso

            if (listeDossierSauvegarde.SelectedIndex == 0)
            {
                afficheInputBox();
            }

            //traitement des informations manquantes
            if (prenomField.Text == null || ageField.Text == null || sauvegardeImgAvatar == null || listeDossierSauvegarde.SelectedIndex == -1)
            {
                List<String> valeursVides = new List<string>();

                if (prenomField.Text == "")
                {
                    valeursVides.Add("prenom");
                }
                if (ageField.Text == "")
                {
                    valeursVides.Add("age");
                }
                if (sauvegardeImgAvatar == null)
                {
                    valeursVides.Add("avatar");
                }
                if (listeDossierSauvegarde.SelectedIndex == -1)
                {
                    valeursVides.Add("dossier de sauvegarde");
                }
                Console.WriteLine(valeursVides.Count);

                //creation du message d-erreur
                String message = "Il manque les informations suivantes : ";

                foreach (String s in valeursVides)
                {
                    Console.WriteLine(s);
                    message = message + Environment.NewLine + s;
                }
                afficheMessageBox("Valeurs manquantes",message);

                valeursVides.Clear();
            }
            else
            {
                //les valeurs sont non nulles ou non vides mais il faut les valider
                bool existe = false;
                bool isNumerical;
                int ageJoueur;
                String top = Convert.ToString(0);
                String left = Convert.ToString(0);
                String etoile = Convert.ToString(0);


                //il faut s-avoir si un nouveau nom de dossier a ete donne ou s-il a ete choisi dans la liste existante
                if (dossier == "")
                {
                    dossier = Convert.ToString(listeDossierSauvegarde.SelectedItem);
                }

                //il faut s-assurer que le prenom n-existe pas dans la liste des joueurs
                for (int i = 0; i < joueursFichier.Length; i++)
                {
                    if (joueursFichier[i].Contains(prenomField.Text.ToLower()))
                    {
                        existe = true;
                    }
                }

                //il faut s-assurer que l-age est bien un entier
                isNumerical = int.TryParse(ageField.Text, out ageJoueur);

                //il faut communiquer avec l-utilisateur
                if (existe == true || isNumerical == false)
                {
                    if (existe == true)
                    {
                        String message = "Le personnage " + prenomField.Text.ToLower() + " existe deja." + Environment.NewLine + "Veuillez choisir un autre nom";
                        afficheMessageBox("Erreur",message);
                    }

                    if (isNumerical == false)
                    {
                        String message = "L'age doit etre un nombre entier";
                        afficheMessageBox("Erreur",message);
                    }
                }
                else
                {
                    int[] epreuves = { 0, 0, 0, 0 };
                    //apres toutes les verifications, on peut enregistrer le nouveau joueur
                    String enregistrementJoueur = prenomField.Text.ToLower() + "-" + ageJoueur + "-" + sauvegardeImgAvatar + "-" + top + "-" + left + "-" + etoile + "-" + dossier + "-" + epreuves[0] + "-" + epreuves[1] + "-" + epreuves[2] + "-" + epreuves[3];
                    System.IO.File.AppendAllText("Joueurs.txt", Environment.NewLine);
                    System.IO.File.AppendAllText("Joueurs.txt", enregistrementJoueur);

                    //il faut creer une nouvelle instance de joueur

                    chevalier = new Joueur(prenomField.Text, ageJoueur, sauvegardeImgAvatar, dossier, epreuves);
                    Console.WriteLine("Le dossier " + dossier + " a ete cree");
                    Console.Write(chevalier.getNiveau());
                    //on affiche le prelude
                    afficherDiaporama();
                }
        }
    }

        private void afficherDiaporama()
        {
            //il manque la planche avec le roi
            //on affiche le diaporama
            this.Controls.Remove(accueil);
            textePresentationJeu.Text = "Bienvenu à toi "+ chevalier.nomJoueur() + " , je suis le magicien, et je serai ton guide tout au long de ton périple. Bon courage!";
            this.Controls.Remove(nouveauJoueur);
            this.Controls.Remove(chargerJoueur);

            //on affiche le bouton afficherCarte
            diaporamaHistoire.Controls.Add(textePresentationJeu);
            diaporamaHistoire.Controls.Add(AfficherCarte);
            diaporamaHistoire.Controls.Add(suivant);

            this.Controls.Add(diaporamaHistoire);
            
        }

        private void afficherCarte(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            this.Controls.Remove(control.Parent);
            Carte();
        }

        private void declencheTimer(object sender, EventArgs e)
        {
            arrivee = (Lieu)sender;
            
            timer2.Enabled = true;
        }
       
        private void timerDeplacement(object sender, EventArgs e)
        {
            //le timer est deja declenche. a chaque tick, le perso bouge
            //on a le point de depart et le point d-arrivee. on fait d-abord bouger l-abscisse puis l-ordonnee
            
            while (imgChevalier.Left != arrivee.Left)
            {
                if (imgChevalier.Left < arrivee.Left)
                {
                    imgChevalier.Left+=1;
                    imgChevalier.Refresh();
                }
                else
                {
                    imgChevalier.Left-=1;
                    imgChevalier.Refresh();
                }
            }

            while (imgChevalier.Top != arrivee.Top)
            {
                if (imgChevalier.Top < arrivee.Top)
                {
                    imgChevalier.Top+=1;
                    imgChevalier.Refresh();
                }
                else
                {
                    imgChevalier.Top-=1;
                    imgChevalier.Refresh();
                }
            }
            imgChevalier.Refresh();

            //on desactive le timer
            timer2.Enabled = false;

            //on change le backcolor du label pour lancer le jeu
            chevalier.setJoueurTop(imgChevalier.Top);
            chevalier.setJoueurLeft(imgChevalier.Left);

            if (arrivee.Cursor == Cursors.Default)
            {
                arrivee.Cursor = Cursors.Hand;
            }
            else if (arrivee.Cursor == Cursors.Hand)
            {
                arrivee.Cursor = Cursors.Default;
            }
            
        }

        private void sauvegardeButton (object sender, EventArgs e)
        {
            sauvegardePartie();
        }

        private void sauvegardePartie()
        {
            //sauvegarde en pleine partie / enregistrement dans le tableau joueursFichier. l-enregistrement en dur se fera a la fermeture de l-application
            Boolean enregistrer = false;

            chevalier.setJoueurTop(imgChevalier.Top);
            chevalier.setJoueurLeft(imgChevalier.Left);
            String enregistrementJoueur = chevalier.nomJoueur() + "-" + chevalier.ageJoueur() + "-" + chevalier.avatarJoueur() + "-" + chevalier.topJoueur() + "-" + chevalier.leftJoueur() + "-" + chevalier.scoreJoueur() + "-" + chevalier.dossierJoueur() +"-" + chevalier.getEpreuvesGagnees(0) + "-" + chevalier.getEpreuvesGagnees(1) + "-" + chevalier.getEpreuvesGagnees(2) + "-" + chevalier.getEpreuvesGagnees(3);

            //on enregistre dans le tableau joueursFichiers les nouvelles valeurs pour le joueur actuel

            for (int i=0; i < joueursFichier.Length; i++)
            {
                if (joueursFichier[i].Contains(chevalier.nomJoueur()) && enregistrer == false)
                {
                    joueursFichier[i] = enregistrementJoueur;
                    enregistrer = true;
                }
            }

            //on signale au joueur que l-enregistrement a ete fait

            if (enregistrer == true)
            {
                afficheMessageBox("Sauvegarde", "Les donnees ont ete sauvegardees");
            }
            else
            {
                afficheMessageBox("Erreur", "Une erreur s-est produite, les donnees n-ont pas pu etre enregistrees");
            }
        }

        private void quitterPartie (object sender, EventArgs e)
        {
            //enregistrement en dur des donnees
            System.IO.File.WriteAllLines("Joueurs.txt", joueursFichier);

            //on quitte le jeu
            Application.Exit();
        }

        private void changementImageLieu (object sender, EventArgs e)
        {
            //on change l-image du lieu
            Panel p = (Panel)sender;
            nouvelleImageLieu(p);
        }

        private void changementImageLieuOrigine (object sender, EventArgs e)
        {
            //on change l-image du lieu
            Panel P = (Panel)sender;

            if (P.Name.Equals("Memory"))
            {
                P.BackgroundImage = Properties.Resources.villageIconeGris;
            }
            else if (P.Name.Equals("Chateau"))
            {
                P.BackgroundImage = Properties.Resources.chateauIconeGris;
            }
            else if (P.Name.Equals("Chasse aux mots"))
            {
                P.BackgroundImage = Properties.Resources.cabaneIconeGris;
            }
            else if (P.Name.Equals("Grand Ou Petit"))
            {
                P.BackgroundImage = Properties.Resources.troncIconeGris;
            }
            else
            {
                P.BackgroundImage = Properties.Resources.montagneIconeGris;
            }

            this.Update();
        }

        //MINI JEUX

        private void nouvelleImageLieu (Panel P)
        {
            if (P.Name.Equals("Memory"))
            {
                P.BackgroundImage = Properties.Resources.villageIcone;
            }
            else if (P.Name.Equals("Chateau"))
            {
                P.BackgroundImage = Properties.Resources.chateauIcone;
            }
            else if (P.Name.Equals("Chasse aux mots"))
            {
                P.BackgroundImage = Properties.Resources.cabaneIcone;
            }
            else if (P.Name.Equals("Grand Ou Petit"))
            {
                P.BackgroundImage = Properties.Resources.troncIcone;
            }
            else
            {
                P.BackgroundImage = Properties.Resources.montagneIcone;
            }

            this.Update();
        }

        private void afficheJeu (String nomJeu, Image img, Panel p)
        {
            
            //on met le bon fond d'ecran

            Jeu.BackgroundImage = img;

            titreJeu.Text = "Niveau 1 : " + nomJeu;
            titreJeu.Width = 300;
            titreJeu.Height = 30;
            titreJeu.ForeColor = Color.White;
            titreJeu.BackColor = Color.Transparent;
            titreJeu.Top = 120;
            titreJeu.Left = 550;
            titreJeu.Font = new Font(titreJeu.Font.FontFamily,16);

            //on ajoute le minijeu
            miniJeu.Controls.Add(p);

            Console.Write(miniJeu.Controls[0].ToString());
            if (chevalier.epreuvesJoueur().Contains(miniJeu.Controls[0]))
            {
                p.EnabledChanged += new EventHandler(finMiniJeu);
                
            }
            

            //position de l'avatar en haut a gauche  
            imgChevalier.Left = 20;
            imgChevalier.Top = 20;
            imgChevalier.BackColor = Color.Transparent;
            
                obj.Text = "Objectif";
                obj.ForeColor = Color.White;
                obj.BackColor = Color.Transparent;
                obj.Font = new Font(obj.Font.FontFamily, 12);
                obj.Width = 100;
                obj.Left = 20;
                obj.Top = 400;
                //on met le nom du joueur
                prenomJoueur.Text = chevalier.nomJoueur();
                prenomJoueur.BackColor = Color.Transparent;

            //on ajoute les etoiles au conteneurEtoiles

               ajoutEtoiles();
            

            if (chevalier.getEpreuvesGagnees(IndiceJeu) == 1)
                {
                    //epreuve remportee / alors il n'y a pas d'etoiles jaunes a remporter

                    //on ajoute les etoiles grises et le label Objectif au panel Objectif
                    
                    for (int i = 1; i < 4; i++)
                    {
                        int left = 30;
                        int top = i * 70;
                        objectif.Controls.Add(new Etoile(left,top, 2));
                    }
                }
                else
                {
                    //epreuve perdue ou premiere fois /il y a encore des etoiles a remporter

                    //on ajoute les etoiles jaunes

                    for (int i = 0; i < 3; i++)
                    {
                        int left = 30;
                        int top = i * 70;
                    objectif.Controls.Add(new Etoile(left, top, 1));
                    }
                }

                 objectif.Controls.Add(obj);

                 //on ajoute tous les composants dans le panel
                Jeu.Controls.Add(tabBord);
                Jeu.Controls.Add(objectif);
                Jeu.Controls.Add(ConteneurEtoile);
                Jeu.Controls.Add(coffre);
                Jeu.Controls.Add(imgChevalier);
                Jeu.Controls.Add(prenomJoueur);
                Jeu.Controls.Add(titreJeu);
                Jeu.Controls.Add(miniJeu);
                this.Controls.Add(Jeu);
        }

        private void LanceMiniJeu(object sender, EventArgs e)
        {

            Lieu l = (Lieu)sender;
            this.Controls.Remove(CarteJeu);
            Image img;

            List<Panel> epreuvesO = chevalier.epreuvesJoueur();

            jeuEnCours = l.Name;
            if (l.Name == "Chasse aux mots")
            {
                //la chasse aux mots se deroule dans la montagne
                img = Properties.Resources.montagne1;
                IndiceJeu = 1;
                afficheJeu(l.Name, img, epreuvesO.ElementAt(IndiceJeu));
            }
            else if (l.Name == "Grand Ou Petit")
            {
                //grand ou petit se deroule dans une clairiere
                img = Properties.Resources.clairiere1;
                IndiceJeu = 2;
                afficheJeu(l.Name, img, epreuvesO.ElementAt(IndiceJeu));


            }
            else if (l.Name == "Que fait le Roi?")
            {
                //que fait le roi se deroule a cote de la riviere
                img = Properties.Resources.riviere1;
                IndiceJeu = 3;
                afficheJeu(l.Name, img, epreuvesO.ElementAt(IndiceJeu));
            }
            else if (l.Name == "Memory") 
            {
                img = Properties.Resources.village1;
                IndiceJeu = 0;
                afficheJeu(l.Name, img, epreuvesO.ElementAt(IndiceJeu));
            }
            else
            {
                devoileCoffre();
            }
        }

        private void Carte ()
        {
            //on mettra tout le contenu de CarteJeu
            
            this.Controls.Add(CarteJeu);

            //on initialise les elements de la carte : avatar, magicien, chateau, prochaine etoile,
            imgChevalier.Image = Image.FromFile(@chevalier.avatarJoueur());
            imgChevalier.SizeMode = PictureBoxSizeMode.StretchImage;
            imgChevalier.Width = 100;
            imgChevalier.Height = 130;
            imgChevalier.BackColor = Color.Transparent;

            //position  
            imgChevalier.Left = chevalier.leftJoueur();
            imgChevalier.Top = chevalier.topJoueur();

            //on affiche les elements du jeu
            CarteJeu.Controls.Add(imgChevalier);
            CarteJeu.Controls.Add(Village);
            CarteJeu.Controls.Add(Montagne);
            CarteJeu.Controls.Add(Tronc);
            CarteJeu.Controls.Add(Cabane);
            CarteJeu.Controls.Add(Chateau);
            CarteJeu.Controls.Add(tabBord);
        }

        private void retourTabBord (object sender, EventArgs e)
        {
            Control source = (Control)sender;
            Control parent = source.Parent;

            if (parent.Parent == Jeu)
            {
                miniJeu.Controls.Clear();
                this.Controls.Remove(Jeu);
                Carte();
            }
            else if (parent.Parent == CarteJeu)
            {
                DialogResult res = afficheMessageBox("Attention","Tu es sur le point de quitter la partie. Souhaites-tu sauvegarder tes donnees? Appuies sur Annuler pour revenir sur la carte.");
               
                if (res != DialogResult.Cancel)
                {
                   
                    if (res == DialogResult.Yes)
                    {
                        //il faut sauvegarder
                        sauvegardePartie();
                    }

                    //on remove l-ecran chargement du form
                    this.Controls.Remove(CarteJeu);

                    //on affiche l-accueil
                    this.Controls.Add(accueil);

                    //on affiche les boutons a l-ecran accueil
                    accueil.Controls.Add(menuPrincipal);
                    accueil.Controls.Add(nouvellePartie);
                    accueil.Controls.Add(chargerPartie);
                    accueil.Controls.Add(quitter);

                }
            }
        }

        public void finMiniJeu(object sender, EventArgs e)
        {
            Console.Write("Je suis passee par la");
            Panel p = (Panel)sender;
            //on enregistre les etoiles si l-epreuve est obligatoire et s-il n-ajamais remporte l-epreuve

            if (p.Enabled == false)
            {

                if (chevalier.getEpreuvesGagnees(IndiceJeu) == 0)
                {
                    //on passe l-indice du jeu a 1

                    chevalier.setEpreuvesRemportees(IndiceJeu);

                    //on met toutes les etoiles jaunes du panel Objectif en gris

                    objectif.Controls.Clear();
                    objectif.Controls.Add(obj);

                    for (int i = 0; i < 3; i++)
                    {
                        int left = 30;
                        int top = i * 70;
                        objectif.Controls.Add(new Etoile(left, top, 2));
                    }

                    //on enregistre le nouveau score
                    chevalier.setJoueurScore(3);

                    //on met les etoiles dans conteneurEtoiles

                    ajoutEtoiles();

                }
                //on demande au joueur s-il veut jouer au niveau suivant mais pas d-etoiles a gagner supp. c-est juste pour savoir s-il a assimile

                DialogResult reponse = MessageBox.Show("Veux-tu jouer au niveau suivant?", "Niveau suivant", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (reponse == DialogResult.Yes)
                {
                    lanceNiveauSuperieur();
                }
                else
                {
                    miniJeu.Controls.Clear();
                    this.Controls.Remove(Jeu);
                    Carte();
                }
            }
        }

        public void finMiniJeuFacultatif(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            if (p.Enabled == false)
            {
                Console.Write("Je viens de terminer un jeu facultatif");

                MessageBox.Show("Vous avez termine cette quete", "Quete terminee", MessageBoxButtons.OK, MessageBoxIcon.None);

                //ici il faudra mettre l-image du lieu en couleur de maniere definitive
                nouvelleImageLieu(listeLieux[IndiceJeu]);

                //remove le mouseHover et le mouseSortie
                listeLieux[IndiceJeu].MouseHover -= changementImageLieu;
                listeLieux[IndiceJeu].MouseLeave -= changementImageLieuOrigine;
            }
        }

        public void lanceNiveauSuperieur ()
        {
            titreJeu.Text = "Niveau 2 : " + jeuEnCours;
            miniJeu.Controls.Clear();
            chevalier.epreuvesFacultatives().ElementAt(IndiceJeu).EnabledChanged += new EventHandler(finMiniJeuFacultatif);
            miniJeu.Controls.Add(chevalier.epreuvesFacultatives().ElementAt(IndiceJeu));
        }

        public void ajoutEtoiles ()
        {
            //on met les etoiles dans conteneurEtoiles - a factoriser

            ConteneurEtoile.Controls.Clear();
            //etoiles jaunes

            if (chevalier.scoreJoueur() != 0)
            {
                for (int i = 0; i < chevalier.scoreJoueur(); i++)
                {
                    int left = i * 70;

                    ConteneurEtoile.Controls.Add(new Etoile(left, 1));
                }
            }

            //etoiles grises
            for (int i = chevalier.scoreJoueur(); i < 12; i++)
            {
                int left = i * 70;

                ConteneurEtoile.Controls.Add(new Etoile(left, 2));
            }
        }

        public void ConseilsGuide()
        {
            if (guide.Parent.Parent.Name.Equals("Carte"))
            {
                message = "Clique sur un des lieux grises pour te deplacer sur la carte et acceder aux jeux";
            }
            else if (guide.Parent.Parent.Name.Equals("Jeu"))
            {
                if (jeuEnCours == "Memory")
                {
                    message = "Clique sur une 1ère carte et puis sur une 2ème. Si tu entends et vois la même chose, c'est gagné ! Arriveras-tu à retourner toutes les cartes ?";
                }
                else if (jeuEnCours == "Chasse aux mots")
                {
                    message = "Écoute bien et retrouve la bonne image.";
                }
                else if (jeuEnCours == "Que fait le Roi?")
                {
                    message = "Clique sur un bouton et écoute la phrase. Retrouve l'image qui correspond. Aide toi des indices en cliquant sur les images.";
                }
                else if (jeuEnCours == "Grand ou Petit")
                {
                    message = "Choisis et clique sur une carte de la 1ère ligne et écoute bien. Retrouve la même image mais en plus petit dans la dernière ligne. Glisse la sous la grande image.";
                }
            }
        }

        public void AfficheMessage(object sender, EventArgs e)
        {
            ConseilsGuide();
            MessageBox.Show(message, "Aide La Petite Boite", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        public void devoileCoffre ()
        {
            this.Controls.Remove(CarteJeu);

            CourRoi.Controls.Add(MessageRoi);
            CourRoi.Controls.Add(Yes);
            CourRoi.Controls.Add(No);
            CourRoi.Controls.Add(GrosCoffre);
            this.Controls.Add(CourRoi);
            
        }

        public void resultat(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Name.Equals("Oui") && chevalier.scoreJoueur() == 12)
            {
                MessageBox.Show("Tu as su mener à bien toutes les quêtes chevalier/chevalière ! Regardons maintenant ce qu'il y a dans la boite ! Clique sur le coffre pour devoiler son contenu", "Felicitations", MessageBoxButtons.OK, MessageBoxIcon.None);
                coffre.Click += new EventHandler(afficheRecompense);
            }
            else
            {
                MessageBox.Show("Le nombre d'etoiles en votre possesion ne vous permet pas d'ouvrir le coffre", "Attention", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        public void afficheRecompense(object sender, EventArgs e)
        {
            this.Controls.Remove(CourRoi);
            this.Controls.Add(Recompense);

            Recompense.Width = 1280;
            Recompense.Height = 722;
            Recompense.Location = new Point(0, 0);
            Recompense.BackColor = Color.AliceBlue;
            Recompense.Controls.Add(recompense1);
            Recompense.Controls.Add(recompense2);
            Recompense.Controls.Add(recompense2);

            //sur cette page, on a trois picturebox avec les liens vers les recompenses (video, coloriages, etc
        }
    }
}
