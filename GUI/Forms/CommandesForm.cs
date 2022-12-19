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
    
    
    public partial class CommandesForm : Form
    {
        private CommandeDTO? currentSelectedCommande;
        private MenuDTO selectedArticle;
        private ProjectContext projectContext;
        private MenuForm menuForm;
        private CreateCommandModal createCommandModal;
        public CommandesForm()
        {
            InitializeComponent();
            this.projectContext = new ProjectContext();
            this.menuForm = new MenuForm();
            this.createCommandModal = new CreateCommandModal();
            Init();
        }

        public void Init() 
        {
            this.comboBoxTableCommande.DisplayMember ="IdCommande";
            this.comboBoxTableCommande.ValueMember = "IdCommande";
            this.LoadCommandeSelector(MainService.GetInstance().GetCommandeService().GetAllCommandes());
        
        }

        public void OpenCommandeWindow() 
        {
            this.lblPrix.Text = "$";
            this.lblNombreClientsValue.Text = "";
            this.lblNumeroTableValue.Text = "";
            this.listViewCommande.Items.Clear();
            this.DialogResult = DialogResult.None;
            this.ShowDialog();
        
        }

        private void LoadCommandeSelector(List<CommandeDTO> commandes) 
        {
            this.comboBoxTableCommande.Items.Clear();
            foreach(CommandeDTO commande in commandes) 
            { 
                this.comboBoxTableCommande.Items.Add(commande);
            }
        
        }

        private void LoadCommandeFields(CommandeDTO commande) 
        {
            
            this.lblNombreClientsValue.Text = commande.NombreClients.ToString();
            this.lblNumeroTableValue.Text = commande.IdTable.ToString();
            List<MenuDTO> articles = MainService.GetInstance().GetCommandesArticlesService().GetAllArticlesForCommande(commande.IdCommande);
            foreach(MenuDTO article in articles) 
            { 
            
                this.AddArticleToListView(article);
                this.lblPrix.Text += article.Price.ToString();
            }
            
        
        }

        private void AddArticleToListView(MenuDTO article) 
        {
            ListViewItem lvItem = new ListViewItem(article.Name);
            lvItem.Tag = article.Id;
            this.listViewCommande.Items.Add(lvItem);
        
        }

        

        private void btnRetourMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void comboBoxTableCommande_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listViewCommande.Items.Clear();
            this.currentSelectedCommande = (CommandeDTO)this.comboBoxTableCommande.Items[this.comboBoxTableCommande.SelectedIndex];
            this.LoadCommandeFields(this.currentSelectedCommande);
        }

        private void btnSupprimerArticle_Click(object sender, EventArgs e)
        {

            if (this.currentSelectedCommande is not null) 
            {
                
                List<MenuDTO> articlesInCommande = MainService.GetInstance().GetCommandesArticlesService().GetAllArticlesForCommande(this.currentSelectedCommande.IdCommande);
                MenuDTO selectedArticle = this.GetSelectedArticle();
                MainService.GetInstance().GetCommandesArticlesService().DeleteCommandeArticleLink(this.currentSelectedCommande.IdCommande, selectedArticle.Id);
                this.RemoveArticleFromListView(selectedArticle);
            }
        }

        public MenuDTO GetSelectedArticle() 
        {
            return this.selectedArticle;
        }

        private void RemoveArticleFromListView(MenuDTO article) 
        { 
            foreach(ListViewItem lvItem in this.listViewCommande.Items) 
            { 
                if(((int)lvItem.Tag) == article.Id) 
                {
                    this.listViewCommande.Items.Remove(lvItem);
                }
            
            } 
        }

        private void listViewCommande_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSupprimerArticle.Enabled = true;
        }

        private void btnAfficherMenu_Click(object sender, EventArgs e)
        {
            this.menuForm.OpenMenuForm();
        }

        private void btnCreateCommande_Click(object sender, EventArgs e)
        {
            this.createCommandModal.OpenModal();
            if(this.createCommandModal.DialogResult == DialogResult.OK) 
            {
                CommandeDTO createdCommande = this.createCommandModal.GetCreatedCommande();
                this.comboBoxTableCommande.Items.Add(createdCommande);
                this.comboBoxTableCommande.SelectedItem = createdCommande;
            }
        }
    }
}
