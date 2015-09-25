// Acre.cs
// Classe servant à gérer les acres durant le déroulement du jeu.
// Programmé par Antony Garand
// Le 18 avril 2014
using System;
using System.Linq;
using System.Windows.Forms;

namespace SimVille
{
    [Serializable]
    /// <summary>
    /// Définit et contrôle les âcres tout au long du jeu
    /// </summary>
    class Acre
    {
        /// <summary>
        /// Contient les images qui seront affichés dans les picturebox
        /// </summary>
        private static ImageList imageListImages;
        /// <summary>
        /// Cellule contenant une image
        /// </summary>
        /// <summary>
        /// Contient le type de terrain sous forme numérale.
        /// </summary>
        private int imageID;
        /*Image list:
         * 0. Champ
         * 1. Foret
         * 2. Energie
         * 3. Police
         * 4. Hopital
         * 5. Residentiel
         * 6. Commercial
         * 7. Stade
         * Rivière: Direction initiale - direction finale
         * 8. Rivière Sud
         * 9. Rivière Nord-Est
         * 10.Rivière Nord-Ouest
         * 11.Rivière Sud-Est
         * 12.Rivière Sud-Ouest
         * 13. Rivière Ouest-Est
         * 14. Statistiques
         * 15. Icone
     */
        private int habitantQuartier;
        private static int habitantTotal;
        private static int nbCommerce;

        //Fin déclaration


        //Début instantiation
        private enum ImageListID
        {
             Champ,
             Foret,
             Energie,
             Police,
             Hopital,
             Residentiel,
             Commercial,
             Stade,
             RivièreSud,
             RivièreNordEst,
             RivièreNordOuest,
             RivièreSudEst,
             RivièreSudOuest,
             RivièreOuestEst,
             Statistiques,
             Icone
        };
        
        /// <summary>
        /// Créer un âcre avec un champ à l'intérieur
        /// </summary>
        /// <param name="imageListTerrain">Liste d'images à afficher dans le terrain</param>
        public Acre(ImageList imageListImagesTemp){
            if (imageListImages == null)
            {
                imageListImages = imageListImagesTemp;
            }
            if(nbCommerce == null)
            {
                nbCommerce = 0;
            }
            imageID = (int)ImageListID.Champ;
        }

        //Fin instantiation

        //Début fonctions
        /// <summary>
        /// Met a jour le nombre d'habitant du quartier, en ajustant le nombre d'habitants total en même temps.
        /// </summary>
        /// <param name="newNbHab">Nouveau nombre d'habitants</param>
        public void UpdateHabitants(int newNbHab)
        {
            newNbHab *= 10;
            if (imageID > 1 && imageID < 8)
            {
                habitantTotal -= habitantQuartier;
                habitantQuartier = newNbHab;
                habitantTotal += habitantQuartier;
            }
        }
        //Fin fonctions

        //Début Get/Set
        public int ImageID
        {
            get
            {
                return this.imageID;
            }
            set
            {
                //Si c'était un commerce mais on le change, on retire un commerce au nb total
                if (this.imageID == 6)
                {
                    nbCommerce--;
                }
                //Si on le transforme en commerce, on ajoute un commerce au nb total de commerce
                if(value == 6)
                {
                    nbCommerce++;
                }
                this.imageID = value;
            }
        }
  
        public static int HabitantTotal
        {
            get
            {
                return habitantTotal;
            }
        }

        public int HabitantQuartier
        {
            get
            {
                return this.habitantQuartier;
            }
        }

        public static int NbCommerce
    {
        get
        {
            return nbCommerce;
        }
    }

        //Fin Get/Set
    }
}
