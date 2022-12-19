namespace Projet_4_etoiles
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAssignation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVoirCommandes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAssignation
            // 
            this.btnAssignation.BackColor = System.Drawing.Color.Gold;
            this.btnAssignation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAssignation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignation.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAssignation.ForeColor = System.Drawing.Color.Black;
            this.btnAssignation.Location = new System.Drawing.Point(545, 552);
            this.btnAssignation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAssignation.Name = "btnAssignation";
            this.btnAssignation.Size = new System.Drawing.Size(246, 60);
            this.btnAssignation.TabIndex = 0;
            this.btnAssignation.Text = "Réservation";
            this.btnAssignation.UseVisualStyleBackColor = false;
            this.btnAssignation.Click += new System.EventHandler(this.btnAssignation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(258, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenue a la page d\'accueil du restaurant ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Vivaldi", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(375, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 68);
            this.label2.TabIndex = 2;
            this.label2.Text = "4 Étoiles ";
            // 
            // btnVoirCommandes
            // 
            this.btnVoirCommandes.BackColor = System.Drawing.Color.Gold;
            this.btnVoirCommandes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoirCommandes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoirCommandes.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoirCommandes.ForeColor = System.Drawing.Color.Black;
            this.btnVoirCommandes.Location = new System.Drawing.Point(201, 552);
            this.btnVoirCommandes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoirCommandes.Name = "btnVoirCommandes";
            this.btnVoirCommandes.Size = new System.Drawing.Size(246, 60);
            this.btnVoirCommandes.TabIndex = 5;
            this.btnVoirCommandes.Text = "Voir les commandes";
            this.btnVoirCommandes.UseVisualStyleBackColor = false;
            this.btnVoirCommandes.Click += new System.EventHandler(this.btnVoirCommandes_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(964, 704);
            this.Controls.Add(this.btnVoirCommandes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAssignation);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "page d\'accueil ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAssignation;
        private Label label1;
        private Label label2;
        private Button btnVoirCommandes;
    }
}