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
            this.lblNumeroTable = new System.Windows.Forms.Label();
            this.groupBoxCommande = new System.Windows.Forms.GroupBox();
            this.listViewCommande = new System.Windows.Forms.ListView();
            this.colonneArticle = new System.Windows.Forms.ColumnHeader();
            this.btnAjouterArticle = new System.Windows.Forms.Button();
            this.btnSupprimerArticle = new System.Windows.Forms.Button();
            this.colonneQuantite = new System.Windows.Forms.ColumnHeader();
            this.btnModifierQuantite = new System.Windows.Forms.Button();
            this.btnSauvegarderModification = new System.Windows.Forms.Button();
            this.btnRetourMenu = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.btnPayer = new System.Windows.Forms.Button();
            this.groupBoxCommande.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTableCommande
            // 
            this.comboBoxTableCommande.FormattingEnabled = true;
            this.comboBoxTableCommande.Location = new System.Drawing.Point(84, 21);
            this.comboBoxTableCommande.Name = "comboBoxTableCommande";
            this.comboBoxTableCommande.Size = new System.Drawing.Size(151, 28);
            this.comboBoxTableCommande.TabIndex = 0;
            // 
            // lblNumeroTable
            // 
            this.lblNumeroTable.AutoSize = true;
            this.lblNumeroTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroTable.Location = new System.Drawing.Point(12, 24);
            this.lblNumeroTable.Name = "lblNumeroTable";
            this.lblNumeroTable.Size = new System.Drawing.Size(63, 20);
            this.lblNumeroTable.TabIndex = 1;
            this.lblNumeroTable.Text = "# Table:";
            // 
            // groupBoxCommande
            // 
            this.groupBoxCommande.Controls.Add(this.lblPrix);
            this.groupBoxCommande.Controls.Add(this.lblTotal);
            this.groupBoxCommande.Controls.Add(this.btnSauvegarderModification);
            this.groupBoxCommande.Controls.Add(this.btnModifierQuantite);
            this.groupBoxCommande.Controls.Add(this.listViewCommande);
            this.groupBoxCommande.Controls.Add(this.btnAjouterArticle);
            this.groupBoxCommande.Controls.Add(this.btnSupprimerArticle);
            this.groupBoxCommande.Location = new System.Drawing.Point(48, 55);
            this.groupBoxCommande.Name = "groupBoxCommande";
            this.groupBoxCommande.Size = new System.Drawing.Size(546, 480);
            this.groupBoxCommande.TabIndex = 3;
            this.groupBoxCommande.TabStop = false;
            this.groupBoxCommande.Text = "Commande";
            // 
            // listViewCommande
            // 
            this.listViewCommande.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listViewCommande.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colonneArticle,
            this.colonneQuantite});
            this.listViewCommande.Enabled = false;
            this.listViewCommande.Location = new System.Drawing.Point(21, 40);
            this.listViewCommande.Name = "listViewCommande";
            this.listViewCommande.Scrollable = false;
            this.listViewCommande.Size = new System.Drawing.Size(293, 397);
            this.listViewCommande.TabIndex = 3;
            this.listViewCommande.UseCompatibleStateImageBehavior = false;
            this.listViewCommande.View = System.Windows.Forms.View.Details;
            // 
            // colonneArticle
            // 
            this.colonneArticle.Text = "Article";
            this.colonneArticle.Width = 200;
            // 
            // btnAjouterArticle
            // 
            this.btnAjouterArticle.Location = new System.Drawing.Point(338, 104);
            this.btnAjouterArticle.Name = "btnAjouterArticle";
            this.btnAjouterArticle.Size = new System.Drawing.Size(178, 29);
            this.btnAjouterArticle.TabIndex = 2;
            this.btnAjouterArticle.Text = "Ajouter Articles";
            this.btnAjouterArticle.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerArticle
            // 
            this.btnSupprimerArticle.Enabled = false;
            this.btnSupprimerArticle.Location = new System.Drawing.Point(338, 56);
            this.btnSupprimerArticle.Name = "btnSupprimerArticle";
            this.btnSupprimerArticle.Size = new System.Drawing.Size(178, 29);
            this.btnSupprimerArticle.TabIndex = 1;
            this.btnSupprimerArticle.Text = "Supprimer Article";
            this.btnSupprimerArticle.UseVisualStyleBackColor = true;
            // 
            // colonneQuantite
            // 
            this.colonneQuantite.Text = "Quantité";
            this.colonneQuantite.Width = 100;
            // 
            // btnModifierQuantite
            // 
            this.btnModifierQuantite.Location = new System.Drawing.Point(338, 152);
            this.btnModifierQuantite.Name = "btnModifierQuantite";
            this.btnModifierQuantite.Size = new System.Drawing.Size(178, 29);
            this.btnModifierQuantite.TabIndex = 4;
            this.btnModifierQuantite.Text = "Modifier Quantité";
            this.btnModifierQuantite.UseVisualStyleBackColor = true;
            // 
            // btnSauvegarderModification
            // 
            this.btnSauvegarderModification.Enabled = false;
            this.btnSauvegarderModification.Location = new System.Drawing.Point(338, 199);
            this.btnSauvegarderModification.Name = "btnSauvegarderModification";
            this.btnSauvegarderModification.Size = new System.Drawing.Size(178, 50);
            this.btnSauvegarderModification.TabIndex = 5;
            this.btnSauvegarderModification.Text = "Sauvegarder les modifications";
            this.btnSauvegarderModification.UseVisualStyleBackColor = true;
            // 
            // btnRetourMenu
            // 
            this.btnRetourMenu.Enabled = false;
            this.btnRetourMenu.Location = new System.Drawing.Point(610, 207);
            this.btnRetourMenu.Name = "btnRetourMenu";
            this.btnRetourMenu.Size = new System.Drawing.Size(178, 50);
            this.btnRetourMenu.TabIndex = 6;
            this.btnRetourMenu.Text = "Retourner au menu principal";
            this.btnRetourMenu.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(338, 315);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 28);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total : ";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrix.Location = new System.Drawing.Point(420, 315);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(49, 28);
            this.lblPrix.TabIndex = 7;
            this.lblPrix.Text = "Prix";
            // 
            // btnPayer
            // 
            this.btnPayer.Location = new System.Drawing.Point(610, 277);
            this.btnPayer.Name = "btnPayer";
            this.btnPayer.Size = new System.Drawing.Size(178, 52);
            this.btnPayer.TabIndex = 7;
            this.btnPayer.Text = "Payer Facture";
            this.btnPayer.UseVisualStyleBackColor = true;
            // 
            // CommandesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.btnPayer);
            this.Controls.Add(this.btnRetourMenu);
            this.Controls.Add(this.groupBoxCommande);
            this.Controls.Add(this.lblNumeroTable);
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
        private Label lblNumeroTable;
        private GroupBox groupBoxCommande;
        private ListView listViewCommande;
        private ColumnHeader colonneArticle;
        private Button btnAjouterArticle;
        private Button btnSupprimerArticle;
        private ColumnHeader colonneQuantite;
        private Button btnSauvegarderModification;
        private Button btnModifierQuantite;
        private Button btnRetourMenu;
        private Label lblPrix;
        private Label lblTotal;
        private Button btnPayer;
    }
}