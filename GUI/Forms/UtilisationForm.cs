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

        private UtilisationDTO workingUtilisation;
        private ProjectContext projectContext;
        public UtilisationForm()
        {
            InitializeComponent();
            this.projectContext = new ProjectContext();
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

    }
}
