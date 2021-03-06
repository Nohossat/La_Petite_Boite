﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jeu;
using System.IO;
using System.Media;
using Ressources;
using System.Drawing.Text;

namespace Chasse_aux_mots
{
    public partial class ChasseAuxMots : Form
    {
        public ChasseAuxMots() 
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button1);
            this.Controls.Add(new ChasseAuxMotsPanel());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button1);
            this.Controls.Add(new ChasseAuxMots8Panel());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button1);
            this.Controls.Add(new ChasseAuxMots12Panel());
        }
    }

    public partial class ChasseAuxMotsPanel : chasseMots
    {
        PictureBox pictureBox4;
        PictureBox pictureBox3;
        PictureBox pictureBox2;
        PictureBox pictureBox1;

        public ChasseAuxMotsPanel(PrivateFontCollection pfc) : base(pfc)
        {
            initializeChasseAuxMots4();
            chargementPartie();
            finalScore = 4;
            trouves = new Boolean[4];
            //on reunit l-ensemble des flags dans un tableau

            for (int i = 0; i < trouves.Count(); i++)
            {
                trouves[i] = false;
            }

            pictureBox1.Image = items.doudou1;
            pictureBox2.Image = items.jardin1;
            pictureBox3.Image = items.chateau1;
            pictureBox4.Image = items.roi1;

            //on regroupe l-ensemble des audios dans un vecteur pour faciliter leur gestion

            sons.Add(items.doudouTurc);
            sons.Add(items.jardinTurc);
            sons.Add(items.chateauTurc);
            sons.Add(items.roiFR);
        }

        public ChasseAuxMotsPanel() : base()
        {
            initializeChasseAuxMots4();
            chargementPartie();
            finalScore = 4;
            trouves = new Boolean[4];
            //on reunit l-ensemble des flags dans un tableau

            for (int i = 0; i < trouves.Count(); i++)
            {
                trouves[i] = false;
            }

            pictureBox1.Image = items.doudou1;
            pictureBox2.Image = items.jardin1;
            pictureBox3.Image = items.chateau1;
            pictureBox4.Image = items.roi1;

            //on regroupe l-ensemble des audios dans un vecteur pour faciliter leur gestion

            sons.Add(items.doudouTurc);
            sons.Add(items.jardinTurc);
            sons.Add(items.chateauTurc);
            sons.Add(items.roiFR);
        }

        private void Ecouter_Click(object sender, EventArgs e)
        {
            Random choix = new Random();
            int choixSon = choix.Next(1, 5);

            while ((choixSon == 1 & trouves[0] == true) || (choixSon == 2 & trouves[1] == true) || (choixSon == 3 & trouves[2] == true) || (choixSon == 4 & trouves[3] == true))
            {
                choixSon = choix.Next(1, 5);
            }

            index = choixSon - 1;
            JouerSon(sons[index], choixSon, ref carteACliquerTag);
        }
        
    }

    public partial class ChasseAuxMots8Panel : chasseMots
    {
        PictureBox pictureBox8;
        PictureBox pictureBox7;
        PictureBox pictureBox6;
        PictureBox pictureBox5;
        PictureBox pictureBox4;
        PictureBox pictureBox3;
        PictureBox pictureBox2;
        PictureBox pictureBox1;
        

        public ChasseAuxMots8Panel(PrivateFontCollection pfc) : base(pfc)
        {
            initializeChasseAuxMots8();
            chargementPartie();
            finalScore = 8;
            trouves = new Boolean[8];
            //on reunit l-ensemble des flags dans un tableau

            for (int i = 0; i < trouves.Count(); i++)
            {
                trouves[i] = false;
            }

            //on affecte les images aux cartes
            pictureBox1.Image = items.doudou1;
            pictureBox2.Image = items.jardin1;
            pictureBox3.Image = items.chateau1;
            pictureBox4.Image = items.foret1;
            pictureBox5.Image = items.chaise1;
            pictureBox6.Image = items.table1;
            pictureBox7.Image = items.lit1;
            pictureBox8.Image = items.roi1;

            //on regroupe l-ensemble des audios dans un vecteur pour faciliter leur gestion

            sons.Add(items.doudouFR);
            sons.Add(items.jardinTurc);
            sons.Add(items.chateauTurc);
            sons.Add(items.foretTurc);
            sons.Add(items.chaiseTurc);
            sons.Add(items.tableFR);
            sons.Add(items.litFR);
            sons.Add(items.roiFR);
        }

        public ChasseAuxMots8Panel() : base()
        {
            initializeChasseAuxMots8();
            chargementPartie();
            finalScore = 8;
            trouves = new Boolean[8];
            //on reunit l-ensemble des flags dans un tableau

            for (int i = 0; i < trouves.Count(); i++)
            {
                trouves[i] = false;
            }

            //on affecte les images aux cartes
            pictureBox1.Image = items.doudou1;
            pictureBox2.Image = items.jardin1;
            pictureBox3.Image = items.chateau1;
            pictureBox4.Image = items.foret1;
            pictureBox5.Image = items.chaise1;
            pictureBox6.Image = items.table1;
            pictureBox7.Image = items.lit1;
            pictureBox8.Image = items.roi1;

            //on regroupe l-ensemble des audios dans un vecteur pour faciliter leur gestion

            sons.Add(items.doudouFR);
            sons.Add(items.jardinTurc);
            sons.Add(items.chateauTurc);
            sons.Add(items.foretTurc);
            sons.Add(items.chaiseTurc);
            sons.Add(items.tableFR);
            sons.Add(items.litFR);
            sons.Add(items.roiFR);
        }

        private void Ecouter_Click(object sender, EventArgs e)
        {
            Random choix = new Random();
            int choixSon = choix.Next(1, 9);
            while ((choixSon == 1 & trouves[0] == true) || (choixSon == 2 & trouves[1] == true) || (choixSon == 3 & trouves[2] == true) || (choixSon == 4 & trouves[3] == true) || (choixSon == 5 & trouves[4] == true) || (choixSon == 6 & trouves[5] == true) || (choixSon == 7 & trouves[6] == true) || (choixSon == 8 & trouves[7] == true))
            {
                choixSon = choix.Next(1, 9);
            }

            index = choixSon - 1;
            JouerSon(sons[index], choixSon, ref carteACliquerTag);
        }
        
    }

    public partial class ChasseAuxMots12Panel : chasseMots
    {
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        

        public ChasseAuxMots12Panel(PrivateFontCollection pfc) : base (pfc)
        {
            initialize();
            chargementPartie();
            finalScore = 12;
            trouves = new Boolean[12];

            pictureBox1.Image = items.doudou1;
            pictureBox2.Image = items.jardin1;
            pictureBox3.Image = items.chateau1;
            pictureBox4.Image = items.foret1;
            pictureBox5.Image = items.chaise1;
            pictureBox6.Image = items.table1;
            pictureBox7.Image = items.lit1;
            pictureBox8.Image = items.roi1;
            pictureBox9.Image = items.pont1;
            pictureBox10.Image = items.coffre1;
            pictureBox11.Image = items.escalier1;
            pictureBox12.Image = items.ecole1;

            //on reunit l-ensemble des flags dans un tableau

            for (int i = 0; i < trouves.Count(); i++)
            {
                trouves[i] = false;
            }

            //on regroupe l-ensemble des audios dans un vecteur pour faciliter leur gestion

            sons.Add(items.doudouFR);
            sons.Add(items.jardinFR);
            sons.Add(items.chateauFR);
            sons.Add(items.foretFR);
            sons.Add(items.chaiseFR);
            sons.Add(items.tableTurc);
            sons.Add(items.litTurc);
            sons.Add(items.roiTurc);
            sons.Add(items.pontFR);
            sons.Add(items.coffreFR);
            sons.Add(items.escalierTurc);
            sons.Add(items.ecoleTurc);
        }

        public ChasseAuxMots12Panel() : base()
        {
            initialize();
            chargementPartie();
            finalScore = 12;
            trouves = new Boolean[12];

            pictureBox1.Image = items.doudou1;
            pictureBox2.Image = items.jardin1;
            pictureBox3.Image = items.chateau1;
            pictureBox4.Image = items.foret1;
            pictureBox5.Image = items.chaise1;
            pictureBox6.Image = items.table1;
            pictureBox7.Image = items.lit1;
            pictureBox8.Image = items.roi1;
            pictureBox9.Image = items.pont1;
            pictureBox10.Image = items.coffre1;
            pictureBox11.Image = items.escalier1;
            pictureBox12.Image = items.ecole1;

            //on reunit l-ensemble des flags dans un tableau

            for (int i = 0; i < trouves.Count(); i++)
            {
                trouves[i] = false;
            }

            //on regroupe l-ensemble des audios dans un vecteur pour faciliter leur gestion

            sons.Add(items.doudouFR);
            sons.Add(items.jardinFR);
            sons.Add(items.chateauFR);
            sons.Add(items.foretFR);
            sons.Add(items.chaiseFR);
            sons.Add(items.tableTurc);
            sons.Add(items.litTurc);
            sons.Add(items.roiTurc);
            sons.Add(items.pontFR);
            sons.Add(items.coffreFR);
            sons.Add(items.escalierTurc);
            sons.Add(items.ecoleTurc);
        }

        private void Ecouter_Click(object sender, EventArgs e)
        {
            Random choix = new Random();
            int choixSon = choix.Next(1, 13);

            while ((choixSon == 1 & trouves[0] == true) || (choixSon == 2 & trouves[1] == true) || (choixSon == 3 & trouves[2] == true) || (choixSon == 4 & trouves[3] == true) || (choixSon == 5 & trouves[4] == true) || (choixSon == 6 & trouves[5] == true) || (choixSon == 7 & trouves[6] == true) || (choixSon == 8 & trouves[7] == true) || (choixSon == 9 & trouves[8] == true) || (choixSon == 10 & trouves[9] == true) || (choixSon == 11 & trouves[10] == true) || (choixSon == 12 & trouves[11] == true))
            {
                choixSon = choix.Next(1, 13);
            }

            index = choixSon - 1;
            JouerSon(sons[index], choixSon, ref carteACliquerTag);
        }
    }

    
}
