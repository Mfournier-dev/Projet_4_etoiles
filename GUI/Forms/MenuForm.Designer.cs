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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnFermeture = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblPlats = new System.Windows.Forms.Label();
            this.lblDessert = new System.Windows.Forms.Label();
            this.lblBreuvage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(24, 129);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(243, 396);
            this.checkedListBox1.TabIndex = 0;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(326, 129);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(243, 396);
            this.checkedListBox2.TabIndex = 1;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Location = new System.Drawing.Point(626, 129);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(243, 396);
            this.checkedListBox3.TabIndex = 2;
            // 
            // btnAjouter
            // 
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAjouter.Location = new System.Drawing.Point(53, 546);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(354, 67);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter A La Commande";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnFermeture
            // 
            this.btnFermeture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFermeture.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFermeture.Location = new System.Drawing.Point(489, 546);
            this.btnFermeture.Name = "btnFermeture";
            this.btnFermeture.Size = new System.Drawing.Size(354, 67);
            this.btnFermeture.TabIndex = 5;
            this.btnFermeture.Text = "Fermer La Fenetre";
            this.btnFermeture.UseVisualStyleBackColor = true;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitre.Location = new System.Drawing.Point(288, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(331, 48);
            this.lblTitre.TabIndex = 6;
            this.lblTitre.Text = "Menu Les 4 Étoiles";
            // 
            // lblPlats
            // 
            this.lblPlats.AutoSize = true;
            this.lblPlats.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlats.Location = new System.Drawing.Point(53, 88);
            this.lblPlats.Name = "lblPlats";
            this.lblPlats.Size = new System.Drawing.Size(180, 30);
            this.lblPlats.TabIndex = 7;
            this.lblPlats.Text = "Plats Principaux";
            // 
            // lblDessert
            // 
            this.lblDessert.AutoSize = true;
            this.lblDessert.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDessert.Location = new System.Drawing.Point(390, 88);
            this.lblDessert.Name = "lblDessert";
            this.lblDessert.Size = new System.Drawing.Size(102, 30);
            this.lblDessert.TabIndex = 8;
            this.lblDessert.Text = "Desserts";
            // 
            // lblBreuvage
            // 
            this.lblBreuvage.AutoSize = true;
            this.lblBreuvage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBreuvage.Location = new System.Drawing.Point(686, 88);
            this.lblBreuvage.Name = "lblBreuvage";
            this.lblBreuvage.Size = new System.Drawing.Size(121, 30);
            this.lblBreuvage.TabIndex = 9;
            this.lblBreuvage.Text = "Breuvages";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 625);
            this.Controls.Add(this.lblBreuvage);
            this.Controls.Add(this.lblDessert);
            this.Controls.Add(this.lblPlats);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnFermeture);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.checkedListBox3);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox3;
        private Button btnAjouter;
        private Button btnFermeture;
        private Label lblTitre;
        private Label lblPlats;
        private Label lblDessert;
        private Label lblBreuvage;
    }
}