using Projet_4_etoiles.Business.Services;
using Projet_4_etoiles.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_4_etoiles.GUI.Forms
{
    public partial class CreateCommandModal : Form
    {
        private CommandeDTO createdCommande;
        private TablesDTO tables;
        public CreateCommandModal()
        {
            InitializeComponent();
        }

        public void OpenModal() 
        {
            
            this.txtNbPersonnes.Text = null;
            this.DialogResult = DialogResult.None;
            this.ShowDialog();
        
        }


        public CommandeDTO GetCreatedCommande() 
        {
            return this.createdCommande;
        }

        private void btnCreerCommande_Click(object sender, EventArgs e)
        {
            this.createdCommande = MainService.GetInstance().GetCommandeService().CreateCommande(
                int.Parse(this.comboBoxTableNumber.Text),
                int.Parse(this.txtNbPersonnes.Text)

                );

            this.DialogResult = DialogResult.OK;
        }
    }
}
