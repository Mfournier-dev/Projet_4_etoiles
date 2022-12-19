using Microsoft.VisualBasic.Devices;
using Projet_4_etoiles.Business.Services;
using Projet_4_etoiles.DataAccess.Context;
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
    public partial class MenuForm : Form
    {
        private CommandeDTO? currentSelectedCommande;
        private MenuDTO? currentSelectedItem;
        private CreateItem createNewItem;
        private CommandeDTO commandeDTO;
        private CommandesArticlesDTO comArtDTO;
        private MenuDTO menuDTO;
        public MenuForm()
        {
            InitializeComponent();
            this.createNewItem = new CreateItem();
            this.Init();
        }

        private void Init()
        {
            this.comboBoxCommandeId.DisplayMember = "IdCommande";
            this.comboBoxCommandeId.ValueMember = "Id";
            this.LoadCommandeSelector(MainService.GetInstance().GetCommandeService().GetAllCommandes());
        }

        private void RemoveItemFromListView(MenuDTO item)
        {
            foreach (ListViewItem lvItem in this.liPlatPrincipaux.Items)
            {
                if (((int)lvItem.Tag) == item.Id)
                {
                    this.liPlatPrincipaux.Items.Remove(lvItem);
                }
            }
            foreach (ListViewItem lvItem in this.liDesserts.Items)
            {
                if (((int)lvItem.Tag) == item.Id)
                {
                    this.liDesserts.Items.Remove(lvItem);
                }
            }
            foreach (ListViewItem lvItem in this.liBreuvages.Items)
            {
                if (((int)lvItem.Tag) == item.Id)
                {
                    this.liBreuvages.Items.Remove(lvItem);
                }
            }

        }
        private void comboBoxCommandeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.currentSelectedCommande = (CommandeDTO) this.comboBoxCommandeId.Items[this.comboBoxCommandeId.SelectedIndex];
           
        }

        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            this.createNewItem.OpeenModal();
            if (this.createNewItem.DialogResult == DialogResult.OK)
            {
                MenuDTO createdItem = this.createNewItem.GetCreatedItem();

                if (createdItem.Category == "Plats principaux")
                {
                    this.liPlatPrincipaux.Items.Add(createdItem.Name);
                }
                else if (createdItem.Category == "Desserts")
                {
                    this.liDesserts.Items.Add(createdItem.Name);
                }
                else if (createdItem.Category == "Breuvages")
                {
                    this.liBreuvages.Items.Add(createdItem.Name);
                }
                else { MessageBox.Show("Aucune categorie a ete choisi."); }

                this.lblID.Text = createdItem.Id.ToString();
            }

        }

        private void btnSupprimerItem_Click(object sender, EventArgs e)
        {
            if (this.currentSelectedItem is not null)
            {
                MainService.GetInstance().GetMenuService().DeleteNewItem(this.currentSelectedItem);
            }
            this.ClearDetailsFields();
        }

        private void LoadCommandeSelector(List<CommandeDTO> commandes)
        {
            this.comboBoxCommandeId.Items.Clear();
            foreach (CommandeDTO commande in commandes)
            {
                this.comboBoxCommandeId.Items.Add(commande);
            }
        }
        private void btnShowId_Click(object sender, EventArgs e)
        {
            List<MenuDTO> items = MainService.GetInstance().GetMenuService().GetAll();
            foreach (MenuDTO item in items)
            {
                item.Equals(this.currentSelectedItem);
                this.lblID.Text = item.Id.ToString();
            }
        }
        public void ClearDetailsFields()
        {
            this.liPlatPrincipaux.Items.Clear();
            this.liDesserts.Items.Clear();
            this.liBreuvages.Items.Clear();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            this.comArtDTO = MainService.GetInstance().GetCommandesArticlesService().CreateNewCommandeArticleLink(
                (int)menuDTO.Id,
                int.Parse(this.comboBoxCommandeId.Text),
                int.Parse(this.txtQuantite.Text)
                );

            this.DialogResult = DialogResult.OK;
        }

        public void OpenMenuForm()
        {
            List<MenuDTO> items = MainService.GetInstance().GetMenuService().GetAll();
            foreach (MenuDTO item in items)
            {
                if (item.Category.Contains("Plats principaux"))
                {
                    this.liPlatPrincipaux.Items.Add(item.Name);
                }
                else if (item.Category.Contains("Desserts"))
                {
                    this.liDesserts.Items.Add(item.Name);
                }
                else
                {
                    this.liBreuvages.Items.Add(item.Name);
                }
            }
           
            this.DialogResult = DialogResult.None;
            this.ShowDialog();
        }

        private void btnFermeture_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        
    }

}
