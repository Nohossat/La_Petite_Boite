using Grand_ou_Petit;
using Grand_ou_petit_8;
using Grand_ou_petit_12;
using memory8Cartes;
using memory12cartes;
using memory16Cartes;
using Chasse_aux_mots;
using chassesAuxMots8Cartes;
using chasseAuxMots12Cartes;
using Que_fait_le_Roi;
using Que_fait_le_roi_8;
using Que_fait_le_roi_12;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace La_petite_boite
{
    internal class Joueur
    {
        String nom;
        int age;
        String avatar;
        int TopPosition;
        int LeftPosition;
        int ScoreEtoile;
        String dossierSauvegarde;
        int niveau;
        List<Panel> jeuxObligatoires = new List<Panel>();
        List<Panel> jeuxFacultatifs = new List<Panel>();
        int[] epreuvesGagnees = new int[4];

        //ce constructeur sert lors de la creation d-un nouveau joueur
        public Joueur(String n, int a, String img, String dossier, int[] epreuves)
        {
            this.nom = n;
            this.age = a;
            this.avatar = img;
            this.TopPosition = 350;
            this.LeftPosition = 1050;
            this.ScoreEtoile = 0;
            this.dossierSauvegarde = dossier;
            this.epreuvesGagnees = epreuves;

            if (this.age < 6)
            {
                this.niveau = 1;
                jeuxObligatoires.Add(new MemoryPanel());
                jeuxObligatoires.Add(new ChasseAuxMotsPanel());
                jeuxObligatoires.Add(new GrandOuPetit());
                jeuxObligatoires.Add(new QueFaitLeRoi4Panel());

                jeuxFacultatifs.Add(new Memory12Panel());
                jeuxFacultatifs.Add(new ChasseAuxMots8Panel());
                jeuxFacultatifs.Add(new GrandOuPetit8Panel());
                jeuxFacultatifs.Add(new QueFaitLeRoi8Panel());

                //dans jeux facultatifs, il faudra mettre les jeux de niveau 2
            }
            else
            {
                this.niveau = 2;
                //ici il faudra mettre les jeux de niveau 2 et 3
                jeuxObligatoires.Add(new Memory12Panel());
                jeuxObligatoires.Add(new ChasseAuxMots8Panel());
                jeuxObligatoires.Add(new GrandOuPetit8Panel());
                jeuxObligatoires.Add(new QueFaitLeRoi8Panel());

                jeuxFacultatifs.Add(new Memory16Panel());
                jeuxFacultatifs.Add(new ChasseAuxMots12Panel());
                jeuxFacultatifs.Add(new GrandOuPetit12Panel());
                jeuxFacultatifs.Add(new QueFaitLeRoi12Panel());
            }
        }

        //chargement d-une partie
        public Joueur(String n, int a, String img, int top, int left, int etoile, String dossier, int[] epreuves)
        {
            this.nom = n;
            this.age = a;
            this.avatar = img;
            this.TopPosition = top;
            this.LeftPosition = left;
            this.ScoreEtoile = etoile;
            this.dossierSauvegarde = dossier;
            this.epreuvesGagnees = epreuves;

            if (this.age < 6)
            {
                this.niveau = 1;
                jeuxObligatoires.Add(new MemoryPanel());
                jeuxObligatoires.Add(new ChasseAuxMotsPanel());
                jeuxObligatoires.Add(new GrandOuPetit());
                jeuxObligatoires.Add(new QueFaitLeRoi4Panel());

                jeuxFacultatifs.Add(new Memory12Panel());
                jeuxFacultatifs.Add(new ChasseAuxMots8Panel());
                jeuxFacultatifs.Add(new GrandOuPetit8Panel());
                jeuxFacultatifs.Add(new QueFaitLeRoi8Panel());

            }
            else
            {
                this.niveau = 2;
                jeuxObligatoires.Add(new Memory12Panel());
                jeuxObligatoires.Add(new ChasseAuxMots8Panel());
                jeuxObligatoires.Add(new GrandOuPetit8Panel());
                jeuxObligatoires.Add(new QueFaitLeRoi8Panel());

                jeuxFacultatifs.Add(new Memory16Panel());
                jeuxFacultatifs.Add(new ChasseAuxMots12Panel());
                jeuxFacultatifs.Add(new GrandOuPetit12Panel());
                jeuxFacultatifs.Add(new QueFaitLeRoi12Panel());
            }
        }

        //getters

        public int ageJoueur()
        {
            return this.age;
        }

        public String nomJoueur()
        {
            return this.nom;
        }

        public String avatarJoueur()
        {
            return this.avatar;
        }

        public int leftJoueur()
        {
            return this.LeftPosition;
        }

        public int topJoueur()
        {
            return this.TopPosition;
        }

        public int scoreJoueur()
        {
            return this.ScoreEtoile;
        }

        public String dossierJoueur ()
        {
            return this.dossierSauvegarde;
        }

        public int getNiveau()
        {
            return this.niveau;
        }

        public List<Panel> epreuvesJoueur()
        {
            return this.jeuxObligatoires;
        }

        public List<Panel> epreuvesFacultatives()
        {
            return this.jeuxFacultatifs;
        }

        public int getEpreuvesGagnees(int i)
        {
            return this.epreuvesGagnees[i];
        }
        //setters

        public void setJoueurScore (int t)
        {
            this.ScoreEtoile = this.ScoreEtoile + t;
        }

        public void setJoueurTop(int t)
        {
            this.TopPosition = t;
        }

        public void setJoueurLeft(int t)
        {
            this.LeftPosition = t;
        }
        public void setEpreuvesRemportees (int i)
        {
            this.epreuvesGagnees[i] = 1;
        }
    }
}