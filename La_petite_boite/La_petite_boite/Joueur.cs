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
using Jeu;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace La_petite_boite
{
    public class Joueur : Panel
    {
        String nom;
        int age;
        String avatar;
        Lieu position;
        int ScoreEtoile;
        String dossierSauvegarde;
        int niveau;
        List<Jeu.Jeu> jeuxObligatoires = new List<Jeu.Jeu>();
        List<Jeu.Jeu> jeuxFacultatifs = new List<Jeu.Jeu>();
        int[] epreuvesGagnees = new int[4];


        //chargement d-une partie
        public Joueur(String n, int a, String img, Lieu pos, int etoile, String dossier, int[] epreuves)
        {
            this.nom = n;
            this.age = a;
            this.avatar = img;
            this.position = pos;
            this.ScoreEtoile = etoile;
            this.dossierSauvegarde = dossier;
            this.epreuvesGagnees = epreuves;
            this.DoubleBuffered = true;

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
        
        public Lieu positionJoueur()
        {
            return this.position;
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

        public List<Jeu.Jeu> epreuvesJoueur()
        {
            return this.jeuxObligatoires;
        }

        public List<Jeu.Jeu> epreuvesFacultatives()
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

        public void setPosition (Lieu p)
        {
            this.position = p;
        }
        public void setEpreuvesRemportees (int i)
        {
            this.epreuvesGagnees[i] = 1;
        }
    }
}