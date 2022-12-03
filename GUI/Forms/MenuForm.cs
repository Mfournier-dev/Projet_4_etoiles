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
    public partial class MenuForm : Form
    {
        private MenuDTO workingMenu;
        private ViewIntent workingIntent;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            comboBoxCategorie.Items.Add("Plats Principaux");
            comboBoxCategorie.Items.Add("Breuvages");
            comboBoxCategorie.Items.Add("Desserts");
        }


        public MenuDTO OpenWithIntent(MenuDTO menu, ViewIntent intent)
        {
            this.workingMenu = menu;
            this.workingIntent = intent;

            switch (this.workingIntent)
            {
                case ViewIntent.CREATION:
                    return this.OpenForCreation();
                    break;

                case ViewIntent.MODIFICATION:
                    return this.OpenForModification();
                    break;

                case ViewIntent.DELETION:
                    return this.OpenForDeletion();
                    break;

                case ViewIntent.VISUALIZATION:
                default:
                    return this.OpenDisplay();
                    break;
            }
        }

        protected MenuDTO OpenForCreation()
        {
            this.lblID.Text = "";
            this.txtNomItem.Text = null;
            this.txtPrixItem.Text = null;
            this.comboBoxCategorie.Text = null;
            this.btnAjouter.Text = "Create";

            this.ShowDialog();
            return this.workingMenu;
        }

        protected MenuDTO OpenForModification()
        {
            this.lblID.Text = this.workingMenu.Id.ToString();
            this.txtNomItem.Text = this.workingMenu.Name;
            this.txtPrixItem.Text = this.workingMenu.Price.ToString();
            this.comboBoxCategorie.Text = this.workingMenu.Category;
            this.btnAjouter.Text = "Save Changes";

            this.ShowDialog();
            return this.workingMenu;

        }

        protected MenuDTO OpenDisplay()
        {
            this.lblID.Text = this.workingMenu.Id.ToString();
            this.txtNomItem.Text = this.workingMenu.Name;
            this.txtPrixItem.Text = this.workingMenu.Price.ToString();
            this.comboBoxCategorie.Text = this.workingMenu.Category;
            this.btnAjouter.Text = "Display";

            this.ShowDialog();
            return this.workingMenu;

        }

        protected MenuDTO OpenForDeletion()
        {
            this.txtNomItem.Enabled = false;
            this.txtPrixItem.Enabled = false;
            this.comboBoxCategorie.Enabled = false;

            this.lblID.Text = this.workingMenu.Id.ToString();
            this.txtNomItem.Text = this.workingMenu.Name;
            this.txtPrixItem.Text = this.workingMenu.Price.ToString();
            this.comboBoxCategorie.Text = this.workingMenu.Category;
            this.btnAjouter.Text = "Delete";

            this.ShowDialog();
            return this.workingMenu;

        }

        protected void TriggerDTOCreation()
        {
            // TODO: Validation
            this.workingMenu.Name = this.txtNomItem.Text;
            this.workingMenu.Category = this.comboBoxCategorie.SelectedValue.ToString();
            this.workingMenu.Price = int.Parse(this.txtPrixItem.Text);
            MainService.GetInstance().GetMenuService().CreateNewItem(this.workingMenu);

            this.DialogResult = DialogResult.OK;
        }

        protected void TriggerDTOModification()
        {
            // TODO: Validation
            this.workingMenu.Name = this.txtNomItem.Text;
            this.workingMenu.Category = this.comboBoxCategorie.SelectedValue.ToString();
            this.workingMenu.Price = int.Parse(this.txtPrixItem.Text);
            MainService.GetInstance().GetMenuService().ModifyItem(this.workingMenu);
            this.DialogResult = DialogResult.OK;
        }

        protected void TriggerDTODeletion()
        {
            // TODO: Validation
            this.workingMenu.Name = this.txtNomItem.Text;
            this.workingMenu.Category = this.comboBoxCategorie.SelectedValue.ToString();
            this.workingMenu.Price = int.Parse(this.txtPrixItem.Text);
            MainService.GetInstance().GetMenuService().DeleteNewItem(this.workingMenu);
            this.DialogResult = DialogResult.OK;
        }

        protected void CloseModalWindow()
        {
            this.DialogResult = DialogResult.OK;
        }


        private void btnItems_Click(object sender, EventArgs e)
        {
            switch (this.workingIntent)
            {
                case ViewIntent.CREATION:
                    this.TriggerDTOCreation();
                    break;

                case ViewIntent.MODIFICATION:
                    this.TriggerDTOModification();
                    break;

                case ViewIntent.DELETION:
                    this.TriggerDTODeletion();
                    break;

                case ViewIntent.VISUALIZATION:
                default:
                    this.CloseModalWindow();
                    break;
            }
        }
    }
}
