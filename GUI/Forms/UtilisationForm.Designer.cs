namespace Projet_4_etoiles
{
    partial class UtilisationForm
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
            this.LblTablesUsed = new System.Windows.Forms.Label();
            this.lstTablesUsed = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDisplayId = new System.Windows.Forms.Label();
            this.grpChoice = new System.Windows.Forms.GroupBox();
            this.rbAssignation = new System.Windows.Forms.RadioButton();
            this.rbReservation = new System.Windows.Forms.RadioButton();
            this.lblAssignation = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblId_utilisation = new System.Windows.Forms.Label();
            this.txtNoTelephone = new System.Windows.Forms.TextBox();
            this.lblNoTelephone = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbNoTable = new System.Windows.Forms.ComboBox();
            this.lblNoTable = new System.Windows.Forms.Label();
            this.txtNombrePersonnes = new System.Windows.Forms.TextBox();
            this.lblNombrePersonnes = new System.Windows.Forms.Label();
            this.cbReservationHour = new System.Windows.Forms.ComboBox();
            this.txtNomReservation = new System.Windows.Forms.TextBox();
            this.calReservationDate = new System.Windows.Forms.MonthCalendar();
            this.lblReservationHour = new System.Windows.Forms.Label();
            this.lblReservationDate = new System.Windows.Forms.Label();
            this.lblNomReservation = new System.Windows.Forms.Label();
            this.LblReservation = new System.Windows.Forms.Label();
            this.grpChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTablesUsed
            // 
            this.LblTablesUsed.AutoSize = true;
            this.LblTablesUsed.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTablesUsed.Location = new System.Drawing.Point(610, 84);
            this.LblTablesUsed.Name = "LblTablesUsed";
            this.LblTablesUsed.Size = new System.Drawing.Size(162, 20);
            this.LblTablesUsed.TabIndex = 53;
            this.LblTablesUsed.Text = "Tables en utilisation";
            // 
            // lstTablesUsed
            // 
            this.lstTablesUsed.FormattingEnabled = true;
            this.lstTablesUsed.ItemHeight = 15;
            this.lstTablesUsed.Location = new System.Drawing.Point(583, 107);
            this.lstTablesUsed.Name = "lstTablesUsed";
            this.lstTablesUsed.Size = new System.Drawing.Size(216, 154);
            this.lstTablesUsed.TabIndex = 52;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(583, 441);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(216, 52);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblDisplayId
            // 
            this.lblDisplayId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplayId.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDisplayId.Location = new System.Drawing.Point(229, 137);
            this.lblDisplayId.Name = "lblDisplayId";
            this.lblDisplayId.Size = new System.Drawing.Size(226, 32);
            this.lblDisplayId.TabIndex = 50;
            // 
            // grpChoice
            // 
            this.grpChoice.Controls.Add(this.rbAssignation);
            this.grpChoice.Controls.Add(this.rbReservation);
            this.grpChoice.Location = new System.Drawing.Point(229, 93);
            this.grpChoice.Name = "grpChoice";
            this.grpChoice.Size = new System.Drawing.Size(226, 41);
            this.grpChoice.TabIndex = 49;
            this.grpChoice.TabStop = false;
            // 
            // rbAssignation
            // 
            this.rbAssignation.AutoSize = true;
            this.rbAssignation.Location = new System.Drawing.Point(206, 19);
            this.rbAssignation.Name = "rbAssignation";
            this.rbAssignation.Size = new System.Drawing.Size(14, 13);
            this.rbAssignation.TabIndex = 1;
            this.rbAssignation.TabStop = true;
            this.rbAssignation.UseVisualStyleBackColor = true;
            // 
            // rbReservation
            // 
            this.rbReservation.AutoSize = true;
            this.rbReservation.Location = new System.Drawing.Point(6, 19);
            this.rbReservation.Name = "rbReservation";
            this.rbReservation.Size = new System.Drawing.Size(14, 13);
            this.rbReservation.TabIndex = 0;
            this.rbReservation.TabStop = true;
            this.rbReservation.UseVisualStyleBackColor = true;
            // 
            // lblAssignation
            // 
            this.lblAssignation.AutoSize = true;
            this.lblAssignation.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAssignation.ForeColor = System.Drawing.Color.Red;
            this.lblAssignation.Location = new System.Drawing.Point(384, 62);
            this.lblAssignation.Name = "lblAssignation";
            this.lblAssignation.Size = new System.Drawing.Size(131, 28);
            this.lblAssignation.TabIndex = 48;
            this.lblAssignation.Text = "Assignation";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(328, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 28);
            this.lblTitle.TabIndex = 47;
            this.lblTitle.Text = "Utilisation des tables";
            // 
            // lblId_utilisation
            // 
            this.lblId_utilisation.AutoSize = true;
            this.lblId_utilisation.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblId_utilisation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblId_utilisation.Location = new System.Drawing.Point(107, 149);
            this.lblId_utilisation.Name = "lblId_utilisation";
            this.lblId_utilisation.Size = new System.Drawing.Size(109, 20);
            this.lblId_utilisation.TabIndex = 46;
            this.lblId_utilisation.Text = "ID_utilisation";
            // 
            // txtNoTelephone
            // 
            this.txtNoTelephone.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNoTelephone.Location = new System.Drawing.Point(229, 289);
            this.txtNoTelephone.Name = "txtNoTelephone";
            this.txtNoTelephone.Size = new System.Drawing.Size(226, 27);
            this.txtNoTelephone.TabIndex = 45;
            // 
            // lblNoTelephone
            // 
            this.lblNoTelephone.AutoSize = true;
            this.lblNoTelephone.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNoTelephone.ForeColor = System.Drawing.Color.Red;
            this.lblNoTelephone.Location = new System.Drawing.Point(42, 292);
            this.lblNoTelephone.Name = "lblNoTelephone";
            this.lblNoTelephone.Size = new System.Drawing.Size(174, 20);
            this.lblNoTelephone.TabIndex = 44;
            this.lblNoTelephone.Text = "Numéro de téléphone";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(583, 325);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(216, 52);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(583, 383);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(216, 52);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(583, 267);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(216, 52);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cbNoTable
            // 
            this.cbNoTable.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbNoTable.FormattingEnabled = true;
            this.cbNoTable.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbNoTable.Location = new System.Drawing.Point(308, 222);
            this.cbNoTable.Name = "cbNoTable";
            this.cbNoTable.Size = new System.Drawing.Size(66, 28);
            this.cbNoTable.TabIndex = 40;
            // 
            // lblNoTable
            // 
            this.lblNoTable.AutoSize = true;
            this.lblNoTable.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNoTable.Location = new System.Drawing.Point(80, 225);
            this.lblNoTable.Name = "lblNoTable";
            this.lblNoTable.Size = new System.Drawing.Size(137, 20);
            this.lblNoTable.TabIndex = 39;
            this.lblNoTable.Text = "Numéro de table";
            // 
            // txtNombrePersonnes
            // 
            this.txtNombrePersonnes.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombrePersonnes.Location = new System.Drawing.Point(229, 189);
            this.txtNombrePersonnes.Name = "txtNombrePersonnes";
            this.txtNombrePersonnes.Size = new System.Drawing.Size(227, 27);
            this.txtNombrePersonnes.TabIndex = 38;
            // 
            // lblNombrePersonnes
            // 
            this.lblNombrePersonnes.AutoSize = true;
            this.lblNombrePersonnes.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombrePersonnes.Location = new System.Drawing.Point(42, 192);
            this.lblNombrePersonnes.Name = "lblNombrePersonnes";
            this.lblNombrePersonnes.Size = new System.Drawing.Size(175, 20);
            this.lblNombrePersonnes.TabIndex = 37;
            this.lblNombrePersonnes.Text = "Nombre de personnes";
            // 
            // cbReservationHour
            // 
            this.cbReservationHour.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbReservationHour.FormattingEnabled = true;
            this.cbReservationHour.Items.AddRange(new object[] {
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:00",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00"});
            this.cbReservationHour.Location = new System.Drawing.Point(229, 503);
            this.cbReservationHour.Name = "cbReservationHour";
            this.cbReservationHour.Size = new System.Drawing.Size(221, 28);
            this.cbReservationHour.TabIndex = 36;
            // 
            // txtNomReservation
            // 
            this.txtNomReservation.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomReservation.Location = new System.Drawing.Point(228, 256);
            this.txtNomReservation.Name = "txtNomReservation";
            this.txtNomReservation.Size = new System.Drawing.Size(227, 27);
            this.txtNomReservation.TabIndex = 35;
            // 
            // calReservationDate
            // 
            this.calReservationDate.Location = new System.Drawing.Point(229, 328);
            this.calReservationDate.Name = "calReservationDate";
            this.calReservationDate.TabIndex = 34;
            // 
            // lblReservationHour
            // 
            this.lblReservationHour.AutoSize = true;
            this.lblReservationHour.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReservationHour.ForeColor = System.Drawing.Color.Red;
            this.lblReservationHour.Location = new System.Drawing.Point(30, 506);
            this.lblReservationHour.Name = "lblReservationHour";
            this.lblReservationHour.Size = new System.Drawing.Size(186, 20);
            this.lblReservationHour.TabIndex = 33;
            this.lblReservationHour.Text = "Heure de la réservation";
            // 
            // lblReservationDate
            // 
            this.lblReservationDate.AutoSize = true;
            this.lblReservationDate.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReservationDate.ForeColor = System.Drawing.Color.Red;
            this.lblReservationDate.Location = new System.Drawing.Point(39, 328);
            this.lblReservationDate.Name = "lblReservationDate";
            this.lblReservationDate.Size = new System.Drawing.Size(177, 20);
            this.lblReservationDate.TabIndex = 32;
            this.lblReservationDate.Text = "Date de la réservation";
            // 
            // lblNomReservation
            // 
            this.lblNomReservation.AutoSize = true;
            this.lblNomReservation.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomReservation.ForeColor = System.Drawing.Color.Red;
            this.lblNomReservation.Location = new System.Drawing.Point(36, 259);
            this.lblNomReservation.Name = "lblNomReservation";
            this.lblNomReservation.Size = new System.Drawing.Size(180, 20);
            this.lblNomReservation.TabIndex = 31;
            this.lblNomReservation.Text = "Nom sur la réservation";
            // 
            // LblReservation
            // 
            this.LblReservation.AutoSize = true;
            this.LblReservation.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblReservation.Location = new System.Drawing.Point(168, 62);
            this.LblReservation.Name = "LblReservation";
            this.LblReservation.Size = new System.Drawing.Size(131, 28);
            this.LblReservation.TabIndex = 30;
            this.LblReservation.Text = "Réservation";
            // 
            // UtilisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 564);
            this.Controls.Add(this.LblTablesUsed);
            this.Controls.Add(this.lstTablesUsed);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDisplayId);
            this.Controls.Add(this.grpChoice);
            this.Controls.Add(this.lblAssignation);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblId_utilisation);
            this.Controls.Add(this.txtNoTelephone);
            this.Controls.Add(this.lblNoTelephone);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbNoTable);
            this.Controls.Add(this.lblNoTable);
            this.Controls.Add(this.txtNombrePersonnes);
            this.Controls.Add(this.lblNombrePersonnes);
            this.Controls.Add(this.cbReservationHour);
            this.Controls.Add(this.txtNomReservation);
            this.Controls.Add(this.calReservationDate);
            this.Controls.Add(this.lblReservationHour);
            this.Controls.Add(this.lblReservationDate);
            this.Controls.Add(this.lblNomReservation);
            this.Controls.Add(this.LblReservation);
            this.Name = "UtilisationForm";
            this.Text = "UtilisationForm";
            this.grpChoice.ResumeLayout(false);
            this.grpChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblTablesUsed;
        private ListBox lstTablesUsed;
        private Button btnSave;
        private Label lblDisplayId;
        private GroupBox grpChoice;
        private RadioButton rbAssignation;
        private RadioButton rbReservation;
        private Label lblAssignation;
        private Label lblTitle;
        private Label lblId_utilisation;
        private TextBox txtNoTelephone;
        private Label lblNoTelephone;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnDelete;
        private ComboBox cbNoTable;
        private Label lblNoTable;
        private TextBox txtNombrePersonnes;
        private Label lblNombrePersonnes;
        private ComboBox cbReservationHour;
        private TextBox txtNomReservation;
        private MonthCalendar calReservationDate;
        private Label lblReservationHour;
        private Label lblReservationDate;
        private Label lblNomReservation;
        private Label LblReservation;
    }
}