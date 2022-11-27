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
            this.SuspendLayout();
            // 
            // btnAssignation
            // 
            this.btnAssignation.Location = new System.Drawing.Point(988, 278);
            this.btnAssignation.Name = "btnAssignation";
            this.btnAssignation.Size = new System.Drawing.Size(134, 35);
            this.btnAssignation.TabIndex = 0;
            this.btnAssignation.Text = "Réservation";
            this.btnAssignation.UseVisualStyleBackColor = true;
            this.btnAssignation.Click += new System.EventHandler(this.btnAssignation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 549);
            this.Controls.Add(this.btnAssignation);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAssignation;
    }
}