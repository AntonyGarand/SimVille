using System;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace SimVille
{
    [Serializable]
    class Region
    {
        private static ImageList imageListImages;
        private Acre[,] tabAcres;
        public Region(ImageList imageList)
        {
            //Génération des champs
            tabAcres = new Acre[20, 12];
            imageListImages = imageList;
            //Création des Acres et place leur ID à 0
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    tabAcres[i,j] = new Acre(imageListImages);
                 }
            }
        }
        /// <summary>
        /// Génère un nouveau terrain et remet l'économie à son état initial. 
        /// </summary>
        public void Generation()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    tabAcres[i, j].ImageID = 0;
                }
            }
            Economie.ArgentBanque = 1000000;
            Random rnd = new Random();

            #region Génération de la foret
            //Nombre de forets aléatoire
            int nbForet = rnd.Next(1, 4);
            Debug.WriteLine("Nombre de forets: " + nbForet.ToString());
            Thread.Sleep(100);
            for (int i = 0; i < nbForet; i++)
            {
                //Point minimale de la foret
                int[] Depart = new int[2];
                Depart[0] = rnd.Next(0, 20);
                Thread.Sleep(10);
                Depart[1] = rnd.Next(0, 12);
                Thread.Sleep(10);
                int[] grandeur = new int[2];
                grandeur[0] = rnd.Next(2, 5);
                Thread.Sleep(10);
                grandeur[1] = rnd.Next(2, 5);
                Thread.Sleep(10);
                Debug.WriteLine("Depart: " + Depart[0] + "," + Depart[1]);
                Debug.WriteLine("Grandeur : " + grandeur[0] + "," + grandeur[1]);
                for (int x = 0; x < grandeur[0]; x++)
                {
                    Thread.Sleep(10);
                    for (int y = 0; y < grandeur[1]; y++)
                    {
                        Thread.Sleep(10);
                        if (x + Depart[0] < 20 && y + Depart[1] < 12)
                        {
                            tabAcres[x + Depart[0], y + Depart[1]].ImageID = 1;
                        }
                    }
                }
            }
            #endregion

            #region génération de la rivière

            //Génération de la rivière

            int posX = rnd.Next(0, 20);
            tabAcres[posX, 0].ImageID = 8;
            for (int i = 1; i < 12; )
            {
                //On détermine le prochain déplacement de la rivière
                int move = rnd.Next(0, 3);

                switch (move)
                {
                    //Déplacement à gauche
                    case 0:
                        //Si la rivière n'est pas au bout à gauche (Au cas ou elle ne peut pas se déplacer à gauche)
                        if (posX - 1 >= 0)
                        {
                            //On vérifie si c'est le premier "tuyau" à aller à gauche (Si le tuyau au dessus descend)
                            if (tabAcres[posX, i - 1].ImageID == 8 || tabAcres[posX, i - 1].ImageID == 9 || tabAcres[posX, i - 1].ImageID == 10)
                            {
                                tabAcres[posX--, i].ImageID = 12;
                            }
                            //On vérifie si elle peut aller à gauche (Si elle n'est pas déjà aller à droite)
                            else if (posX + 1 < 20)
                            {
                                if (tabAcres[posX + 1, i].ImageID == 12 || tabAcres[posX + 1, i].ImageID == 13)
                                {
                                    tabAcres[posX--, i].ImageID = 13;
                                }
                            }
                        }
                        //Sinon, on descend
                        else
                        {
                            DescendreRiviere(ref posX, ref i);
                        }
                        break;

                    //Descente d'une case
                    case 1:
                        DescendreRiviere(ref posX, ref i);
                        break;

                    //Déplacement à droite
                    case 2:
                        //Si la rivière n'est pas au bout à droite (Au cas ou elle ne peut pas se déplacer à droite)
                        if (posX + 1 < 20)
                        {
                            //On vérifie si c'est le premier "tuyau" à aller à droite (Si le tuyau au dessus descend)
                            if (tabAcres[posX, i - 1].ImageID == 8 || tabAcres[posX, i - 1].ImageID == 9 ||
                                tabAcres[posX, i - 1].ImageID == 10)
                            {
                                tabAcres[posX++, i].ImageID = 11;
                            }
                            //On vérifie si elle peut aller à gauche (Si elle n'est pas déjà aller à droite)
                            else if (posX - 1 >= 0)
                            {
                                if (tabAcres[posX - 1, i].ImageID == 13 || tabAcres[posX - 1, i].ImageID == 11)
                                {
                                    tabAcres[posX++, i].ImageID = 13;
                                }
                            }
                        }
                        //Sinon, on descend
                        else
                        {
                            DescendreRiviere(ref posX, ref i);
                        }
                        break;
                }
            }

            #endregion

        }

        /// <summary>
        /// Retourne le ID de l'image d'un âcre
        /// </summary>
        /// <param name="x">Position en X de l'âcre à intéroger</param>
        /// <param name="y">Position en Y de l'âcre à intéroger</param>
        /// <returns>ID de l'image à afficher</returns>
        public int ImageID(int x, int y)
        {
            return tabAcres[x, y].ImageID;
        }
        /// <summary>
        /// Change le ID du terrain par celui désiré. 
        /// </summary>
        /// <param name="x">Coordonnée en X du terrain</param>
        /// <param name="y">Coordonnée en Y du terrain</param>
        /// <param name="value">Nouvelle valeur à assigner au terrain</param>
        public void ImageID(int x, int y, int value)
        {
            tabAcres[x, y].ImageID = value;
        }

        /// <summary>
        /// Descend la rivière à partir de sa position actuelle
        /// </summary>
        /// <param name="posX">Position X actuelle</param>
        /// <param name="posY">Position Y actuelle</param>
        private void DescendreRiviere(ref int posX, ref int posY)
        {
            //On vérifie si on descend en ligne droite
            if (tabAcres[posX, posY - 1].ImageID == 8)
            {
                tabAcres[posX, posY++].ImageID = 8;
                return;
            }
            //On vérifie si elle passe par sa droite
            if (posX + 1 < 20)
            {
                if (tabAcres[posX + 1, posY].ImageID == 13 || tabAcres[posX + 1, posY].ImageID == 12)
                {
                    tabAcres[posX, posY++].ImageID = 9;
                    return;
                }
            }
            //On vérifie si elle passe par sa gauche
            if (posX - 1 > 0)
            {
                if (tabAcres[posX - 1, posY].ImageID == 13 || tabAcres[posX - 1, posY].ImageID == 11)
                {
                    tabAcres[posX, posY++].ImageID = 10;
                }
            }
        }

        /// <summary>
        /// Calcule la distance entre deux points
        /// </summary>
        /// <param name="coord1">Première coordonnée</param>
        /// <param name="coord2">Deuxième coordonnée</param>
        /// <returns>Distance (int) entre les points</returns>
        public int Distance(int[] coord1, int[] coord2)
        {
            return (System.Math.Abs((coord1[0] - coord2[0])) + System.Math.Abs(coord1[1] - coord2[1]));
        }

        /// <summary>
        /// Calcule la distance minimale entre un point et un type de batiment
        /// </summary>
        /// <param name="coord">Point actuel</param>
        /// <param name="typeBatiment">ID du type de bâtiment à rechercher</param>
        /// <returns>Distance (int) minimale entre un point et le type de bâtiment</returns>
        private int DistanceConstruction(int[] coord, int typeBatiment)
        {
            int dist = 100;
            //Vérification dans chaque point
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    //Si le type de terrain de cette case est égale au type de bâtiment
                    if(tabAcres[i, j].ImageID == typeBatiment)
                    {
                        int[] toto = {i,j};
                        int distanceAct = Distance(coord, toto);
                        
                        //Si la distance actuelle est plus petite que la distance minimale trouvée, on la met dans la distance minimale.
                        dist = (dist > distanceAct) ? distanceAct : dist;
                    }
                }
            }
            return dist;
        }
        /// <summary>
        /// Détermine si une construction est valide en fonction de son cout et de la distance entre l'énergie.
        /// </summary>
        /// <param name="coord">Coordonnées de l'emplacement à construire</param>
        /// <param name="typeBatiment">Type de batiment que l'on désire construire</param>
        public void ValiderConstruction(int[] coord, int typeBatiment, int taxes)
        {
            Messages.Id message = Messages.Id.ErreurProgrammation;
            int argentDisponible = Economie.ArgentBanque;
            int terrainID = tabAcres[coord[0], coord[1]].ImageID;
            int argentRequis = 0;
            
            switch (typeBatiment)
            { 
                case 2: //Énergie
                    argentRequis = 60000;
                    break;
                case 3: //Poste de police
                    argentRequis = 35000;
                    break;
                case 4: //Hopital
                    argentRequis = 90000;
                    break;
                case 5: //Residentiel
                    argentRequis = 40000;
                    break;
                case 6: //Commercial
                    argentRequis = 65000;
                    break;
                case 7: //Stade
                    argentRequis = 75000;
                    break;
            }
            if (terrainID == 1) //Si on construit sur une foret, on ajoute 10000 ou 15000 à la construction
                argentRequis += (typeBatiment > 5) ? 15000 : 10000;
            
            //Si on peut se permettre de construire
            if(argentRequis < argentDisponible)
            {
                int distance = 0;
                //Si le terrain est un champ ou une foret (Si on peut construire)
                if(terrainID == 0 || terrainID == 1)
                {
                    //Si on construit autre chose qu'une source d'énergie
                    if(typeBatiment != 2)
                    {
                        //On calcule la distance entre la source d'énergie la plus proche et notre position
                        distance = DistanceConstruction(coord, 2);
                    }
                    //On construit si la distance est plus petite que 12
                    if(distance < 12)
                    {
                        message = Messages.Id.MessageOk;
                        tabAcres[coord[0], coord[1]].ImageID = typeBatiment;
                        Economie.ArgentBanque -= argentRequis;
                        CalculStatistiques(coord, taxes);
                    }
                    else
                    {
                        message = Messages.Id.ErreurLocationInvalide;
                    }
                }
                else
                {
                    message = Messages.Id.ErreurLocationInvalide;
                }
            }
            //Si nous n'avons pas assez d'argent
            else
            {
                message = Messages.Id.ErreurFondInsuffisants;
            }

            MessageBox.Show(Messages.Message[(int)message]);
        }
        /// <summary>
        /// Calcul les statistiques d'un terrain
        /// </summary>
        /// <param name="coord">Coordonnées d'un terrain en {x, y}</param>
        /// <param name="taxes">Taux de taxes</param>
        /// <returns>Statistiques d'un terrain</returns>
        public int[] CalculStatistiques(int[] coord, int taxes)
        {
            int[] stats = new int[4];
            int distTemp = DistanceConstruction(coord, 7);
            stats[1] = (distTemp >= 20) ? 0 : 100 - 5*distTemp;

            distTemp =  DistanceConstruction(coord, 3);
            stats[2] = (distTemp >= 10) ? 100 : 10 * distTemp;

            distTemp = DistanceConstruction(coord, 4);
            stats[0] = (distTemp >= 15) ? 0 : (int)(100.0 - (100.0 / 15.0 * distTemp)); //Loisirs
            if (tabAcres[coord[0], coord[1]].ImageID == 5)
            {
                int nbHabs = (int)(((double)stats[1] + (100.0 - (double)stats[2]) + (double)stats[1]) / 3.0 - taxes * 2);
                if (tabAcres[coord[0], coord[1]].ImageID > 1 && tabAcres[coord[0], coord[1]].ImageID < 8)
                    stats[3] = (nbHabs >= 0) ? nbHabs : 0;
                else
                    stats[3] = 0;
                tabAcres[coord[0], coord[1]].UpdateHabitants(stats[3]);
            }
            else
                stats[3] = 0;
            return stats;
        }
        /// <summary>
        /// Calcul l'argent moyen des habitants
        /// </summary>
        /// <returns>Revenu mensuel moyen</returns>
        public int[] CalculArgent()
        {
            int[] retour = new int[2]; //Hab, revenu total
            retour[0] = Acre.HabitantTotal;
            retour[1] = 40000 + (Acre.NbCommerce * 1000);
            return retour;
        }
        /// <summary>
        /// Ajoutes le montant des taxes en banque
        /// </summary>
        /// <param name="taxe">Pourcentage de taxes actuel</param>
        /// <returns>Revenu de l'état</returns>
        public int ProchainMois(int taxe)
        {
            int[] stats = CalculArgent();
            int revenuEtat = (stats[0] * stats[1] * taxe) / 48;
                //Nombre d’habitants total * Revenu Moyen * Taux de taxe /12 mois / 4 personnes par famille
            Economie.ArgentBanque += revenuEtat;
            return revenuEtat;
        }
        /// <summary>
        /// Retourne le nombre d'argent en banque total
        /// </summary>
        /// <returns>Montant en banque</returns>
        public int NbArgentBanque()
        {
            return Economie.ArgentBanque;
        }
        /// <summary>
        /// Provoque une catastrophe aléatoire
        /// </summary>
        public void Catastrophe()
        {
            Random rnd = new Random();
            int catasrtopheID = rnd.Next(0, 7);
            int[] position = new int[2];
            bool touche = false;
            int messageID = 0;
            switch (catasrtopheID)
            {
                case 1:
                    //Tempête de verglas
                    position[0] = rnd.Next(0, 14);
                    position[1] = rnd.Next(0, 6);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if(tabAcres[position[0] + i,position[1] + j].ImageID == 2) //Si source d'énergie
                            {
                                touche = true;
                                tabAcres[position[0] + i,position[1] + j].ImageID = 0;
                                messageID = 5;
                            }
                        }
                    }
                    break;
                case 2:
                    //Reforme de sante
                    position[0] = rnd.Next(0, 16);
                    position[1] = rnd.Next(0, 8);
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if(tabAcres[position[0] + i,position[1] + j].ImageID == 4) //Si hopital
                            {
                                touche = true;
                                tabAcres[position[0] + i,position[1] + j].ImageID = 0;
                            }
                        }
                    }
                    break;
                case 3:
                    position[0] = rnd.Next(0, 13);
                    position[1] = rnd.Next(0, 5);
                    //Tremblement de terre
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if(tabAcres[position[0] + i,position[1] + j].ImageID == 5) //Si residentiel
                            {
                                touche = true;
                                tabAcres[position[0] + i,position[1] + j].ImageID = 0;
                            }
                        }
                    }
                    break;
                case 4://Incendie
                    position[0] = rnd.Next(0, 16);
                    position[1] = rnd.Next(0, 8);
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if(tabAcres[position[0] + i,position[1] + j].ImageID == 6) //Si commercial
                            {
                                touche = true;
                                tabAcres[position[0] + i,position[1] + j].ImageID = 0;
                            }
                        }
                    }
                    break;
                case 5:
                    position[0] = rnd.Next(0, 14);
                    position[1] = rnd.Next(0, 7);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if(tabAcres[position[0] + i,position[1] + j].ImageID == 7) //Si Stade
                            {
                                touche = true;
                                tabAcres[position[0] + i,position[1] + j].ImageID = 0;
                            }
                        }
                    }
                    break;
            }
            if (touche)
            { MessageBox.Show(Messages.Message[5]); }
        }
    }
}
