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
        public MenuForm()
        {
            InitializeComponent();
            this.createNewItem = new CreateItem();
            this.Init();
        }

        private void Init()
        {
            this.comboBoxCommandeId.DisplayMember = "idCommande";
            this.comboBoxCommandeId.ValueMember = "IdCommande";
            //this.LoadCommandeSelector(MainService.GetInstance().GetCommandeService().get);
        }


        private void AddItemToListView(MenuDTO item)
        {
            ListViewItem lvItem = new(item.Name);
            lvItem.Tag = item.Id;

            if (item.Category == "Plat principaux")
            {
                this.liPlatPrincipaux.Items.Add(lvItem);
            }
            else if (item.Category == "Desserts")
            {
                this.liDesserts.Items.Add(lvItem);
            }
            else if (item.Category == "Breuvages")
            {
                this.liBreuvages.Items.Add(lvItem);
            }
            else { MessageBox.Show("Aucune categorie a ete choisi."); }

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

                if (createdItem.Category == "Plat principaux")
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

        public void ClearDetailsFields()
        {
            this.liPlatPrincipaux.Items.Clear();
            this.liDesserts.Items.Clear();
            this.liBreuvages.Items.Clear();
        }

        public void OpenMenuForm()
        {
            this.DialogResult = DialogResult.None;
            this.ShowDialog();
        }

        private void btnFermeture_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }

}
