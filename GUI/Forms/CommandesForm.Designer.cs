namespace Projet_4_etoiles.GUI.Forms
{
    partial class CommandesForm
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
            this.comboBoxTableCommande = new System.Windows.Forms.ComboBox();
            this.lblNumeroCommande = new System.Windows.Forms.Label();
            this.groupBoxCommande = new System.Windows.Forms.GroupBox();
            this.lblNumeroTableValue = new System.Windows.Forms.Label();
            this.lblNumeroTable = new System.Windows.Forms.Label();
            this.lblNombreClientsValue = new System.Windows.Forms.Label();
            this.lblNombreClients = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSauvegarderModification = new System.Windows.Forms.Button();
            this.btnModifierQuantite = new System.Windows.Forms.Button();
            this.listViewCommande = new System.Windows.Forms.ListView();
            this.colonneArticle = new System.Windows.Forms.ColumnHeader();
            this.colonneQuantite = new System.Windows.Forms.ColumnHeader();
            this.btnAfficherMenu = new System.Windows.Forms.Button();
            this.btnSupprimerArticle = new System.Windows.Forms.Button();
            this.btnRetourMenu = new System.Windows.Forms.Button();
            this.btnCreateCommande = new System.Windows.Forms.Button();
            this.btnSupprimerCommande = new System.Windows.Forms.Button();
            this.groupBoxCommande.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTableCommande
            // 
            this.comboBoxTableCommande.FormattingEnabled = true;
            this.comboBoxTableCommande.Location = new System.Drawing.Point(160, 20);
            this.comboBoxTableCommande.Name = "comboBoxTableCommande";
            this.comboBoxTableCommande.Size = new System.Drawing.Size(61, 28);
            this.comboBoxTableCommande.TabIndex = 0;
            this.comboBoxTableCommande.SelectedIndexChanged += new System.EventHandler(this.comboBoxTableCommande_SelectedIndexChanged);
            // 
            // lblNumeroCommande
            // 
            this.lblNumeroCommande.AutoSize = true;
            this.lblNumeroCommande.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroCommande.Location = new System.Drawing.Point(48, 23);
            this.lblNumeroCommande.Name = "lblNumeroCommande";
            this.lblNumeroCommande.Size = new System.Drawing.Size(106, 20);
            this.lblNumeroCommande.TabIndex = 1;
            this.lblNumeroCommande.Text = "# Commande:";
            // 
            // groupBoxCommande
            // 
            this.groupBoxCommande.Controls.Add(this.lblNumeroTableValue);
            this.groupBoxCommande.Controls.Add(this.lblNumeroTable);
            this.groupBoxCommande.Controls.Add(this.lblNombreClientsValue);
            this.groupBoxCommande.Controls.Add(this.lblNombreClients);
            this.groupBoxCommande.Controls.Add(this.lblPrix);
            this.groupBoxCommande.Controls.Add(this.lblTotal);
            this.groupBoxCommande.Controls.Add(this.btnSauvegarderModification);
            this.groupBoxCommande.Controls.Add(this.btnModifierQuantite);
            this.groupBoxCommande.Controls.Add(this.listViewCommande);
            this.groupBoxCommande.Controls.Add(this.btnAfficherMenu);
            this.groupBoxCommande.Controls.Add(this.btnSupprimerArticle);
            this.groupBoxCommande.Location = new System.Drawing.Point(48, 55);
            this.groupBoxCommande.Name = "groupBoxCommande";
            this.groupBoxCommande.Size = new System.Drawing.Size(546, 480);
            this.groupBoxCommande.TabIndex = 3;
            this.groupBoxCommande.TabStop = false;
            this.groupBoxCommande.Text = "Commande";
            // 
            // lblNumeroTableValue
            // 
            this.lblNumeroTableValue.AutoSize = true;
            this.lblNumeroTableValue.Location = new System.Drawing.Point(443, 39);
            this.lblNumeroTableValue.Name = "lblNumeroTableValue";
            this.lblNumeroTableValue.Size = new System.Drawing.Size(88, 20);
            this.lblNumeroTableValue.TabIndex = 11;
            this.lblNumeroTableValue.Text = "placeholder";
            // 
            // lblNumeroTable
            // 
            this.lblNumeroTable.AutoSize = true;
            this.lblNumeroTable.Location = new System.Drawing.Point(313, 39);
            this.lblNumeroTable.Name = "lblNumeroTable";
            this.lblNumeroTable.Size = new System.Drawing.Size(125, 20);
            this.lblNumeroTable.TabIndex = 10;
            this.lblNumeroTable.Text = "Numero de table:";
            // 
            // lblNombreClientsValue
            // 
            this.lblNombreClientsValue.AutoSize = true;
            this.lblNombreClientsValue.Location = new System.Drawing.Point(165, 39);
            this.lblNombreClientsValue.Name = "lblNombreClientsValue";
            this.lblNombreClientsValue.Size = new System.Drawing.Size(88, 20);
            this.lblNombreClientsValue.TabIndex = 9;
            this.lblNombreClientsValue.Text = "placeholder";
            // 
            // lblNombreClients
            // 
            this.lblNombreClients.AutoSize = true;
            this.lblNombreClients.Location = new System.Drawing.Point(21, 39);
            this.lblNombreClients.Name = "lblNombreClients";
            this.lblNombreClients.Size = new System.Drawing.Size(138, 20);
            this.lblNombreClients.TabIndex = 8;
            this.lblNombreClients.Text = "Nombre de clients :";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrix.Location = new System.Drawing.Point(444, 369);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(49, 28);
            this.lblPrix.TabIndex = 7;
            this.lblPrix.Text = "Prix";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(362, 369);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 28);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total : ";
            // 
            // btnSauvegarderModification
            // 
            this.btnSauvegarderModification.Enabled = false;
            this.btnSauvegarderModification.Location = new System.Drawing.Point(345, 263);
            this.btnSauvegarderModification.Name = "btnSauvegarderModification";
            this.btnSauvegarderModification.Size = new System.Drawing.Size(178, 50);
            this.btnSauvegarderModification.TabIndex = 5;
            this.btnSauvegarderModification.Text = "Sauvegarder les modifications";
            this.btnSauvegarderModification.UseVisualStyleBackColor = true;
            // 
            // btnModifierQuantite
            // 
            this.btnModifierQuantite.Location = new System.Drawing.Point(345, 216);
            this.btnModifierQuantite.Name = "btnModifierQuantite";
            this.btnModifierQuantite.Size = new System.Drawing.Size(178, 29);
            this.btnModifierQuantite.TabIndex = 4;
            this.btnModifierQuantite.Text = "Modifier Quantité";
            this.btnModifierQuantite.UseVisualStyleBackColor = true;
            this.btnModifierQuantite.Click += new System.EventHandler(this.btnModifierQuantite_Click);
            // 
            // listViewCommande
            // 
            this.listViewCommande.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listViewCommande.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colonneArticle,
            this.colonneQuantite});
            this.listViewCommande.Location = new System.Drawing.Point(21, 79);
            this.listViewCommande.Name = "listViewCommande";
            this.listViewCommande.Scrollable = false;
            this.listViewCommande.Size = new System.Drawing.Size(293, 358);
            this.listViewCommande.TabIndex = 3;
            this.listViewCommande.UseCompatibleStateImageBehavior = false;
            this.listViewCommande.View = System.Windows.Forms.View.Details;
            this.listViewCommande.SelectedIndexChanged += new System.EventHandler(this.listViewCommande_SelectedIndexChanged);
            // 
            // colonneArticle
            // 
            this.colonneArticle.Text = "Article";
            this.colonneArticle.Width = 200;
            // 
            // colonneQuantite
            // 
            this.colonneQuantite.Text = "Quantité";
            this.colonneQuantite.Width = 100;
            // 
            // btnAfficherMenu
            // 
            this.btnAfficherMenu.Location = new System.Drawing.Point(345, 168);
            this.btnAfficherMenu.Name = "btnAfficherMenu";
            this.btnAfficherMenu.Size = new System.Drawing.Size(178, 29);
            this.btnAfficherMenu.TabIndex = 2;
            this.btnAfficherMenu.Text = "Afficher Menu";
            this.btnAfficherMenu.UseVisualStyleBackColor = true;
            this.btnAfficherMenu.Click += new System.EventHandler(this.btnAfficherMenu_Click);
            // 
            // btnSupprimerArticle
            // 
            this.btnSupprimerArticle.Enabled = false;
            this.btnSupprimerArticle.Location = new System.Drawing.Point(345, 120);
            this.btnSupprimerArticle.Name = "btnSupprimerArticle";
            this.btnSupprimerArticle.Size = new System.Drawing.Size(178, 29);
            this.btnSupprimerArticle.TabIndex = 1;
            this.btnSupprimerArticle.Text = "Supprimer Article";
            this.btnSupprimerArticle.UseVisualStyleBackColor = true;
            this.btnSupprimerArticle.Click += new System.EventHandler(this.btnSupprimerArticle_Click);
            // 
            // btnRetourMenu
            // 
            this.btnRetourMenu.Location = new System.Drawing.Point(610, 280);
            this.btnRetourMenu.Name = "btnRetourMenu";
            this.btnRetourMenu.Size = new System.Drawing.Size(178, 50);
            this.btnRetourMenu.TabIndex = 6;
            this.btnRetourMenu.Text = "Retourner au menu principal";
            this.btnRetourMenu.UseVisualStyleBackColor = true;
            this.btnRetourMenu.Click += new System.EventHandler(this.btnRetourMenu_Click);
            // 
            // btnCreateCommande
            // 
            this.btnCreateCommande.Location = new System.Drawing.Point(610, 202);
            this.btnCreateCommande.Name = "btnCreateCommande";
            this.btnCreateCommande.Size = new System.Drawing.Size(178, 50);
            this.btnCreateCommande.TabIndex = 8;
            this.btnCreateCommande.Text = "Creer une nouvelle commande";
            this.btnCreateCommande.UseVisualStyleBackColor = true;
            this.btnCreateCommande.Click += new System.EventHandler(this.btnCreateCommande_Click);
            // 
            // btnSupprimerCommande
            // 
            this.btnSupprimerCommande.Location = new System.Drawing.Point(610, 134);
            this.btnSupprimerCommande.Name = "btnSupprimerCommande";
            this.btnSupprimerCommande.Size = new System.Drawing.Size(178, 46);
            this.btnSupprimerCommande.TabIndex = 9;
            this.btnSupprimerCommande.Text = "Supprimer commande";
            this.btnSupprimerCommande.UseVisualStyleBackColor = true;
            this.btnSupprimerCommande.Click += new System.EventHandler(this.btnSupprimerCommande_Click);
            // 
            // CommandesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.btnSupprimerCommande);
            this.Controls.Add(this.btnCreateCommande);
            this.Controls.Add(this.btnRetourMenu);
            this.Controls.Add(this.groupBoxCommande);
            this.Controls.Add(this.lblNumeroCommande);
            this.Controls.Add(this.comboBoxTableCommande);
            this.Name = "CommandesForm";
            this.Text = "Commande";
            this.groupBoxCommande.ResumeLayout(false);
            this.groupBoxCommande.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxTableCommande;
        private Label lblNumeroCommande;
        private GroupBox groupBoxCommande;
        private ListView listViewCommande;
        private ColumnHeader colonneArticle;
        private Button btnAfficherMenu;
        private Button btnSupprimerArticle;
        private ColumnHeader colonneQuantite;
        private Button btnSauvegarderModification;
        private Button btnModifierQuantite;
        private Button btnRetourMenu;
        private Label lblPrix;
        private Label lblTotal;
        private Label lblNombreClientsValue;
        private Label lblNombreClients;
        private Label lblNumeroTableValue;
        private Label lblNumeroTable;
        private Button btnCreateCommande;
        private Button btnSupprimerCommande;
    }
}