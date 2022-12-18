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
    public partial class CreateItem : Form
    {
        private MenuDTO createdItem;
        MenuDTO item;
        public CreateItem()
        {
            InitializeComponent();
        }
        private void CreateItem_Load(object sender, EventArgs e)
        {
            
        }
        public void OpeenModal()
        {
            this.txtNomItem.Text = null;
            this.txtPrixItem.Text = null;
            comboBoxCategorie.Items.Add("Plats principaux");
            comboBoxCategorie.Items.Add("Desserts");
            comboBoxCategorie.Items.Add("Breuvages");
            this.DialogResult = DialogResult.None;
            this.ShowDialog();
        }
        public MenuDTO GetCreatedItem()
        {
            return this.createdItem;
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            this.createdItem = MainService.GetInstance().GetMenuService().CreateNewItem(
                this.txtNomItem.Text,
                this.comboBoxCategorie.Text,
                Convert.ToDecimal(this.txtPrixItem.Text)
                );

            this.DialogResult = DialogResult.OK;
        }

    }
}
