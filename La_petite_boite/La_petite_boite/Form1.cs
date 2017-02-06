using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing.Text;
using System.Media;
using Ressources;
using System.Threading;
using System.Text;
using System.Runtime.InteropServices;

namespace La_petite_boite
{
    public partial class petiteBoite : FormSpecial
    {
        Assembly _assembly = Assembly.GetExecutingAssembly();

        List<Bitmap> imagesAvatars = new List<Bitmap>();
        List<Bitmap> imagesAvatarsGris = new List<Bitmap>();
        public List<Bitmap> imagesEnterBoutons = new List<Bitmap>();
        public List<Bitmap> imagesLeaveBoutons = new List<Bitmap>();
        List<Bitmap> imagesDiaporama = new List<Bitmap>();

        public static bool chargementReussi = false;
        public bool sauvegardeFlag = false;
        bool FonctionChateauActive = false;
        bool FinJeu = false;
        bool CarteDejaAffiche = false;
        bool responsiveTab = false;

        ComboBox listeDossierSauvegarde = new ComboBox();

        //BOUTONS
        LittleButton actionJoueur = new LittleButton(530);

        SpecialButton nouvellePartie = new SpecialButton("#003255", "#A52A2A", 500, 90);
        SpecialButton chargerPartie = new SpecialButton("#003255", "#A52A2A", 500, 90);
        SpecialButton quitter = new SpecialButton("#003255", "#A52A2A", 500, 90);
        SpecialButton contact = new SpecialButton("#A52A2A", "#A52A2A", 200, 90);
        SpecialButton commencer = new SpecialButton("#ffffff", "#6d5622", 200, 70);
        SpecialButton retour = new SpecialButton("#ffffff", "#6d5622", 200, 70);

        Double width;
        Double height;

        public Form tuto;

        int indexAvatar = -1;
        public static int age;
        public static int top;
        public static int left;
        public static int score = 0;
        public static int avatar;
        public int IndiceJeu = 0;
        public int choixFinMiniJeu = 0;
        public static int[] epreuvesEmportees = new int[4];
        int passageChateau = 0;

        public Joueur chevalier;
        public List<Jeu.Jeu> epreuvesO;
        public List<Jeu.Jeu> epreuvesF;

        SpecialLabel prenomLabel = new SpecialLabel();
        SpecialLabel ageLabel = new SpecialLabel();
        SpecialLabel dossierSauvegarde = new SpecialLabel();
        SpecialLabel prenomJoueur = new SpecialLabel();
        SpecialLabel gain = new SpecialLabel();
        public static SpecialLabel titreJeu = new SpecialLabel();

        ListBox joueursPossibles = new ListBox();

        Lieu[] listeLieux;
        
        Lieu Village = new Lieu(470, -28, 448, 270, items.villagePrevious, items.villageAfter, items.mapVillage, "Memory"); //MEMORY
        Lieu Chateau = new Lieu(106, 1006, 327, 404, items.chateauPrevious, items.chateauAfter, items.map, "Chateau");//CHATEAU
        Lieu Cabane = new Lieu(417, 755, 213, 192, items.cabanePrevious, items.cabaneAfter, items.mapCabane, "Chasse aux mots");//CHASSE AUX MOTS
        Lieu Tronc = new Lieu(80, 600, 177, 196, items.troncPrevious, items.troncAfter, items.mapTronc, "Grand Ou Petit");//GRAND OU PETIT
        Lieu Montagne = new Lieu(-5, -3, 378, 196, items.montagnePrevious, items.montagneAfter, items.mapMontagne, "Que fait le Roi?");//QUE FAIT LE ROI
        Lieu arrivee = new Lieu();
        Lieu accueil = new Lieu();
        public static Lieu positionInitiale = new Lieu();

        Panel nouveauJoueur = new Panel();
        Panel choixAvatar = new Panel();
        Panel saisirInfos = new Panel();
        Panel diaporamaHistoire = new Panel();
        Panel tabBord = new Panel();
        Panel conteneurInfos = new Panel();
        public static TableLayoutPanelPlus objectif = new TableLayoutPanelPlus();
        public static Panel chargerJoueur = new Panel();
        public static Panel ConteneurEtoile = new Panel();
        public static Panel conteneurEtoilesCoffre = new Panel();
        public Panel etoilesObjectif = new Panel();
        public Panel Jeu = new Panel();
        public Panel pageContact = new Panel();
        public Panel CarteJeu = new Panel();
        public Panel panelJoueur = new Panel();
        List<Panel> listePanels = new List<Panel>();

        PictureBox imgChevalier = new PictureBox();
        PictureBox imagePersonnage1 = new PictureBox();
        PictureBox imagePersonnage2 = new PictureBox();
        PictureBox imagePersonnage3 = new PictureBox();
        PictureBox imagePersonnage4 = new PictureBox();
        PictureBox guide = new PictureBox();
        PictureBox coffre = new PictureBox();
        PictureBox sauvegarde = new PictureBox();
        PictureBox quitterMiniJeu = new PictureBox();
        PictureBox precedent = new PictureBox();
        List<PictureBox> listeAvatars = new List<PictureBox>();
        
        Point positionJoueur = new Point();

        public static PrivateFontCollection privateFontCollection;
        public static PrivateFontCollection fontPopUp;

        SpecialLabel titrePrincipal = new SpecialLabel();
        SpecialLabel textePresentationJeu = new SpecialLabel();
        
        String jeuEnCours = "";
        String nomJoueur = "";
        public static String dossier = "";
        public static String nom;
        public static String dos;
        public static String lieuTemporaire;
        public static String resultatJeu;
        public static List<String> Textes = new List<string>();
        public static List<String> joueursFichier = new List<string>();
        public static List<String> listeSauvegarde = new List<string>();
        List<String> textesDiaporama = new List<String>();

        TableLayoutPanelPlus miniJeu = new TableLayoutPanelPlus();
        TableLayoutPanelPlus Table = new TableLayoutPanelPlus();

        TextBox prenomField = new TextBox();
        TextBox ageField = new TextBox();

        System.Windows.Forms.Timer fade = new System.Windows.Forms.Timer();

        //Charger les elements
        public petiteBoite()
        {
            
            Thread t = new Thread(new ThreadStart(splashStart));
            t.Start();

            //---------------------------------FICHIERS-------------------------------------//

            //on lit le fichier Joueurs et on cree une nouvelle instance Joueur avec les donnees trouvees
            //if Francais

            chargementTexte("textesFR.txt", Textes);
            chargementTexte("Joueurs.txt", joueursFichier);
            chargementTexte("dossiers_sauvegarde.txt", listeSauvegarde);
            InitializeComponent();
            Thread.Sleep(6000);
            
            afficheAccueil();
            t.Abort();
        }

        public void splashStart()
        {
            Application.Run(new splash());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //on determine la resolution de la fenetre
            Double flagResolution = Screen.PrimaryScreen.Bounds.Height / Screen.PrimaryScreen.Bounds.Width;
            Console.WriteLine("resolution flag :" + Screen.PrimaryScreen);

            if (flagResolution == 1366 / 768)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.ClientSize = new Size(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y);
            }
            else {
                this.FormBorderStyle = FormBorderStyle.None;
                this.ClientSize = new Size(1292, 726);
                this.Size = new Size(1292, 726);
            }

            if (Screen.PrimaryScreen.Bounds.Width < 1100)
            {
                //le tableau de bord et les etoiles sont plus petits
                responsiveTab = true;

            }
            this.DoubleBuffered = true;
            //EMBED FONTS
            privateFontCollection = items.chargementFont("Ressources.Resources.Jeu.maturafont.TTF");
            fontPopUp = items.chargementFont("Ressources.Resources.Jeu.lucida.ttf");
            generationElements();
        }

