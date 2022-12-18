namespace Projet_4_etoiles.GUI.Forms
{
    partial class MenuForm
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnFermeture = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblPlats = new System.Windows.Forms.Label();
            this.lblDessert = new System.Windows.Forms.Label();
            this.lblBreuvage = new System.Windows.Forms.Label();
            this.liPlatPrincipaux = new System.Windows.Forms.ListView();
            this.liDesserts = new System.Windows.Forms.ListView();
            this.liBreuvages = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCommandeId = new System.Windows.Forms.ComboBox();
            this.btnCreateItem = new System.Windows.Forms.Button();
            this.btnSupprimerItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAjouter.Location = new System.Drawing.Point(390, 531);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(242, 82);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter A La Commande";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnFermeture
            // 
            this.btnFermeture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFermeture.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFermeture.Location = new System.Drawing.Point(733, 541);
            this.btnFermeture.Name = "btnFermeture";
            this.btnFermeture.Size = new System.Drawing.Size(186, 72);
            this.btnFermeture.TabIndex = 5;
            this.btnFermeture.Text = "Fermer La Fenetre";
            this.btnFermeture.UseVisualStyleBackColor = true;
            this.btnFermeture.Click += new System.EventHandler(this.btnFermeture_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitre.Location = new System.Drawing.Point(588, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(331, 48);
            this.lblTitre.TabIndex = 6;
            this.lblTitre.Text = "Menu Les 4 Étoiles";
            // 
            // lblPlats
            // 
            this.lblPlats.AutoSize = true;
            this.lblPlats.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlats.Location = new System.Drawing.Point(52, 76);
            this.lblPlats.Name = "lblPlats";
            this.lblPlats.Size = new System.Drawing.Size(180, 30);
            this.lblPlats.TabIndex = 7;
            this.lblPlats.Text = "Plats Principaux";
            // 
            // lblDessert
            // 
            this.lblDessert.AutoSize = true;
            this.lblDessert.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDessert.Location = new System.Drawing.Point(333, 76);
            this.lblDessert.Name = "lblDessert";
            this.lblDessert.Size = new System.Drawing.Size(102, 30);
            this.lblDessert.TabIndex = 8;
            this.lblDessert.Text = "Desserts";
            // 
            // lblBreuvage
            // 
            this.lblBreuvage.AutoSize = true;
            this.lblBreuvage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBreuvage.Location = new System.Drawing.Point(554, 76);
            this.lblBreuvage.Name = "lblBreuvage";
            this.lblBreuvage.Size = new System.Drawing.Size(121, 30);
            this.lblBreuvage.TabIndex = 9;
            this.lblBreuvage.Text = "Breuvages";
            // 
            // liPlatPrincipaux
            // 
            this.liPlatPrincipaux.Location = new System.Drawing.Point(42, 130);
            this.liPlatPrincipaux.Name = "liPlatPrincipaux";
            this.liPlatPrincipaux.Size = new System.Drawing.Size(210, 375);
            this.liPlatPrincipaux.TabIndex = 14;
            this.liPlatPrincipaux.UseCompatibleStateImageBehavior = false;
            // 
            // liDesserts
            // 
            this.liDesserts.Location = new System.Drawing.Point(272, 130);
            this.liDesserts.Name = "liDesserts";
            this.liDesserts.Size = new System.Drawing.Size(210, 375);
            this.liDesserts.TabIndex = 15;
            this.liDesserts.UseCompatibleStateImageBehavior = false;
            // 
            // liBreuvages
            // 
            this.liBreuvages.Location = new System.Drawing.Point(504, 130);
            this.liBreuvages.Name = "liBreuvages";
            this.liBreuvages.Size = new System.Drawing.Size(210, 375);
            this.liBreuvages.TabIndex = 16;
            this.liBreuvages.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "CommandeID:";
            // 
            // comboBoxCommandeId
            // 
            this.comboBoxCommandeId.FormattingEnabled = true;
            this.comboBoxCommandeId.Location = new System.Drawing.Point(145, 531);
            this.comboBoxCommandeId.Name = "comboBoxCommandeId";
            this.comboBoxCommandeId.Size = new System.Drawing.Size(214, 33);
            this.comboBoxCommandeId.TabIndex = 18;
            this.comboBoxCommandeId.SelectedIndexChanged += new System.EventHandler(this.comboBoxCommandeId_SelectedIndexChanged);
            // 
            // btnCreateItem
            // 
            this.btnCreateItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateItem.Location = new System.Drawing.Point(741, 220);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Size = new System.Drawing.Size(176, 82);
            this.btnCreateItem.TabIndex = 19;
            this.btnCreateItem.Text = "Ajouter un item";
            this.btnCreateItem.UseVisualStyleBackColor = true;
            this.btnCreateItem.Click += new System.EventHandler(this.btnCreateItem_Click);
            // 
            // btnSupprimerItem
            // 
            this.btnSupprimerItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupprimerItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSupprimerItem.Location = new System.Drawing.Point(741, 340);
            this.btnSupprimerItem.Name = "btnSupprimerItem";
            this.btnSupprimerItem.Size = new System.Drawing.Size(177, 82);
            this.btnSupprimerItem.TabIndex = 20;
            this.btnSupprimerItem.Text = "Supprimer Item";
            this.btnSupprimerItem.UseVisualStyleBackColor = true;
            this.btnSupprimerItem.Click += new System.EventHandler(this.btnSupprimerItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 625);
            this.Controls.Add(this.btnSupprimerItem);
            this.Controls.Add(this.btnCreateItem);
            this.Controls.Add(this.comboBoxCommandeId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liBreuvages);
            this.Controls.Add(this.liDesserts);
            this.Controls.Add(this.liPlatPrincipaux);
            this.Controls.Add(this.lblBreuvage);
            this.Controls.Add(this.lblDessert);
            this.Controls.Add(this.lblPlats);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnFermeture);
            this.Controls.Add(this.btnAjouter);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAjouter;
        private Button btnFermeture;
        private Label lblTitre;
        private Label lblPlats;
        private Label lblDessert;
        private Label lblBreuvage;
        private ListView liPlatPrincipaux;
        private ListView liDesserts;
        private ListView liBreuvages;
        private Label label1;
        private ComboBox comboBoxCommandeId;
        private Button btnCreateItem;
        private Button btnSupprimerItem;
    }
}