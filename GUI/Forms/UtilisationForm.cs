using Projet_4_etoiles.Business.Services;
using Projet_4_etoiles.DataAccess.Context;
using Projet_4_etoiles.DataAccess.DTO;
using Projet_4_etoiles.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_4_etoiles
{
    public partial class UtilisationForm : Form
    {

        private UtilisationDTO? currentSelectedUtilisation;
        private UtilisationDTO createdUtilisation;
        private UtilisationDTO workingUtilisation;
        private ProjectContext projectContext;
        public UtilisationForm()
        {
            InitializeComponent();
            this.projectContext = new ProjectContext();
            Init();
        }

        private void Init() {

            this.cbUtilisationList.DisplayMember = "NomReservation";
            this.cbUtilisationList.ValueMember = "IdUtilisation";
            this.LoadUtilisationSelector(MainService.GetInstance().GetUtilisationService().GetAllUtilisations());

        }

        public void OpenWindow()
        {
            ClearFields();
            DeactivateFields();
            this.DialogResult = DialogResult.None;
            this.ShowDialog();
        }

        private void cbUtilisationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.currentSelectedUtilisation = (UtilisationDTO)this.cbUtilisationList.Items[this.cbUtilisationList.SelectedIndex];
            this.LoadDetailsFields(this.currentSelectedUtilisation);
        }

        private void LoadDetailsFields(UtilisationDTO utilisation)
        {
            this.lblDisplayId.Text = utilisation.IdUtilisation.ToString();
            this.txtNombrePersonnes.Text = utilisation.NombreClients.ToString();
            this.cbNoTable.Text = utilisation.IdTable.ToString();
            this.txtNomReservation.Text = utilisation.NomReservation;
            this.txtNoTelephone.Text = utilisation.NumeroTelephone;
            this.dtpDateReservation.Value = utilisation.DateReservation;
            this.cbReservationHour.Text = utilisation.HeureReservation.ToString("HH:mm");
        }


        private void LoadUtilisationSelector(List<UtilisationDTO> utilisations)
        {
            this.cbUtilisationList.Items.Clear();
            foreach (UtilisationDTO utilisation in utilisations)
            {
                this.cbUtilisationList.Items.Add(utilisation);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
            ActivateFields();
            this.cbReservationHour.Focus();
            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnSave.Enabled = true;
            this.btnUpdate.Enabled = false;
            this.cbUtilisationList.Enabled = false;
        }

        private void ResetButtons()
        {

            this.btnAdd.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnUpdate.Enabled = true;
            this.btnSave.Enabled = false;
            this.btnConfirm.Enabled = false;
            this.cbUtilisationList.Enabled = true;

        }

        private void ClearFields() {
            this.lblDisplayId.Text = "";
            this.txtNombrePersonnes.Text = "";
            this.txtNomReservation.Text = "";
            this.txtNoTelephone.Text = "";
            this.dtpDateReservation.Value = DateTime.Now;
            this.cbNoTable.SelectedIndex = 0;
            this.cbReservationHour.SelectedIndex = 0;
            this.cbUtilisationList.Text = "";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string hourString = cbReservationHour.Text;
            DateTime dateTime = DateTime.ParseExact(hourString, "H:mm", null, System.Globalization.DateTimeStyles.None);
            this.createdUtilisation = MainService.GetInstance().GetUtilisationService().CreateUtilisation(
                int.Parse(this.txtNombrePersonnes.Text),
                int.Parse(this.cbNoTable.Text),
                this.dtpDateReservation.Value,
                dateTime,
                this.txtNomReservation.Text,
                this.txtNoTelephone.Text
                );
            this.cbUtilisationList.Items.Add(createdUtilisation);
            ClearFields();
            DeactivateFields();
            ResetButtons();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ActivateFields();
            this.cbReservationHour.Focus();
            this.cbUtilisationList.Enabled = false;
            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnConfirm.Enabled = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string hourString = cbReservationHour.Text;
            DateTime dateTime = DateTime.ParseExact(hourString, "H:mm", null, System.Globalization.DateTimeStyles.None);

            this.currentSelectedUtilisation.NombreClients = int.Parse(this.txtNombrePersonnes.Text);
            this.currentSelectedUtilisation.IdTable = int.Parse(this.cbNoTable.Text);
            this.currentSelectedUtilisation.DateReservation = this.dtpDateReservation.Value;
            this.currentSelectedUtilisation.HeureReservation = dateTime;
            this.currentSelectedUtilisation.NomReservation = this.txtNomReservation.Text;
            this.currentSelectedUtilisation.NumeroTelephone = this.txtNoTelephone.Text;

            this.currentSelectedUtilisation = MainService.GetInstance().GetUtilisationService().ModifyUtilisation(this.currentSelectedUtilisation);
            DeactivateFields();
            ResetButtons();
            this.LoadUtilisationSelector(MainService.GetInstance().GetUtilisationService().GetAllUtilisations());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.currentSelectedUtilisation is not null)
            {
                MainService.GetInstance().GetUtilisationService().DeleteUtilisation(this.currentSelectedUtilisation);
            }
            ClearFields();
            this.LoadUtilisationSelector(MainService.GetInstance().GetUtilisationService().GetAllUtilisations());
        }

        private void ActivateFields() 
        {
            this.txtNombrePersonnes.ReadOnly = false;
            this.cbNoTable.Enabled = true;
            this.dtpDateReservation.Enabled = true;
            this.txtNomReservation.ReadOnly = false;
            this.txtNoTelephone.ReadOnly = false;
        }

        private void DeactivateFields()
        {
            this.txtNombrePersonnes.ReadOnly = true;
            this.cbNoTable.Enabled = false;
            this.dtpDateReservation.Enabled = false;
            this.txtNomReservation.ReadOnly = true;
            this.txtNoTelephone.ReadOnly = true;
        }
    }
}