        private void generationElements()
        {
            //la fonction fadein controle la vitesse d'affichage des differents panneaux. choisir un niveau d'opacite inf a 1 et pair pour que la fonction soit OK

            //---------------------LAYOUTS------------------------//
            
            Table.Location = new Point(0, 0);
            Table.Size = new Size(1292, 726);
            Table.AutoSize = true;
            Table.ColumnCount = 4;
            Table.RowCount = 4;
            Table.BackColor = Color.Transparent;
            Table.AutoSizeMode = AutoSizeMode.GrowOnly;
            Table.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            Table.Dock = DockStyle.Fill;
            Table.Margin = new Padding(0);
            

            //---------------------TIMERS------------------------//

            fade.Tick += new EventHandler(this.fadein);

            //---------------------PANELS------------------------//

            listePanels.Add(accueil);
            listePanels.Add(nouveauJoueur);
            listePanels.Add(diaporamaHistoire);
            listePanels.Add(CarteJeu);
            listePanels.Add(Jeu);
            listePanels.Add(pageContact);
            listePanels.Add(panelJoueur);

            foreach (Panel p in listePanels)
            {
                p.BackgroundImageLayout = ImageLayout.Stretch;
                p.Size = new Size(1273, 689);
                p.Anchor = AnchorStyles.None;
                p.Dock = DockStyle.Fill;
                p.Location = new Point(0, 0);
            }

            width = this.Width;
            height = 0.71 * this.Height;
            Double pY = 0.17 * this.Height;

            panelJoueur.Size = new Size((int)width, (int)height);
            panelJoueur.Location = new Point(0, (int)pY);
            panelJoueur.Dock = DockStyle.None;
            panelJoueur.Paint += new PaintEventHandler(this.Form1_Paint);
            panelJoueur.BackColor = Color.Transparent;

            //accueil
            accueil.BackgroundImage = items.accueil;

            //pageContact
            pageContact.BackgroundImage = items.accueil;

            //ecran nouveau joueur
            nouveauJoueur.BackgroundImage = items.menu;

            //carteJeu
            CarteJeu.BackgroundImage = items.map;
            
            //--------------------MINI PANELS-------------------------------//

            //mini-panel choix avatar
            choixAvatar.Width = 700;
            choixAvatar.Height = 150;
            choixAvatar.Location = new Point(20, 10);
            choixAvatar.Anchor = AnchorStyles.None;
            choixAvatar.BackColor = Color.Transparent;

            //mini panel saisie informations personnelles
            saisirInfos.Width = 500;
            saisirInfos.Height = 240;
            saisirInfos.Location = new Point(130, 170);
            saisirInfos.BackColor = Color.Transparent;

            //conteneur Infos
            conteneurInfos.Width = 750;
            conteneurInfos.Height = 600;
            conteneurInfos.Location = new Point(0, 0);
            conteneurInfos.Anchor = AnchorStyles.None;
            conteneurInfos.BackColor = Color.Transparent;
            conteneurInfos.BackgroundImage = items.fondBlanc;
            conteneurInfos.BackgroundImageLayout = ImageLayout.Stretch;

            //tabBord
            tabBord.BackColor = Color.Transparent;
            tabBord.BackgroundImage = items.banniereGriseTabBord;


            //on ajoute les boutons au tableau de bord
            tabBord.Controls.Add(sauvegarde);
            tabBord.Controls.Add(quitterMiniJeu);
            tabBord.Controls.Add(guide);

            //on ajoute dans la liste Bitmaps les images qui vont remplacer les img des PictureBox en cas de survol

            imagesEnterBoutons.Add(items.sauvegardeHover);
            imagesEnterBoutons.Add(items.quitterHover);
            imagesEnterBoutons.Add(items.aideHover);
            imagesEnterBoutons.Add(items.retourFlecheRouge);

            //les images qui doivent apparaitre lorsque l'on quitte les boutons/picturebox
            imagesLeaveBoutons.Add(items.sauvegarde);
            imagesLeaveBoutons.Add(items.quitter);
            imagesLeaveBoutons.Add(items.aide);
            imagesLeaveBoutons.Add(items.retourFleche);

            //conteneurEtoilesCoffre
            conteneurEtoilesCoffre.Width = 1000;
            conteneurEtoilesCoffre.Height = 111;
            conteneurEtoilesCoffre.BackgroundImage = items.banniereGriseConteneurEtoiles;
            conteneurEtoilesCoffre.BackColor = Color.Transparent;
            conteneurEtoilesCoffre.Dock = DockStyle.None;
            conteneurEtoilesCoffre.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            //conteneurEtoile
            Double posL = 0.64 * this.Width;
            ConteneurEtoile.Width = (int)posL;
            ConteneurEtoile.Height = 100;
            ConteneurEtoile.BackColor = Color.Transparent;
            

            //objectifs
            if (responsiveTab == true)
            {
                objectif.Width = 120;
            }
            else
            {
                objectif.Width = 200;
            }

            objectif.Height = 200;
            objectif.Top = 0;
            objectif.Left = 0;
            objectif.BackColor = Color.Transparent;
            objectif.Dock = DockStyle.Fill;
            objectif.AutoSize = true;
            objectif.ColumnCount = 1;
            objectif.RowCount = 2;
            objectif.AutoSizeMode = AutoSizeMode.GrowOnly;
            objectif.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            objectif.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));

            //etoilesObjectif

            etoilesObjectif.Width = 140;
            etoilesObjectif.Height = 150;
            objectif.Controls.Add(etoilesObjectif, 0, 1);

            //miniJeu
            miniJeu.Top = 0;
            miniJeu.Left = 0;
            miniJeu.Width = 1274;
            miniJeu.Height = 500;
            miniJeu.AutoSize = true;
            miniJeu.ColumnCount = 1;
            miniJeu.RowCount = 1;
            miniJeu.BackColor = Color.Transparent;
            miniJeu.AutoSizeMode = AutoSizeMode.GrowOnly;
            miniJeu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            miniJeu.Dock = DockStyle.Fill;


            //------------------------IMAGES-------------------------------//

            //avatars
            listeAvatars.Add(imagePersonnage1);
            listeAvatars.Add(imagePersonnage2);
            listeAvatars.Add(imagePersonnage3);
            listeAvatars.Add(imagePersonnage4);

            imagesAvatars.Add(items.chevalier1);
            imagesAvatars.Add(items.chevalier2);
            imagesAvatars.Add(items.chevalier3);
            imagesAvatars.Add(items.chevalier4);

            imagesAvatarsGris.Add(items.chevalier1gris);
            imagesAvatarsGris.Add(items.chevalier2gris);
            imagesAvatarsGris.Add(items.chevalier3gris);
            imagesAvatarsGris.Add(items.chevalier4gris);

            //on ajoute les images au panel choixAvatar
            for (int i = 0; i < listeAvatars.Count(); i++)
            {
                listeAvatars[i].Click += new EventHandler(clickAvatar);
                choixAvatar.Controls.Add(listeAvatars[i]);
                listeAvatars[i].Image = imagesAvatars[i];
                listeAvatars[i].SizeMode = PictureBoxSizeMode.StretchImage;
                listeAvatars[i].BackColor = Color.Transparent;
                listeAvatars[i].Top = 0;
                listeAvatars[i].Left = i * 200;
                listeAvatars[i].Width = 100;
                listeAvatars[i].Height = 130;
            }

            //imgChevalier
            imgChevalier.SizeMode = PictureBoxSizeMode.StretchImage;
            imgChevalier.BackColor = Color.Transparent;

            //coffre
            coffre.Image = items.coffre;
            coffre.Width = 100;
            coffre.Height = 90;
            coffre.SizeMode = PictureBoxSizeMode.StretchImage;
            coffre.BackColor = Color.Transparent;

            //guide
            guide.Image = imagesLeaveBoutons[2];
            guide.Width = 50;
            guide.Height = 50;
            guide.SizeMode = PictureBoxSizeMode.StretchImage;
            guide.Cursor = Cursors.Hand;
            guide.Click += new EventHandler(AfficheMessage);
            guide.MouseEnter += new EventHandler(boutonEnter);
            guide.MouseLeave += new EventHandler(boutonLeave);

            //sauvegarde
            sauvegarde.Image = imagesLeaveBoutons[0];
            sauvegarde.BackColor = Color.Green;
            sauvegarde.Width = 34;
            sauvegarde.Height = 34;
            sauvegarde.SizeMode = PictureBoxSizeMode.StretchImage;
            sauvegarde.BackColor = Color.Transparent;
            sauvegarde.Cursor = Cursors.Hand;
            sauvegarde.Click += new EventHandler(sauvegardeButton);
            sauvegarde.MouseEnter += new EventHandler(boutonEnter);
            sauvegarde.MouseLeave += new EventHandler(boutonLeave);

            //quitterMiniJeu
            quitterMiniJeu.Image = imagesLeaveBoutons[1];
            quitterMiniJeu.Width = 40;
            quitterMiniJeu.Height = 40;
            quitterMiniJeu.SizeMode = PictureBoxSizeMode.StretchImage;
            quitterMiniJeu.Cursor = Cursors.Hand;
            quitterMiniJeu.BackColor = Color.Transparent;
            quitterMiniJeu.Click += new EventHandler(retourTabBord);
            quitterMiniJeu.MouseEnter += new EventHandler(boutonEnter);
            quitterMiniJeu.MouseLeave += new EventHandler(boutonLeave);
            
            //precedent
            precedent.Height = 71;
            precedent.Width = 100;
            precedent.Left = 50;
            precedent.Top = 40;
            precedent.BackColor = Color.Transparent;
            precedent.SizeMode = PictureBoxSizeMode.StretchImage;
            precedent.Image = imagesLeaveBoutons[3];
            precedent.Cursor = Cursors.Hand;
            precedent.Dock = DockStyle.None;
            precedent.Anchor = AnchorStyles.Top;
            precedent.Click += new EventHandler(afficherDiapoPrecedente);
            precedent.MouseEnter += new EventHandler(boutonEnter);
            precedent.MouseLeave += new EventHandler(boutonLeave);
            
            //--------------------------------BOUTONS----------------------------------------//

            //nouvelle partie
            nouvellePartie.Text = Textes[14];
            nouvellePartie.Click += new EventHandler(nouvelle_partie_button);
            nouvellePartie.Font = new Font(privateFontCollection.Families[0], 40);
            

            //chargerPartie
            chargerPartie.Text = Textes[15];
            chargerPartie.Click += new EventHandler(charger_partie_button);
            chargerPartie.Font = new Font(privateFontCollection.Families[0], 40);
            

            //quitter
            quitter.Text = Textes[16];
            quitter.Click += new EventHandler(quitterPartie);
            quitter.Font = new Font(privateFontCollection.Families[0], 40);

            //contact
            contact.Text = Textes[117];
            contact.Click += new EventHandler(affichePageContact);
            contact.Font = new Font(privateFontCollection.Families[0], 20);
            
            //commencer
            commencer.Text = Textes[17];
            commencer.Left = 525;
            commencer.Font = new Font(privateFontCollection.Families[0], 20);
            commencer.Click += new EventHandler(commencer_button);
            

            //retour
            retour.Text = Textes[18];
            retour.Left = 725;
            retour.Font = new Font(privateFontCollection.Families[0], 20);
            retour.Click += new EventHandler(retourButton);
            

            //ActionJouer button
            actionJoueur.Top = 0;
            actionJoueur.Left = 0;
            actionJoueur.Height = 90;
            actionJoueur.Width = 500;
            actionJoueur.Anchor = AnchorStyles.Top;
            actionJoueur.Font = new Font(privateFontCollection.Families[0], 40);
            

            //-------------------------------CHAMPS------------------------------//
            
            //menu principal

            titrePrincipal.Text = Textes[104];
            titrePrincipal.Width = this.Width;
            titrePrincipal.Height = 160;
            titrePrincipal.Font = new Font(privateFontCollection.Families[0], 65);
            titrePrincipal.ForeColor = Color.Brown;
            titrePrincipal.BackColor = Color.Transparent;
            titrePrincipal.TextAlign = ContentAlignment.MiddleCenter;
            titrePrincipal.AutoSize = false;
            titrePrincipal.Dock = DockStyle.Fill;
            

            //dossier de sauvegarde
            dossierSauvegarde.Text = Textes[108];
            dossierSauvegarde.ForeColor = ColorTranslator.FromHtml("#6d5622");
            dossierSauvegarde.Font = new Font(fontPopUp.Families[0], 14);
            dossierSauvegarde.Top = 110;
            dossierSauvegarde.Left = 110;
            dossierSauvegarde.Width = 260;
            dossierSauvegarde.Height = 25;

            //combobox dossier sauvegarde
            listeDossierSauvegarde.Top = 150;
            listeDossierSauvegarde.Left = 115;
            listeDossierSauvegarde.Width = 250;
            listeDossierSauvegarde.Height = 25;
            listeDossierSauvegarde.Font = new Font(listeDossierSauvegarde.Font.FontFamily, 14);
            listeDossierSauvegarde.SelectedIndexChanged += new EventHandler(choixDossier);

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
            prenomLabel.Text = Textes[109];
            prenomLabel.ForeColor = ColorTranslator.FromHtml("#6d5622");
            prenomLabel.Font = new Font(fontPopUp.Families[0], 14);
            prenomLabel.Width = 100;
            prenomLabel.Height = 25;
            prenomLabel.Top = 0;
            prenomLabel.Left = 30;

            prenomField.Font = new Font(prenomField.Font.FontFamily, 14);
            prenomField.Width = 190;
            prenomField.Height = 25;
            prenomField.Top = 0;
            prenomField.Left = 150;
            prenomField.Text = null;

            //affichePrenomJoueur
            prenomJoueur.Top = 65;
            prenomJoueur.Left = 140;
            prenomJoueur.Width = 150;
            prenomJoueur.Height = 35;
            prenomJoueur.ForeColor = Color.White;
            prenomJoueur.TextAlign = ContentAlignment.MiddleCenter;
            prenomJoueur.Font = new Font(privateFontCollection.Families[0], 17);
            prenomJoueur.BackColor = Color.Transparent;
            prenomJoueur.Dock = DockStyle.Fill;

            //age
            ageLabel.Text = Textes[110];
            ageLabel.ForeColor = ColorTranslator.FromHtml("#6d5622");
            ageLabel.Font = new Font(fontPopUp.Families[0], 14);
            ageLabel.Width = 100;
            ageLabel.Height = 25;
            ageLabel.Top = 40;
            ageLabel.Left = 30;

            ageField.Width = 190;
            ageField.Font = new Font(ageField.Font.FontFamily, 14);
            ageField.Height = 25;
            ageField.Top = 40;
            ageField.Left = 150;
            ageField.Text = null;

            //texte au dessus des etoiles a gagner lors d'un mini jeu
            gain.Text = Textes[113];
            gain.Font = new Font(privateFontCollection.Families[0], 23);
            gain.BackColor = Color.Transparent;
            gain.ForeColor = Color.White;
            gain.Location = new Point(0, 0);
            gain.TextAlign = ContentAlignment.MiddleCenter;
            gain.Dock = DockStyle.Fill;
            objectif.Controls.Add(gain, 0, 0);
            
            //texte qui s'affiche dans le panel Dialogue du diaporama

            textePresentationJeu.Width = 1100;
            textePresentationJeu.Height = 300;
            textePresentationJeu.Top = 0;
            textePresentationJeu.Left = 0;
            textePresentationJeu.Font = new Font(fontPopUp.Families[0], 17);
            textePresentationJeu.ForeColor = ColorTranslator.FromHtml("#a25d1b");
            textePresentationJeu.BackColor = Color.Transparent;
            textePresentationJeu.TextAlign = ContentAlignment.MiddleCenter;

            //images pour le diaporama

            imagesDiaporama.Add(items.diapoTrone);
            imagesDiaporama.Add(items.diapoMag);
            
            //titre pour le mini jeu

            titreJeu.Width = 500;
            titreJeu.Height = 50;
            titreJeu.ForeColor = Color.White;
            titreJeu.Top = 120;
            titreJeu.Left = 600;
            titreJeu.Font = new Font(privateFontCollection.Families[0], 23);
            titreJeu.Anchor = AnchorStyles.Bottom;
            titreJeu.TextAlign = ContentAlignment.BottomCenter;
            titreJeu.Dock = DockStyle.None;
            
            //elements de la carte
            
            posLieu(Village, 0.09, 0.65);
            posLieu(Chateau, 0.82, 0.55);
            posLieu(Cabane, 0.59, 0.65);
            posLieu(Tronc, 0.47, 0.21);
            posLieu(Montagne, 0.09, 0.21);
            
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
        
        public void posLieu (Lieu a, Double x, Double y)
        {
            //on determine le point d'arret du joueur lorsqu'il se rend sur un lieu
            width = x * this.Width;
            height = y * this.Height;

            if ((int)width % 2 != 0)
            {
                //si impair
                width += 1;
            }

            if ((int)height % 2 != 0)
            {
                //si impair
                height += 1;
            }

            a.setPosition(new Point((int)width, (int)height));
        }

        //ameliorer le fadein
        private void fadein(object sender, EventArgs e)
        {
            //on applique le fade in
            this.Opacity += 0.02;

            if (this.Opacity == 1)
            {
                fade.Stop();
            }
        }

        public void boutonLeave(object sender, EventArgs e)
        {
            PictureBox boutonTabBord = (PictureBox)sender;

            //on determine quelle est la position dans la liste des imgEnter pour determiner l'indice de l'image Leave a montrer
            Bitmap img = (Bitmap)boutonTabBord.Image;

            int index = imagesEnterBoutons.IndexOf(img);

            boutonTabBord.Image = imagesLeaveBoutons[index];
        }

        public void boutonEnter(object sender, EventArgs e)
        {
            PictureBox boutonTabBord = (PictureBox) sender;

            //on determine quelle est la position dans la liste des imgLeave pour determiner l'indice de l'image Enter a montrer
            Bitmap img = (Bitmap) boutonTabBord.Image;

            int index = imagesLeaveBoutons.IndexOf(img);

            boutonTabBord.Image = imagesEnterBoutons[index];
        }
       
        private void resizableControls(object sender, EventArgs e)
        {
            if (this.Controls.Contains(CarteJeu))
            {
                //trouver les bons rapports de proportionnalite et transformer la banniere grise en picturebox
                positionLieux();
            }
        }

        public void JouerSon(Stream stream)
        {
            stream.Position = 0;
            SoundPlayer son = new SoundPlayer(stream);
            son.Play();
            son.Dispose();
        }

        public static void chargementTexte(String nomFichier, List<String> tableauRes)
        {
            try
            {
                using (var reader = new StreamReader(nomFichier, Encoding.GetEncoding("iso-8859-1")))
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
                Console.Write("The file can't be read !" + e);
            }
        }

        //Enregistrement de donnees dans les fichiers de texte
        private void enregistrementFichier(String fichier)
        {
            try
            {
                using (var writer = new StreamWriter(fichier))
                {
                    foreach (String s in joueursFichier)
                    {
                        writer.WriteLine(s);
                    }
                }
                
            }
            catch
            {
                Console.Write("Can't write into the specified file");
            }
        }

        //Afficher Accueil

        public void afficheAccueil()
        {
            //affichage leger
            //this.Opacity = 0.50;
            //fade.Enabled = true;
            //fade.Start();

            this.Controls.Clear();
            Table.Controls.Clear();
            Table.ColumnStyles.Clear();
            Table.RowStyles.Clear();
            
            Table.ColumnCount = 4;
            Table.RowCount = 4;

            //on affiche l-accueil
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));

            accueil.Controls.Add(Table);

            titrePrincipal.Text = Textes[104];
            titrePrincipal.ForeColor = Color.Brown;

            //on affiche les boutons a l-ecran accueil
            Table.Controls.Add(titrePrincipal, 0, 0);
            Table.Controls.Add(nouvellePartie, 0, 1);
            Table.Controls.Add(chargerPartie, 0, 2);
            Table.Controls.Add(quitter, 1, 3);
            Table.Controls.Add(contact, 3, 3);

            foreach (Control c in Table.Controls)
            {
                Table.SetColumnSpan(c, 4);
                c.Dock = DockStyle.None;
                c.Anchor = AnchorStyles.None;
            }

            Table.SetColumnSpan(quitter, 2);
            Table.SetColumnSpan(contact, 1);

            nouvellePartie.Anchor = AnchorStyles.Bottom;
            chargerPartie.Anchor = AnchorStyles.Top;
            this.Controls.Add(accueil);
        }

        //affichePageContact

        public void affichePageContact(object sender, EventArgs e)
        {
            //texte de lapage Contact
            SpecialLabel presentation = new SpecialLabel();

            presentation.Text = String.Format(Textes[118], Environment.NewLine);
            presentation.Width = 1100;
            presentation.Height = 500;
            presentation.Top = 0;
            presentation.Left = 0;
            presentation.Font = new Font(fontPopUp.Families[0], 20);
            presentation.ForeColor = ColorTranslator.FromHtml("#fff");
            presentation.BackColor = Color.Transparent;
            presentation.TextAlign = ContentAlignment.MiddleCenter;

            retour.previousColor = "#003255";
            retour.afterColor = "#A52A2A";
            retour.ForeColor = ColorTranslator.FromHtml(retour.previousColor);
            retour.Font = new Font(privateFontCollection.Families[0], 40);

            this.Controls.Clear();
            Table.Controls.Clear();
           
            //on change le titre de la page
            titrePrincipal.Text = Textes[117];
            
            Table.Controls.Add(titrePrincipal, 0, 0);
            Table.Controls.Add(presentation, 0, 1);
            Table.Controls.Add(retour, 0, 3);

            foreach (Control c in Table.Controls)
            {
                Table.SetColumnSpan(c, 4);
                c.Dock = DockStyle.None;
                c.Anchor = AnchorStyles.None;
            }

            Table.SetRowSpan(presentation,2);

            pageContact.Controls.Add(Table);
            this.Controls.Add(pageContact);
        }
        
        //afficher panel Nouvelle Partie

        private void nouvelle_partie_button(object sender, EventArgs e)
        {
            //on cache l/accueil
            this.Controls.Remove(accueil);

            retour.previousColor = "#ffffff";
            retour.afterColor = "#6d5622";
            retour.ForeColor = ColorTranslator.FromHtml(retour.previousColor);
            retour.Font = new Font(privateFontCollection.Families[0], 20);

            Table.Controls.Clear();
            Table.ColumnStyles.Clear();
            Table.RowStyles.Clear();
            Table.ColumnCount = 4;
            Table.RowCount = 4;
            
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 38F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));

            
            conteneurInfos.Controls.Add(choixAvatar);
            conteneurInfos.Controls.Add(saisirInfos);

            choixAvatar.Dock = DockStyle.None;
            saisirInfos.Dock = DockStyle.None;
            commencer.Dock = DockStyle.None;
            retour.Dock = DockStyle.None;

            choixAvatar.Anchor = AnchorStyles.Top;
            saisirInfos.Anchor = AnchorStyles.Top;
            commencer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            retour.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            
            titrePrincipal.Text = Textes[107];
            titrePrincipal.ForeColor = ColorTranslator.FromHtml("#6d5622");

            //on ajoute choixAvatar et saisirInfos au panneau nouveauJoueur
            Table.Controls.Add(titrePrincipal, 0, 0); 
            Table.Controls.Add(conteneurInfos, 1, 1);
            Table.Controls.Add(commencer, 1, 3);
            Table.Controls.Add(retour, 2, 3);
            

            //on ajoute les elements prenom et age au panneau saisirInfos
            saisirInfos.Controls.Add(prenomField);
            saisirInfos.Controls.Add(prenomLabel);
            saisirInfos.Controls.Add(ageField);
            saisirInfos.Controls.Add(ageLabel);
            saisirInfos.Controls.Add(dossierSauvegarde);
            saisirInfos.Controls.Add(listeDossierSauvegarde);

            //on fusionne les trois premieres lignes du tableau
            Table.SetColumnSpan(titrePrincipal, 4);
            Table.SetColumnSpan(conteneurInfos, 2);
            Table.SetColumnSpan(retour, 1);
            Table.SetRowSpan(conteneurInfos, 2);
            
            nouveauJoueur.Controls.Add(Table);
            this.Controls.Add(nouveauJoueur);
        }

        //traitement des donnees saisies dans le panel Nouvelle Partie

        private void choixDossier(object sender, EventArgs e)
        {
            //creation d'un dossier permet d'eviter la polysemie par exe

            if (listeDossierSauvegarde.SelectedIndex > 0)
            {
                //choix parmi les valeurs du combobox
                dossier = Convert.ToString(listeDossierSauvegarde.SelectedItem);
            }
            else if (listeDossierSauvegarde.SelectedIndex == 0)
            {
                //choix Nouveau dossier
                afficheInputBox();
                this.BeginInvoke((MethodInvoker)delegate { listeDossierSauvegarde.Text = dossier; });
            }
        }

        private void commencer_button(object sender, EventArgs e)
        {

            //traitement des informations manquantes
            if (prenomField.Text == null || ageField.Text == null || indexAvatar == -1 || dossier.Equals(""))
            {
                List<String> valeursVides = new List<string>();

                if (prenomField.Text == "")
                {
                    valeursVides.Add(Textes[21]);
                }
                if (ageField.Text == "")
                {
                    valeursVides.Add(Textes[22]);
                }
                if (indexAvatar == -1)
                {
                    valeursVides.Add(Textes[23]);
                }
                if (dossier.Equals(""))
                {
                    valeursVides.Add(Textes[24]);
                }
                
                //creation du message d-erreur
                String message = Textes[25];

                foreach (String s in valeursVides)
                {
                    Console.WriteLine(s);
                    message = message + Environment.NewLine + s;
                }
                
                //Pop up affichage message
                List<String> nomsButtons = new List<string>();
                List<int> refEvents = new List<int>();
                nomsButtons.Add(Textes[26]);
                refEvents.Add(0);

                var Popup = new PopUp(ColorTranslator.FromHtml("#be1621"), items.attention, 1, message, nomsButtons, refEvents);
                Popup.ShowDialog();

                valeursVides.Clear();
            }
            else
            {
                //Validation des donnees

                bool existe = false;
                bool isNumerical;
                int ageJoueur;
                String top = Convert.ToString(0);
                String left = Convert.ToString(0);
                String etoile = Convert.ToString(0);
                
                //il faut s-assurer que le prenom n-existe pas dans la liste des joueurs d'un mm dossier
                for (int i = 0; i < joueursFichier.Count(); i++)
                {
                    if (joueursFichier[i].Contains(prenomField.Text.ToLower()))
                    {
                        Console.WriteLine(joueursFichier[i]);
                        Console.WriteLine(dossier);

                        if (joueursFichier[i].Contains(dossier))
                        {
                            existe = true;
                        }
                        
                    }
                }

                //il faut s-assurer que l-age est bien un entier
                isNumerical = int.TryParse(ageField.Text, out ageJoueur);

                //il faut communiquer avec l-utilisateur
                if (existe == true || isNumerical == false)
                {
                    String message = "";
                    List<String> nomsButtons = new List<string>();
                    List<int> refEvents = new List<int>();
                    nomsButtons.Add(Textes[26]);
                    refEvents.Add(0);
                    
                    if (existe == true)
                    {
                        message = String.Format(Textes[27], prenomField.Text.ToLower(), Environment.NewLine);
                       
                    }

                    if (isNumerical == false)
                    {
                        message = Textes[28];
                    }

                    var Popup = new PopUp(ColorTranslator.FromHtml("#be1621"), items.attention, 1, message, nomsButtons, refEvents);
                    Popup.ShowDialog();
                    reponsePopUp();
                }
                else
                {
                    int[] epreuves = { 0, 0, 0, 0 };
                    //apres toutes les verifications, on peut enregistrer le nouveau joueur
                    String enregistrementJoueur = prenomField.Text.ToLower() + "-" + ageJoueur + "-" + indexAvatar + "-" + Montagne.Name + "-" + etoile + "-" + dossier + "-" + epreuves[0] + "-" + epreuves[1] + "-" + epreuves[2] + "-" + epreuves[3];

                    //on l-enregistre d-abord dans la liste joueursFichier, la fonction quitter va enregistrer les donnees en dur
                    joueursFichier.Add(enregistrementJoueur);

                    //il faut creer une nouvelle instance de joueur

                    chevalier = new Joueur(prenomField.Text, ageJoueur, indexAvatar, Chateau, Int16.Parse(etoile), dossier, epreuves);

                    //on affiche le prelude
                    afficherDiaporama();
                }
            }
        }

        //Fonctions d'affichage de messages

        private void afficheInputBox()
        {
            //creation d-une nouvelle form InputBox

            var InputBox = new Form2();
            InputBox.ShowDialog();
        }

        //Selection de l'avatar
        public void clickAvatar(object sender, EventArgs e)
        {
            //on recupere l-objet 
            PictureBox ImgTemporaire = (PictureBox)sender;

            //on remet les couleurs de l-image selectionnee
            indexAvatar = listeAvatars.IndexOf(ImgTemporaire);
            ImgTemporaire.Image = imagesAvatars[indexAvatar];


            //on change les images des autres avatars
            for (int i = 0; i < listeAvatars.Count(); i++)
            {
                //si ce n-est pas le perso choisi, on grise l-image
                if (i != indexAvatar)
                {
                    listeAvatars[i].Image = imagesAvatarsGris[i];
                }
            }
        }

        //afficher le panel ChargerPartie
        private void charger_partie_button(object sender, EventArgs e)
        {
            int i;
            var ChargeBox = new Charger();
            ChargeBox.ShowDialog();

            if (chargementReussi == true)
            {
                chargementReussi = false;
                //on retrouve le lieu associe a la valeur contenu dans lieuTemporaire (recupere dans Charger.cs)
                for (i = 0; i < listeLieux.Length; i++)
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

        //retour vers l'accueil
        private void retourButton(object sender, EventArgs e)
        {
            this.Controls.Remove(retour.Parent);
            afficheAccueil();
        }

        //Afficher le diaporama

        public void diaporama()
        {
            //configuration du TableLayoutPanel
            Table.ColumnCount = 6;
            Table.RowCount = 5;
            Table.Controls.Clear();
            Table.RowStyles.Clear();
            Table.ColumnStyles.Clear();
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 57F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));

            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));

            Table.Controls.Add(precedent, 1, 3);
            Table.Controls.Add(textePresentationJeu, 1, 2);
            Table.Controls.Add(actionJoueur, 2, 3);
            Table.SetColumnSpan(textePresentationJeu, 4);
            Table.SetColumnSpan(actionJoueur, 2);

            foreach (Control c in Table.Controls)
            {
                c.Dock = DockStyle.None;
                c.Anchor = AnchorStyles.None;
            }
            
            precedent.Show();
            
            diaporamaHistoire.Controls.Add(Table);
            diaporamaHistoire.Tag = "0";
            diaporamaHistoire.BackgroundImage = imagesDiaporama.ElementAt(0);

            //texte pour le diaporama
            textesDiaporama.Clear();
            textesDiaporama.Add(String.Format(Textes[1], nomJoueur, Environment.NewLine));
            textesDiaporama.Add(String.Format(Textes[2], Environment.NewLine));
            textesDiaporama.Add(String.Format(Textes[3], nomJoueur, Environment.NewLine));
            textesDiaporama.Add(Textes[4]);
        }

        private void afficherDiaporama()
        {
            //lors du diaporama on a le texte et une voix off qui explique l-histoire

            //On retire la methode afficheRecompense si le joueur est deja passe par le chateau
            if (FonctionChateauActive == true)
            {
                if (passageChateau == 1)
                {
                    actionJoueur.Click -= retourTabBord;
                   
                }
                else if (passageChateau == 2) {
                    actionJoueur.Click -= afficheRecompense;
                }
            }
            
            if (CarteDejaAffiche == true)
            {
                actionJoueur.Click -= afficherCarte;
            }
            
            actionJoueur.Text = Textes[10];
            actionJoueur.Width = 150;
            actionJoueur.Click += new EventHandler(ReadyButton);
            nomJoueur = chevalier.nomJoueur();
            diaporama();
            textePresentationJeu.Text = textesDiaporama.ElementAt(0);
            this.Controls.Clear();
            this.Controls.Add(diaporamaHistoire);
        }

        private void ReadyButton(object sender, EventArgs e)
        {
            textePresentationJeu.Text = textesDiaporama.ElementAt(1);
            diaporamaHistoire.Tag = "1";
            actionJoueur.Width = 500;
            actionJoueur.Text = Textes[11];
            actionJoueur.Click -= ReadyButton;
            actionJoueur.Click += new EventHandler(afficherDiapoSuivant);
        }

        public void afficherDiapoPrecedente(object sender, EventArgs e)
        {
            String index = (String)diaporamaHistoire.Tag;

            if (index.Equals("0"))
            {
                if (FonctionChateauActive == true)
                {
                    //retour carte si on est au chateau
                    FonctionChateauActive = false;
                    this.Controls.Clear();
                    Carte();
                }
                else
                {
                    this.Controls.Clear();
                    //retour a l'accueil
                    afficheAccueil();
                }
                
            }
            else if (index.Equals("1"))
            {
                //retour au premier panel roi
                diaporamaHistoire.Tag = "0";
                textePresentationJeu.Text = textesDiaporama.ElementAt(0);
                actionJoueur.Width = 200;
                actionJoueur.Text = Textes[10];
                actionJoueur.Click -= afficherDiapoSuivant;
                actionJoueur.Click += new EventHandler(ReadyButton);
            }
            else if (index.Equals("2"))
            {
                //retaur au deuxieme panel roi
                diaporamaHistoire.Tag = "1";
                textePresentationJeu.Text = textesDiaporama.ElementAt(1);
                diaporamaHistoire.BackgroundImage = imagesDiaporama.ElementAt(0);
                actionJoueur.Width = 500;
                actionJoueur.Text = Textes[11];
                actionJoueur.Click -= afficherCarte;
                actionJoueur.Click += new EventHandler(afficherDiapoSuivant);
            }
        }

        private void afficherDiapoSuivant(object sender, EventArgs e)
        {
            textePresentationJeu.Text = textesDiaporama.ElementAt(2);
            diaporamaHistoire.Tag = "2";
            diaporamaHistoire.BackgroundImage = imagesDiaporama.ElementAt(1);
            actionJoueur.Width = 500;
            actionJoueur.Text = Textes[12];
            actionJoueur.Click -= afficherDiapoSuivant;
            actionJoueur.Click += new EventHandler(afficherCarte);
        }

        //afficher la Carte

        private void afficherCarte(object sender, EventArgs e)
        {
            Table.ColumnCount = 4;
            //on vide le layout
            Table.Controls.Clear();
            this.Controls.Clear();
            Carte();
        }

        public void Carte()
        {
            //this.Opacity = 0.80;
            //fade.Start();
            Table.ColumnCount = 4;

            //on vide le layout
            Table.Controls.Clear();
            //performance du display
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, CarteJeu, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panelJoueur, new object[] { true });
            

            //on initialise l'image associee au joueur et sa position
            imgChevalier.Image = imagesAvatars[chevalier.avatarJoueur()];
            positionJoueur = chevalier.positionJoueur().getPosition();
            imgChevalier.Location = positionJoueur;
            imgChevalier.Width = 123;
            imgChevalier.Height = 160;

            //on ajoute les etoiles dans la banniere grise 
            ajoutEtoiles();
            
            //on cache le panel qui me permet de faire le deplacement du joueur
            panelJoueur.Hide();

            //on initialise les elements de la carte 
            conteneurEtoilesCoffre.Controls.Add(ConteneurEtoile);
            conteneurEtoilesCoffre.Controls.Add(coffre);
            CarteJeu.Controls.Add(conteneurEtoilesCoffre);
            CarteJeu.Controls.Add(imgChevalier);
            CarteJeu.Controls.Add(Montagne);
            CarteJeu.Controls.Add(Village);
            CarteJeu.Controls.Add(Tronc);
            CarteJeu.Controls.Add(Cabane);
            CarteJeu.Controls.Add(Chateau);
            CarteJeu.Controls.Add(tabBord);
            CarteJeu.Controls.Add(panelJoueur);
            this.Controls.Add(CarteJeu);
            
            //on determine les positions et les dimensions des lieux selon la taille de la form
            positionLieux();
            
            //affichage pop up pour recuperer les recompenses une fois
            if (FinJeu == true)
            {
                FinJeu = false;
                //ici pop up spe
                List<String> nomsButtons = new List<string>();
                List<int> refEvents = new List<int>();
                nomsButtons.Add(Textes[26]);
                refEvents.Add(0);
                
                var message = String.Format(Textes[40], Environment.NewLine);
                var Popup = new PopUp(ColorTranslator.FromHtml("#bbc88c"), items.felicitations, 1, message, nomsButtons, refEvents);
                Popup.ShowDialog();
                reponsePopUp();
            }


            //on affiche le premier conseil du guide
            if (CarteDejaAffiche == false)
            {
                CarteDejaAffiche = true;
                List<String> nomsButtons = new List<string>();
                List<int> refEvents = new List<int>();
                nomsButtons.Add(Textes[115]);
                refEvents.Add(0);

                var message = String.Format(Textes[51], Environment.NewLine);
                var Popup = new PopUp(ColorTranslator.FromHtml("#4d78ab"), items.guide, 1, message, nomsButtons, refEvents);
                Popup.ShowDialog();
                reponsePopUp();
            }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Double hauteur = 0.17 * this.Height;
            int h = positionJoueur.Y - (int)hauteur;
            //Console.WriteLine("La position du joueur sur le panelJoueur : " + positionJoueur.X + " et " + h); 
           
            e.Graphics.DrawImage(imagesAvatars[chevalier.avatarJoueur()], positionJoueur.X, h, 123, 160);
        }

        public void positionLieux()
        {
            Console.WriteLine(CarteJeu.Size);
            Double montagneTop;
            Double villageTop;
            Double troncTop;
            Double cabaneTop;
            Double chateauTop;
            Double villageLeft;
            Double troncLeft;
            Double cabaneLeft;
            Double chateauLeft;
            Double montagneLeft;

            Double montagneLargeur;
            Double villageLargeur;
            Double troncLargeur;
            Double cabaneLargeur;
            Double chateauLargeur;
            Double villageHauteur;
            Double troncHauteur;
            Double cabaneHauteur;
            Double chateauHauteur;
            Double montagneHauteur;

            //on ajoute le conteneur d'etoiles
            conteneurEtoilesCoffre.Top = -5;
            conteneurEtoilesCoffre.BringToFront();
            coffre.Top = 10;
            ConteneurEtoile.Top = 25;
            ConteneurEtoile.Left = 35;

            if (responsiveTab == true)
            {
                Double posL = 0.20 * CarteJeu.Width;
                conteneurEtoilesCoffre.Left = (int)posL;
                posL = 0.68 * CarteJeu.Width;
                coffre.Left = (int)posL;
                posL = 0.64 * CarteJeu.Width;
                ConteneurEtoile.Width = (int)posL;
            }
            else
            {
                Double posL = 0.23 * CarteJeu.Width;
                conteneurEtoilesCoffre.Left = (int) posL;
                posL = 0.67 * CarteJeu.Width;
                coffre.Left = (int)posL;
                posL = 0.64 * CarteJeu.Width;
                ConteneurEtoile.Width = (int)posL;
            }
            
            //position du tableau de bord
            Double tabBordTop = 0.90 * CarteJeu.Height;
            tabBord.Top = (int)tabBordTop;
            tabBord.Width = 240;
            tabBord.Height = 87;

            if (responsiveTab == true)
            {
                Double tabBordLeft = 0.796 * CarteJeu.Width;
                tabBord.Left = (int)tabBordLeft;
                
            }
            else
            {
                Double tabBordLeft = 0.84 * CarteJeu.Width;
                tabBord.Left = (int)tabBordLeft;
            }
            
            
            //guide
            guide.Width = 49;
            guide.Height = 49;
            guide.Left = 143;
            guide.Top = 8;

            //sauvegarde
            sauvegarde.Width = 49;
            sauvegarde.Height = 49;
            sauvegarde.Left = 84;
            sauvegarde.Top = 8;

            //quitterMiniJeu
            quitterMiniJeu.Width = 49;
            quitterMiniJeu.Height = 49;
            quitterMiniJeu.Left = 25;
            quitterMiniJeu.Top = 8;

            villageHauteur = 0.36 * CarteJeu.Height;
            villageLargeur = 0.33 * CarteJeu.Width;

            troncHauteur = 0.26 * CarteJeu.Height;
            troncLargeur = 0.13 * CarteJeu.Width;

            cabaneHauteur = 0.26 * CarteJeu.Height;
            cabaneLargeur = 0.16 * CarteJeu.Width;

            chateauHauteur = 0.54 * CarteJeu.Height;
            chateauLargeur = 0.24 * CarteJeu.Width;

            montagneHauteur = 0.26 * CarteJeu.Height;
            montagneLargeur = 0.29 * CarteJeu.Width;

            Village.Width = (int)villageLargeur;
            Village.Height = (int)villageHauteur;

            Cabane.Width = (int)cabaneLargeur;
            Cabane.Height = (int)cabaneHauteur;

            Tronc.Width = (int)troncLargeur;
            Tronc.Height = (int)troncHauteur;

            Chateau.Width = (int)chateauLargeur;
            Chateau.Height = (int)chateauHauteur;

            Montagne.Width = (int)montagneLargeur;
            Montagne.Height = (int)montagneHauteur;

            villageTop = 0.69 * CarteJeu.Height;
            troncTop = 0.145 * CarteJeu.Height;
            cabaneTop = 0.59 * CarteJeu.Height;
            chateauTop = 0.176 * CarteJeu.Height;
            villageLeft = -0.022 * CarteJeu.Width;
            troncLeft = 0.45 * CarteJeu.Width;
            cabaneLeft = 0.564 * CarteJeu.Width;
            chateauLeft = 0.75 * CarteJeu.Width;
            montagneLeft = 0.002 * CarteJeu.Width;
            montagneTop = 0.005 * CarteJeu.Height;

            Montagne.Top = (int)montagneTop;
            Village.Top = (int)villageTop;
            Tronc.Top = (int)troncTop;
            Chateau.Top = (int)chateauTop;
            Cabane.Top = (int)cabaneTop;
            Montagne.Left = (int)montagneLeft;
            Village.Left = (int)villageLeft;
            Tronc.Left = (int)troncLeft;
            Chateau.Left = (int)chateauLeft;
            Cabane.Left = (int)cabaneLeft;

            posLieu(Village, 0.09, 0.65);
            posLieu(Chateau, 0.82, 0.55);
            posLieu(Cabane, 0.59, 0.65);
            posLieu(Tronc, 0.47, 0.21);
            posLieu(Montagne, 0.09, 0.21);

            //refresh carte
            Refresh();
        }

        //deplacement de l'avatar
        private void declencheTimer(object sender, EventArgs e)
        {
            arrivee = (Lieu)sender;
            panelJoueur.Show();
            imgChevalier.Hide();
            panelJoueur.BringToFront();
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
                
            }
            //depart == village
            else if (chevalier.positionJoueur().Name.Equals("Memory"))
            {
                if (arrivee.Name.Equals("Grand Ou Petit") || arrivee.Name.Equals("Que fait le Roi?"))
                {
                    deplacementVertical(arrivee);
                }
                else
                {
                    deplacementHorizontal(arrivee);
                }
            }
            //depart == cabane
            else if (chevalier.positionJoueur().Name.Equals("Chasse aux mots"))
            {
                if (arrivee.Name.Equals("Grand Ou Petit"))
                {
                    //cabane ou tronc
                    deplacementCabaneTronc();
                }
                else
                {
                    deplacementHorizontal(arrivee);
                }
            }
            //depart == Tronc
            else if (chevalier.positionJoueur().Name.Equals("Grand Ou Petit"))
            {
                if (arrivee.Name.Equals("Chasse aux mots"))
                {
                    //cabane
                    deplacementCabaneTronc();
                }
                else
                {
                    deplacementHorizontal(arrivee);
                }
            }
            //depart == Montagne
            else if (chevalier.positionJoueur().Name.Equals("Que fait le Roi?"))
            {
                if (arrivee.Name.Equals("Chateau"))
                {
                    deplacementHorizontal(arrivee);
                }
                else
                {
                    //montagne
                    deplacementVertical(arrivee);
                }
            }

            //on desactive le timer
            timer2.Enabled = false;
            //on cache le panel qui permet le deplacement du joueur
            panelJoueur.Hide();
            //on actualise la position du joueur dans l'objet Joueur
            chevalier.setPosition(arrivee);
            positionJoueur = chevalier.positionJoueur().getPosition();
            //on actualise la position de l'avatar
            imgChevalier.Location = positionJoueur;
            //on affiche a nouveau l'avatar
            imgChevalier.Show();

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
            while (positionJoueur.X != a.getPosition().X)
            {
                if (positionJoueur.X < a.getPosition().X)
                {
                    positionJoueur.X += 2;
                }
                else
                {
                    positionJoueur.X -= 2;
                }

                //on invalide la region ou se trouve le perso
                CarteJeu.Invalidate(new Rectangle(positionJoueur.X, positionJoueur.Y, imgChevalier.Width, imgChevalier.Height));
                CarteJeu.Update();
            }

            while (positionJoueur.Y != a.getPosition().Y)
            {
                if (positionJoueur.Y < a.getPosition().Y)
                {
                    positionJoueur.Y += 2;
                }
                else
                {
                    positionJoueur.Y -= 2;
                }

                //on invalide la region ou se trouve le perso
                CarteJeu.Invalidate(new Rectangle(positionJoueur.X, positionJoueur.Y, imgChevalier.Width, imgChevalier.Height));
                CarteJeu.Update();
            }
        }

        private void deplacementVertical(Lieu a)
        {
            while (positionJoueur.Y != a.getPosition().Y)
            {
                if (positionJoueur.Y < a.getPosition().Y)
                {
                    positionJoueur.Y += 2;
                }
                else
                {
                    positionJoueur.Y -= 2;
                }
                //on invalide la region ou se trouve le perso
                CarteJeu.Invalidate(new Rectangle(positionJoueur.X, positionJoueur.Y, imgChevalier.Width, imgChevalier.Height));
                CarteJeu.Update();
            }

            while (positionJoueur.X != a.getPosition().X)
            {
                if (positionJoueur.X < a.getPosition().X)
                {
                    positionJoueur.X += 2;

                }
                else
                {
                    positionJoueur.X -= 2;
                }

                //on invalide la region ou se trouve le perso
                CarteJeu.Invalidate(new Rectangle(positionJoueur.X, positionJoueur.Y, imgChevalier.Width, imgChevalier.Height));
                CarteJeu.Update();
            }
        }

        private void deplacementCabaneTronc()
        {
            //if depart == Tronc
            if (chevalier.positionJoueur().Name.Equals("Grand Ou Petit"))
            {
                deplacementHorizontal(Chateau);
                deplacementVertical(Cabane);
            }
            //if depart== Cabane
            else if (chevalier.positionJoueur().Name.Equals("Chasse aux mots"))
            {
                deplacementHorizontal(Chateau);
                deplacementVertical(Tronc);
            }
        }

        //sauvegarde

        private void sauvegardeButton(object sender, EventArgs e)
        {
            sauvegardePartie();
        }

        private void sauvegardePartie()
        {
            //sauvegarde en pleine partie / enregistrement dans le tableau joueursFichier. l-enregistrement en dur se fera a la fermeture de l-application
            Boolean enregistrer = false;
            Console.WriteLine(chevalier.positionJoueur());
            String enregistrementJoueur = chevalier.nomJoueur() + "-" + chevalier.ageJoueur() + "-" + chevalier.avatarJoueur() + "-" + chevalier.positionJoueur().Name + "-" + chevalier.scoreJoueur() + "-" + chevalier.dossierJoueur() + "-" + chevalier.getEpreuvesGagnees(0) + "-" + chevalier.getEpreuvesGagnees(1) + "-" + chevalier.getEpreuvesGagnees(2) + "-" + chevalier.getEpreuvesGagnees(3);

            //on enregistre dans le tableau joueursFichiers les nouvelles valeurs pour le joueur actuel

            for (int i = 0; i < joueursFichier.Count(); i++)
            {
               
                if (joueursFichier.ElementAt(i).Contains(chevalier.nomJoueur()) && joueursFichier.ElementAt(i).Contains(chevalier.dossierJoueur()) && enregistrer == false)
                {
                    Console.WriteLine(chevalier.dossierJoueur());
                    //on met a jour les donnees
                    joueursFichier[i] = enregistrementJoueur;
                    enregistrer = true;
                }
            }

            //on signale au joueur que l-enregistrement a ete fait

            List<String> nomsButtons = new List<string>();
            List<int> refEvents = new List<int>();
            nomsButtons.Add(Textes[26]);

            if (choixFinMiniJeu == 3)
            {
                //si notre choix precedent pointait sur l'event sauvegardeRetourAccueil
                //retour a l'accueil
                refEvents.Add(5);
            }
            else
            {
                //retour au jeu
                refEvents.Add(0);
            }
            
            if (enregistrer == true)
            {
                var message = Textes[47];
                var Popup = new PopUp(ColorTranslator.FromHtml("#3a9259"), items.guide, 1, message, nomsButtons, refEvents);
                Popup.ShowDialog();
                //reponsePopUp();
            }
            else
            {
                var message = Textes[48];
                var Popup = new PopUp(ColorTranslator.FromHtml("#be1621"), items.attention, 1, message , nomsButtons, refEvents);
                Popup.ShowDialog();
                //reponsePopUp();
            }
        }

        //sauvegarde + exit

        private void quitterPartie(object sender, EventArgs e)
        {
            //enregistrement en dur des donnees
            enregistrementFichier("Joueurs.txt");

            //on quitte le jeu
            Application.Exit();
        }

        //modification de l'etat du lieu sur la carte 

        private void changementImageLieu(object sender, EventArgs e)
        {
            //on change l-image du lieu
            Lieu p = (Lieu)sender;
            p.chargementSurvolImage();
        }

        private void changementImageLieuOrigine(object sender, EventArgs e)
        {
            //on change l-image du lieu
            Lieu p = (Lieu)sender;
            p.chargementDebutImage();
        }

        //MINI JEUX

        //afficher le mini jeu
        public void afficheTuto()
        {
            if (jeuEnCours.Equals("Chasse aux mots"))
            {
                tuto = new tutoChasseAuxMots();
            }
            else if (jeuEnCours.Equals("Grand Ou Petit"))
            {
                tuto = new tutoGrandOuPetit();
            }
            else if (jeuEnCours.Equals("Que fait le Roi?"))
            {
                tuto = new tutoQueFaitLeRoi();
            }
            else if (jeuEnCours.Equals("Memory"))
            {
                tuto = new tutoMemory();
            }
            tuto.ShowDialog();
        }

        private void afficheJeu(String nomJeu, Panel p)
        {
            //this.Opacity = 0.80;
            //fade.Start();
            this.Controls.Remove(CarteJeu);
            Jeu.Controls.Add(Table);
            this.Controls.Add(Jeu);

            //on ajoute le minijeu
            miniJeu.Controls.Clear();
            miniJeu.Controls.Add(p);
            conteneurEtoilesCoffre.Margin = new Padding(0);
            coffre.Top = 5;
            
            tabBord.BackgroundImageLayout = ImageLayout.Stretch;
            tabBord.Width = 140;
            tabBord.Height = 70;
            tabBord.Dock = DockStyle.None;
            tabBord.Anchor = AnchorStyles.Left | AnchorStyles.Top;

            if (responsiveTab == true)
            {
                quitterMiniJeu.Left = 15;
                sauvegarde.Left = 50;
                guide.Left = 85;
            }
            else
            {
                quitterMiniJeu.Left = 22;
                sauvegarde.Left = 62;
                guide.Left = 102;

            }

            sauvegarde.Top = 11;
            sauvegarde.Width = 30;
            sauvegarde.Height = 30;

            guide.Top = 11;
            guide.Width = 30;
            guide.Height = 30;

            quitterMiniJeu.Top = 11;
            quitterMiniJeu.Width = 30;
            quitterMiniJeu.Height = 30;
            
            imgChevalier.Width = 100;
            imgChevalier.Height = 130;

            if (epreuvesO.Contains(miniJeu.Controls[0]) || epreuvesF.Contains(miniJeu.Controls[0]))
            {
                if (epreuvesO.Contains(miniJeu.Controls[0]))
                {
                    titreJeu.Text = Textes[31];
                }
                else
                {
                    titreJeu.Text = Textes[32];
                }

                titreJeu.Text = titreJeu.Text + " : " +jeuEnCours;
                p.EnabledChanged += new EventHandler(finMiniJeu);
            }
            
            //on met le nom du joueur
            prenomJoueur.Text = chevalier.nomJoueur();
           
            //on ajoute les etoiles au conteneurEtoiles

            ajoutEtoiles();

            //on met a jour les etoiles a gagner
            miseAJourEtoiles();

            //on configure le layout
            Table.Controls.Clear();
            Table.ColumnStyles.Clear();
            Table.RowStyles.Clear();

            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));

            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));

            p.Dock = DockStyle.None;
            p.Anchor = AnchorStyles.None;

            imgChevalier.Anchor = AnchorStyles.None;
            
            //on ajoute tous les composants dans le panel
            Table.Controls.Add(tabBord, 0, 3);
            Table.Controls.Add(objectif, 0, 2);
            Table.Controls.Add(conteneurEtoilesCoffre, 2, 0);
            Table.Controls.Add(imgChevalier, 0, 0);
            Table.Controls.Add(prenomJoueur, 1, 0);
            Table.Controls.Add(titreJeu, 1, 1);
            Table.Controls.Add(miniJeu, 1, 2);

            Table.SetColumnSpan(titreJeu, 3);
            Table.SetColumnSpan(conteneurEtoilesCoffre, 2);
            Table.SetColumnSpan(miniJeu, 3);
            Table.SetRowSpan(miniJeu, 2);
            Table.SetRowSpan(imgChevalier, 2);

            Thread t = new Thread(new ThreadStart(afficheTuto));
            t.Start();
            //Thread.Sleep(6000);
            //t.Abort();
        }

        private void LanceMiniJeu(object sender, EventArgs e)
        {
            Lieu l = (Lieu)sender;
            FonctionChateauActive = false;

            epreuvesO = chevalier.epreuvesJoueur();
            epreuvesF = chevalier.epreuvesFacultatives();

            jeuEnCours = l.Name;

            if (jeuEnCours.Equals("Chasse aux mots"))
            {
                //la chasse aux mots se deroule dans la montagne
                Jeu.BackgroundImage = items.montagne;
                IndiceJeu = 1;
            }
            else if (jeuEnCours.Equals("Grand Ou Petit"))
            {
                //grand ou petit se deroule dans une clairiere
                Jeu.BackgroundImage = items.clairiere;
                IndiceJeu = 2;
            }
            else if (jeuEnCours.Equals("Que fait le Roi?"))
            {
                //que fait le roi se deroule a cote de la riviere
                Jeu.BackgroundImage = items.riviere;
                IndiceJeu = 3;
            }
            else if (jeuEnCours.Equals("Memory"))
            {
                Jeu.BackgroundImage = items.village;
                IndiceJeu = 0;
            }
            else
            {
                FonctionChateauActive = true;
                devoileCoffre();
            }
            
            //la verification du nombre d'etoiles gagnees ne sert que si le joueur accede a un mini jeu et non au chateau
            if (FonctionChateauActive == false)
            {
                //si le joueur a deja gagnee l'epreuve obligatoire,
                //on peut lui demander s-il veut joueur au niveau suivant
                if (chevalier.getEpreuvesGagnees(IndiceJeu) == 1)
                {
                    List<String> nomsButtons = new List<string>();
                    List<int> refEvents = new List<int>();
                    nomsButtons.Add(Textes[31]);
                    nomsButtons.Add(Textes[32]);
                    nomsButtons.Add(Textes[34]);
                    refEvents.Add(2);
                    refEvents.Add(3);
                    refEvents.Add(1);

                    var message = Textes[35];
                    var Popup = new PopUp(ColorTranslator.FromHtml("#4d78ab"), items.guide, 3, message, nomsButtons, refEvents);
                    Popup.ShowDialog();
                    reponsePopUp();
                }
                else
                {
                    //s'il n'a jamais gagne les etoiles
                    afficheJeu(jeuEnCours, epreuvesO.ElementAt(IndiceJeu));
                }
            }
        }

        //retour vers La Carte ou l-Accueil depuis le mini jeu
        private void retourTabBord(object sender, EventArgs e)
        {
            if (this.Controls.Contains(Jeu))
            {
                miniJeu.Controls.Clear();
                this.Controls.Remove(Jeu);
                Carte();
            }
            else if (this.Controls.Contains(diaporamaHistoire))
            {
                this.Controls.Remove(diaporamaHistoire);
                Carte();
            }
            else if (this.Controls.Contains(CarteJeu))
            {
                List<String> nomsButtons = new List<string>();
                List<int> refEvents = new List<int>();
                nomsButtons.Add(Textes[43]);
                nomsButtons.Add(Textes[116]);
                nomsButtons.Add(Textes[44]);
                refEvents.Add(4);
                refEvents.Add(5);
                refEvents.Add(0);
                var message = String.Format(Textes[45], Environment.NewLine);
                var Popup = new PopUp(ColorTranslator.FromHtml("#eda43b"), items.attention, 3, message, nomsButtons, refEvents);
                Popup.ShowDialog();
                reponsePopUp();
            }
        }

        //traitement apres la reussite du mini jeu
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
                    miseAJourEtoiles();
                    //on enregistre les nouvelles etoiles
                    chevalier.setJoueurScore(3);

                    if (chevalier.scoreJoueur() == 12)
                    {
                        FinJeu = true;
                    }
                    //on met les etoiles dans conteneurEtoiles
                    ajoutEtoiles();
                }
                //on demande au joueur s-il veut jouer au niveau suivant mais pas d-etoiles a gagner supp. c-est juste pour savoir s-il a assimile
                //ici pop up spe
                List<String> nomsButtons = new List<string>();
                List<int> refEvents = new List<int>();
                nomsButtons.Add(Textes[36]);
                nomsButtons.Add(Textes[32]);
                nomsButtons.Add(Textes[34]);
                refEvents.Add(2);
                refEvents.Add(3);
                refEvents.Add(1);

                var message = Textes[37];
                var Popup = new PopUp(ColorTranslator.FromHtml("#bbc88c"), items.felicitations, 3, message, nomsButtons, refEvents);
                Popup.ShowDialog();
                reponsePopUp();
            }
        }

        public void finMiniJeuFacultatif(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            if (p.Enabled == false)
            {
                //ici il faudra mettre l-image du lieu en gris de maniere definitive

                CarteJeu.BackgroundImage = listeLieux[IndiceJeu].chargementLieuInactif();

                //remove le mouseEnter et le mouseSortie
                listeLieux[IndiceJeu].MouseEnter -= changementImageLieu;
                listeLieux[IndiceJeu].MouseLeave -= changementImageLieuOrigine;

                //on peut proposer au joueur de rejouer ou de revenir a la carte

                List<String> nomsButtons = new List<string>();
                List<int> refEvents = new List<int>();
                nomsButtons.Add(Textes[31]);
                nomsButtons.Add(Textes[32]);
                nomsButtons.Add(Textes[34]);
                refEvents.Add(2);
                refEvents.Add(3);
                refEvents.Add(1);
                var message = Textes[38];
                var Popup = new PopUp(ColorTranslator.FromHtml("#bbc88c"), items.felicitations, 3, message, nomsButtons, refEvents);
                Popup.ShowDialog();
                reponsePopUp();
            }
        }
        
        public void reponsePopUp()
        {
            if (choixFinMiniJeu == 0)
            {
                //on revient a la carte
                Table.Controls.Clear();
                this.Controls.Remove(Jeu);
                Carte();
            }
            else if (choixFinMiniJeu == 1)
            {
                //on affiche et on reload le premier niveau
                if (this.Controls.Contains(CarteJeu))
                {
                    afficheJeu(jeuEnCours, epreuvesO.ElementAt(IndiceJeu));
                }
                else
                {
                    miniJeu.Controls.Clear();
                    epreuvesO.ElementAt(IndiceJeu).chargementPartie();
                    epreuvesO.ElementAt(IndiceJeu).Dock = DockStyle.None;
                    epreuvesO.ElementAt(IndiceJeu).Anchor = AnchorStyles.None;
                    miniJeu.Controls.Add(epreuvesO.ElementAt(IndiceJeu));
                    titreJeu.Text = Textes[31] + ": " +jeuEnCours;
                }
                
            }
            else if (choixFinMiniJeu == 2)
            {
                //on joue au deuxieme niveau
                if (this.Controls.Contains(CarteJeu))
                {
                    afficheJeu(jeuEnCours, epreuvesO.ElementAt(IndiceJeu));
                }
                else
                {
                    //on vide le panel mini jeu
                    miniJeu.Controls.Clear();
                    //on initialise la nouvelle partie et on l'affiche
                    epreuvesF.ElementAt(IndiceJeu).chargementPartie();
                    epreuvesF.ElementAt(IndiceJeu).Dock = DockStyle.None;
                    epreuvesF.ElementAt(IndiceJeu).Anchor = AnchorStyles.None;
                    miniJeu.Controls.Add(epreuvesF.ElementAt(IndiceJeu));
                    //on change le titre du mini jeu
                    titreJeu.Text = Textes[32] + ": " + jeuEnCours;
                }
            }
            else if (choixFinMiniJeu == 3)
            {
                //on sauvegarde et on quitte
                sauvegardePartie();
                //enregistrement en dur des donnees
                enregistrementFichier("Joueurs.txt");

                //on revient a l-accueil
                afficheAccueil();
            }
            else if (choixFinMiniJeu == 4)
            {
                //on revient a l'accueil
                afficheAccueil();
            }
        }

        //ajouter les etoiles au conteneurEtoiles
        public void ajoutEtoiles()
        {
            ConteneurEtoile.Controls.Clear();
            //etoiles jaunes

            if (chevalier.scoreJoueur() != 0)
            {
                for (int i = 0; i < chevalier.scoreJoueur(); i++)
                {
                    if (responsiveTab == true)
                    {
                        int left = i * 55;
                        //etoiles plus petites
                        ConteneurEtoile.Controls.Add(new Etoile(40, 40, left, 1));
                    }
                    else
                    {
                        int left = i * 70;
                        ConteneurEtoile.Controls.Add(new Etoile(left, 1));
                    }
                    
                }
            }

            //on complete avec les etoiles encore dispo soit les etoiles grises
            for (int i = chevalier.scoreJoueur(); i < 12; i++)
            {

                if (responsiveTab == true)
                {
                    int left = i * 55;
                    //etoiles plus petites
                    ConteneurEtoile.Controls.Add(new Etoile(40, 40, left, 2));
                }
                else
                {
                    int left = i * 70;
                    ConteneurEtoile.Controls.Add(new Etoile(left, 2));
                }
            }
        }

        //mise a jour gain etoiles

        public void miseAJourEtoiles()
        {
            etoilesObjectif.Controls.Clear();
            
            if (chevalier.getEpreuvesGagnees(IndiceJeu) == 1)
            {
                //epreuve remportee / alors il n'y a pas d'etoiles jaunes a remporter

                if (responsiveTab == true)
                {
                    etoilesObjectif.Controls.Add(new Etoile(40, 40, 0, 0, 2));
                    etoilesObjectif.Controls.Add(new Etoile(40, 40, 70, 0, 2));
                    etoilesObjectif.Controls.Add(new Etoile(40, 40 , 35, 70, 2));
                }
                else
                {
                    etoilesObjectif.Controls.Add(new Etoile(0, 0, 2));
                    etoilesObjectif.Controls.Add(new Etoile(90, 0, 2));
                    etoilesObjectif.Controls.Add(new Etoile(45, 70, 2));
                }

            }
            else
            {
                //epreuve perdue ou premiere fois /il y a encore des etoiles a remporter
                //on ajoute les etoiles jaunes
                if (responsiveTab == true)
                {
                    etoilesObjectif.Controls.Add(new Etoile(40, 40, 0, 0, 1));
                    etoilesObjectif.Controls.Add(new Etoile(40, 40, 70, 0, 1));
                    etoilesObjectif.Controls.Add(new Etoile(40, 40, 35, 70, 1));
                }
                else
                {
                    etoilesObjectif.Controls.Add(new Etoile(0, 0, 1));
                    etoilesObjectif.Controls.Add(new Etoile(90, 0, 1));
                    etoilesObjectif.Controls.Add(new Etoile(45, 70, 1));
                }
            }
        }

        //aide du jeu

        public String ConseilsGuide()
        {
            String message = "";

            if (this.Controls.Contains(CarteJeu))
            {
                message = Textes[51];
            }
            else if (this.Controls.Contains(Jeu))
            {
                if (jeuEnCours == "Memory")
                {
                    message = String.Format(Textes[52], Environment.NewLine);
                }
                else if (jeuEnCours == "Chasse aux mots")
                {
                    message = Textes[53];
                }
                else if (jeuEnCours == "Que fait le Roi?")
                {
                    message = String.Format(Textes[54], Environment.NewLine);
                }
                else if (jeuEnCours == "Grand ou Petit")
                {
                    message = String.Format(Textes[55], Environment.NewLine);
                }
            }

            return message;
        }

        public void AfficheMessage(object sender, EventArgs e)
        {
            List<String> nomsButtons = new List<string>();
            List<int> refEvents = new List<int>();
            nomsButtons.Add(Textes[26]);
            refEvents.Add(0);
            var message = ConseilsGuide(); 
            var Popup = new PopUp(ColorTranslator.FromHtml("#4d78ab"), items.guide, 1, message, nomsButtons, refEvents);
            Popup.ShowDialog();
        }

    //revelation du coffre

        public void devoileCoffre()
        {
            this.Controls.Remove(CarteJeu);
            diaporama();

            if (chevalier.scoreJoueur() < 12)
            {
                passageChateau = 1;
                actionJoueur.Text = Textes[26];
                actionJoueur.Click -= afficherCarte;
                actionJoueur.Click += new EventHandler(retourTabBord);
                precedent.Hide();
                textePresentationJeu.Text = String.Format(Textes[5], Environment.NewLine);
            }
            else
            {
                passageChateau = 2;
                actionJoueur.Text = Textes[114];
                actionJoueur.Click -= afficherCarte;
                actionJoueur.Click += new EventHandler(afficheRecompense);
                textePresentationJeu.Text = String.Format(Textes[6], Environment.NewLine);
            }
            
            this.Controls.Add(diaporamaHistoire);
        }
        
        public void afficheRecompense(object sender, EventArgs e)
        {
            recompense PanelRecompense = new recompense(privateFontCollection);
            
            this.Controls.Add(PanelRecompense);
            PanelRecompense.BringToFront();
        }
        
    }

    //Classes annexes

    #region
    public class TableLayoutPanelPlus : TableLayoutPanel
    {
        public TableLayoutPanelPlus()
        {
            this.DoubleBuffered = true;
        }
    }

    public class FormSpecial : Form
    {
        public FormSpecial()
        {

        }

        // Prevent form and controls from flickering
        //try to understand why
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
    }

    public abstract class PopForm : Form
    {
        //pop up qui sert pour l'affichage du tutorial d'un mini jeu
        Button exit = new Button();
        SpecialLabel label1 = new SpecialLabel();
        public delegate void actionTuto();
        public List<actionTuto> tableauFonctions = new List<actionTuto>();
        int compteur = -1;
        public System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
        public Panel conteneur = new Panel();
        public Win32.POINT p = new Win32.POINT();

        protected PopForm () 
        {
            this.ClientSize = new Size(540, 530); 
            this.BackColor = ColorTranslator.FromHtml("#DAA520");
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoScaleDimensions = new SizeF(6F, 13F);

            //conteneur
            this.Controls.Add(conteneur);
            conteneur.Location = new Point(0,100);
            conteneur.Size = new Size(540, 430);
            //timer2
            timer2.Interval = 2500;
            timer2.Tick += new EventHandler(timerPause);

            //exit
            this.exit.BackgroundImage = items.exit;
            this.exit.BackgroundImageLayout = ImageLayout.Stretch;
            this.exit.Size = new Size(50,50);
            this.exit.Location = new Point(470, 20);
            this.exit.BackColor = Color.Transparent;
            this.exit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.exit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.TabStop = false;
            this.exit.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            this.exit.FlatStyle = FlatStyle.Flat;
            this.exit.Dock = DockStyle.None;
            this.exit.Cursor = Cursors.Hand;
            this.Controls.Add(exit);
            this.exit.Click += new EventHandler(sortieApplication);

            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = Color.White;
            this.label1.Font = new Font(petiteBoite.privateFontCollection.Families[0], 30);
            this.label1.Location = new Point(130, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = petiteBoite.Textes[39];
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(label1);
            
        }

        private void sortieApplication(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void timerPause(object sender, EventArgs e)
        {
            compteur++;
            if (compteur < tableauFonctions.Count)
            {
                tableauFonctions[compteur]();
            }
            else
            {
                timer2.Stop();
            }
        }

    }

    public class Win32
    {
        [DllImport("User32.Dll")]
        public static extern long SetCursorPos(int x, int y);

        [DllImport("User32.Dll")]
        public static extern bool ClientToScreen(IntPtr hWnd, ref POINT point);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;
            public int y;
        }
    }

#endregion
}
