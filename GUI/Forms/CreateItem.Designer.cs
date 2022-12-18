namespace Projet_4_etoiles.GUI.Forms
{
    partial class CreateItem
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
            this.grboxManageItems = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txtPrixItem = new System.Windows.Forms.TextBox();
            this.lblNomItem = new System.Windows.Forms.Label();
            this.txtNomItem = new System.Windows.Forms.TextBox();
            this.btnItems = new System.Windows.Forms.Button();
            this.grboxManageItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // grboxManageItems
            // 
            this.grboxManageItems.Controls.Add(this.label1);
            this.grboxManageItems.Controls.Add(this.comboBoxCategorie);
            this.grboxManageItems.Controls.Add(this.lblPrix);
            this.grboxManageItems.Controls.Add(this.txtPrixItem);
            this.grboxManageItems.Controls.Add(this.lblNomItem);
            this.grboxManageItems.Controls.Add(this.txtNomItem);
            this.grboxManageItems.Controls.Add(this.btnItems);
            this.grboxManageItems.Location = new System.Drawing.Point(23, 12);
            this.grboxManageItems.Name = "grboxManageItems";
            this.grboxManageItems.Size = new System.Drawing.Size(299, 393);
            this.grboxManageItems.TabIndex = 14;
            this.grboxManageItems.TabStop = false;
            this.grboxManageItems.Text = "groupBoxItems";
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
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(116, 152);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(167, 33);
            this.comboBoxCategorie.TabIndex = 17;
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
            // txtPrixItem
            // 
            this.txtPrixItem.Location = new System.Drawing.Point(80, 103);
            this.txtPrixItem.Name = "txtPrixItem";
            this.txtPrixItem.PlaceholderText = "999.999$";
            this.txtPrixItem.Size = new System.Drawing.Size(203, 31);
            this.txtPrixItem.TabIndex = 15;
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
            // txtNomItem
            // 
            this.txtNomItem.Location = new System.Drawing.Point(80, 53);
            this.txtNomItem.Name = "txtNomItem";
            this.txtNomItem.PlaceholderText = "Item name";
            this.txtNomItem.Size = new System.Drawing.Size(203, 31);
            this.txtNomItem.TabIndex = 13;
            // 
            // btnItems
            // 
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnItems.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnItems.Location = new System.Drawing.Point(28, 229);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(225, 121);
            this.btnItems.TabIndex = 10;
            this.btnItems.Text = "creer";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // CreateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 418);
            this.Controls.Add(this.grboxManageItems);
            this.Name = "CreateItem";
            this.Text = "CreateItem";
            this.grboxManageItems.ResumeLayout(false);
            this.grboxManageItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grboxManageItems;
        private Label label1;
        private ComboBox comboBoxCategorie;
        private Label lblPrix;
        private TextBox txtPrixItem;
        private Label lblNomItem;
        private TextBox txtNomItem;
        private Button btnItems;
    }
}