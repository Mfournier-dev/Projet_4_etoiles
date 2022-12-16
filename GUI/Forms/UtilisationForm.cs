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
            this.txtNombrePersonnes.Text = "";
            this.txtNomReservation.Text = "";
            this.txtNoTelephone.Text = "";
            this.dtpDateReservation.Value = DateTime.Now;
            this.cbNoTable.SelectedIndex = 0;
            this.cbReservationHour.SelectedIndex = 0;
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
            this.cbReservationHour.Text = utilisation.HeureReservation.ToString();

        }


        private void LoadUtilisationSelector(List<UtilisationDTO> utilisations)
        {
            this.cbUtilisationList.Items.Clear();
            foreach (UtilisationDTO utilisation in utilisations)
            {
                this.cbUtilisationList.Items.Add(utilisation);
            }

        }

    }
}
