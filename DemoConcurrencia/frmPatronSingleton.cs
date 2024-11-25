using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConcurrencia
{
    public partial class frmPatronSingleton : Form
    {
        public frmPatronSingleton()
        {
            InitializeComponent();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Singleton cadenaconexion = Singleton.Instance;
            cadenaconexion.cadenaConexion = txtCadenaConexion.Text;
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            Singleton cadenaconexion = Singleton.Instance;
            lblCadenaConexionRecuperada.Text = cadenaconexion.cadenaConexion;

        }
    }
}
