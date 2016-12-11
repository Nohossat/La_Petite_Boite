using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Ressources;
using System.IO;

namespace memory8Cartes
{
    public partial class Memory8 : Form
    {
        public Memory8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //memory 8 cartes
            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button1);
            this.Controls.Add(new MemoryPanel());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //memory 12 cartes
            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button1);
            this.Controls.Add(new Memory12Panel());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //memory 16 cartes
            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button1);
            this.Controls.Add(new Memory16Panel());
        }
    }

    public partial class MemoryPanel : Memory
    {
        PictureBox doubleCarte4;
        PictureBox carte4;
        PictureBox doubleCarte3;
        PictureBox carte3;
        PictureBox doubleCarte2;
        PictureBox carte2;
        PictureBox doubleCarte1;
        PictureBox carte1;

        public MemoryPanel()
        {
            initialize();
            this.chargementPartie();
            sons.Add(items.doudouFR);
            sons.Add(items.chateauTurc);
            sons.Add(items.jardinTurc);
            sons.Add(items.roiFR);

            img.Add(items.doudou1);
            img.Add(items.chateau1);
            img.Add(items.jardin1);
            img.Add(items.roi1);
        }

        public void jouer(object sender, EventArgs e)
        {
            int index;
            PictureBox carteCourante = (PictureBox)sender;

            index = Int32.Parse((String)carteCourante.Tag) - 1;

            //attribution des mots pour chaque paires selon le tag 

            chargementData(carteCourante, img[index], sons[index]);
            controleCartes(carteCourante, 4);
        }

    }

    public partial class Memory12Panel : Memory
    {
        private PictureBox carte5;
        private PictureBox carte3;
        private PictureBox carte1;
        private PictureBox carte4Double;
        private PictureBox carte4;
        private PictureBox carte3Double;
        private PictureBox carte6;
        private PictureBox carte6Double;
        private PictureBox carte2Double;
        private PictureBox carte2;
        private PictureBox carte1Double;
        private PictureBox carte5Double;

        public Memory12Panel()
        {
            initialize();
            chargementPartie();
            sons.Add(items.foretTurc);
            sons.Add(items.ecoleTurc);
            sons.Add(items.tableFR);
            sons.Add(items.litTurc);
            sons.Add(items.coffreFR);
            sons.Add(items.chaiseFR);

            img.Add(items.foret1);
            img.Add(items.ecole1);
            img.Add(items.table1);
            img.Add(items.lit1);
            img.Add(items.coffre1);
            img.Add(items.chaise1);
        }
        
        private void jouer(object sender, EventArgs e)
        {
            int index;
            PictureBox carteCourante = (PictureBox)sender;

            index = Int32.Parse((String)carteCourante.Tag) - 1;

            //attribution des mots pour chaque paires selon le tag 

            chargementData(carteCourante, img[index], sons[index]);
            controleCartes(carteCourante, 6);
            
         }
     }
    
    public partial class Memory16Panel : Memory
    {
        private PictureBox carte9Double;
        private PictureBox carte9;
        private PictureBox carte8double;
        private PictureBox carte8;
        private PictureBox carte7Double;
        private PictureBox carte7;
        private PictureBox carte6Double;
        private PictureBox carte6;
        private PictureBox carte5Double;
        private PictureBox carte5;
        private PictureBox carte4Double;
        private PictureBox carte4;
        private PictureBox carte3Double;
        private PictureBox carte3;
        private PictureBox carte2Double;
        private PictureBox carte2;
        private PictureBox carte1Double;
        private PictureBox carte1;
        

        public Memory16Panel()
        {
            initialize();
            chargementPartie();

            //chargement sons
            sons.Add(items.ecoleFR);
            sons.Add(items.coffreFR);
            sons.Add(items.litFR);
            sons.Add(items.pontFR);
            sons.Add(items.tableTurc);
            sons.Add(items.escalierTurc);
            sons.Add(items.foretTurc);
            sons.Add(items.pijama);
            sons.Add(items.chateauTurc);

            //chargement images
            img.Add(items.ecole1);
            img.Add(items.coffre1);
            img.Add(items.lit1);
            img.Add(items.pont1);
            img.Add(items.table1);
            img.Add(items.escalier1);
            img.Add(items.foret1);
            img.Add(items.pijama1);
            img.Add(items.chateau1);
        }
        
        private void jouer(object sender, EventArgs e)
        {
            int index;
            PictureBox carteCourante = (PictureBox)sender;

            index = Int32.Parse((String)carteCourante.Tag) - 1;

            //attribution des mots pour chaque paires selon le tag 

            chargementData(carteCourante, img[index], sons[index]);
            controleCartes(carteCourante, 9);
            
        }
    }
}
