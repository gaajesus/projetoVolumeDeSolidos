using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Calculadora_Volume_de_solidos
{
    public partial class Cilindro : Form
    {
        Thread nt;
        public Cilindro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(voltar);
            nt.SetApartmentState(ApartmentState.MTA);
            nt.Start();

        }

        private void voltar()
        {
            Application.Run(new Inicio());

        }
    }
}
