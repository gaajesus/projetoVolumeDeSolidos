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
    public partial class Inicio : Form
    {
        Thread nt;
        public Inicio()
        {
            InitializeComponent();
        }

        private void picCilindro_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm1);
            nt.SetApartmentState(ApartmentState.MTA);
            nt.Start(); 
        }

        private void novoForm1()
        {
            Application.Run(new Cilindro());
        }

        private void picPrisma_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm2);
            nt.SetApartmentState(ApartmentState.MTA);
            nt.Start();
        }

        private void novoForm2()
        {
            Application.Run(new Prisma());
        }

        private void picCone_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm3);
            nt.SetApartmentState(ApartmentState.MTA);
            nt.Start();
        }

        private void novoForm3()
        {
            Application.Run(new Cone());
        }

        private void picPiramide_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm4);
            nt.SetApartmentState(ApartmentState.MTA);
            nt.Start();
        }

        private void novoForm4()
        {
            Application.Run(new Piramide());
        }

        private void picEsfera_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm5);
            nt.SetApartmentState(ApartmentState.MTA);
            nt.Start();
        }

        private void novoForm5()
        {
            Application.Run(new Esfera());
        }

        private void picCubo_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm6);
            nt.SetApartmentState(ApartmentState.MTA);
            nt.Start();
        }

        private void novoForm6()
        {
            Application.Run(new cubo());
        }
    }
}
