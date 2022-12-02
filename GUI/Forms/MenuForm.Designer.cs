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
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnFermeture = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblPlats = new System.Windows.Forms.Label();
            this.lblDessert = new System.Windows.Forms.Label();
            this.lblBreuvage = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnCreateItem = new System.Windows.Forms.Button();
            this.btnModifierItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.grboxManageItems = new System.Windows.Forms.GroupBox();
            this.txtNomItem = new System.Windows.Forms.TextBox();
            this.lblNomItem = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lableId = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.grboxManageItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(320, 109);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(243, 396);
            this.checkedListBox2.TabIndex = 1;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Location = new System.Drawing.Point(626, 109);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(243, 396);
            this.checkedListBox3.TabIndex = 2;
            // 
            // btnAjouter
            // 
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAjouter.Location = new System.Drawing.Point(245, 531);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(407, 82);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter A La Commande";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnFermeture
            // 
            this.btnFermeture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFermeture.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFermeture.Location = new System.Drawing.Point(913, 531);
            this.btnFermeture.Name = "btnFermeture";
            this.btnFermeture.Size = new System.Drawing.Size(299, 82);
            this.btnFermeture.TabIndex = 5;
            this.btnFermeture.Text = "Fermer La Fenetre";
            this.btnFermeture.UseVisualStyleBackColor = true;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitre.Location = new System.Drawing.Point(443, 9);
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
            this.lblDessert.Location = new System.Drawing.Point(390, 76);
            this.lblDessert.Name = "lblDessert";
            this.lblDessert.Size = new System.Drawing.Size(102, 30);
            this.lblDessert.TabIndex = 8;
            this.lblDessert.Text = "Desserts";
            // 
            // lblBreuvage
            // 
            this.lblBreuvage.AutoSize = true;
            this.lblBreuvage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBreuvage.Location = new System.Drawing.Point(686, 76);
            this.lblBreuvage.Name = "lblBreuvage";
            this.lblBreuvage.Size = new System.Drawing.Size(121, 30);
            this.lblBreuvage.TabIndex = 9;
            this.lblBreuvage.Text = "Breuvages";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(24, 109);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(243, 396);
            this.checkedListBox1.TabIndex = 0;
            // 
            // btnCreateItem
            // 
            this.btnCreateItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateItem.Location = new System.Drawing.Point(59, 277);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Size = new System.Drawing.Size(178, 42);
            this.btnCreateItem.TabIndex = 10;
            this.btnCreateItem.Text = "Creer";
            this.btnCreateItem.UseVisualStyleBackColor = true;
            // 
            // btnModifierItem
            // 
            this.btnModifierItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifierItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModifierItem.Location = new System.Drawing.Point(59, 325);
            this.btnModifierItem.Name = "btnModifierItem";
            this.btnModifierItem.Size = new System.Drawing.Size(178, 42);
            this.btnModifierItem.TabIndex = 11;
            this.btnModifierItem.Text = "Modifier";
            this.btnModifierItem.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteItem.Location = new System.Drawing.Point(59, 373);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(178, 42);
            this.btnDeleteItem.TabIndex = 12;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // grboxManageItems
            // 
            this.grboxManageItems.Controls.Add(this.lblID);
            this.grboxManageItems.Controls.Add(this.lableId);
            this.grboxManageItems.Controls.Add(this.label1);
            this.grboxManageItems.Controls.Add(this.comboBoxCategorie);
            this.grboxManageItems.Controls.Add(this.lblPrix);
            this.grboxManageItems.Controls.Add(this.textBox1);
            this.grboxManageItems.Controls.Add(this.lblNomItem);
            this.grboxManageItems.Controls.Add(this.txtNomItem);
            this.grboxManageItems.Controls.Add(this.btnCreateItem);
            this.grboxManageItems.Controls.Add(this.btnDeleteItem);
            this.grboxManageItems.Controls.Add(this.btnModifierItem);
            this.grboxManageItems.Location = new System.Drawing.Point(913, 76);
            this.grboxManageItems.Name = "grboxManageItems";
            this.grboxManageItems.Size = new System.Drawing.Size(299, 429);
            this.grboxManageItems.TabIndex = 13;
            this.grboxManageItems.TabStop = false;
            this.grboxManageItems.Text = "groupBox1";
            // 
            // txtNomItem
            // 
            this.txtNomItem.Location = new System.Drawing.Point(80, 53);
            this.txtNomItem.Name = "txtNomItem";
            this.txtNomItem.Size = new System.Drawing.Size(203, 31);
            this.txtNomItem.TabIndex = 13;
            // 
            // lblNomItem
            // 
            this.lblNomItem.AutoSize = true;
            this.lblNomItem.Location = new System.Drawing.Point(18, 53);
            this.lblNomItem.Name = "lblNomItem";
            this.lblNomItem.Size = new System.Drawing.Size(56, 25);
            this.lblNomItem.TabIndex = 14;
            this.lblNomItem.Text = "Nom:";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(18, 106);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(44, 25);
            this.lblPrix.TabIndex = 16;
            this.lblPrix.Text = "Prix:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 31);
            this.textBox1.TabIndex = 15;
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(116, 152);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(167, 33);
            this.comboBoxCategorie.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Categorie:";
            // 
            // lableId
            // 
            this.lableId.AutoSize = true;
            this.lableId.Location = new System.Drawing.Point(30, 233);
            this.lableId.Name = "lableId";
            this.lableId.Size = new System.Drawing.Size(34, 25);
            this.lableId.TabIndex = 19;
            this.lableId.Text = "ID:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(80, 233);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(106, 25);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "PlaceHolder";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 625);
            this.Controls.Add(this.grboxManageItems);
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
            this.grboxManageItems.ResumeLayout(false);
            this.grboxManageItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox3;
        private Button btnAjouter;
        private Button btnFermeture;
        private Label lblTitre;
        private Label lblPlats;
        private Label lblDessert;
        private Label lblBreuvage;
        private CheckedListBox checkedListBox1;
        private Button btnCreateItem;
        private Button btnModifierItem;
        private Button btnDeleteItem;
        private GroupBox grboxManageItems;
        private Label lblPrix;
        private TextBox textBox1;
        private Label lblNomItem;
        private TextBox txtNomItem;
        private Label lblID;
        private Label lableId;
        private Label label1;
        private ComboBox comboBoxCategorie;
    }
}