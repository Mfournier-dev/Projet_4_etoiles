using Projet_4_etoiles.DataAccess.DAO;
using Projet_4_etoiles.DataAccess.DTO;
using Projet_4_etoiles.GUI;
using Projet_4_etoiles.GUI.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Projet_4_etoiles
{
    public partial class MainForm : Form
    {
        private UtilisationForm uForm;
        private MenuDTO menuDTO;
        private CommandesForm commandeForm;
        private ViewIntent viewInt;
        public MainForm()
        {
            InitializeComponent();
            this.uForm = new UtilisationForm();
            this.commandeForm = new CommandesForm();
            this.viewInt = new ViewIntent();
        }

        private void btnAssignation_Click(object sender, EventArgs e)
        {
            uForm.OpenWindow();
        }


        private void btnVoirCommandes_Click(object sender, EventArgs e)
        {
            commandeForm.OpenCommandeWindow();
        }
    }
}