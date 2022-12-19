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
            MessageBox.Show("Commande crée.");
            this.DialogResult = DialogResult.OK;
        }

        private void txtNbPersonnes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
