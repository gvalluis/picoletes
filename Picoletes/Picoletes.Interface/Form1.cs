using Picoletes.Dominio.Services;
using System;
using System.Windows.Forms;

namespace Picoletes.Interface
{
    public partial class InterfacePrincipal : Form
    {
        public InterfacePrincipal()
        {
            InitializeComponent();
        }

        private void ExecutarRetiradaClick(object sender, EventArgs e)
        {

            MessageBox.Show("Retirada de produtos realizada com sucesso", "Retirada",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GerarRetiradaClick(object sender, EventArgs e)
        {
            RetiradaService retiradaService = new RetiradaService();
            retiradaService.GerarBaseRetirada();
            MessageBox.Show("Arquivo de retirada gerado", "Sucesso",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
