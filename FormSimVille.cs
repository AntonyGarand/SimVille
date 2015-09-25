//FormSimVille.cs
//Jeu de simulation de vie
//Par Antony Garand

//Modification 15/04/14:
//  Ajout de la génération de la rivière
//  Ajout de la génération de la forêt

//Modification 18/04/14:
//  Ajout du gestionnaire d'évênements pour le clic des âcres

//Modification 24/04/14:
//  Ajout du calcul des distances et restrictions sur la construction 

//Modification du 20/05/14
//Finalisation des catastrophes, annotations

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SimVille
{
    public partial class FormSimVille : Form
    {
        private DateTime dateActuelle = DateTime.Now;
        private PictureBox[,] pictureBoxRegion = new System.Windows.Forms.PictureBox[20, 12];
        private static Region terrain;
        private int selectedIndex;
        
        public FormSimVille()
        {
            InitializeComponent();
            
        }
        private void FormSimVille_Load(object sender, EventArgs e)
        {
            #region images dans les contrôles

            radioButtonEnergie.ImageIndex = 2;
            radioButtonPolice.ImageIndex = 3;
            radioButtonHopital.ImageIndex = 4;
            radioButtonRésidentiel.ImageIndex = 5;
            radioButtonCommercial.ImageIndex = 6;
            radioButtonStade.ImageIndex = 7;
            radioButtonStatistiques.ImageIndex = 14;

            #endregion

            terrain = new Region(imageListImages);
            //PictureBoxRegion[]
            EventHandler evenementClick = new System.EventHandler(this.PictureBoxRegionClick);
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    pictureBoxRegion[i, j] = new PictureBox();
                    //On assigne un champ lors de la première génération
                    pictureBoxRegion[i, j].Dock = DockStyle.Fill;
                    pictureBoxRegion[i, j].Image = imageListImages.Images[terrain.ImageID(i, j)];
                    pictureBoxRegion[i, j].Margin = new Padding(0, 0, 0, 0);
                    tableLayoutPanelRegion.Controls.Add(pictureBoxRegion[i, j], i, j);
                    pictureBoxRegion[i, j].Click += evenementClick;
                }
            }
            terrain.Generation();
            UpdateImage();
            timerMinuterie.Start();
        }

        /// <summary>
        /// Regénère un terrain avec une rivière et 1-4 forets
        /// </summary>
        public void ButtonRegeneration_Click(object sender, EventArgs e)
        {
            dateActuelle = DateTime.Now;
            terrain.Generation();
            UpdateImage();
            timerMinuterie.Start();
        }

        /// <summary>
        /// Affiche les bonnes images dans les Picturebox
        /// </summary>
        private void UpdateImage()
        {
            //Mise à jour des images dans les PictureBox
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    pictureBoxRegion[i, j].Image = imageListImages.Images[terrain.ImageID(i, j)];
                }
            }
            //Mise à jour du texte
            labelBanqueValue.Text = terrain.NbArgentBanque().ToString();
            labelDateValue.Text = dateActuelle.ToShortDateString();
        }

        /// <summary>
        /// Évènement se produisant lorsqu'on clique sur une cellule
        /// </summary>
        /// <param name="sender">Picturebox ayant causée l'évènement</param>
        /// <param name="e">Évènement</param>
        private void PictureBoxRegionClick(object sender, EventArgs e)
        { 
            int[] coord = { tableLayoutPanelRegion.GetColumn((PictureBox)sender), tableLayoutPanelRegion.GetRow((PictureBox)sender) };
            //Si nous sommes sur "Statistiques"
            if (selectedIndex == 10)
            {
                pictureBoxSelectionPreview.Image = pictureBoxRegion[coord[0], coord[1]].Image;
                labelLigneValue.Text = coord[1].ToString();
                labelColonneValue.Text = coord[0].ToString();
                int[] stats = new int[4];
                stats = terrain.CalculStatistiques(coord, trackBarTaxes.Value);
                progressBarLoisirs.Value = stats[1];
                progressBarSante.Value = stats[0];
                progressBarCriminalite.Value = stats[2];
                progressBarSatisfaction.Value = (stats[3] >= 0) ? stats[3] : 0;
                labelHabAcreValue.Text = (stats[3] >= 0) ? (stats[3] * 10).ToString() : "0";
            }
            else
            {
                terrain.ValiderConstruction(coord, selectedIndex, trackBarTaxes.Value);
                UpdateImage();
            }

        }
        /// <summary>
        /// Se produit lorsqu'on change l'index de sélection
        /// </summary>
        private void RadioButtonListCheckedChanged(object sender, EventArgs e)
        {
            RadioButton temp = (RadioButton)sender;
            string type = temp.Text;
            switch(type)
            {
                case "Énergie":
                    selectedIndex = 2;
                    break;
                case "Police":
                    selectedIndex = 3;
                    break;
                case "Hôpital":
                    selectedIndex = 4;
                    break;
                case "Résidentiel":
                    selectedIndex = 5;
                    break;
                case "Commercial":
                    selectedIndex = 6;
                    break;
                case "Stade":
                    selectedIndex = 7;
                    break;
                case "Statistiques":
                    selectedIndex = 10;
                    break;
                default:
                    selectedIndex = 0;
                    break;
            }
        }
        /// <summary>
        /// Change de mois
        /// </summary>
        private void TimerMinuterieTick(object sender, EventArgs e)
        {
            int[] argent = terrain.CalculArgent();//Hab, revenu total

            labelHabitantsValue.Text = argent[0].ToString();
            labelRevenuHabValue.Text = argent[1].ToString();
            int revenuEtat = terrain.ProchainMois(trackBarTaxes.Value);
            
            labelRevenuMensuelValue.Text = revenuEtat.ToString();
            
            dateActuelle = dateActuelle.AddMonths(1);
            terrain.Catastrophe();
            UpdateImage();
        }
        /// <summary>
        /// Change la vitesse de défilement automatique
        /// </summary>
        private void TrackBarGameSpeedScroll(object sender, EventArgs e)
        {
            labelSimulationSpeed.Text = trackBarGameSpeed.Value.ToString();
            timerMinuterie.Interval = trackBarGameSpeed.Value * 1000;
        }
        /// <summary>
        /// Change le pourcentage de taxe
        /// </summary>
        private void TrackBarTaxes_Scroll(object sender, EventArgs e)
        {
           labelTaxesValue.Text = (trackBarTaxes.Value.ToString() + " %");
           int bak = selectedIndex;
           selectedIndex = 10;
            foreach(PictureBox pict in pictureBoxRegion){
                PictureBoxRegionClick(pict, e);
            }
            selectedIndex = bak;
        }
        /// <summary>
        /// Enregistre la classe Région
        /// </summary>
        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            timerMinuterie.Stop();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "SimVille Save|*.svs";
            saveFileDialog.Title = "Enregistrer sous";
            DialogResult resultat = saveFileDialog.ShowDialog();
            try{
                Stream flux = saveFileDialog.OpenFile();
                if (resultat == DialogResult.OK)
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();                    
                            //Write
                        formatter.Serialize(flux, terrain);
                        MessageBox.Show("Sauvegarde terminée!");
                        flux.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur! " + Environment.NewLine + ex.Message);
                    }
                    finally
                    {
                        if (flux != null)
                            flux.Close();
                    }
                }
                timerMinuterie.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur! " + Environment.NewLine + ex.Message);
            }
        }
        /// <summary>
        /// Ouvre un objet Région précédement enregistrer
        /// </summary>
        private void buttonOuvrir_Click(object sender, EventArgs e)
        {
            timerMinuterie.Stop();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult resultat = openFileDialog.ShowDialog();
            try
            {
                Stream flux = openFileDialog.OpenFile();

                if (resultat == DialogResult.OK)
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        //Read
                        terrain = (Region)formatter.Deserialize(flux);
                        UpdateImage();
                        MessageBox.Show("Ouverture terminée!");
                        flux.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur! " + Environment.NewLine + ex.Message);
                    }
                    finally
                    {
                        if (flux != null)
                            flux.Close();
                    }
                timerMinuterie.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur! " + Environment.NewLine + ex.Message);
            }
        }

    }
}