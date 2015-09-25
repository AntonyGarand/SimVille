using System.Windows.Forms;
namespace SimVille
{
    partial class FormSimVille
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSimVille));
            this.tableLayoutPanelRegion = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxOutils = new System.Windows.Forms.GroupBox();
            this.radioButtonStatistiques = new System.Windows.Forms.RadioButton();
            this.imageListImages = new System.Windows.Forms.ImageList(this.components);
            this.radioButtonStade = new System.Windows.Forms.RadioButton();
            this.radioButtonCommercial = new System.Windows.Forms.RadioButton();
            this.radioButtonRésidentiel = new System.Windows.Forms.RadioButton();
            this.radioButtonHopital = new System.Windows.Forms.RadioButton();
            this.radioButtonPolice = new System.Windows.Forms.RadioButton();
            this.radioButtonEnergie = new System.Windows.Forms.RadioButton();
            this.groupBoxSelection = new System.Windows.Forms.GroupBox();
            this.labelSatisfaction = new System.Windows.Forms.Label();
            this.progressBarSatisfaction = new System.Windows.Forms.ProgressBar();
            this.labelCriminalite = new System.Windows.Forms.Label();
            this.progressBarCriminalite = new System.Windows.Forms.ProgressBar();
            this.labelSante = new System.Windows.Forms.Label();
            this.progressBarSante = new System.Windows.Forms.ProgressBar();
            this.labelLoisirs = new System.Windows.Forms.Label();
            this.progressBarLoisirs = new System.Windows.Forms.ProgressBar();
            this.labelColonneValue = new System.Windows.Forms.Label();
            this.labelColonne = new System.Windows.Forms.Label();
            this.pictureBoxSelectionPreview = new System.Windows.Forms.PictureBox();
            this.labelLigneValue = new System.Windows.Forms.Label();
            this.labelLigne = new System.Windows.Forms.Label();
            this.timerMinuterie = new System.Windows.Forms.Timer(this.components);
            this.groupBoxStatistiques = new System.Windows.Forms.GroupBox();
            this.labelHabAcreValue = new System.Windows.Forms.Label();
            this.labelHabParAcre = new System.Windows.Forms.Label();
            this.labelHabitantsValue = new System.Windows.Forms.Label();
            this.labelHabitants = new System.Windows.Forms.Label();
            this.labelRevenuMensuelValue = new System.Windows.Forms.Label();
            this.labelRevenuMensuel = new System.Windows.Forms.Label();
            this.labelRevenuHabValue = new System.Windows.Forms.Label();
            this.labelRevenuHab = new System.Windows.Forms.Label();
            this.labelBanqueValue = new System.Windows.Forms.Label();
            this.labelEnBanque = new System.Windows.Forms.Label();
            this.groupBoxParametres = new System.Windows.Forms.GroupBox();
            this.trackBarTaxes = new System.Windows.Forms.TrackBar();
            this.labelTaxesValue = new System.Windows.Forms.Label();
            this.labelTaxes = new System.Windows.Forms.Label();
            this.trackBarGameSpeed = new System.Windows.Forms.TrackBar();
            this.labelSecondesMois = new System.Windows.Forms.Label();
            this.labelSimulationSpeed = new System.Windows.Forms.Label();
            this.labelTauxSimulation = new System.Windows.Forms.Label();
            this.labelDateValue = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonNouvellePartie = new System.Windows.Forms.Button();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.buttonOuvrir = new System.Windows.Forms.Button();
            this.groupBoxOutils.SuspendLayout();
            this.groupBoxSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectionPreview)).BeginInit();
            this.groupBoxStatistiques.SuspendLayout();
            this.groupBoxParametres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTaxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGameSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelRegion
            // 
            this.tableLayoutPanelRegion.ColumnCount = 20;
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelRegion.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelRegion.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelRegion.Name = "tableLayoutPanelRegion";
            this.tableLayoutPanelRegion.RowCount = 12;
            this.tableLayoutPanelRegion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanelRegion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanelRegion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanelRegion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanelRegion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanelRegion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanelRegion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanelRegion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanelRegion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanelRegion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanelRegion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanelRegion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanelRegion.Size = new System.Drawing.Size(1000, 600);
            this.tableLayoutPanelRegion.TabIndex = 0;            // 
            // groupBoxOutils
            // 
            this.groupBoxOutils.Controls.Add(this.radioButtonStatistiques);
            this.groupBoxOutils.Controls.Add(this.radioButtonStade);
            this.groupBoxOutils.Controls.Add(this.radioButtonCommercial);
            this.groupBoxOutils.Controls.Add(this.radioButtonRésidentiel);
            this.groupBoxOutils.Controls.Add(this.radioButtonHopital);
            this.groupBoxOutils.Controls.Add(this.radioButtonPolice);
            this.groupBoxOutils.Controls.Add(this.radioButtonEnergie);
            this.groupBoxOutils.Location = new System.Drawing.Point(14, 618);
            this.groupBoxOutils.Name = "groupBoxOutils";
            this.groupBoxOutils.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxOutils.Size = new System.Drawing.Size(1000, 111);
            this.groupBoxOutils.TabIndex = 0;
            this.groupBoxOutils.TabStop = false;
            this.groupBoxOutils.Text = "Outils";
            // 
            // radioButtonStatistiques
            // 
            this.radioButtonStatistiques.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonStatistiques.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonStatistiques.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonStatistiques.ImageList = this.imageListImages;
            this.radioButtonStatistiques.Location = new System.Drawing.Point(615, 17);
            this.radioButtonStatistiques.Name = "radioButtonStatistiques";
            this.radioButtonStatistiques.Padding = new System.Windows.Forms.Padding(0, 5, 3, 5);
            this.radioButtonStatistiques.Size = new System.Drawing.Size(76, 85);
            this.radioButtonStatistiques.TabIndex = 13;
            this.radioButtonStatistiques.TabStop = true;
            this.radioButtonStatistiques.Text = "Statistiques";
            this.radioButtonStatistiques.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonStatistiques.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButtonStatistiques.UseVisualStyleBackColor = true;
            this.radioButtonStatistiques.CheckedChanged += new System.EventHandler(this.RadioButtonListCheckedChanged);
            // 
            // imageListImages
            // 
            this.imageListImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListImages.ImageStream")));
            this.imageListImages.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListImages.Images.SetKeyName(0, "Champ.png");
            this.imageListImages.Images.SetKeyName(1, "Foret.png");
            this.imageListImages.Images.SetKeyName(2, "Energie.png");
            this.imageListImages.Images.SetKeyName(3, "Police.png");
            this.imageListImages.Images.SetKeyName(4, "Hopital.png");
            this.imageListImages.Images.SetKeyName(5, "Residentiel.png");
            this.imageListImages.Images.SetKeyName(6, "Commercial.png");
            this.imageListImages.Images.SetKeyName(7, "Stade.png");
            this.imageListImages.Images.SetKeyName(8, "RiviereNordSud.png");
            this.imageListImages.Images.SetKeyName(9, "RiviereSudEst.png");
            this.imageListImages.Images.SetKeyName(10, "RiviereSudOuest.png");
            this.imageListImages.Images.SetKeyName(11, "RiviereNordEst.png");
            this.imageListImages.Images.SetKeyName(12, "RiviereNordOuest.png");
            this.imageListImages.Images.SetKeyName(13, "RiviereEstOuest.png");
            this.imageListImages.Images.SetKeyName(14, "Statistiques.png");
            this.imageListImages.Images.SetKeyName(15, "SimVille.ico");
            // 
            // radioButtonStade
            // 
            this.radioButtonStade.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonStade.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonStade.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonStade.ImageList = this.imageListImages;
            this.radioButtonStade.Location = new System.Drawing.Point(515, 17);
            this.radioButtonStade.Name = "radioButtonStade";
            this.radioButtonStade.Padding = new System.Windows.Forms.Padding(3, 5, 6, 5);
            this.radioButtonStade.Size = new System.Drawing.Size(76, 85);
            this.radioButtonStade.TabIndex = 12;
            this.radioButtonStade.TabStop = true;
            this.radioButtonStade.Text = "Stade";
            this.radioButtonStade.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonStade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButtonStade.UseVisualStyleBackColor = true;
            this.radioButtonStade.CheckedChanged += new System.EventHandler(this.RadioButtonListCheckedChanged);
            // 
            // radioButtonCommercial
            // 
            this.radioButtonCommercial.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCommercial.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonCommercial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonCommercial.ImageList = this.imageListImages;
            this.radioButtonCommercial.Location = new System.Drawing.Point(415, 17);
            this.radioButtonCommercial.Name = "radioButtonCommercial";
            this.radioButtonCommercial.Padding = new System.Windows.Forms.Padding(0, 5, 3, 5);
            this.radioButtonCommercial.Size = new System.Drawing.Size(76, 85);
            this.radioButtonCommercial.TabIndex = 11;
            this.radioButtonCommercial.TabStop = true;
            this.radioButtonCommercial.Text = "Commercial";
            this.radioButtonCommercial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonCommercial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButtonCommercial.UseVisualStyleBackColor = true;
            this.radioButtonCommercial.CheckedChanged += new System.EventHandler(this.RadioButtonListCheckedChanged);
            // 
            // radioButtonRésidentiel
            // 
            this.radioButtonRésidentiel.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonRésidentiel.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonRésidentiel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonRésidentiel.ImageList = this.imageListImages;
            this.radioButtonRésidentiel.Location = new System.Drawing.Point(315, 17);
            this.radioButtonRésidentiel.Name = "radioButtonRésidentiel";
            this.radioButtonRésidentiel.Padding = new System.Windows.Forms.Padding(3, 5, 6, 5);
            this.radioButtonRésidentiel.Size = new System.Drawing.Size(76, 85);
            this.radioButtonRésidentiel.TabIndex = 10;
            this.radioButtonRésidentiel.TabStop = true;
            this.radioButtonRésidentiel.Text = "Résidentiel";
            this.radioButtonRésidentiel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonRésidentiel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButtonRésidentiel.UseVisualStyleBackColor = true;
            this.radioButtonRésidentiel.CheckedChanged += new System.EventHandler(this.RadioButtonListCheckedChanged);
            // 
            // radioButtonHopital
            // 
            this.radioButtonHopital.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonHopital.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonHopital.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonHopital.ImageList = this.imageListImages;
            this.radioButtonHopital.Location = new System.Drawing.Point(215, 17);
            this.radioButtonHopital.Name = "radioButtonHopital";
            this.radioButtonHopital.Padding = new System.Windows.Forms.Padding(3, 5, 6, 5);
            this.radioButtonHopital.Size = new System.Drawing.Size(76, 85);
            this.radioButtonHopital.TabIndex = 9;
            this.radioButtonHopital.TabStop = true;
            this.radioButtonHopital.Text = "Hôpital";
            this.radioButtonHopital.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonHopital.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButtonHopital.UseVisualStyleBackColor = true;
            this.radioButtonHopital.CheckedChanged += new System.EventHandler(this.RadioButtonListCheckedChanged);
            // 
            // radioButtonPolice
            // 
            this.radioButtonPolice.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonPolice.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonPolice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonPolice.ImageList = this.imageListImages;
            this.radioButtonPolice.Location = new System.Drawing.Point(115, 17);
            this.radioButtonPolice.Name = "radioButtonPolice";
            this.radioButtonPolice.Padding = new System.Windows.Forms.Padding(3, 5, 6, 5);
            this.radioButtonPolice.Size = new System.Drawing.Size(76, 85);
            this.radioButtonPolice.TabIndex = 8;
            this.radioButtonPolice.TabStop = true;
            this.radioButtonPolice.Text = "Police";
            this.radioButtonPolice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonPolice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButtonPolice.UseVisualStyleBackColor = true;
            this.radioButtonPolice.CheckedChanged += new System.EventHandler(this.RadioButtonListCheckedChanged);
            // 
            // radioButtonEnergie
            // 
            this.radioButtonEnergie.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonEnergie.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonEnergie.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonEnergie.ImageList = this.imageListImages;
            this.radioButtonEnergie.Location = new System.Drawing.Point(15, 17);
            this.radioButtonEnergie.Name = "radioButtonEnergie";
            this.radioButtonEnergie.Padding = new System.Windows.Forms.Padding(3, 5, 6, 5);
            this.radioButtonEnergie.Size = new System.Drawing.Size(76, 85);
            this.radioButtonEnergie.TabIndex = 7;
            this.radioButtonEnergie.TabStop = true;
            this.radioButtonEnergie.Text = "Énergie";
            this.radioButtonEnergie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonEnergie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButtonEnergie.UseVisualStyleBackColor = true;
            this.radioButtonEnergie.CheckedChanged += new System.EventHandler(this.RadioButtonListCheckedChanged);
            // 
            // groupBoxSelection
            // 
            this.groupBoxSelection.Controls.Add(this.labelSatisfaction);
            this.groupBoxSelection.Controls.Add(this.progressBarSatisfaction);
            this.groupBoxSelection.Controls.Add(this.labelCriminalite);
            this.groupBoxSelection.Controls.Add(this.progressBarCriminalite);
            this.groupBoxSelection.Controls.Add(this.labelSante);
            this.groupBoxSelection.Controls.Add(this.progressBarSante);
            this.groupBoxSelection.Controls.Add(this.labelLoisirs);
            this.groupBoxSelection.Controls.Add(this.progressBarLoisirs);
            this.groupBoxSelection.Controls.Add(this.labelColonneValue);
            this.groupBoxSelection.Controls.Add(this.labelColonne);
            this.groupBoxSelection.Controls.Add(this.pictureBoxSelectionPreview);
            this.groupBoxSelection.Controls.Add(this.labelLigneValue);
            this.groupBoxSelection.Controls.Add(this.labelLigne);
            this.groupBoxSelection.Location = new System.Drawing.Point(1029, 12);
            this.groupBoxSelection.Name = "groupBoxSelection";
            this.groupBoxSelection.Size = new System.Drawing.Size(177, 227);
            this.groupBoxSelection.TabIndex = 1;
            this.groupBoxSelection.TabStop = false;
            this.groupBoxSelection.Text = "Sélection";
            // 
            // labelSatisfaction
            // 
            this.labelSatisfaction.AutoSize = true;
            this.labelSatisfaction.Location = new System.Drawing.Point(6, 190);
            this.labelSatisfaction.Name = "labelSatisfaction";
            this.labelSatisfaction.Size = new System.Drawing.Size(106, 13);
            this.labelSatisfaction.TabIndex = 12;
            this.labelSatisfaction.Text = "Satisfaction générale";
            // 
            // progressBarSatisfaction
            // 
            this.progressBarSatisfaction.Location = new System.Drawing.Point(6, 206);
            this.progressBarSatisfaction.Name = "progressBarSatisfaction";
            this.progressBarSatisfaction.Size = new System.Drawing.Size(161, 12);
            this.progressBarSatisfaction.TabIndex = 11;
            this.progressBarSatisfaction.Value = 50;
            // 
            // labelCriminalite
            // 
            this.labelCriminalite.AutoSize = true;
            this.labelCriminalite.Location = new System.Drawing.Point(3, 159);
            this.labelCriminalite.Name = "labelCriminalite";
            this.labelCriminalite.Size = new System.Drawing.Size(54, 13);
            this.labelCriminalite.TabIndex = 10;
            this.labelCriminalite.Text = "Criminalité";
            // 
            // progressBarCriminalite
            // 
            this.progressBarCriminalite.Location = new System.Drawing.Point(6, 175);
            this.progressBarCriminalite.Name = "progressBarCriminalite";
            this.progressBarCriminalite.Size = new System.Drawing.Size(161, 12);
            this.progressBarCriminalite.TabIndex = 9;
            this.progressBarCriminalite.Value = 50;
            // 
            // labelSante
            // 
            this.labelSante.AutoSize = true;
            this.labelSante.Location = new System.Drawing.Point(6, 128);
            this.labelSante.Name = "labelSante";
            this.labelSante.Size = new System.Drawing.Size(35, 13);
            this.labelSante.TabIndex = 8;
            this.labelSante.Text = "Santé";
            // 
            // progressBarSante
            // 
            this.progressBarSante.Location = new System.Drawing.Point(6, 144);
            this.progressBarSante.Name = "progressBarSante";
            this.progressBarSante.Size = new System.Drawing.Size(161, 12);
            this.progressBarSante.TabIndex = 7;
            this.progressBarSante.Value = 50;
            // 
            // labelLoisirs
            // 
            this.labelLoisirs.AutoSize = true;
            this.labelLoisirs.Location = new System.Drawing.Point(3, 97);
            this.labelLoisirs.Name = "labelLoisirs";
            this.labelLoisirs.Size = new System.Drawing.Size(36, 13);
            this.labelLoisirs.TabIndex = 6;
            this.labelLoisirs.Text = "Loisirs";
            // 
            // progressBarLoisirs
            // 
            this.progressBarLoisirs.Location = new System.Drawing.Point(6, 113);
            this.progressBarLoisirs.Name = "progressBarLoisirs";
            this.progressBarLoisirs.Size = new System.Drawing.Size(161, 12);
            this.progressBarLoisirs.TabIndex = 5;
            this.progressBarLoisirs.Value = 50;
            // 
            // labelColonneValue
            // 
            this.labelColonneValue.AutoSize = true;
            this.labelColonneValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColonneValue.Location = new System.Drawing.Point(96, 50);
            this.labelColonneValue.Name = "labelColonneValue";
            this.labelColonneValue.Size = new System.Drawing.Size(14, 13);
            this.labelColonneValue.TabIndex = 4;
            this.labelColonneValue.Text = "0";
            // 
            // labelColonne
            // 
            this.labelColonne.AutoSize = true;
            this.labelColonne.Location = new System.Drawing.Point(3, 50);
            this.labelColonne.Name = "labelColonne";
            this.labelColonne.Size = new System.Drawing.Size(46, 13);
            this.labelColonne.TabIndex = 3;
            this.labelColonne.Text = "Colonne";
            // 
            // pictureBoxSelectionPreview
            // 
            this.pictureBoxSelectionPreview.Location = new System.Drawing.Point(117, 19);
            this.pictureBoxSelectionPreview.Name = "pictureBoxSelectionPreview";
            this.pictureBoxSelectionPreview.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxSelectionPreview.TabIndex = 2;
            this.pictureBoxSelectionPreview.TabStop = false;
            // 
            // labelLigneValue
            // 
            this.labelLigneValue.AutoSize = true;
            this.labelLigneValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLigneValue.Location = new System.Drawing.Point(96, 25);
            this.labelLigneValue.Name = "labelLigneValue";
            this.labelLigneValue.Size = new System.Drawing.Size(14, 13);
            this.labelLigneValue.TabIndex = 1;
            this.labelLigneValue.Text = "0";
            // 
            // labelLigne
            // 
            this.labelLigne.AutoSize = true;
            this.labelLigne.Location = new System.Drawing.Point(3, 25);
            this.labelLigne.Name = "labelLigne";
            this.labelLigne.Size = new System.Drawing.Size(33, 13);
            this.labelLigne.TabIndex = 0;
            this.labelLigne.Text = "Ligne";
            // 
            // timerMinuterie
            // 
            this.timerMinuterie.Interval = 1000;
            this.timerMinuterie.Tick += new System.EventHandler(this.TimerMinuterieTick);
            // 
            // groupBoxStatistiques
            // 
            this.groupBoxStatistiques.Controls.Add(this.labelHabAcreValue);
            this.groupBoxStatistiques.Controls.Add(this.labelHabParAcre);
            this.groupBoxStatistiques.Controls.Add(this.labelHabitantsValue);
            this.groupBoxStatistiques.Controls.Add(this.labelHabitants);
            this.groupBoxStatistiques.Controls.Add(this.labelRevenuMensuelValue);
            this.groupBoxStatistiques.Controls.Add(this.labelRevenuMensuel);
            this.groupBoxStatistiques.Controls.Add(this.labelRevenuHabValue);
            this.groupBoxStatistiques.Controls.Add(this.labelRevenuHab);
            this.groupBoxStatistiques.Controls.Add(this.labelBanqueValue);
            this.groupBoxStatistiques.Controls.Add(this.labelEnBanque);
            this.groupBoxStatistiques.Location = new System.Drawing.Point(1029, 256);
            this.groupBoxStatistiques.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxStatistiques.Name = "groupBoxStatistiques";
            this.groupBoxStatistiques.Size = new System.Drawing.Size(177, 356);
            this.groupBoxStatistiques.TabIndex = 2;
            this.groupBoxStatistiques.TabStop = false;
            this.groupBoxStatistiques.Text = "Statistiques";
            // 
            // labelHabAcreValue
            // 
            this.labelHabAcreValue.AutoSize = true;
            this.labelHabAcreValue.Location = new System.Drawing.Point(114, 185);
            this.labelHabAcreValue.Name = "labelHabAcreValue";
            this.labelHabAcreValue.Size = new System.Drawing.Size(43, 13);
            this.labelHabAcreValue.TabIndex = 9;
            this.labelHabAcreValue.Text = "000000";
            this.labelHabAcreValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHabParAcre
            // 
            this.labelHabParAcre.AutoSize = true;
            this.labelHabParAcre.Location = new System.Drawing.Point(6, 165);
            this.labelHabParAcre.Name = "labelHabParAcre";
            this.labelHabParAcre.Size = new System.Drawing.Size(91, 13);
            this.labelHabParAcre.TabIndex = 8;
            this.labelHabParAcre.Text = "Habitants / Acre: ";
            // 
            // labelHabitantsValue
            // 
            this.labelHabitantsValue.AutoSize = true;
            this.labelHabitantsValue.Location = new System.Drawing.Point(114, 145);
            this.labelHabitantsValue.Name = "labelHabitantsValue";
            this.labelHabitantsValue.Size = new System.Drawing.Size(43, 13);
            this.labelHabitantsValue.TabIndex = 7;
            this.labelHabitantsValue.Text = "000000";
            this.labelHabitantsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHabitants
            // 
            this.labelHabitants.AutoSize = true;
            this.labelHabitants.Location = new System.Drawing.Point(6, 130);
            this.labelHabitants.Name = "labelHabitants";
            this.labelHabitants.Size = new System.Drawing.Size(58, 13);
            this.labelHabitants.TabIndex = 6;
            this.labelHabitants.Text = "Habitants: ";
            // 
            // labelRevenuMensuelValue
            // 
            this.labelRevenuMensuelValue.AutoSize = true;
            this.labelRevenuMensuelValue.Location = new System.Drawing.Point(114, 110);
            this.labelRevenuMensuelValue.Name = "labelRevenuMensuelValue";
            this.labelRevenuMensuelValue.Size = new System.Drawing.Size(43, 13);
            this.labelRevenuMensuelValue.TabIndex = 5;
            this.labelRevenuMensuelValue.Text = "000000";
            this.labelRevenuMensuelValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRevenuMensuel
            // 
            this.labelRevenuMensuel.AutoSize = true;
            this.labelRevenuMensuel.Location = new System.Drawing.Point(6, 95);
            this.labelRevenuMensuel.Name = "labelRevenuMensuel";
            this.labelRevenuMensuel.Size = new System.Drawing.Size(77, 13);
            this.labelRevenuMensuel.TabIndex = 4;
            this.labelRevenuMensuel.Text = "Revenu/ mois:";
            // 
            // labelRevenuHabValue
            // 
            this.labelRevenuHabValue.AutoSize = true;
            this.labelRevenuHabValue.Location = new System.Drawing.Point(114, 75);
            this.labelRevenuHabValue.Name = "labelRevenuHabValue";
            this.labelRevenuHabValue.Size = new System.Drawing.Size(43, 13);
            this.labelRevenuHabValue.TabIndex = 3;
            this.labelRevenuHabValue.Text = "000000";
            this.labelRevenuHabValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRevenuHab
            // 
            this.labelRevenuHab.AutoSize = true;
            this.labelRevenuHab.Location = new System.Drawing.Point(6, 60);
            this.labelRevenuHab.Name = "labelRevenuHab";
            this.labelRevenuHab.Size = new System.Drawing.Size(131, 13);
            this.labelRevenuHab.TabIndex = 2;
            this.labelRevenuHab.Text = "Revenu moyen / habitant:";
            // 
            // labelBanqueValue
            // 
            this.labelBanqueValue.AutoSize = true;
            this.labelBanqueValue.Location = new System.Drawing.Point(114, 40);
            this.labelBanqueValue.Name = "labelBanqueValue";
            this.labelBanqueValue.Size = new System.Drawing.Size(43, 13);
            this.labelBanqueValue.TabIndex = 1;
            this.labelBanqueValue.Text = "000000";
            this.labelBanqueValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEnBanque
            // 
            this.labelEnBanque.AutoSize = true;
            this.labelEnBanque.Location = new System.Drawing.Point(6, 25);
            this.labelEnBanque.Name = "labelEnBanque";
            this.labelEnBanque.Size = new System.Drawing.Size(62, 13);
            this.labelEnBanque.TabIndex = 0;
            this.labelEnBanque.Text = "En banque:";
            // 
            // groupBoxParametres
            // 
            this.groupBoxParametres.Controls.Add(this.trackBarTaxes);
            this.groupBoxParametres.Controls.Add(this.labelTaxesValue);
            this.groupBoxParametres.Controls.Add(this.labelTaxes);
            this.groupBoxParametres.Controls.Add(this.trackBarGameSpeed);
            this.groupBoxParametres.Controls.Add(this.labelSecondesMois);
            this.groupBoxParametres.Controls.Add(this.labelSimulationSpeed);
            this.groupBoxParametres.Controls.Add(this.labelTauxSimulation);
            this.groupBoxParametres.Controls.Add(this.labelDateValue);
            this.groupBoxParametres.Controls.Add(this.labelDate);
            this.groupBoxParametres.Location = new System.Drawing.Point(1212, 12);
            this.groupBoxParametres.Name = "groupBoxParametres";
            this.groupBoxParametres.Size = new System.Drawing.Size(185, 600);
            this.groupBoxParametres.TabIndex = 3;
            this.groupBoxParametres.TabStop = false;
            this.groupBoxParametres.Text = "Paramètres";
            // 
            // trackBarTaxes
            // 
            this.trackBarTaxes.Location = new System.Drawing.Point(9, 237);
            this.trackBarTaxes.Maximum = 50;
            this.trackBarTaxes.Name = "trackBarTaxes";
            this.trackBarTaxes.Size = new System.Drawing.Size(170, 45);
            this.trackBarTaxes.TabIndex = 22;
            this.trackBarTaxes.Value = 1;
            this.trackBarTaxes.Scroll += new System.EventHandler(this.TrackBarTaxes_Scroll);
            // 
            // labelTaxesValue
            // 
            this.labelTaxesValue.AutoSize = true;
            this.labelTaxesValue.Location = new System.Drawing.Point(19, 214);
            this.labelTaxesValue.Name = "labelTaxesValue";
            this.labelTaxesValue.Size = new System.Drawing.Size(24, 13);
            this.labelTaxesValue.TabIndex = 21;
            this.labelTaxesValue.Text = "0 %";
            // 
            // labelTaxes
            // 
            this.labelTaxes.AutoSize = true;
            this.labelTaxes.Location = new System.Drawing.Point(6, 190);
            this.labelTaxes.Name = "labelTaxes";
            this.labelTaxes.Size = new System.Drawing.Size(77, 13);
            this.labelTaxes.TabIndex = 19;
            this.labelTaxes.Text = "Taux de taxes:";
            // 
            // trackBarGameSpeed
            // 
            this.trackBarGameSpeed.Location = new System.Drawing.Point(9, 142);
            this.trackBarGameSpeed.Maximum = 30;
            this.trackBarGameSpeed.Minimum = 1;
            this.trackBarGameSpeed.Name = "trackBarGameSpeed";
            this.trackBarGameSpeed.Size = new System.Drawing.Size(170, 45);
            this.trackBarGameSpeed.TabIndex = 18;
            this.trackBarGameSpeed.Value = 1;
            this.trackBarGameSpeed.Scroll += new System.EventHandler(this.TrackBarGameSpeedScroll);
            // 
            // labelSecondesMois
            // 
            this.labelSecondesMois.AutoSize = true;
            this.labelSecondesMois.Location = new System.Drawing.Point(39, 112);
            this.labelSecondesMois.Name = "labelSecondesMois";
            this.labelSecondesMois.Size = new System.Drawing.Size(97, 13);
            this.labelSecondesMois.TabIndex = 17;
            this.labelSecondesMois.Text = "Secondes = 1 mois";
            // 
            // labelSimulationSpeed
            // 
            this.labelSimulationSpeed.AutoSize = true;
            this.labelSimulationSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSimulationSpeed.Location = new System.Drawing.Point(19, 112);
            this.labelSimulationSpeed.Name = "labelSimulationSpeed";
            this.labelSimulationSpeed.Size = new System.Drawing.Size(14, 13);
            this.labelSimulationSpeed.TabIndex = 16;
            this.labelSimulationSpeed.Text = "1";
            // 
            // labelTauxSimulation
            // 
            this.labelTauxSimulation.AutoSize = true;
            this.labelTauxSimulation.Location = new System.Drawing.Point(6, 84);
            this.labelTauxSimulation.Name = "labelTauxSimulation";
            this.labelTauxSimulation.Size = new System.Drawing.Size(98, 13);
            this.labelTauxSimulation.TabIndex = 15;
            this.labelTauxSimulation.Text = "Taux de simulation:";
            // 
            // labelDateValue
            // 
            this.labelDateValue.AutoSize = true;
            this.labelDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateValue.Location = new System.Drawing.Point(19, 38);
            this.labelDateValue.Name = "labelDateValue";
            this.labelDateValue.Size = new System.Drawing.Size(70, 13);
            this.labelDateValue.TabIndex = 14;
            this.labelDateValue.Text = "3 juin 2048";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(6, 25);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 13;
            this.labelDate.Text = "Date";
            // 
            // buttonNouvellePartie
            // 
            this.buttonNouvellePartie.Location = new System.Drawing.Point(1035, 646);
            this.buttonNouvellePartie.Name = "buttonNouvellePartie";
            this.buttonNouvellePartie.Size = new System.Drawing.Size(91, 23);
            this.buttonNouvellePartie.TabIndex = 4;
            this.buttonNouvellePartie.Text = "Nouvelle Partie";
            this.buttonNouvellePartie.UseVisualStyleBackColor = true;
            this.buttonNouvellePartie.Click += new System.EventHandler(this.ButtonRegeneration_Click);
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(1273, 646);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.buttonEnregistrer.TabIndex = 5;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // buttonOuvrir
            // 
            this.buttonOuvrir.Location = new System.Drawing.Point(1273, 675);
            this.buttonOuvrir.Name = "buttonOuvrir";
            this.buttonOuvrir.Size = new System.Drawing.Size(75, 23);
            this.buttonOuvrir.TabIndex = 6;
            this.buttonOuvrir.Text = "Ouvrir";
            this.buttonOuvrir.UseVisualStyleBackColor = true;
            this.buttonOuvrir.Click += new System.EventHandler(this.buttonOuvrir_Click);
            // 
            // FormSimVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 741);
            this.Controls.Add(this.buttonOuvrir);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.buttonNouvellePartie);
            this.Controls.Add(this.groupBoxParametres);
            this.Controls.Add(this.groupBoxStatistiques);
            this.Controls.Add(this.groupBoxSelection);
            this.Controls.Add(this.groupBoxOutils);
            this.Controls.Add(this.tableLayoutPanelRegion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSimVille";
            this.Text = "Sim Ville";
            this.Load += new System.EventHandler(this.FormSimVille_Load);
            this.groupBoxOutils.ResumeLayout(false);
            this.groupBoxSelection.ResumeLayout(false);
            this.groupBoxSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectionPreview)).EndInit();
            this.groupBoxStatistiques.ResumeLayout(false);
            this.groupBoxStatistiques.PerformLayout();
            this.groupBoxParametres.ResumeLayout(false);
            this.groupBoxParametres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTaxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGameSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRegion;
        private System.Windows.Forms.GroupBox groupBoxOutils;
        private System.Windows.Forms.GroupBox groupBoxSelection;
        private System.Windows.Forms.Label labelSatisfaction;
        private System.Windows.Forms.ProgressBar progressBarSatisfaction;
        private System.Windows.Forms.Label labelCriminalite;
        private System.Windows.Forms.ProgressBar progressBarCriminalite;
        private System.Windows.Forms.Label labelSante;
        private System.Windows.Forms.ProgressBar progressBarSante;
        private System.Windows.Forms.Label labelLoisirs;
        private System.Windows.Forms.ProgressBar progressBarLoisirs;
        private System.Windows.Forms.Label labelColonneValue;
        private System.Windows.Forms.Label labelColonne;
        private System.Windows.Forms.PictureBox pictureBoxSelectionPreview;
        private System.Windows.Forms.Label labelLigneValue;
        private System.Windows.Forms.Label labelLigne;
        private System.Windows.Forms.Timer timerMinuterie;
        private System.Windows.Forms.GroupBox groupBoxStatistiques;
        private System.Windows.Forms.Label labelRevenuHabValue;
        private System.Windows.Forms.Label labelRevenuHab;
        private System.Windows.Forms.Label labelBanqueValue;
        private System.Windows.Forms.Label labelEnBanque;
        private System.Windows.Forms.Label labelRevenuMensuelValue;
        private System.Windows.Forms.Label labelRevenuMensuel;
        private System.Windows.Forms.ImageList imageListImages;
        private System.Windows.Forms.Label labelHabAcreValue;
        private System.Windows.Forms.Label labelHabParAcre;
        private System.Windows.Forms.Label labelHabitantsValue;
        private System.Windows.Forms.Label labelHabitants;
        private System.Windows.Forms.RadioButton radioButtonEnergie;
        private System.Windows.Forms.RadioButton radioButtonCommercial;
        private System.Windows.Forms.RadioButton radioButtonRésidentiel;
        private System.Windows.Forms.RadioButton radioButtonHopital;
        private System.Windows.Forms.RadioButton radioButtonPolice;
        private System.Windows.Forms.RadioButton radioButtonStatistiques;
        private System.Windows.Forms.RadioButton radioButtonStade;
        private System.Windows.Forms.GroupBox groupBoxParametres;
        private System.Windows.Forms.TrackBar trackBarGameSpeed;
        private System.Windows.Forms.Label labelSecondesMois;
        private System.Windows.Forms.Label labelSimulationSpeed;
        private System.Windows.Forms.Label labelTauxSimulation;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonNouvellePartie;
        private Label labelDateValue;
        private TrackBar trackBarTaxes;
        private Label labelTaxesValue;
        private Label labelTaxes;
        private Button buttonEnregistrer;
        private Button buttonOuvrir;
    }
}

