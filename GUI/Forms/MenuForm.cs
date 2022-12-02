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
    }
}
