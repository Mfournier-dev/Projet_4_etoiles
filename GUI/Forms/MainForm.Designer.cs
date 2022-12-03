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
            this.btnAssignation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAssignation
            // 
            this.btnAssignation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAssignation.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAssignation.Location = new System.Drawing.Point(375, 435);
            this.btnAssignation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAssignation.Name = "btnAssignation";
            this.btnAssignation.Size = new System.Drawing.Size(232, 89);
            this.btnAssignation.TabIndex = 0;
            this.btnAssignation.Text = "Réservation";
            this.btnAssignation.UseVisualStyleBackColor = true;
            this.btnAssignation.Click += new System.EventHandler(this.btnAssignation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(150, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenue a la page d\'accueil du restaurant ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(339, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 65);
            this.label2.TabIndex = 2;
            this.label2.Text = "4 Étoiles ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(389, 319);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 65);
            this.label3.TabIndex = 3;
            this.label3.Text = "* * * *  ";
            // 
            // btnOpenMenu
            // 
            this.btnOpenMenu.Location = new System.Drawing.Point(62, 34);
            this.btnOpenMenu.Name = "btnOpenMenu";
            this.btnOpenMenu.Size = new System.Drawing.Size(171, 62);
            this.btnOpenMenu.TabIndex = 4;
            this.btnOpenMenu.Text = "Open MenuForm";
            this.btnOpenMenu.UseVisualStyleBackColor = true;
            this.btnOpenMenu.Click += new System.EventHandler(this.btnOpenMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 704);
            this.Controls.Add(this.btnOpenMenu);
            this.Controls.Add(this.label3);
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
        private Label label3;
        private Button btnOpenMenu;
    }
}