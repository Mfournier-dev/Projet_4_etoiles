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
        private ProjectContext projectContext;
        public CommandesForm()
        {
            InitializeComponent();
            this.projectContext = new ProjectContext();
            Init();
        }

        public void Init() 
        {
            this.comboBoxTableCommande.DisplayMember ="IdTable";
            this.comboBoxTableCommande.ValueMember = "IdCommande";
            //this.LoadCommandeSelector(MainService.GetInstance().GetCommandeService().GetAllCommandes());
        
        }

        public void OpenCommandeWindow() 
        {
            this.lblPrix.Text = "$";
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
            this.lblNumeroTable.Text = commande.IdTable.ToString();
            this.lblNombreClientsValue.Text = commande.NombreClients.ToString();
            List<MenuDTO> articles = MainService.GetInstance().GetCommandesArticlesService().GetAllArticlesForCommande(commande.IdCommande);
            foreach(MenuDTO article in articles) 
            { 
            
                this.AddArticleToListView(article);
            }
        
        }

        private void AddArticleToListView(MenuDTO article) 
        {
            ListViewItem lvItem = new ListViewItem(article.Name);
            lvItem.Tag = article.Id;
            this.listViewCommande.Items.Add(lvItem);
        
        }

        private void listViewCommande_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.currentSelectedCommande = (CommandeDTO) this.comboBoxTableCommande.Items[this.comboBoxTableCommande.SelectedIndex];
            this.LoadCommandeFields(this.currentSelectedCommande);
        }

        private void btnRetourMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
