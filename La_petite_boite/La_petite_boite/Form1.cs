using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Drawing.Text;

//reste a faire:  design,

namespace La_petite_boite
    //il faut regler bug affichage images, ajouter les recompenses et diapo roi.
{
   
    public partial class Form1 : Form
    {
        Assembly _assembly = Assembly.GetExecutingAssembly();
        Stream _imageStream;

        //creation des objets et variables globales
        public static Boolean chargementReussi = false;
        public static int age;
        public static int top;
        public static int left;
        public static int score = 0;
        public static int[] epreuvesEmportees = new int[4];
        public Joueur chevalier;
        public static Label obj = new Label();
        public static String resultatJeu;
        public static Panel objectif = new Panel();
        public static List <String> joueursFichier = new List<string>();
        public static List <String> listeSauvegarde = new List<string>();
        public static Panel chargerJoueur = new Panel();
        public static Panel ConteneurEtoile = new Panel();
        public static Panel conteneurEtoilesCoffre = new Panel();
        public static String dossier = "";
        public static String nom;
        public static String avatar;
        public static String dos;
        public int IndiceJeu = 0;
        public List<Jeu.Jeu> epreuvesO;
        public static Label titreJeu = new Label();
        public static Lieu positionInitiale = new Lieu();
        public static String lieuTemporaire;
        public static PrivateFontCollection privateFontCollection;
        public Form tuto;

        SpecialButton nouvellePartie = new SpecialButton();
        SpecialButton chargerPartie = new SpecialButton();
        SpecialButton quitter = new SpecialButton();
        ControlButton commencer = new ControlButton();
        ControlButton retour = new ControlButton();
        LittleButton pret = new LittleButton(600);
        LittleButton suivant = new LittleButton(600);
        LittleButton precedent = new LittleButton(600);
        LittleButton AfficherCarte = new LittleButton(600);
        Button Yes;
        Button No;
        ComboBox listeDossierSauvegarde = new ComboBox();
        int compteurClickAvatar = 0;
        Lieu Village = new Lieu(512, -28, 448, 270, "villagePrevious.png", "villageAfter.png", "villageFin.png", "mapVillage.png", new Point(140, 520), "Memory"); //MEMORY
        Lieu Chateau = new Lieu(126, 1026, 327, 404, "chateauPrevious.png", "chateauAfter.png", "chateauFin.png", "mapChateau.png", new Point(1130, 380),"Chateau");//CHATEAU
        Lieu Cabane = new Lieu(437, 775, 213, 192, "cabanePrevious.png", "cabaneAfter.png", "cabaneFin.png", "mapCabane.png", new Point(830, 520), "Chasse aux mots");//CHASSE AUX MOTS
        Lieu Tronc = new Lieu(104, 620, 177, 196, "troncPrevious.png", "troncAfter.png", "troncFin.png", "mapTronc.png", new Point(650, 186), "Grand Ou Petit");//GRAND OU PETIT
        Lieu Montagne = new Lieu(1, 1, 378, 196, "montagnePrevious.png", "montagneAfter.png", "montagneFin.png", "mapMontagne.png", new Point(140, 156),"Que fait le Roi?");//QUE FAIT LE ROI
        Lieu arrivee = new Lieu();
        SpecialLabel menuPrincipal = new SpecialLabel();
        SpecialLabel Titre = new SpecialLabel();
        Label prenomLabel = new Label();
        Label ageLabel = new Label();
        Label dossierSauvegarde = new Label();
        Label prenomJoueur = new Label();
        SpecialLabel textePresentationJeu = new SpecialLabel();
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
        Panel CourRoi;
        Panel Recompense = new recompense();
        PictureBox imgChevalier = new PictureBox();
        PictureBox imagePersonnage1 = new PictureBox();
        PictureBox imagePersonnage2 = new PictureBox();
        PictureBox imagePersonnage3 = new PictureBox();
        PictureBox imagePersonnage4 = new PictureBox();
        PictureBox guide = new PictureBox();
        PictureBox coffre = new PictureBox();
        PictureBox sauvegarde = new PictureBox();
        PictureBox quitterMiniJeu = new PictureBox();
        PictureBox[] listeAvatars;
        String sauvegardeImgAvatar = null;
        String jeuEnCours = "";
        String message ="";
        TextBox prenomField = new TextBox();
        TextBox ageField = new TextBox();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            //EMBED FONTS
            chargementFont();
            generationElements();
        }

        private void generationElements()
        {
            //---------------------PANELS------------------------//


            //chargement
            chargementImage("chargement.png", chargement);

            //accueil
            chargementImage("accueil.png", accueil);
            accueil.Location = new Point(-6, -2);
            accueil.Width = 1400;
            accueil.Height = 770;

            //ecran nouveau joueur
            chargementImage("menu.png", nouveauJoueur);
            nouveauJoueur.Width = 1400;
            nouveauJoueur.Height = 770;
            nouveauJoueur.Location = new Point(-6, -2);


            //diaporamaHistoire
            chargementImage("diapoTrone1.png", diaporamaHistoire);
            diaporamaHistoire.Location = new Point(-6, -2);
            diaporamaHistoire.Width = 1400;
            diaporamaHistoire.Height = 770;
            
            //carteJeu
            chargementImage("mapDebut2.png", CarteJeu);
            CarteJeu.Name = "Carte";
            CarteJeu.Location = new Point(0, 0);
            CarteJeu.Width = 1400;
            CarteJeu.Height = 770;

            //Cour du roi
            CourRoi = new Panel();
            chargementImage("diapoTrone1.png", CourRoi);
            CourRoi.Width = 1400;
            CourRoi.Height = 722;
            CourRoi.Location = new Point(-6, -2);
            
            //ecran mini-jeu
            Jeu.Location = new Point(-6, -2);
            Jeu.Width = 1400;
            Jeu.Height = 770;
            Jeu.Name = "Jeu";
            Jeu.BorderStyle = BorderStyle.FixedSingle;

            //--------------------MINI PANELS-------------------------------//
            
            //mini-panel choix avatar
            choixAvatar.Width = 700;
            choixAvatar.Height = 150;
            choixAvatar.Location = new Point(350, 165);
            choixAvatar.Anchor = AnchorStyles.None;
            choixAvatar.BackColor = Color.Transparent;

            //mini panel saisie informations personnelles
            saisirInfos.Width = 500;
            saisirInfos.Height = 250;
            saisirInfos.Top = 340;
            saisirInfos.Left = 450;
            saisirInfos.BackColor = Color.Transparent;
            saisirInfos.BorderStyle = BorderStyle.FixedSingle;

            //tabBord

            tabBord.Width = 200;
            tabBord.Height = 100;
            tabBord.Top = 680;
            tabBord.Left = 1190;
            tabBord.BackColor = Color.Transparent;

            //on ajoute les boutons au tableau de bord

            tabBord.Controls.Add(sauvegarde);
            tabBord.Controls.Add(quitterMiniJeu);
            tabBord.Controls.Add(guide);

            sauvegarde.Top = 8;
            sauvegarde.Left = 0;

            quitterMiniJeu.Top = 8;
            quitterMiniJeu.Left = 80;

            guide.Top = 0;
            guide.Left = 140;

            //conteneurEtoilesCoffre

            conteneurEtoilesCoffre.Top = -5;
            conteneurEtoilesCoffre.Left = 390;
            conteneurEtoilesCoffre.Width = 1000;
            conteneurEtoilesCoffre.Height = 100;
            conteneurEtoilesCoffre.BackColor = Color.Transparent;

            //conteneurEtoile

            ConteneurEtoile.Top = 5;
            ConteneurEtoile.Left = 20;
            ConteneurEtoile.Width = 860;
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
            miniJeu.Left = 100;
            miniJeu.Width = 1274;
            miniJeu.Height = 700;
            miniJeu.BackColor = Color.Transparent;

            //------------------------IMAGES-------------------------------//

            //avatars
            chargementImage("chevalier1.png", imagePersonnage1);
            imagePersonnage1.Name = "chevalier1.png";
            imagePersonnage1.Left = 0;

            chargementImage("chevalier2.png", imagePersonnage2);
            imagePersonnage2.Name = "chevalier2.png";
            imagePersonnage2.Left = 200;

            chargementImage("chevalier3.png", imagePersonnage3);
            imagePersonnage3.Name = "chevalier3.png";
            imagePersonnage3.Left = 400;

            chargementImage("chevalier4.png", imagePersonnage4);
            imagePersonnage4.Name = "chevalier4.png";
            imagePersonnage4.Left = 600;

            listeAvatars = new PictureBox[] { imagePersonnage1, imagePersonnage2, imagePersonnage3, imagePersonnage4 };
            //on ajoute les images au panel choixAvatar

            for (int i = 0; i < listeAvatars.Length; i++)
            {
                listeAvatars[i].Click += new EventHandler(clickAvatar);
                choixAvatar.Controls.Add(listeAvatars[i]);
                listeAvatars[i].SizeMode = PictureBoxSizeMode.StretchImage;
                listeAvatars[i].BackColor = Color.Transparent;
                listeAvatars[i].Top = 0;
                listeAvatars[i].Width = 100;
                listeAvatars[i].Height = 130;
            }

            //imgChevalier
            imgChevalier.SizeMode = PictureBoxSizeMode.StretchImage;
            imgChevalier.Width = 100;
            imgChevalier.Height = 130;
            imgChevalier.BackColor = Color.Transparent;

            //guide
            chargementImage("question.png", guide);
            guide.Width = 50;
            guide.Height = 50;
            guide.SizeMode = PictureBoxSizeMode.StretchImage;
            guide.Click += new EventHandler(AfficheMessage);

            //coffre
            chargementImage("coffre.png", coffre);
            coffre.Width = 100;
            coffre.Height = 90;
            coffre.Top = 5;
            coffre.Left = 890;
            coffre.SizeMode = PictureBoxSizeMode.StretchImage;
            coffre.BackColor = Color.Transparent;


            //sauvegarde
            chargementImage("disquette.png", sauvegarde);
            sauvegarde.BackColor = Color.Green;
            sauvegarde.Width = 34;
            sauvegarde.Height = 34;
            sauvegarde.SizeMode = PictureBoxSizeMode.StretchImage;
            sauvegarde.BackColor = Color.Transparent;
            sauvegarde.Click += new EventHandler(sauvegardeButton);

            //quitterMiniJeu
            chargementImage("exit.png", quitterMiniJeu);
            quitterMiniJeu.Name = "quitterMiniJeu";
            quitterMiniJeu.Width = 34;
            quitterMiniJeu.Height = 34;
            quitterMiniJeu.SizeMode = PictureBoxSizeMode.StretchImage;
            quitterMiniJeu.BackColor = Color.Transparent;
            quitterMiniJeu.Click += new EventHandler(retourTabBord);
            

            //---------------------------------FICHIERS-------------------------------------//

            //on lit le fichier Joueurs et on cree une nouvelle instance Joueur avec les donnees trouvees

            chargementTexte("La_petite_boite.Resources.Joueurs.txt", joueursFichier);

            //on lit le fichier Sauvegarde et on le met dans un tableau

            chargementTexte("La_petite_boite.Resources.dossiers_sauvegarde.txt", listeSauvegarde);

            //--------------------------------BOUTONS----------------------------------------//

            //nouvelle partie
            nouvellePartie.Text = "Nouvelle Partie";
            nouvellePartie.Top = 265;
            nouvellePartie.Click += new EventHandler(nouvelle_partie_button);
            nouvellePartie.Font = new Font(privateFontCollection.Families[0], 40);

            //chargerPartie
            chargerPartie.Text = "Charger Partie";
            chargerPartie.Top = 365;
            chargerPartie.Click += new EventHandler(charger_partie_button);
            chargerPartie.Font = new Font(privateFontCollection.Families[0], 40);

            //quitter
            quitter.Text = "Quitter";
            quitter.Top = 630;
            quitter.Click += new EventHandler(quitterPartie);
            quitter.Font = new Font(privateFontCollection.Families[0], 40);

            //commencer
            commencer.Text = "Commencer";
            commencer.Left = 525;
            commencer.Font = new Font(Form1.privateFontCollection.Families[0], 20);
            commencer.Click += new EventHandler(commencer_button);

            //retour
            retour.Text = "Retour";
            retour.Left = 725;
            retour.Font = new Font(Form1.privateFontCollection.Families[0], 20);
            retour.Click += new EventHandler(retourButton);
            
       
            //Pret button
            pret.Text = "Pret";
            pret.Left = 600;
            pret.Height = 90;
            pret.Width = 200;
            pret.Font = new Font(privateFontCollection.Families[0], 40);
            pret.Click += new EventHandler(ReadyButton);

            //suivant
            suivant.Text = "Suivant";
            suivant.Height = 90;
            suivant.Width = 250;
            suivant.Left = 800;
            suivant.Font = new Font(privateFontCollection.Families[0], 30);
            suivant.Click += new EventHandler(afficherDiapoSuivant);

            //precedent
            precedent.Text = "Precedent";
            precedent.Height = 90;
            precedent.Width = 300;
            precedent.Left = 350;
            precedent.Font = new Font(privateFontCollection.Families[0], 30);
            precedent.Click += new EventHandler(afficherDiapoPrecedente);

            //afficherCarte
            AfficherCarte.Text = "Commencer le Jeu";
            AfficherCarte.Height = 90;
            AfficherCarte.Width = 400;
            AfficherCarte.Left = 800;
            AfficherCarte.Font = new Font(privateFontCollection.Families[0], 30);
            AfficherCarte.Click += new EventHandler(afficherCarte);


            Yes = new Button();
            Yes.Text = "Oui";
            Yes.Name = "Oui";
            Yes.Location = new Point(250, 700);
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
            No.Location = new Point(600, 700);
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
            menuPrincipal.Top = 10;
            menuPrincipal.Left = 0;
            menuPrincipal.Width = 1400;
            menuPrincipal.Height = 200;
            menuPrincipal.Font = new Font(privateFontCollection.Families[0], 65);
            menuPrincipal.ForeColor = ColorTranslator.FromHtml("#18518c");
            menuPrincipal.BackColor = Color.Transparent;


            //Titre pour le panneau nouveau personnage
            Titre.Text = "Choix du chevalier";
            Titre.Top = 45;
            Titre.Width = 1400;
            Titre.Height = 100;
            Titre.Font = new Font(privateFontCollection.Families[0], 60);
            Titre.ForeColor = ColorTranslator.FromHtml("#6d5622");
            Titre.BackColor = Color.Transparent;

            //dossier de sauvegarde

            dossierSauvegarde.Text = "Dossier de sauvegarde";
            dossierSauvegarde.ForeColor = Color.White;
            dossierSauvegarde.Font = new Font(dossierSauvegarde.Font.FontFamily, 14);
            dossierSauvegarde.Top = 140;
            dossierSauvegarde.Left = 150;
            dossierSauvegarde.Width = 220;
            dossierSauvegarde.Height = 25;

            //combobox dossier sauvegarde
            listeDossierSauvegarde.Top = 180;
            listeDossierSauvegarde.Left = 125;
            listeDossierSauvegarde.Width = 250;
            listeDossierSauvegarde.Height = 25;
            listeDossierSauvegarde.Font = new Font(listeDossierSauvegarde.Font.FontFamily, 14);
            listeDossierSauvegarde.SelectedIndexChanged += new EventHandler(afficherJoueursPossibles);

            //on link le tableau listeSauvegarde avec le combobox via une boucle

            for (int i = 0; i < listeSauvegarde.Count(); i++)
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
            prenomLabel.Width = 100;
            prenomLabel.Height = 25;
            prenomLabel.Top = 30;
            prenomLabel.Left = 30;

            prenomField.Font = new Font(prenomField.Font.FontFamily, 14);
            prenomField.Width = 190;
            prenomField.Height = 25;
            prenomField.Top = 30;
            prenomField.Left = 150;
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
            ageLabel.Width = 100;
            ageLabel.Height = 25;
            ageLabel.Top = 70;
            ageLabel.Left = 30;
            
            ageField.Width = 190;
            ageField.Font = new Font(ageField.Font.FontFamily, 14);
            ageField.Height = 25;
            ageField.Top = 70;
            ageField.Left = 150;
            ageField.Text = null;

            //texte pour le diaporama

            textePresentationJeu.Width = 950;
            textePresentationJeu.Height = 80;
            textePresentationJeu.Top = 540;
            textePresentationJeu.Left = 210; 
            textePresentationJeu.Font = new Font(privateFontCollection.Families[0], 21);
            textePresentationJeu.ForeColor = ColorTranslator.FromHtml("#f2f2f2");
            textePresentationJeu.BackColor = Color.Transparent;
            textePresentationJeu.TextAlign = ContentAlignment.TopLeft;


            MessageRoi = new Label();
            MessageRoi.Location = new Point(100, 500);
            MessageRoi.Width = 500;
            MessageRoi.Height = 100;
            MessageRoi.BackColor = Color.Transparent;
            MessageRoi.ForeColor = Color.Silver;
            MessageRoi.Font = new Font(MessageRoi.Font.FontFamily, 13);
            MessageRoi.Text = "est-ce que tu as vraiment recolter toutes les etoiles?";

            //titre pour le mini jeu

            titreJeu.Width = 300;
            titreJeu.Height = 30;
            titreJeu.ForeColor = Color.White;
            titreJeu.BackColor = Color.Transparent;
            titreJeu.Top = 120;
            titreJeu.Left = 600;
            titreJeu.Font = new Font(titreJeu.Font.FontFamily, 16);

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
        
        public void chargementFont()
        {
            Stream fontStream;

            // specify embedded resource name
            string resource = "La_petite_boite.Resources.Jeu.maturafont.TTF";

            //access resource
            try
            {
                // receive resource stream
                fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource);
                Console.WriteLine("Chargement reussi");

                // create an unsafe memory block for the font data
                IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);

                // create a buffer to read in to
                byte[] fontdata = new byte[fontStream.Length];

                // read the font data from the resource
                fontStream.Read(fontdata, 0, (int)fontStream.Length);

                // copy the bytes to the unsafe memory block
                Marshal.Copy(fontdata, 0, data, (int)fontStream.Length);

                // pass the font to the font collection
                privateFontCollection = new PrivateFontCollection();
                privateFontCollection.AddMemoryFont(data, (int)fontStream.Length);

                // close the resource stream
                fontStream.Close();

                // free up the unsafe memory
                Marshal.FreeCoTaskMem(data);
            }
            catch (ArgumentException t)
            {
                Console.WriteLine("Error accessing fontfile!" + t);
            }
        }

        private void chargementImage (String res, Panel pan)
        {
            //access resource
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("La_petite_boite.Resources.Jeu." + res);
                pan.Name = res;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error accessing resources!" + e);
            }

            //display image
            try
            {
                pan.BackgroundImage = new Bitmap(_imageStream);
            }
            catch (Exception e)
            {
                Console.WriteLine("Can't create image!" + e);
            }
        }

        private void chargementImage(String res, PictureBox p)
        {
            //access resource
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("La_petite_boite.Resources.Jeu." + res);
                p.Name = res;
            }
            catch
            {
                Console.WriteLine("Error accessing resources!");
            }

            //display image
            try
            {
                p.Image = new Bitmap(_imageStream);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cant create image for picturebox!" + e);
            }
        }

        private void chargementTexte (String nomFichier, List<String> tableauRes)
        {
            try
            {
                using (StreamReader reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(nomFichier)))
                {
                    String line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        tableauRes.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write("Le fichier n'a pas pu etre lu" + e);
            }
        }

        private void enregistrementFichier (String fichier)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Assembly.GetExecutingAssembly().GetManifestResourceStream(fichier)))
                {
                    foreach (String s in joueursFichier)
                    {
                        writer.WriteLine(s);
                    }
                }
            }
            catch
            {
                Console.Write("Erreur lors de l-ecriture du fichier");
            }
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

                for (int i = 0; i < joueursFichier.Count(); i++)
                {
                    if (joueursFichier.ElementAt(i).Contains(dossier))
                    {
                        ligne = joueursFichier.ElementAt(i).Split('-');
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
            //on cache l/accueil
            this.Controls.Remove(accueil);

            //on definit la nouvelle page
            this.Controls.Add(nouveauJoueur);

            //on ajoute choixAvatar et saisirInfos au panneau nouveauJoueur
            nouveauJoueur.Controls.Add(Titre);
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

            if (compteurClickAvatar != 0)
            {
                //on remet les couleurs de l-image selectionnee
                chargementImage(ImgTemporaire.Name, ImgTemporaire);
            }
            
            String nomImageGrise = "";

            //on sauvegarde le nom de l-avatar
            sauvegardeImgAvatar = ImgTemporaire.Name;

            //on change les images des autres avatars
            for (int i = 0; i < listeAvatars.Length; i++)
            {
                //si ce n-est pas l-avatar
                if (listeAvatars[i].Name.Equals(sauvegardeImgAvatar) == false)
                {
                    //on grise l-image
                    nomImageGrise = listeAvatars[i].Name.Substring(0,10);
                    nomImageGrise = nomImageGrise + "gris.png";
                    chargementImage(nomImageGrise, listeAvatars[i]);
                }
            }
            compteurClickAvatar++;
        }

        private void charger_partie_button(object sender, EventArgs e)
        {
            int i;
            var ChargeBox = new Charger();
            ChargeBox.ShowDialog();

            if (chargementReussi == true)
            {
                //on retrouve le lieu associe a la valeur contenu dans lieuTemporaire (recupere dans Charger.cs)
                for (i=0;i<listeLieux.Length;i++)
                {
                    if (listeLieux[i].Name.Equals(lieuTemporaire))
                    {
                        positionInitiale = listeLieux[i];
                    }
                }
                Console.Write(positionInitiale);
                //on instancie le joueur
                chevalier = new Joueur(nom, age, avatar, positionInitiale, score, dos, epreuvesEmportees);
                afficherDiaporama();
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
                for (int i = 0; i < joueursFichier.Count(); i++)
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
                    String enregistrementJoueur = prenomField.Text.ToLower() + "-" + ageJoueur + "-" + sauvegardeImgAvatar + "-" + Montagne.Name + "-" + etoile + "-" + dossier + "-" + epreuves[0] + "-" + epreuves[1] + "-" + epreuves[2] + "-" + epreuves[3];
                    System.IO.File.AppendAllText("Joueurs.txt", Environment.NewLine);
                    System.IO.File.AppendAllText("Joueurs.txt", enregistrementJoueur);

                    //il faut creer une nouvelle instance de joueur
                    
                    chevalier = new Joueur(prenomField.Text, ageJoueur, sauvegardeImgAvatar, Chateau, Int16.Parse(etoile), dossier, epreuves);
                    
                    //on affiche le prelude
                    afficherDiaporama();
                }
        }
    }

        private void afficherDiaporama()
        {

            //on affiche la planche avec le roi puis la planche avec le magicien...le bouton suivant doit clignoter
            //lors du diaporama on a le texte et une voix off qui explique l-histoire
            
            this.Controls.Remove(accueil);
            this.Controls.Remove(nouveauJoueur);
            this.Controls.Remove(chargerJoueur);
            textePresentationJeu.Text = "Bienvenue à toi "+ chevalier.nomJoueur() + " , je suis le roi Kazan. Es-tu pret pour la mission que j'ai a te confier?";
            diaporamaHistoire.Controls.Add(pret);
            diaporamaHistoire.Controls.Add(textePresentationJeu);
            this.Controls.Add(diaporamaHistoire);
            
        }

        private void ReadyButton(object sender, EventArgs e)
        {
            textePresentationJeu.Text = "Avant de commencer, rends visite au magicien. Il te donnera de precieux conseils pour la suite de l'aventure";
            diaporamaHistoire.Controls.Remove(pret);
            diaporamaHistoire.Controls.Add(precedent);
            diaporamaHistoire.Controls.Add(suivant);
        }

        private void afficherDiapoPrecedente(object sender, EventArgs e)
        {
            //on retourne a l-ecran du roi
            if (diaporamaHistoire.Name.Equals("diapoMag.png") == true)
            {
                chargementImage("diapoTrone1.png", diaporamaHistoire);
                textePresentationJeu.Text = "Avant de commencer, rends visite au magicien. Il te donnera de precieux conseils pour la suite de l'aventure";
                diaporamaHistoire.Controls.Add(precedent);
                diaporamaHistoire.Controls.Add(suivant);
                diaporamaHistoire.Controls.Remove(AfficherCarte);
            }
            else
            {
                textePresentationJeu.Text = "Bienvenue à toi " + chevalier.nomJoueur() + " , je suis le roi Kazan. Es-tu pret pour la mission que j'ai a te confier?";
                diaporamaHistoire.Controls.Remove(suivant);
                diaporamaHistoire.Controls.Remove(precedent);
                diaporamaHistoire.Controls.Add(pret);
            }
        }

        private void afficherDiapoSuivant(object sender, EventArgs e)
        {
            diaporamaHistoire.Controls.Remove(suivant);
            textePresentationJeu.Text = "Bienvenue à toi " + chevalier.nomJoueur() + " , je suis le magicien Kazan, et je serai ton guide tout au long de ton périple. Bon courage!";
            chargementImage("diapoMag.png", diaporamaHistoire);
            diaporamaHistoire.Controls.Add(AfficherCarte);
        }
        
        private void afficherCarte(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            this.Controls.Remove(control.Parent);
            Carte();
        }

        public void Carte()
        {
            Refresh();
            //on mettra tout le contenu de CarteJeu
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, CarteJeu, new object[] { true });

            this.Controls.Add(CarteJeu);

            //on initialise les elements de la carte : avatar, magicien, chateau, prochaine etoile,

            //pour afficher le decor il faut que l-image chevalier appartienne au label de depart

            chargementImage(chevalier.avatarJoueur(), imgChevalier);
            
            //position  
            imgChevalier.Left = chevalier.positionJoueur().getPosition().X;
            imgChevalier.Top = chevalier.positionJoueur().getPosition().Y;

            ajoutEtoiles();

            //on affiche les elements du jeu
            conteneurEtoilesCoffre.Controls.Add(ConteneurEtoile);
            conteneurEtoilesCoffre.Controls.Add(coffre);

            chargementImage("mapDebut2.png", CarteJeu);
            CarteJeu.Controls.Add(conteneurEtoilesCoffre);
            CarteJeu.Controls.Add(imgChevalier);
            CarteJeu.Controls.Add(Montagne);
            CarteJeu.Controls.Add(Village);
            CarteJeu.Controls.Add(Tronc);
            CarteJeu.Controls.Add(Cabane);
            CarteJeu.Controls.Add(Chateau);
            CarteJeu.Controls.Add(tabBord);
        }

        private void declencheTimer(object sender, EventArgs e)
        {
            arrivee = (Lieu)sender;
            //il faut afficher la bonne carte

            /* arrivee.chargementMap(CarteJeu);

            CarteJeu.Controls.Remove(Village);
            CarteJeu.Controls.Remove(Montagne);
            CarteJeu.Controls.Remove(Tronc);
            CarteJeu.Controls.Remove(Cabane);
            CarteJeu.Controls.Remove(Chateau);

            this.Refresh();*/

            timer2.Enabled = true;
        }
       
        private void timerDeplacement(object sender, EventArgs e)
        {
            
            //selon le depart, le deplacement n-est pas le meme

            //si depart == chateau

            if (chevalier.positionJoueur().Name.Equals("Chateau"))
            {
                if (arrivee.Name.Equals("Que fait le Roi?"))
                {
                    deplacementVertical(Tronc);
                    deplacementVertical(arrivee);
                }
                else
                {
                    //chateau
                    deplacementVertical(arrivee);
                }
                

                //deplacement chateau / montagne a regler
            }
            else if (chevalier.positionJoueur().Name.Equals("Memory"))
            {
                //village

                if (arrivee.Name.Equals("Grand Ou Petit") || arrivee.Name.Equals("Que fait le Roi?"))
                {
                    deplacementVertical(arrivee);
                }
                else
                {
                    deplacementHorizontal(arrivee);
                }
            }
            else if (chevalier.positionJoueur().Name.Equals("Chasse aux mots") || chevalier.positionJoueur().Name.Equals("Grand Ou Petit"))
            {
                if (arrivee.Name.Equals("Chasse aux mots") || arrivee.Name.Equals("Grand Ou Petit"))
                {
                    //cabane ou tronc
                    deplacementCabaneTronc();
                }
                else
                {
                    deplacementHorizontal(arrivee);
                }
                
            }
            else if (chevalier.positionJoueur().Name.Equals("Que fait le Roi?"))
            {
                if (arrivee.Name.Equals("Chateau"))
                {
                    deplacementVertical(Tronc);
                    deplacementVertical(arrivee);
                }
                else
                {
                    //montagne
                    deplacementVertical(arrivee);
                }
                
            }
            

            imgChevalier.Refresh();
            //on desactive le timer
            timer2.Enabled = false;
            chevalier.setPosition(arrivee);

            //on change le curseur pour lancer le jeu
            if (arrivee.Cursor == Cursors.Default)
            {
                arrivee.Cursor = Cursors.Hand;
            }
            else if (arrivee.Cursor == Cursors.Hand)
            {
                arrivee.Cursor = Cursors.Default;
            }
            
        }

        private void deplacementHorizontal(Lieu a)
        {
            while (imgChevalier.Left != a.getPosition().X)
            {
                if (imgChevalier.Left < a.getPosition().X)
                {
                    imgChevalier.Left += 2;
                    imgChevalier.Refresh();

                }
                else
                {
                    imgChevalier.Left -= 2;
                    imgChevalier.Refresh();
                }
            }

            while (imgChevalier.Top != a.getPosition().Y)
            {
                if (imgChevalier.Top < a.getPosition().Y)
                {
                    imgChevalier.Top += 2;
                    imgChevalier.Refresh();
                }
                else
                {
                    imgChevalier.Top -= 2;
                    imgChevalier.Refresh();
                }
            }
        }

        private void deplacementVertical(Lieu a)
        {

            while (imgChevalier.Top != a.getPosition().Y)
            {
                if (imgChevalier.Top < a.getPosition().Y)
                {
                    imgChevalier.Top += 2;
                    imgChevalier.Refresh();
                }
                else
                {
                    imgChevalier.Top -= 2;
                    imgChevalier.Refresh();
                }
            }

            while (imgChevalier.Left != a.getPosition().X)
            {
                if (imgChevalier.Left < a.getPosition().X)
                {
                    imgChevalier.Left += 2;
                    imgChevalier.Refresh();

                }
                else
                {
                    imgChevalier.Left -= 2;
                    imgChevalier.Refresh();
                }
            }
        }

        private void deplacementCabaneTronc()
        {
            deplacementHorizontal(Chateau);
            deplacementVertical(Tronc);
        }

        private void sauvegardeButton (object sender, EventArgs e)
        {
            sauvegardePartie();
        }

        private void sauvegardePartie()
        {
            //sauvegarde en pleine partie / enregistrement dans le tableau joueursFichier. l-enregistrement en dur se fera a la fermeture de l-application
            Boolean enregistrer = false;

            chevalier.setPosition(arrivee);
            String enregistrementJoueur = chevalier.nomJoueur() + "-" + chevalier.ageJoueur() + "-" + chevalier.avatarJoueur() + "-" + chevalier.positionJoueur().Name + "-" + chevalier.scoreJoueur() + "-" + chevalier.dossierJoueur() +"-" + chevalier.getEpreuvesGagnees(0) + "-" + chevalier.getEpreuvesGagnees(1) + "-" + chevalier.getEpreuvesGagnees(2) + "-" + chevalier.getEpreuvesGagnees(3);

            //on enregistre dans le tableau joueursFichiers les nouvelles valeurs pour le joueur actuel

            for (int i=0; i < joueursFichier.Count(); i++)
            {
                if (joueursFichier.ElementAt(i).Contains(chevalier.nomJoueur()) && enregistrer == false)
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
            //System.IO.File.WriteAllLines("Joueurs.txt", joueursFichier);

            enregistrementFichier("La_petite_boite.Resources.Joueurs.txt");

            //on quitte le jeu
            Application.Exit();
        }

        private void changementImageLieu (object sender, EventArgs e)
        {
            //on change l-image du lieu
            Lieu p = (Lieu)sender;
            p.chargementSurvolImage();
        }

        private void changementImageLieuOrigine (object sender, EventArgs e)
        {
            //on change l-image du lieu
            Lieu p = (Lieu)sender;

            p.chargementDebutImage();
        }
        
        //MINI JEUX

        private void afficheJeu (String nomJeu, Panel p)
        {
            
            titreJeu.Text = "Niveau 1 : " + nomJeu;
            

            //on ajoute le minijeu
            miniJeu.Controls.Add(p);
            
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
                Jeu.Controls.Add(conteneurEtoilesCoffre);
                Jeu.Controls.Add(imgChevalier);
                Jeu.Controls.Add(prenomJoueur);
                Jeu.Controls.Add(titreJeu);
                Jeu.Controls.Add(miniJeu);
                this.Controls.Add(Jeu);
            
            tuto.ShowDialog();
        }

        private void LanceMiniJeu(object sender, EventArgs e)
        {
            Lieu l = (Lieu)sender;
            this.Controls.Remove(CarteJeu);
            Boolean FonctionChateauActive = false;

            epreuvesO = chevalier.epreuvesJoueur();

            jeuEnCours = l.Name;
            if (l.Name == "Chasse aux mots")
            {
                //la chasse aux mots se deroule dans la montagne
                chargementImage("montagne.png", Jeu);
                tuto = new tutoChasseAuxMots();
                IndiceJeu = 1;
            }
            else if (l.Name == "Grand Ou Petit")
            {
                //grand ou petit se deroule dans une clairiere
                chargementImage("clairiere.png", Jeu);
                tuto = new tutoGrandOuPetit();
                IndiceJeu = 2;
            }
            else if (l.Name == "Que fait le Roi?")
            {
                //que fait le roi se deroule a cote de la riviere
                chargementImage("riviere.png", Jeu);
                tuto = new tutoQueFaitLeRoi();
                IndiceJeu = 3;
            }
            else if (l.Name == "Memory")
            {
                chargementImage("village.png", Jeu);
                tuto = new tutoMemory();
                IndiceJeu = 0;
            }
            else
            {
                FonctionChateauActive = true;
                devoileCoffre();
            }

            if (FonctionChateauActive == false)
            {
                afficheJeu(l.Name, epreuvesO.ElementAt(IndiceJeu));
            }
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
            else if (parent.Parent == CourRoi)
            {
                this.Controls.Remove(CourRoi);
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

                //ici il faudra mettre l-image du lieu en gris de maniere definitive

                listeLieux[IndiceJeu].chargementFinImage();

                //remove le mouseEnter et le mouseSortie
                listeLieux[IndiceJeu].MouseEnter -= changementImageLieu;
                listeLieux[IndiceJeu].MouseLeave -= changementImageLieuOrigine;

                MessageBox.Show("Vous avez termine cette quete", "Quete terminee", MessageBoxButtons.OK, MessageBoxIcon.None);

                //on peut proposer au joueur de rejouer ou de revenir a la carte

                var Popup = new PopUp();
                Popup.ShowDialog();
            }
        }

        public void lanceNiveauSuperieur ()
        {
            titreJeu.Text = "Niveau 2 : " + jeuEnCours;
            miniJeu.Controls.Clear();
            chevalier.epreuvesFacultatives().ElementAt(IndiceJeu).EnabledChanged += new EventHandler(finMiniJeuFacultatif);
            miniJeu.Controls.Add(chevalier.epreuvesFacultatives().ElementAt(IndiceJeu));
        }

        public void ajoutEtoiles()
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

        public void devoileCoffre()
        {
            this.Controls.Remove(CarteJeu);
            textePresentationJeu.Text = "As-tu reuni l-ensemble des etoiles ?";
            CourRoi.Controls.Add(textePresentationJeu);
            CourRoi.Controls.Add(Yes);
            CourRoi.Controls.Add(No);
            CourRoi.Controls.Add(tabBord);
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

            //Recompense.Width = 1400;
            //Recompense.Height = 722;
            //Recompense.Location = new Point(0, 0);
            //Recompense.BackColor = Color.AliceBlue;
            //Recompense.Controls.Add(recompense1);
            //Recompense.Controls.Add(recompense2);
            //Recompense.Controls.Add(recompense2);

            //sur cette page, on a trois picturebox avec les liens vers les recompenses (video, coloriages, etc
        }
        
    }
}
