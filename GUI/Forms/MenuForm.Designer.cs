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
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnShowId = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAjouter.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAjouter.ForeColor = System.Drawing.Color.Gold;
            this.btnAjouter.Location = new System.Drawing.Point(403, 430);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(194, 66);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter A La Commande";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnFermeture
            // 
            this.btnFermeture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFermeture.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFermeture.ForeColor = System.Drawing.Color.Gold;
            this.btnFermeture.Location = new System.Drawing.Point(625, 408);
            this.btnFermeture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFermeture.Name = "btnFermeture";
            this.btnFermeture.Size = new System.Drawing.Size(157, 88);
            this.btnFermeture.TabIndex = 5;
            this.btnFermeture.Text = "Fermer La Fenetre";
            this.btnFermeture.UseVisualStyleBackColor = false;
            this.btnFermeture.Click += new System.EventHandler(this.btnFermeture_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Pristina", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitre.Location = new System.Drawing.Point(218, 9);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(266, 49);
            this.lblTitre.TabIndex = 6;
            this.lblTitre.Text = "Menu Les 4 Étoiles";
            // 
            // lblPlats
            // 
            this.lblPlats.AutoSize = true;
            this.lblPlats.Font = new System.Drawing.Font("Pristina", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlats.Location = new System.Drawing.Point(16, 78);
            this.lblPlats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlats.Name = "lblPlats";
            this.lblPlats.Size = new System.Drawing.Size(187, 37);
            this.lblPlats.TabIndex = 7;
            this.lblPlats.Text = "Plats Principaux";
            // 
            // lblDessert
            // 
            this.lblDessert.AutoSize = true;
            this.lblDessert.Font = new System.Drawing.Font("Pristina", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDessert.Location = new System.Drawing.Point(266, 78);
            this.lblDessert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDessert.Name = "lblDessert";
            this.lblDessert.Size = new System.Drawing.Size(95, 37);
            this.lblDessert.TabIndex = 8;
            this.lblDessert.Text = "Desserts";
            // 
            // lblBreuvage
            // 
            this.lblBreuvage.AutoSize = true;
            this.lblBreuvage.Font = new System.Drawing.Font("Pristina", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBreuvage.Location = new System.Drawing.Point(418, 78);
            this.lblBreuvage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBreuvage.Name = "lblBreuvage";
            this.lblBreuvage.Size = new System.Drawing.Size(119, 37);
            this.lblBreuvage.TabIndex = 9;
            this.lblBreuvage.Text = "Breuvages";
            // 
            // liPlatPrincipaux
            // 
            this.liPlatPrincipaux.Location = new System.Drawing.Point(34, 121);
            this.liPlatPrincipaux.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.liPlatPrincipaux.Name = "liPlatPrincipaux";
            this.liPlatPrincipaux.Size = new System.Drawing.Size(169, 301);
            this.liPlatPrincipaux.TabIndex = 14;
            this.liPlatPrincipaux.UseCompatibleStateImageBehavior = false;
            this.liPlatPrincipaux.View = System.Windows.Forms.View.List;
            // 
            // liDesserts
            // 
            this.liDesserts.Location = new System.Drawing.Point(218, 121);
            this.liDesserts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.liDesserts.Name = "liDesserts";
            this.liDesserts.Size = new System.Drawing.Size(169, 301);
            this.liDesserts.TabIndex = 15;
            this.liDesserts.UseCompatibleStateImageBehavior = false;
            this.liDesserts.View = System.Windows.Forms.View.List;
            // 
            // liBreuvages
            // 
            this.liBreuvages.Location = new System.Drawing.Point(403, 121);
            this.liBreuvages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.liBreuvages.Name = "liBreuvages";
            this.liBreuvages.Size = new System.Drawing.Size(169, 301);
            this.liBreuvages.TabIndex = 16;
            this.liBreuvages.UseCompatibleStateImageBehavior = false;
            this.liBreuvages.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 449);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Commande ID:";
            // 
            // comboBoxCommandeId
            // 
            this.comboBoxCommandeId.FormattingEnabled = true;
            this.comboBoxCommandeId.Location = new System.Drawing.Point(155, 449);
            this.comboBoxCommandeId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCommandeId.Name = "comboBoxCommandeId";
            this.comboBoxCommandeId.Size = new System.Drawing.Size(144, 28);
            this.comboBoxCommandeId.TabIndex = 18;
            this.comboBoxCommandeId.SelectedIndexChanged += new System.EventHandler(this.comboBoxCommandeId_SelectedIndexChanged);
            // 
            // btnCreateItem
            // 
            this.btnCreateItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateItem.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateItem.ForeColor = System.Drawing.Color.Gold;
            this.btnCreateItem.Location = new System.Drawing.Point(625, 191);
            this.btnCreateItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Size = new System.Drawing.Size(141, 66);
            this.btnCreateItem.TabIndex = 19;
            this.btnCreateItem.Text = "Ajouter un item";
            this.btnCreateItem.UseVisualStyleBackColor = false;
            this.btnCreateItem.Click += new System.EventHandler(this.btnCreateItem_Click);
            // 
            // btnSupprimerItem
            // 
            this.btnSupprimerItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSupprimerItem.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSupprimerItem.ForeColor = System.Drawing.Color.Gold;
            this.btnSupprimerItem.Location = new System.Drawing.Point(624, 306);
            this.btnSupprimerItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupprimerItem.Name = "btnSupprimerItem";
            this.btnSupprimerItem.Size = new System.Drawing.Size(142, 66);
            this.btnSupprimerItem.TabIndex = 20;
            this.btnSupprimerItem.Text = "Supprimer Item";
            this.btnSupprimerItem.UseVisualStyleBackColor = false;
            this.btnSupprimerItem.Click += new System.EventHandler(this.btnSupprimerItem_Click);
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(155, 488);
            this.txtQuantite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(55, 27);
            this.txtQuantite.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 484);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "Quant:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(593, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "ID:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblID.Location = new System.Drawing.Point(640, 140);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(142, 31);
            this.lblID.TabIndex = 24;
            this.lblID.Text = "ID Placeholder";
            // 
            // btnShowId
            // 
            this.btnShowId.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowId.Location = new System.Drawing.Point(640, 73);
            this.btnShowId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowId.Name = "btnShowId";
            this.btnShowId.Size = new System.Drawing.Size(112, 46);
            this.btnShowId.TabIndex = 25;
            this.btnShowId.Text = "Show Id";
            this.btnShowId.UseVisualStyleBackColor = true;
            this.btnShowId.Click += new System.EventHandler(this.btnShowId_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(818, 608);
            this.Controls.Add(this.btnShowId);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantite);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private TextBox txtQuantite;
        private Label label2;
        private Label label3;
        private Label lblID;
        private Button btnShowId;
    }
}