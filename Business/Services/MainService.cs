using Projet_4_etoiles.DataAccess.Context;
using Projet_4_etoiles.GUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projet_4_etoiles.Business.Services
{
    public class MainService : IService
    {
        //Ajouter tous les classes services dans le projet.
        
        private UtilisationForm utilisationForm;
        private ProjectContext _projectContext;
        private CommandeService _commandeService;
        private UtilisationService _utilisationService;
        private CommandesArticlesService _commandesArticlesService;
        private MenuService _menuService;



        private static MainService INSTANCE;
        
        private MainService()
        {
            ApplicationConfiguration.Initialize();
            // Chaque service doit etre passé, seront contenus dans un singleton.
            this._projectContext = new ProjectContext();
            this._commandeService = new CommandeService(this._projectContext);
            this._menuService = new MenuService(this._projectContext);
            this._commandesArticlesService = new CommandesArticlesService(this._projectContext);
            this._utilisationService = new UtilisationService(this._projectContext);
            
        }

        public static MainService GetInstance()
        {
            if(INSTANCE is null)
            {
                INSTANCE = new MainService();
            }
            return INSTANCE;
        }

        public void StartApplication()
        {
            Application.Run(new MainForm());

        }

        public void ExitApplication()
        {
            Application.Exit();
        }

        public void OpenUtilisationForm()
        {
            this.utilisationForm.ShowDialog();
        }


        //Chaque Service doit avoir une methode similaire comme celle ci-dessous.
        public CommandeService GetCommandeService()
        {
            return this._commandeService;
        }

        public MenuService GetMenuService()
        {
            return this._menuService;
        }

        public UtilisationService GetUtilisationService() 
        {
            return this._utilisationService;
        }

        public CommandesArticlesService GetCommandesArticlesService() 
        {
            return this._commandesArticlesService;
        }

    }
}
