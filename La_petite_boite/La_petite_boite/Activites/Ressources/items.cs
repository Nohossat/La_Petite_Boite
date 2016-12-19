using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ressources
{
    public class items
    {
        public items ()
        {

        }

        //font

        public static PrivateFontCollection chargementFont()
        {
            Stream fontStream;
           

           // specify embedded resource name
            string resource = "Ressources.Resources.Jeu.maturafont.TTF";

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
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddMemoryFont(data, (int)fontStream.Length);

                // close the resource stream
                fontStream.Close();

                // free up the unsafe memory
                Marshal.FreeCoTaskMem(data);

                return pfc;
            }
            catch (ArgumentException t)
            {
                Console.WriteLine("Error accessing fontfile!" + t);

                return null;
            }
        }

        //chargementTexte

        public static List<String> chargementTexte(String nomFichier)
        {
            List<String> tableauRes = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader(@"C:\Users\Nohossat TRAORE\Desktop\La_Petite_Boite\La_petite_boite\Ressources\Resources\Jeu\" + nomFichier))
                {
                    
                     String line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        tableauRes.Add(line);
                    }
                }
                return tableauRes;
            }
            catch (Exception e)
            {
                Console.Write("Le fichier n'a pas pu etre lu" + e);
                return null;
            }
        }

        //images JeuPPL

        public static Bitmap banniereGriseConteneurEtoiles
        {
            get
            {
                return Properties.Resources.conteneurEtoile;
            }
        }

        public static Bitmap banniereGriseTabBord
        {
            get
            {
                return Properties.Resources.tabBord;
            }
        }

        public static Bitmap retourFleche
        {
            get
            {
                return Properties.Resources.retourFleche;
            }
        }

        public static Bitmap mapCabane
        {
            get
            {
                return Properties.Resources.mapCabane;
            }
        }

        public static Bitmap mapTronc
        {
            get
            {
                return Properties.Resources.mapTronc;
            }
        }

        public static Bitmap mapMontagne
        {
            get
            {
                return Properties.Resources.mapMontagne;
            }
        }

        public static Bitmap mapVillage
        {
            get
            {
                return Properties.Resources.mapVillage;
            }
        }

        public static Bitmap chargement
        {
            get
            {
                return Properties.Resources.chargement;
            }
        }

        public static Bitmap accueil
        {
            get
            {
                return Properties.Resources.accueil;
            }
        }

        public static Bitmap menu
        {
            get
            {
                return Properties.Resources.menu;
            }
        }

        public static Bitmap diapoTrone
        {
            get
            {
                return Properties.Resources.diapoTrone1;
            }
        }

        public static Bitmap diapoMag
        {
            get
            {
                return Properties.Resources.diapoMag;
            }
        }

        public static Bitmap map
        {
            get
            {
                return Properties.Resources.map;
            }
        }

        public static Bitmap chevalier1
        {
            get
            {
                return Properties.Resources.chevalier1;
            }
        }

        public static Bitmap chevalier2
        {
            get
            {
                return Properties.Resources.chevalier2;
            }
        }

        public static Bitmap chevalier3
        {
            get
            {
                return Properties.Resources.chevalier3;
            }
        }

        public static Bitmap chevalier4
        {
            get
            {
                return Properties.Resources.chevalier4;
            }
        }

        public static Bitmap chevalier1gris
        {
            get
            {
                return Properties.Resources.chevalier1gris;
            }
        }

        public static Bitmap chevalier2gris
        {
            get
            {
                return Properties.Resources.chevalier2gris;
            }
        }

        public static Bitmap chevalier3gris
        {
            get
            {
                return Properties.Resources.chevalier3gris;
            }
        }

        public static Bitmap chevalier4gris
        {
            get
            {
                return Properties.Resources.chevalier4gris;
            }
        }

        public static Bitmap etoileGrise
        {
            get
            {
                return Properties.Resources.etoileGrise;
            }
        }

        public static Bitmap etoileJaune
        {
            get
            {
                return Properties.Resources.etoileJaune;
            }
        }

        public static Bitmap coffre
        {
            get
            {
                return Properties.Resources.coffre;
            }
        }

        public static Bitmap aide
        {
            get
            {
                return Properties.Resources.question;
            }
        }

        public static Bitmap sauvegarde
        {
            get
            {
                return Properties.Resources.disquette;
            }
        }

        public static Bitmap quitter
        {
            get
            {
                return Properties.Resources.exit;
            }
        }

        public static Bitmap clairiere
        {
            get
            {
                return Properties.Resources.clairiere;
            }
        }

        public static Bitmap montagne
        {
            get
            {
                return Properties.Resources.montagne;
            }
        }

        public static Bitmap riviere
        {
            get
            {
                return Properties.Resources.riviere;
            }
        }

        public static Bitmap village
        {
            get
            {
                return Properties.Resources.village;
            }
        }

        public static Bitmap cabaneAfter
        {
            get
            {
                return Properties.Resources.cabaneAfter;
            }
        }

        public static Bitmap cabaneFin
        {
            get
            {
                return Properties.Resources.cabaneFin;
            }
        }

        public static Bitmap cabanePrevious
        {
            get
            {
                return Properties.Resources.cabanePrevious;
            }
        }

        public static Bitmap chateauAfter
        {
            get
            {
                return Properties.Resources.chateauAfter;
            }
        }

        public static Bitmap chateauFin
        {
            get
            {
                return Properties.Resources.chateauFin;
            }
        }

        public static Bitmap chateauPrevious
        {
            get
            {
                return Properties.Resources.chateauPrevious;
            }
        }

        public static Bitmap montagneAfter
        {
            get
            {
                return Properties.Resources.montagneAfter;
            }
        }

        public static Bitmap montagneFin
        {
            get
            {
                return Properties.Resources.montagneFin;
            }
        }

        public static Bitmap montagnePrevious
        {
            get
            {
                return Properties.Resources.montagnePrevious;
            }
        }

        public static Bitmap troncAfter
        {
            get
            {
                return Properties.Resources.troncAfter;
            }
        }

        public static Bitmap troncFin
        {
            get
            {
                return Properties.Resources.troncFin;
            }
        }

        public static Bitmap troncPrevious
        {
            get
            {
                return Properties.Resources.troncPrevious;
            }
        }

        public static Bitmap villageAfter
        {
            get
            {
                return Properties.Resources.villageAfter;
            }
        }

        public static Bitmap villageFin
        {
            get
            {
                return Properties.Resources.villageFin;
            }
        }

        public static Bitmap villagePrevious
        {
            get
            {
                return Properties.Resources.villagePrevious;
            }
        }

        //images minijeu

        public static Bitmap dosCarte
        {
            get
            {
                return Properties.Resources.dosCarte;
            }
        }

        public static Bitmap bain1
        {
            get
            {
                return Properties.Resources.bain1;
            }
        }

        public static Bitmap chaise1
        {
            get
            {
                return Properties.Resources.chaise1;
            }
        }

        public static Bitmap chateau1
        {
            get
            {
                return Properties.Resources.chateau1;
            }
        }

        public static Bitmap coffre1
        {
            get
            {
                return Properties.Resources.coffre1;
            }
        }

        public static Bitmap doudou1
        {
            get
            {
                return Properties.Resources.doudou1;
            }
        }

        public static Bitmap ecole1
        {
            get
            {
                return Properties.Resources.ecole1;
            }
        }

        public static Bitmap escalier1
        {
            get
            {
                return Properties.Resources.escalier1;
            }
        }

        public static Bitmap foret1
        {
            get
            {
                return Properties.Resources.foret1;
            }
        }

        public static Bitmap jardin1
        {
            get
            {
                return Properties.Resources.jardin1;
            }
        }

        public static Bitmap lit1
        {
            get
            {
                return Properties.Resources.lit1;
            }
        }

        public static Bitmap pont1
        {
            get
            {
                return Properties.Resources.pont1;
            }
        }

        public static Bitmap pause1
        {
            get
            {
                return Properties.Resources.pause1;
            }
        }

        public static Bitmap pijama1
        {
            get
            {
                return Properties.Resources.pijama1;
            }
        }

        public static Bitmap roi1
        {
            get
            {
                return Properties.Resources.roi1;
            }
        }
        
        public static Bitmap table1
        {
            get
            {
                return Properties.Resources.table1;
            }
        }
        
        //audio

        public static Stream applaudissement
        {
            get
            {
                return Properties.Resources.applaudissement;
            }
        }

        public static Stream bainTurc
        {
            get
            {
                return Properties.Resources.bainTurc;
            }
        }

        public static Stream chaiseTurc
        {
            get
            {
                return Properties.Resources.chaiseTurc;
            }
        }

        public static Stream chaiseFR
        {
            get
            {
                return Properties.Resources.chaiseFR;
            }
        }

        public static Stream grandeChaiseFR
        {
            get
            {
                return Properties.Resources.grandeChaiseFR;
            }
        }

        public static Stream petiteChaiseFR
        {
            get
            {
                return Properties.Resources.petiteChaiseFR;
            }
        }

        public static Stream chateauTurc
        {
            get
            {
                return Properties.Resources.chateauTurc;
            }
        }

        public static Stream chateauFR
        {
            get
            {
                return Properties.Resources.chateauFR;
            }
        }

        public static Stream grandChateauFR
        {
            get
            {
                return Properties.Resources.grandChateauFR;
            }
        }

        public static Stream petitChateauFR
        {
            get
            {
                return Properties.Resources.petitChateauFR;
            }
        }

        public static Stream grandChateauTurc
        {
            get
            {
                return Properties.Resources.grandChateauTurc;
            }
        }

        public static Stream petitChateauTurc
        {
            get
            {
                return Properties.Resources.petitChateauTurc;
            }
        }

        public static Stream coffreFR
        {
            get
            {
                return Properties.Resources.coffreFR;
            }
        }

        public static Stream coffreTurc
        {
            get
            {
                return Properties.Resources.coffreTurc;
            }
        }

        public static Stream grandCoffreTurc
        {
            get
            {
                return Properties.Resources.grandCoffreTurc;
            }
        }

        public static Stream grandCoffreFR
        {
            get
            {
                return Properties.Resources.grandeBoiteFR;
            }
        }

        public static Stream petitCoffreFR
        {
            get
            {
                return Properties.Resources.petiteBoiteFR;
            }
        }

        public static Stream doudouTurc
        {
            get
            {
                return Properties.Resources.doudouTurc;
            }
        }

        public static Stream doudouFR
        {
            get
            {
                return Properties.Resources.doudouFR;
            }
        }

        public static Stream grandDoudouTurc
        {
            get
            {
                return Properties.Resources.grandDoudouTurc;
            }
        }

        public static Stream petitDoudouTurc
        {
            get
            {
                return Properties.Resources.petitDoudouTurc;
            }
        }

        public static Stream ecoleFR
        {
            get
            {
                return Properties.Resources.ecoleFR;
            }
        }

        public static Stream ecoleTurc
        {
            get
            {
                return Properties.Resources.ecoleTurc;
            }
        }

        public static Stream grandEcoleFR
        {
            get
            {
                return Properties.Resources.grandeEcoleFR;
            }
        }

        public static Stream petitEcoleFR
        {
            get
            {
                return Properties.Resources.petitEcoleFR;
            }
        }

        public static Stream escalierTurc
        {
            get
            {
                return Properties.Resources.escalierTurc;
            }
        }

        public static Stream escalierFR
        {
            get
            {
                return Properties.Resources.escalierFR;
            }
        }

        public static Stream grandEscalierFR
        {
            get
            {
                return Properties.Resources.grandEscalierFR;
            }
        }

        public static Stream petitEscalierFR
        {
            get
            {
                return Properties.Resources.petitEscalierFR;
            }
        }

        public static Stream jardinTurc
        {
            get
            {
                return Properties.Resources.jardinTurc;
            }
        }

        public static Stream jardinFR
        {
            get
            {
                return Properties.Resources.jardinFR;
            }
        }

        public static Stream grandJardinTurc
        {
            get
            {
                return Properties.Resources.grandJardinTurc;
            }
        }

        public static Stream petitJardinTurc
        {
            get
            {
                return Properties.Resources.petitJardinTurc;
            }
        }

        public static Stream foretTurc
        {
            get
            {
                return Properties.Resources.foretTurc;
            }
        }

        public static Stream foretFR
        {
            get
            {
                return Properties.Resources.foretFR;
            }
        }

        public static Stream grandeForetFR
        {
            get
            {
                return Properties.Resources.grandeForetFR;
            }
        }

        public static Stream petiteForetFR
        {
            get
            {
                return Properties.Resources.petiteForetFR;
            }
        }

        public static Stream litFR
        {
            get
            {
                return Properties.Resources.litFR;
            }
        }

        public static Stream litTurc
        {
            get
            {
                return Properties.Resources.litTurc;
            }
        }

        public static Stream grandLitTurc
        {
            get
            {
                return Properties.Resources.grandLitTurc;
            }
        }

        public static Stream petitLitTurc
        {
            get
            {
                return Properties.Resources.petitLitTurc;
            }
        }

        public static Stream pauseFR
        {
            get
            {
                return Properties.Resources.pauseFR;
            }
        }

        public static Stream pouet
        {
            get
            {
                return Properties.Resources.pouet;
            }
        }

        public static Stream pontFR
        {
            get
            {
                return Properties.Resources.pontFR;
            }
        }

        public static Stream grandPontTurc
        {
            get
            {
                return Properties.Resources.grandPontTurc;
            }
        }

        public static Stream petitPontTurc
        {
            get
            {
                return Properties.Resources.petitPontTurc;
            }
        }

        public static Stream grandPontFR
        {
            get
            {
                return Properties.Resources.grandPontFR;
            }
        }

        public static Stream petitPontFR
        {
            get
            {
                return Properties.Resources.petitPontFR;
            }
        }

        public static Stream pijama
        {
            get
            {
                return Properties.Resources.pijama;
            }
        }

        public static Stream questionBoiteFR
        {
            get
            {
                return Properties.Resources.questionBoiteFR;
            }
        }

        public static Stream questionBoiteTurc
        {
            get
            {
                return Properties.Resources.questionBoiteTurc;
            }
        }

        public static Stream roiFR
        {
            get
            {
                return Properties.Resources.roiFR;
            }
        }

        public static Stream roiTurc
        {
            get
            {
                return Properties.Resources.roiTurc;
            }
        }

        public static Stream grandRoiTurc
        {
            get
            {
                return Properties.Resources.grandRoiTurc;
            }
        }

        public static Stream petitRoiTurc
        {
            get
            {
                return Properties.Resources.petitRoiTurc;
            }
        }

        public static Stream roiMetPijamaTurc
        {
            get
            {
                return Properties.Resources.roiMetPijamaTurc;
            }
        }

        public static Stream roiMonteChaiseTurc
        {
            get
            {
                return Properties.Resources.roiMonteChaiseTurc;
            }
        }

        public static Stream roiMonteChaiseFR
        {
            get
            {
                return Properties.Resources.roiMonteChaiseFR;
            }
        }

        public static Stream roiMonteEscalierTurc
        {
            get
            {
                return Properties.Resources.roiMonteEscalierTurc;
            }
        }

        public static Stream roiMonteEscalierFR
        {
            get
            {
                return Properties.Resources.roiMonteEscalierFR;
            }
        }

        public static Stream roiMonteLitFR
        {
            get
            {
                return Properties.Resources.roiMonteLitFR;
            }
        }

        public static Stream roiMonteLitTurc
        {
            get
            {
                return Properties.Resources.roiMonteLitTurc;
            }
        }

        public static Stream roiPrendBainTurc
        {
            get
            {
                return Properties.Resources.roiPrendBainTurc;
            }
        }

        public static Stream roiPrendPauseFR
        {
            get
            {
                return Properties.Resources.roiPrendPauseFR;
            }
        }

        public static Stream roiRentreAuChateauFR
        {
            get
            {
                return Properties.Resources.roiRentreAuChateauFR;
            }
        }

        public static Stream roiRentreAuChateauTurc
        {
            get
            {
                return Properties.Resources.roiRentreAuChateauTurc;
            }
        }

        public static Stream roiSInstalleTableFR
        {
            get
            {
                return Properties.Resources.roiSInstalleTableFR;
            }
        }

        public static Stream roiTraverseLaForetFR
        {
            get
            {
                return Properties.Resources.roiTraverseLaForetFR;
            }
        }

        public static Stream roiTraverseLaForetTurc
        {
            get
            {
                return Properties.Resources.roiTraverseLaForetTurc;
            }
        }

        public static Stream roiTraverseLeJardinTurc
        {
            get
            {
                return Properties.Resources.roiTraverseLeJardinTurc;
            }
        }

        public static Stream roiTraverseLeJardinFR
        {
            get
            {
                return Properties.Resources.roiTraverseLeJardinFR;
            }
        }

        public static Stream roiVaALecoleTurc
        {
            get
            {
                return Properties.Resources.roiVaALecoleTurc;
            }
        }

        public static Stream roiVaALecoleFR
        {
            get
            {
                return Properties.Resources.roiRentreALecoleFR;
            }
        }

        public static Stream tableFR
        {
            get
            {
                return Properties.Resources.tableFR;
            }
        }

        public static Stream tableTurc
        {
            get
            {
                return Properties.Resources.tableTurc;
            }
        }

        public static Stream grandTableTurc
        {
            get
            {
                return Properties.Resources.grandTableTurc;
            }
        }

        public static Stream petitTableTurc
        {
            get
            {
                return Properties.Resources.petiteTableTurc;
            }
        }

    }
}
