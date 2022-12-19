namespace Projet_4_etoiles.GUI.Forms
{
    partial class CreateCommandModal
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
            this.lblSelectTable = new System.Windows.Forms.Label();
            this.lblNombrePersonnes = new System.Windows.Forms.Label();
            this.txtNbPersonnes = new System.Windows.Forms.TextBox();
            this.btnCreerCommande = new System.Windows.Forms.Button();
            this.comboBoxTableNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxTableNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectTable
            // 
            this.lblSelectTable.AutoSize = true;
            this.lblSelectTable.Location = new System.Drawing.Point(132, 83);
            this.lblSelectTable.Name = "lblSelectTable";
            this.lblSelectTable.Size = new System.Drawing.Size(94, 20);
            this.lblSelectTable.TabIndex = 0;
            this.lblSelectTable.Text = "Select table :";
            // 
            // lblNombrePersonnes
            // 
            this.lblNombrePersonnes.AutoSize = true;
            this.lblNombrePersonnes.Location = new System.Drawing.Point(80, 157);
            this.lblNombrePersonnes.Name = "lblNombrePersonnes";
            this.lblNombrePersonnes.Size = new System.Drawing.Size(146, 20);
            this.lblNombrePersonnes.TabIndex = 2;
            this.lblNombrePersonnes.Text = "Nombre personnes : ";
            // 
            // txtNbPersonnes
            // 
            this.txtNbPersonnes.Location = new System.Drawing.Point(232, 154);
            this.txtNbPersonnes.Name = "txtNbPersonnes";
            this.txtNbPersonnes.Size = new System.Drawing.Size(151, 27);
            this.txtNbPersonnes.TabIndex = 3;
            // 
            // btnCreerCommande
            // 
            this.btnCreerCommande.Location = new System.Drawing.Point(174, 241);
            this.btnCreerCommande.Name = "btnCreerCommande";
            this.btnCreerCommande.Size = new System.Drawing.Size(146, 55);
            this.btnCreerCommande.TabIndex = 4;
            this.btnCreerCommande.Text = "Creer Commande";
            this.btnCreerCommande.UseVisualStyleBackColor = true;
            this.btnCreerCommande.Click += new System.EventHandler(this.btnCreerCommande_Click);
            // 
            // comboBoxTableNumber
            // 
            this.comboBoxTableNumber.Location = new System.Drawing.Point(232, 81);
            this.comboBoxTableNumber.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.comboBoxTableNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.comboBoxTableNumber.Name = "comboBoxTableNumber";
            this.comboBoxTableNumber.Size = new System.Drawing.Size(150, 27);
            this.comboBoxTableNumber.TabIndex = 5;
            this.comboBoxTableNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CreateCommandModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 356);
            this.Controls.Add(this.comboBoxTableNumber);
            this.Controls.Add(this.btnCreerCommande);
            this.Controls.Add(this.txtNbPersonnes);
            this.Controls.Add(this.lblNombrePersonnes);
            this.Controls.Add(this.lblSelectTable);
            this.Name = "CreateCommandModal";
            this.Text = "CreateCommandModal";
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxTableNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSelectTable;
        private Label lblNombrePersonnes;
        private TextBox txtNbPersonnes;
        private Button btnCreerCommande;
        private NumericUpDown comboBoxTableNumber;
    }
}