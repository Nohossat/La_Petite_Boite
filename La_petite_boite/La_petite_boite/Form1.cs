using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Media;
using Jeu;
using Ressources;
using System.Web;
using System.Resources;

//reste a faire:  design,

namespace La_petite_boite
//il faut regler bug affichage images, ajouter les recompenses et diapo roi.
{
    public partial class Form1 : FormSpecial
    {
        Assembly _assembly = Assembly.GetExecutingAssembly();

        //creation des objets et variables globales
        public static Boolean chargementReussi = false;
        public bool sauvegardeFlag = false;

        public static int age;
        public static int top;
        public static int left;
        public static int score = 0;
        public static int avatar;
        public int IndiceJeu = 0;
        public int choixFinMiniJeu = 0;
        public static int[] epreuvesEmportees = new int[4];

        public Joueur chevalier;
        
        public static Label titreJeu = new Label();
        public static Panel objectif = new Panel();
        public static Panel chargerJoueur = new Panel();
        public static Panel ConteneurEtoile = new Panel();
        public static Panel conteneurEtoilesCoffre = new Panel();
        public Panel Jeu = new Panel();
        public Panel CarteJeu = new Panel();
        public Panel panelJoueur = new Panel();

        public static String dossier = "";
        public static String nom;
        public static String dos;
        public static String lieuTemporaire;
        public static String resultatJeu;
        public static List<String> joueursFichier = new List<string>();
        public static List<String> listeSauvegarde = new List<string>();

        public List<Jeu.Jeu> epreuvesO;
        public List<Jeu.Jeu> epreuvesF;
        public static Lieu positionInitiale = new Lieu();
        public static PrivateFontCollection privateFontCollection;
        public Form tuto;

        //private variables
        int indexAvatar = -1;
        TableLayoutPanelPlus miniJeu = new TableLayoutPanelPlus();
        TableLayoutPanelPlus Table = new TableLayoutPanelPlus();
        SpecialButton nouvellePartie = new SpecialButton();
        SpecialButton chargerPartie = new SpecialButton();
        SpecialButton quitter = new SpecialButton();

        ControlButton commencer = new ControlButton();
        ControlButton retour = new ControlButton();

        LittleButton actionJoueur = new LittleButton(530);
        LittleButton precedent = new LittleButton(600);

        Button Yes;
        Button No;
        List<Bitmap> imagesDiaporama = new List<Bitmap>();

        ComboBox listeDossierSauvegarde = new ComboBox();

        Lieu Village = new Lieu(470, -28, 448, 270, items.villagePrevious, items.villageAfter, items.mapVillage, new Point(120, 440), "Memory"); //MEMORY
        Lieu Chateau = new Lieu(106, 1006, 327, 404, items.chateauPrevious, items.chateauAfter, items.map, new Point(1050, 380), "Chateau");//CHATEAU
        Lieu Cabane = new Lieu(417, 755, 213, 192, items.cabanePrevious, items.cabaneAfter, items.mapCabane, new Point(760, 440), "Chasse aux mots");//CHASSE AUX MOTS
        Lieu Tronc = new Lieu(80, 600, 177, 196, items.troncPrevious, items.troncAfter, items.mapTronc, new Point(600, 160), "Grand Ou Petit");//GRAND OU PETIT
        Lieu Montagne = new Lieu(-5, -3, 378, 196, items.montagnePrevious, items.montagneAfter, items.mapMontagne, new Point(120, 146), "Que fait le Roi?");//QUE FAIT LE ROI
        Lieu arrivee = new Lieu();

        SpecialLabel menuPrincipal = new SpecialLabel();
        SpecialLabel Titre = new SpecialLabel();
        SpecialLabel textePresentationJeu = new SpecialLabel();

        Label prenomLabel = new Label();
        Label ageLabel = new Label();
        Label dossierSauvegarde = new Label();
        Label prenomJoueur = new Label();
        Label gain = new Label();

        ListBox joueursPossibles = new ListBox();

        Lieu[] listeLieux;
        Lieu accueil = new Lieu();

        Panel nouveauJoueur = new Panel();
        Panel choixAvatar = new Panel();
        Panel saisirInfos = new Panel();
        Panel diaporamaHistoire = new Panel();
        Panel tabBord = new Panel();
        Panel Recompense = new recompense();
        Panel conteneurTitrePPL = new Panel();
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
        List<PictureBox> listeAvatars = new List<PictureBox>();
        Image imgChev = items.bain1;//TEST

        List<Bitmap> imagesAvatars = new List<Bitmap>();
        List<Bitmap> imagesAvatarsGris = new List<Bitmap>();

        Point positionJoueur = new Point();
        String jeuEnCours = "";
        String message = "";
        String nomJoueur = "";
        List<String> textesDiaporama = new List<String>();

        TextBox prenomField = new TextBox();
        TextBox ageField = new TextBox();

        //Charger les elements
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Double flagResolution = Screen.PrimaryScreen.Bounds.Height / System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            Console.WriteLine("resolution flag :" + System.Windows.Forms.Screen.PrimaryScreen);
            if (flagResolution == 1366 / 768)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                this.ClientSize = new System.Drawing.Size(System.Windows.Forms.Screen.PrimaryScreen.Bounds.X, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Y);
            }
            {
                this.ClientSize = new System.Drawing.Size(1292, 726);
                this.Size = new System.Drawing.Size(1289, 728);
            }
            Console.WriteLine(this.Width);
            Console.WriteLine(this.Height);
            this.DoubleBuffered = true;
            //EMBED FONTS
            privateFontCollection = items.chargementFont();
            generationElements();
        }

        private void generationElements()
        {
            //---------------------LAYOUTS------------------------//

            Table.Location = new Point(0, 0);
            Table.Size = new Size(1292, 726);
            Table.AutoSize = true;
            Table.Name = "Table";
            Table.ColumnCount = 4;
            Table.RowCount = 4;
            Table.BackColor = Color.Transparent;
            Table.AutoSizeMode = AutoSizeMode.GrowOnly;
            Table.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            Table.Dock = DockStyle.Fill;
            Table.Margin = new Padding(0);


            //---------------------PANELS------------------------//

            listePanels.Add(chargement);
            listePanels.Add(accueil);
            listePanels.Add(nouveauJoueur);
            listePanels.Add(diaporamaHistoire);
            listePanels.Add(CarteJeu);
            listePanels.Add(Jeu);
            listePanels.Add(panelJoueur);

            foreach (Panel p in listePanels)
            {
                p.BackgroundImageLayout = ImageLayout.Stretch;
                p.Size = new Size(1273, 689);
                p.Anchor = AnchorStyles.None;
                p.Dock = DockStyle.Fill;
                p.Location = new Point(0, 0);
            }

            panelJoueur.Size = new Size(1273, 490);
            panelJoueur.Location = new Point(0, 120);
            panelJoueur.Dock = DockStyle.None;
            panelJoueur.Paint += new PaintEventHandler(this.Form1_Paint);
            panelJoueur.BackColor = Color.Transparent;

            //chargement
            chargement.BackgroundImage = items.chargement;
            

            //accueil
            accueil.BackgroundImage = items.accueil;

            //ecran nouveau joueur
            nouveauJoueur.BackgroundImage = items.menu;
            
            //carteJeu
            CarteJeu.BackgroundImage = items.map;
            CarteJeu.Name = "Carte";
            
            //ecran mini-jeu
            Jeu.Name = "Jeu";

            //--------------------MINI PANELS-------------------------------//

            //mini-panel choix avatar
            choixAvatar.Width = 700;
            choixAvatar.Height = 150;
            choixAvatar.Location = new Point(Convert.ToInt16(Width * 0.23), 165);
            choixAvatar.Anchor = AnchorStyles.None;
            choixAvatar.BorderStyle = BorderStyle.FixedSingle;
            choixAvatar.BackColor = Color.Transparent;

            //mini panel saisie informations personnelles
            saisirInfos.Width = 500;
            saisirInfos.Height = 250;
            saisirInfos.Top = 320;
            saisirInfos.Left = 450;
            saisirInfos.BackColor = Color.Transparent;
            saisirInfos.BorderStyle = BorderStyle.FixedSingle;

            //tabBord
            
            tabBord.BackColor = Color.Transparent;
            tabBord.BackgroundImage = items.banniereGriseTabBord;

            //on ajoute les boutons au tableau de bord

            tabBord.Controls.Add(sauvegarde);
            tabBord.Controls.Add(quitterMiniJeu);
            tabBord.Controls.Add(guide);
            
            //conteneurEtoilesCoffre
            
            conteneurEtoilesCoffre.Width = 1000;
            conteneurEtoilesCoffre.Height = 111;
            conteneurEtoilesCoffre.BackgroundImage = items.banniereGriseConteneurEtoiles;
            conteneurEtoilesCoffre.BackColor = Color.Transparent;

            //conteneurEtoile
            
            ConteneurEtoile.Width = 830;
            ConteneurEtoile.Height = 100;
            ConteneurEtoile.BackColor = Color.Transparent;

            //objectifs

            objectif.Width = 200;
            objectif.Height = 200;
            objectif.Top = 0;
            objectif.Left = 0;
            objectif.BackColor = Color.Transparent;

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
            guide.Image = items.aide;
            guide.Width = 50;
            guide.Height = 50;
            guide.SizeMode = PictureBoxSizeMode.StretchImage;
            guide.Click += new EventHandler(AfficheMessage);
            

            //sauvegarde
            sauvegarde.Image = items.sauvegarde;
            sauvegarde.BackColor = Color.Green;
            sauvegarde.Width = 34;
            sauvegarde.Height = 34;
            sauvegarde.SizeMode = PictureBoxSizeMode.StretchImage;
            sauvegarde.BackColor = Color.Transparent;
            sauvegarde.Click += new EventHandler(sauvegardeButton);

            //quitterMiniJeu
            quitterMiniJeu.Image = items.quitter;
            quitterMiniJeu.Name = "quitterMiniJeu";
            quitterMiniJeu.Width = 40;
            quitterMiniJeu.Height = 40;
            quitterMiniJeu.SizeMode = PictureBoxSizeMode.StretchImage;
            quitterMiniJeu.BackColor = Color.Transparent;
            quitterMiniJeu.Click += new EventHandler(retourTabBord);


            //---------------------------------FICHIERS-------------------------------------//

            //on lit le fichier Joueurs et on cree une nouvelle instance Joueur avec les donnees trouvees

            chargementTexte("Joueurs.txt", joueursFichier);
            chargementTexte("dossiers_sauvegarde.txt", listeSauvegarde);

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
            quitter.Top = 560;
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


            //ActionJouer button
            actionJoueur.Top = 0;
            actionJoueur.Left = 0;
            actionJoueur.Height = 90;
            actionJoueur.Width = 500;
            actionJoueur.Font = new Font(privateFontCollection.Families[0], 40);

            //precedent
            precedent.Height = 120;
            precedent.Width = 170;
            precedent.Left = 50;
            precedent.Top = 40;
            precedent.BackgroundImageLayout = ImageLayout.Stretch;
            precedent.BackgroundImage = items.retourFleche;
            precedent.Click += new EventHandler(afficherDiapoPrecedente);


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

            //contenu du menu ppl pour qu'il soit resizable

            conteneurTitrePPL.Top = 10;
            conteneurTitrePPL.Left = 0;
            conteneurTitrePPL.Width = this.Width;
            conteneurTitrePPL.Height = 160;
            conteneurTitrePPL.BackColor = Color.Transparent;
            conteneurTitrePPL.Dock = DockStyle.Top;

            //menu principal

            menuPrincipal.Text = "Menu Principal";
            menuPrincipal.Top = 10;
            menuPrincipal.Left = 0;
            menuPrincipal.Width = this.Width;
            menuPrincipal.Height = 160;
            menuPrincipal.Font = new Font(privateFontCollection.Families[0], 65);
            //menuPrincipal.ForeColor = ColorTranslator.FromHtml("#18518c"); 
            menuPrincipal.ForeColor = Color.Brown;
            menuPrincipal.BackColor = Color.Transparent;
            menuPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            menuPrincipal.AutoSize = false;
            menuPrincipal.Dock = DockStyle.Fill;

            //Titre pour le panneau nouveau personnage
            Titre.Text = "Choix du chevalier";
            Titre.Top = 45;
            Titre.Width = this.Width;
            Titre.Height = 160;
            Titre.Font = new Font(privateFontCollection.Families[0], 60);
            Titre.ForeColor = ColorTranslator.FromHtml("#6d5622");
            Titre.BackColor = Color.Transparent;
            Titre.TextAlign = ContentAlignment.MiddleCenter;
            Titre.AutoSize = false;
            Titre.Dock = DockStyle.Fill;

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
            prenomJoueur.TextAlign = ContentAlignment.MiddleCenter;
            prenomJoueur.Font = new Font(privateFontCollection.Families[0], 16);
            prenomJoueur.BackColor = Color.Transparent;

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

            
            gain.Text = "Gain";
            gain.Font = new Font(privateFontCollection.Families[0], 15);
            gain.BackColor = Color.Transparent;
            gain.ForeColor = Color.White;
            gain.Location = new Point(0, 0);
            gain.Size = new Size(150, 70);
            gain.TextAlign = ContentAlignment.MiddleCenter;
            objectif.Controls.Add(gain);
            

            //texte pour le diaporama

            textesDiaporama.Add("Bienvenue à toi " + nomJoueur + ", je suis le roi Kazan." + Environment.NewLine + "Es - tu pret pour la mission que j'ai a te confier?");
            textesDiaporama.Add("Avant de commencer, rends visite au magicien. " + Environment.NewLine + "Il te donnera de precieux conseils pour la suite de l'aventure");
            textesDiaporama.Add("Bienvenue à toi " + nomJoueur + " , je suis le magicien Kazan, et je serai ton guide tout au long de ton périple. " + Environment.NewLine + "Bon courage!");
            textesDiaporama.Add("est-ce que tu as vraiment recolter toutes les etoiles?");


            textePresentationJeu.Width = 1100;
            textePresentationJeu.Height = 300;
            textePresentationJeu.Top = 0;
            textePresentationJeu.Left = 0;
            textePresentationJeu.Font = new Font(privateFontCollection.Families[0], 19);
            textePresentationJeu.ForeColor = ColorTranslator.FromHtml("#f2f2f2");
            textePresentationJeu.BackColor = Color.Transparent;
            textePresentationJeu.TextAlign = ContentAlignment.TopCenter;

            //images pour le diaporama

            imagesDiaporama.Add(items.diapoTrone);
            imagesDiaporama.Add(items.diapoMag);


            //titre pour le mini jeu

            titreJeu.Width = 300;
            titreJeu.Height = 30;
            titreJeu.ForeColor = Color.White;
            titreJeu.BackColor = Color.Transparent;
            titreJeu.Top = 120;
            titreJeu.Left = 600;
            titreJeu.Font = new Font(titreJeu.Font.FontFamily, 16);
            titreJeu.TextAlign = ContentAlignment.MiddleCenter;

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

        public void chargementTexte(String nomFichier, List<String> tableauRes)
        {
            try
            {
                using (var reader = new StreamReader(nomFichier))
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
                Console.Write("Erreur lors de l'ecriture du fichier");
            }
        }

        //Afficher Accueil

        public void afficheAccueil()
        {
            Table.Controls.Clear();
            Table.ColumnStyles.Clear();
            Table.RowStyles.Clear();
            this.Controls.Clear();
            //on affiche l-accueil
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));

            accueil.Controls.Add(Table);
            //on affiche les boutons a l-ecran accueil
            conteneurTitrePPL.Controls.Add(menuPrincipal);
            Table.Controls.Add(conteneurTitrePPL, 0, 0);
            Table.Controls.Add(nouvellePartie, 0, 1);
            Table.Controls.Add(chargerPartie, 0, 2);
            Table.Controls.Add(quitter, 0, 3);

            foreach (Control c in Table.Controls)
            {
                Table.SetColumnSpan(c, 4);
                c.Dock = DockStyle.None;
                c.Anchor = AnchorStyles.None;
            }

            nouvellePartie.Anchor = AnchorStyles.Bottom;
            chargerPartie.Anchor = AnchorStyles.Top;

            this.Controls.Add(accueil);
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

                this.Update();

                afficheAccueil();
                
                //on arrete le timer
                timer1.Enabled = false;
                
            }
        }

        //afficher panel Nouvelle Partie
        private void nouvelle_partie_button(object sender, EventArgs e)
        {
            //on cache l/accueil
            this.Controls.Remove(accueil);

            Table.Controls.Clear();
            Table.ColumnStyles.Clear();
            Table.RowStyles.Clear();

            conteneurTitrePPL.Controls.Clear();

            conteneurTitrePPL.Controls.Add(Titre);

            nouveauJoueur.Controls.Add(Table);
            //on definit la nouvelle page
            this.Controls.Add(nouveauJoueur);

            nouveauJoueur.Controls.Add(Table);

            choixAvatar.Dock = DockStyle.None;
            saisirInfos.Dock = DockStyle.None;
            conteneurTitrePPL.Dock = DockStyle.Fill;
            commencer.Dock = DockStyle.Fill;
            retour.Dock = DockStyle.Fill;

            choixAvatar.Anchor = AnchorStyles.None;
            saisirInfos.Anchor = AnchorStyles.None;
            //on ajoute choixAvatar et saisirInfos au panneau nouveauJoueur
            Table.Controls.Add(conteneurTitrePPL, 0, 0);
            Table.Controls.Add(choixAvatar, 1, 1);
            Table.Controls.Add(saisirInfos, 1, 2);
            //on ajoute les boutons commencer et retour au panneau nouveauJoueur
            Table.Controls.Add(commencer, 0, 3);
            Table.Controls.Add(retour, 2, 3);

            //on ajoute les elements prenom et age au panneau saisirInfos
            saisirInfos.Controls.Add(prenomField);
            saisirInfos.Controls.Add(prenomLabel);
            saisirInfos.Controls.Add(ageField);
            saisirInfos.Controls.Add(ageLabel);
            saisirInfos.Controls.Add(dossierSauvegarde);
            saisirInfos.Controls.Add(listeDossierSauvegarde);

            //on fusionne les trois premieres lignes du tableau
            Table.SetColumnSpan(conteneurTitrePPL, 4);
            Table.SetColumnSpan(choixAvatar, 2);
            Table.SetColumnSpan(saisirInfos, 2);
            Table.SetColumnSpan(commencer, 2);
            Table.SetColumnSpan(retour, 2);
        }

        //traitement des donnees saisies dans le panel Nouvelle Partie
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
            if (prenomField.Text == null || ageField.Text == null || indexAvatar == -1 || listeDossierSauvegarde.SelectedIndex == -1)
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
                if (indexAvatar == -1)
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
                afficheMessageBox("Valeurs manquantes", message);

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
                        afficheMessageBox("Erreur", message);
                    }

                    if (isNumerical == false)
                    {
                        String message = "L'age doit etre un nombre entier";
                        afficheMessageBox("Erreur", message);
                    }
                }
                else
                {
                    int[] epreuves = { 0, 0, 0, 0 };
                    //apres toutes les verifications, on peut enregistrer le nouveau joueur
                    String enregistrementJoueur = prenomField.Text.ToLower() + "-" + ageJoueur + "-" + indexAvatar + "-" + Montagne.Name + "-" + etoile + "-" + dossier + "-" + epreuves[0] + "-" + epreuves[1] + "-" + epreuves[2] + "-" + epreuves[3];

                    //on l-enreigistre d-abord dans la liste joueursFichier, la fonction quitter va enregistrer les donnees en dur
                    joueursFichier.Add(enregistrementJoueur);

                    //il faut creer une nouvelle instance de joueur

                    chevalier = new Joueur(prenomField.Text, ageJoueur, indexAvatar, Chateau, Int16.Parse(etoile), dossier, epreuves);

                    //on affiche le prelude
                    afficherDiaporama();
                }
            }
        }

        //Fonctions d'affichage de messages
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

        private void afficherDiaporama()
        {
            //on affiche la planche avec le roi puis la planche avec le magicien...le bouton doit clignoter
            //lors du diaporama on a le texte et une voix off qui explique l-histoire
            nomJoueur = chevalier.nomJoueur();
            textePresentationJeu.Text = textesDiaporama.ElementAt(0);

            actionJoueur.Text = "Oui";
            actionJoueur.Click += new EventHandler(ReadyButton);
            Table.Controls.Clear();
            Table.RowStyles.Clear();
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 57F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 21F));
            Table.Controls.Add(precedent, 0, 0);
            Table.Controls.Add(textePresentationJeu, 0, 2);
            Table.Controls.Add(actionJoueur, 0, 3);
            Table.SetColumnSpan(textePresentationJeu, 4);
            Table.SetColumnSpan(actionJoueur, 4);
            

            foreach (Control c in Table.Controls)
            {
                c.Dock = DockStyle.None;
                c.Anchor = AnchorStyles.None;
            }

            precedent.Dock = DockStyle.Fill;
            actionJoueur.Anchor = AnchorStyles.Top;
            diaporamaHistoire.Controls.Add(Table);
            diaporamaHistoire.Tag = "0";
            diaporamaHistoire.BackgroundImage = imagesDiaporama.ElementAt(0);
            this.Controls.Clear();
            this.Controls.Add(diaporamaHistoire);
        }

        private void ReadyButton(object sender, EventArgs e)
        {
            textePresentationJeu.Text = textesDiaporama.ElementAt(1);
            diaporamaHistoire.Tag = "1";
            actionJoueur.Text = "Voir le Magicien";
            actionJoueur.Click -= ReadyButton;
            actionJoueur.Click += new EventHandler(afficherDiapoSuivant);
        }

        public void afficherDiapoPrecedente(object sender, EventArgs e)
        {
            String index = (String)diaporamaHistoire.Tag;
            Console.WriteLine("index du diapo :" + index);

            if (index.Equals("0"))
            {
                this.Controls.Clear();
                //retour a l'accueil
                this.Controls.Add(accueil);
            }
            else if (index.Equals("1"))
            {
                //retour au premier panel roi
                diaporamaHistoire.Tag = "0";
                textePresentationJeu.Text = textesDiaporama.ElementAt(0);

                actionJoueur.Text = "Oui";
                actionJoueur.Click -= afficherDiapoSuivant;
                actionJoueur.Click += new EventHandler(ReadyButton);
            }
            else if (index.Equals("2"))
            {
                //retaur au deuxieme panel roi
                diaporamaHistoire.Tag = "1";
                textePresentationJeu.Text = textesDiaporama.ElementAt(1);
                diaporamaHistoire.BackgroundImage = imagesDiaporama.ElementAt(0);

                actionJoueur.Text = "Voir le Magicien";
                actionJoueur.Click -= afficherCarte;
                actionJoueur.Click += new EventHandler(afficherDiapoSuivant);
            }
        }

        private void afficherDiapoSuivant(object sender, EventArgs e)
        {
            textePresentationJeu.Text = textesDiaporama.ElementAt(2);
            diaporamaHistoire.Tag = "2";
            diaporamaHistoire.BackgroundImage = imagesDiaporama.ElementAt(1);

            actionJoueur.Text = "Commencer le Jeu";
            actionJoueur.Click -= afficherDiapoSuivant;
            actionJoueur.Click += new EventHandler(afficherCarte);
            Console.WriteLine("index du diapo :" + diaporamaHistoire.Tag);
        }

        //afficher la Carte

        private void afficherCarte(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            Control parent = control.Parent;
            this.Controls.Remove(parent.Parent);
            Carte();
        }

        public void Carte()
        {
            //performance du display a modifier
            typeof(Panel).InvokeMember("DoubleBuffered",
   BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
   null, CarteJeu, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered",
  BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
  null, panelJoueur, new object[] { true });

            //on vide le layout
            Table.Controls.Clear();
            imgChevalier.Image = imagesAvatars[chevalier.avatarJoueur()];
            positionJoueur = chevalier.positionJoueur().getPosition();
            imgChevalier.Location = positionJoueur;
            imgChevalier.Width = 123;
            imgChevalier.Height = 160;
            ajoutEtoiles();
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
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //on fait le repaint
            e.Graphics.DrawImage(imagesAvatars[chevalier.avatarJoueur()], positionJoueur.X, positionJoueur.Y - 120, 123, 160);
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
            conteneurEtoilesCoffre.BringToFront();
            conteneurEtoilesCoffre.Top = -5;
            conteneurEtoilesCoffre.Left = 300;
            ConteneurEtoile.Top = 25;
            ConteneurEtoile.Left = 35;
            coffre.Top = 10;
            coffre.Left = 870;
            
            //position du tableau de bord
            Double tabBordTop = 0.90 * CarteJeu.Height;
            Double tabBordLeft = 0.845 * CarteJeu.Width;
            tabBord.Top = (int) tabBordTop;
            tabBord.Left = (int) tabBordLeft;
            tabBord.Width = 240;
            tabBord.Height = 87;
            
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

            //on desactive le timer
            timer2.Enabled = false;
            panelJoueur.Hide();
            imgChevalier.Show();
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
                CarteJeu.Invalidate(new Rectangle(positionJoueur.X, positionJoueur.Y, imgChevalier.Width, imgChevalier.Height + 120));
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
                CarteJeu.Invalidate(new Rectangle(positionJoueur.X, positionJoueur.Y, imgChevalier.Width, imgChevalier.Height + 120));
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
                CarteJeu.Invalidate(new Rectangle(positionJoueur.X, positionJoueur.Y, imgChevalier.Width, imgChevalier.Height + 120));
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
                CarteJeu.Invalidate(new Rectangle(positionJoueur.X, positionJoueur.Y, imgChevalier.Width, imgChevalier.Height + 120));
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
            chevalier.setPosition(arrivee);
            Console.WriteLine(chevalier.positionJoueur());
            String enregistrementJoueur = chevalier.nomJoueur() + "-" + chevalier.ageJoueur() + "-" + chevalier.avatarJoueur() + "-" + chevalier.positionJoueur().Name + "-" + chevalier.scoreJoueur() + "-" + chevalier.dossierJoueur() + "-" + chevalier.getEpreuvesGagnees(0) + "-" + chevalier.getEpreuvesGagnees(1) + "-" + chevalier.getEpreuvesGagnees(2) + "-" + chevalier.getEpreuvesGagnees(3);

            //on enregistre dans le tableau joueursFichiers les nouvelles valeurs pour le joueur actuel

            for (int i = 0; i < joueursFichier.Count(); i++)
            {
                if (joueursFichier.ElementAt(i).Contains(chevalier.nomJoueur()) && enregistrer == false)
                {
                    //on met a jour les donnees
                    joueursFichier[i] = enregistrementJoueur;
                    enregistrer = true;
                }
            }

            //on signale au joueur que l-enregistrement a ete fait

            List<String> nomsButtons = new List<string>();
            List<int> refEvents = new List<int>();
            nomsButtons.Add("Retour");

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
                var Popup = new PopUp(ColorTranslator.FromHtml("#006532"), items.guide, 1, "Les donnees ont ete sauvegardees !", nomsButtons, refEvents);
                Popup.ShowDialog();
                reponsePopUp();
            }
            else
            {
                var Popup = new PopUp(ColorTranslator.FromHtml("#be1621"), items.attention, 1, "Une erreur s-est produite, les donnees n-ont pas pu etre enregistrees.", nomsButtons, refEvents);
                Popup.ShowDialog();
                reponsePopUp();
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
        private void afficheJeu(String nomJeu, Panel p)
        {
            this.Controls.Remove(CarteJeu);
            Jeu.Controls.Add(Table);
            this.Controls.Add(Jeu);

            //on ajoute le minijeu
            miniJeu.Controls.Add(p);
            conteneurEtoilesCoffre.Margin = new Padding(0);
            coffre.Top = 5;
            
            tabBord.BackgroundImageLayout = ImageLayout.Stretch;
            tabBord.Width = 140;
            tabBord.Height = 70;

            sauvegarde.Top = 11;
            sauvegarde.Left = 62;
            sauvegarde.Width = 30;
            sauvegarde.Height = 30;

            guide.Top = 11;
            guide.Left = 102;
            guide.Width = 30;
            guide.Height = 30;

            quitterMiniJeu.Top = 11;
            quitterMiniJeu.Left = 22;
            quitterMiniJeu.Width = 30;
            quitterMiniJeu.Height = 30;

            imgChevalier.Width = 100;
            imgChevalier.Height = 130;

            if (epreuvesO.Contains(miniJeu.Controls[0]) || epreuvesF.Contains(miniJeu.Controls[0]))
            {
                if (epreuvesO.Contains(miniJeu.Controls[0]))
                {
                    titreJeu.Text = "Niveau 1 : ";
                }
                else
                {
                    titreJeu.Text = "Niveau 2 : ";
                }

                titreJeu.Text = titreJeu.Text + jeuEnCours;
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
            objectif.Dock = DockStyle.None;
            objectif.Anchor = AnchorStyles.Top;
            tabBord.Dock = DockStyle.None;
            tabBord.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            titreJeu.Dock = DockStyle.Fill;
            prenomJoueur.Dock = DockStyle.Fill;
            miniJeu.Dock = DockStyle.Fill;
            conteneurEtoilesCoffre.Dock = DockStyle.None;
            conteneurEtoilesCoffre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imgChevalier.Dock = DockStyle.None;
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
        }

        private void LanceMiniJeu(object sender, EventArgs e)
        {
            Lieu l = (Lieu)sender;
            Boolean FonctionChateauActive = false;

            epreuvesO = chevalier.epreuvesJoueur();
            epreuvesF = chevalier.epreuvesFacultatives();

            jeuEnCours = l.Name;
            if (l.Name == "Chasse aux mots")
            {
                //la chasse aux mots se deroule dans la montagne
                Jeu.BackgroundImage = items.montagne;
                tuto = new tutoChasseAuxMots();
                IndiceJeu = 1;
            }
            else if (l.Name == "Grand Ou Petit")
            {
                //grand ou petit se deroule dans une clairiere
                Jeu.BackgroundImage = items.clairiere;
                tuto = new tutoGrandOuPetit();
                IndiceJeu = 2;
            }
            else if (l.Name == "Que fait le Roi?")
            {
                //que fait le roi se deroule a cote de la riviere
                Jeu.BackgroundImage = items.riviere;
                tuto = new tutoQueFaitLeRoi();
                IndiceJeu = 3;
            }
            else if (l.Name == "Memory")
            {
                Jeu.BackgroundImage = items.village;
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
                //si le joueur a deja gagnee l'epreuve obligatoire,
                //on peut lui demander s-il veut joueur au niveau suivant

                if (chevalier.getEpreuvesGagnees(IndiceJeu) == 1)
                {
                    //s'il a deja gagne les etoiles /pop up personalise

                    DialogResult res = MessageBox.Show("Tu as deja gagne les etoiles de cette epreuve. Souhaites tu rejouer au premier niveau ou veux/tu passer au niveau suivant ?", "No title", MessageBoxButtons.YesNo, MessageBoxIcon.None);


                    if (res == DialogResult.Yes)
                    {
                        //pour l-instant, yes = premier niveau
                        afficheJeu(l.Name, epreuvesO.ElementAt(IndiceJeu));
                    }
                    else
                    {
                        //no = deuxieme niveau
                        afficheJeu(l.Name, epreuvesF.ElementAt(IndiceJeu));
                    }

                }
                else
                {
                    //s'il na jamais gagne les etoiles
                    afficheJeu(l.Name, epreuvesO.ElementAt(IndiceJeu));
                }

                tuto.ShowDialog();
            }
        }

        //retour vers La Carte ou l-Accueil depuis le moni jeu
        private void retourTabBord(object sender, EventArgs e)
        {
            Control source = (Control)sender;
            Control parent = source.Parent;
            Control grandParent = parent.Parent;
            if (grandParent.Parent == Jeu)
            {
                miniJeu.Controls.Clear();
                this.Controls.Remove(Jeu);
                Carte();
            }
            else if (grandParent == CarteJeu)
            {
                List<String> nomsButtons = new List<string>();
                List<int> refEvents = new List<int>();
                nomsButtons.Add("Sauvegarder et Retour a l'accueil");
                nomsButtons.Add("Retour a la Carte");
                refEvents.Add(4);
                refEvents.Add(0);
                var Popup = new PopUp(ColorTranslator.FromHtml("#f39200"), items.attention, 2, "Tu es sur le point de quitter la partie."+ Environment.NewLine+"Souhaites - tu sauvegarder tes donnees ?", nomsButtons, refEvents);
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

                    //on met les etoiles dans conteneurEtoiles

                    ajoutEtoiles();
                }
                //on demande au joueur s-il veut jouer au niveau suivant mais pas d-etoiles a gagner supp. c-est juste pour savoir s-il a assimile
                //ici pop up spe
                List<String> nomsButtons = new List<string>();
                List<int> refEvents = new List<int>();
                nomsButtons.Add("Rejouer");
                nomsButtons.Add("Niveau 2");
                nomsButtons.Add("Carte");
                refEvents.Add(2);
                refEvents.Add(3);
                refEvents.Add(1);

                var Popup = new PopUp(ColorTranslator.FromHtml("#28225c"), items.felicitations, 3, "Niveau 1 reussi!", nomsButtons, refEvents);
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
                nomsButtons.Add("Niveau 1");
                nomsButtons.Add("Niveau 2");
                nomsButtons.Add("Carte");
                refEvents.Add(2);
                refEvents.Add(3);
                refEvents.Add(1);
                
                var Popup = new PopUp(ColorTranslator.FromHtml("#28225c"), items.felicitations, 3, "Niveau 2 reussi! Quete terminee", nomsButtons, refEvents);
                Popup.ShowDialog();
                reponsePopUp();
            }
        }
        
        public void reponsePopUp()
        {
            if (choixFinMiniJeu == 0)
            {
                //on revient a la carte
                this.Controls.Remove(Jeu);
                Carte();
            }
            else if (choixFinMiniJeu == 1)
            {
                //on affiche et on reload le premier niveau
                miniJeu.Controls.Clear();
                epreuvesO.ElementAt(IndiceJeu).chargementPartie();
                miniJeu.Controls.Add(epreuvesO.ElementAt(IndiceJeu));
                titreJeu.Text = "Niveau 1 : " + jeuEnCours;
            }
            else if (choixFinMiniJeu == 2)
            {
                //on joue au deuxieme niveau
                titreJeu.Text = "Niveau 2 : " + jeuEnCours;
                epreuvesF.ElementAt(IndiceJeu).chargementPartie();
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
                    int left = i * 70;

                    ConteneurEtoile.Controls.Add(new Etoile(left, 1));
                }
            }

            //on complete avec les etoiles encore dispo soit les etoiles grises
            for (int i = chevalier.scoreJoueur(); i < 12; i++)
            {
                int left = i * 70;

                ConteneurEtoile.Controls.Add(new Etoile(left, 2));
            }
        }

        //mise a jour gain etoiles

        public void miseAJourEtoiles()
        {
            objectif.Controls.Clear();

            objectif.Controls.Add(gain);
            if (chevalier.getEpreuvesGagnees(IndiceJeu) == 1)
            {
                //epreuve remportee / alors il n'y a pas d'etoiles jaunes a remporter

                objectif.Controls.Add(new Etoile(0, 80, 2));
                objectif.Controls.Add(new Etoile(90, 80, 2));
                objectif.Controls.Add(new Etoile(45, 150, 2));

            }
            else
            {
                //epreuve perdue ou premiere fois /il y a encore des etoiles a remporter
                //on ajoute les etoiles jaunes

                objectif.Controls.Add(new Etoile(0, 80, 1));
                objectif.Controls.Add(new Etoile(90, 80, 1));
                objectif.Controls.Add(new Etoile(45, 150, 1));
            }
        }

        //aide du jeu

        public void ConseilsGuide()
        {
            if (guide.Parent.Parent.Name.Equals("Carte"))
            {
                message = "Clique sur un des lieux gris pour te deplacer sur la carte et acceder aux jeux";
            }
            else if (guide.Parent.Parent.Parent.Name.Equals("Jeu"))
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
            List<String> nomsButtons = new List<string>();
            List<int> refEvents = new List<int>();
            nomsButtons.Add("Retour");
            refEvents.Add(0);
            
            var Popup = new PopUp(ColorTranslator.FromHtml("#27348a"), items.guide, 1, message, nomsButtons, refEvents);
            Popup.ShowDialog();

        }

    //revelation du coffre

        public void devoileCoffre()
        {
            this.Controls.Remove(CarteJeu);
            textePresentationJeu.Text = "As-tu reuni l-ensemble des etoiles ?";
            /*CourRoi.Controls.Add(textePresentationJeu);
            CourRoi.Controls.Add(Yes);
            CourRoi.Controls.Add(No);
            CourRoi.Controls.Add(tabBord);
            this.Controls.Add(CourRoi);*/

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
            //this.Controls.Remove(CourRoi);
            //this.Controls.Add(Recompense);

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
}
