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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDisplayId = new System.Windows.Forms.Label();
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
            this.lblReservationHour = new System.Windows.Forms.Label();
            this.lblReservationDate = new System.Windows.Forms.Label();
            this.lblNomReservation = new System.Windows.Forms.Label();
            this.cbUtilisationList = new System.Windows.Forms.ComboBox();
            this.dtpDateReservation = new System.Windows.Forms.DateTimePicker();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTablesUsed
            // 
            this.LblTablesUsed.AutoSize = true;
            this.LblTablesUsed.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTablesUsed.Location = new System.Drawing.Point(537, 147);
            this.LblTablesUsed.Name = "LblTablesUsed";
            this.LblTablesUsed.Size = new System.Drawing.Size(177, 31);
            this.LblTablesUsed.TabIndex = 53;
            this.LblTablesUsed.Text = "Liste des utilisations";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(561, 292);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 44);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDisplayId
            // 
            this.lblDisplayId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplayId.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDisplayId.Location = new System.Drawing.Point(251, 147);
            this.lblDisplayId.Name = "lblDisplayId";
            this.lblDisplayId.Size = new System.Drawing.Size(259, 42);
            this.lblDisplayId.TabIndex = 50;
            this.lblDisplayId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Pristina", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(375, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(397, 52);
            this.lblTitle.TabIndex = 47;
            this.lblTitle.Text = "Assignation && Réservations";
            // 
            // lblId_utilisation
            // 
            this.lblId_utilisation.AutoSize = true;
            this.lblId_utilisation.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblId_utilisation.ForeColor = System.Drawing.Color.Black;
            this.lblId_utilisation.Location = new System.Drawing.Point(113, 148);
            this.lblId_utilisation.Name = "lblId_utilisation";
            this.lblId_utilisation.Size = new System.Drawing.Size(134, 31);
            this.lblId_utilisation.TabIndex = 46;
            this.lblId_utilisation.Text = "ID_utilisation";
            // 
            // txtNoTelephone
            // 
            this.txtNoTelephone.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNoTelephone.Location = new System.Drawing.Point(253, 421);
            this.txtNoTelephone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoTelephone.Name = "txtNoTelephone";
            this.txtNoTelephone.Size = new System.Drawing.Size(258, 32);
            this.txtNoTelephone.TabIndex = 45;
            this.txtNoTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNoTelephone
            // 
            this.lblNoTelephone.AutoSize = true;
            this.lblNoTelephone.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNoTelephone.ForeColor = System.Drawing.Color.Black;
            this.lblNoTelephone.Location = new System.Drawing.Point(39, 425);
            this.lblNoTelephone.Name = "lblNoTelephone";
            this.lblNoTelephone.Size = new System.Drawing.Size(184, 31);
            this.lblNoTelephone.TabIndex = 44;
            this.lblNoTelephone.Text = "Numéro de téléphone";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(734, 240);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 44);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(561, 240);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 44);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Créer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(890, 263);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 44);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbNoTable
            // 
            this.cbNoTable.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbNoTable.FormattingEnabled = true;
            this.cbNoTable.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "12",
            "13",
            "14"});
            this.cbNoTable.Location = new System.Drawing.Point(342, 305);
            this.cbNoTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbNoTable.Name = "cbNoTable";
            this.cbNoTable.Size = new System.Drawing.Size(75, 34);
            this.cbNoTable.TabIndex = 40;
            // 
            // lblNoTable
            // 
            this.lblNoTable.AutoSize = true;
            this.lblNoTable.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNoTable.Location = new System.Drawing.Point(81, 309);
            this.lblNoTable.Name = "lblNoTable";
            this.lblNoTable.Size = new System.Drawing.Size(150, 31);
            this.lblNoTable.TabIndex = 39;
            this.lblNoTable.Text = "Numéro de table";
            // 
            // txtNombrePersonnes
            // 
            this.txtNombrePersonnes.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombrePersonnes.Location = new System.Drawing.Point(251, 476);
            this.txtNombrePersonnes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombrePersonnes.Name = "txtNombrePersonnes";
            this.txtNombrePersonnes.Size = new System.Drawing.Size(259, 32);
            this.txtNombrePersonnes.TabIndex = 38;
            this.txtNombrePersonnes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombrePersonnes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePersonnes_KeyPress);
            // 
            // lblNombrePersonnes
            // 
            this.lblNombrePersonnes.AutoSize = true;
            this.lblNombrePersonnes.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombrePersonnes.Location = new System.Drawing.Point(38, 480);
            this.lblNombrePersonnes.Name = "lblNombrePersonnes";
            this.lblNombrePersonnes.Size = new System.Drawing.Size(187, 31);
            this.lblNombrePersonnes.TabIndex = 37;
            this.lblNombrePersonnes.Text = "Nombre de personnes";
            // 
            // cbReservationHour
            // 
            this.cbReservationHour.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbReservationHour.FormattingEnabled = true;
            this.cbReservationHour.Items.AddRange(new object[] {
            "",
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
            this.cbReservationHour.Location = new System.Drawing.Point(253, 253);
            this.cbReservationHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbReservationHour.Name = "cbReservationHour";
            this.cbReservationHour.Size = new System.Drawing.Size(257, 34);
            this.cbReservationHour.TabIndex = 36;
            // 
            // txtNomReservation
            // 
            this.txtNomReservation.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomReservation.Location = new System.Drawing.Point(251, 367);
            this.txtNomReservation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomReservation.Name = "txtNomReservation";
            this.txtNomReservation.Size = new System.Drawing.Size(259, 32);
            this.txtNomReservation.TabIndex = 35;
            this.txtNomReservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomReservation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomReservation_KeyPress);
            // 
            // lblReservationHour
            // 
            this.lblReservationHour.AutoSize = true;
            this.lblReservationHour.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReservationHour.ForeColor = System.Drawing.Color.Black;
            this.lblReservationHour.Location = new System.Drawing.Point(25, 257);
            this.lblReservationHour.Name = "lblReservationHour";
            this.lblReservationHour.Size = new System.Drawing.Size(203, 31);
            this.lblReservationHour.TabIndex = 33;
            this.lblReservationHour.Text = "Heure de la réservation";
            // 
            // lblReservationDate
            // 
            this.lblReservationDate.AutoSize = true;
            this.lblReservationDate.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReservationDate.ForeColor = System.Drawing.Color.Black;
            this.lblReservationDate.Location = new System.Drawing.Point(35, 203);
            this.lblReservationDate.Name = "lblReservationDate";
            this.lblReservationDate.Size = new System.Drawing.Size(192, 31);
            this.lblReservationDate.TabIndex = 32;
            this.lblReservationDate.Text = "Date de la réservation";
            // 
            // lblNomReservation
            // 
            this.lblNomReservation.AutoSize = true;
            this.lblNomReservation.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomReservation.ForeColor = System.Drawing.Color.Black;
            this.lblNomReservation.Location = new System.Drawing.Point(32, 371);
            this.lblNomReservation.Name = "lblNomReservation";
            this.lblNomReservation.Size = new System.Drawing.Size(202, 31);
            this.lblNomReservation.TabIndex = 31;
            this.lblNomReservation.Text = "Nom sur la réservation";
            // 
            // cbUtilisationList
            // 
            this.cbUtilisationList.FormattingEnabled = true;
            this.cbUtilisationList.Location = new System.Drawing.Point(734, 147);
            this.cbUtilisationList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbUtilisationList.Name = "cbUtilisationList";
            this.cbUtilisationList.Size = new System.Drawing.Size(315, 28);
            this.cbUtilisationList.TabIndex = 54;
            this.cbUtilisationList.SelectedIndexChanged += new System.EventHandler(this.cbUtilisationList_SelectedIndexChanged);
            // 
            // dtpDateReservation
            // 
            this.dtpDateReservation.Location = new System.Drawing.Point(253, 203);
            this.dtpDateReservation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateReservation.Name = "dtpDateReservation";
            this.dtpDateReservation.Size = new System.Drawing.Size(258, 27);
            this.dtpDateReservation.TabIndex = 55;
            this.dtpDateReservation.ValueChanged += new System.EventHandler(this.dtpDateReservation_ValueChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.Location = new System.Drawing.Point(734, 295);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(134, 44);
            this.btnConfirm.TabIndex = 56;
            this.btnConfirm.Text = "Confirmer";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // UtilisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1093, 551);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dtpDateReservation);
            this.Controls.Add(this.cbUtilisationList);
            this.Controls.Add(this.LblTablesUsed);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDisplayId);
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
            this.Controls.Add(this.lblReservationHour);
            this.Controls.Add(this.lblReservationDate);
            this.Controls.Add(this.lblNomReservation);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UtilisationForm";
            this.Text = "UtilisationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblTablesUsed;
        private Button btnSave;
        private Label lblDisplayId;
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
        private Label lblReservationHour;
        private Label lblReservationDate;
        private Label lblNomReservation;
        private ComboBox cbUtilisationList;
        private DateTimePicker dtpDateReservation;
        private Button btnConfirm;
    }
}