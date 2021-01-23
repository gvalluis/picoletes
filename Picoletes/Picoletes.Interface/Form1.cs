using Picoletes.API.Interfaces;
using Picoletes.API.Repository;
using Picoletes.API.Services;
using System;
using System.Windows.Forms;

namespace Picoletes.Interface
{
    public partial class InterfacePrincipal : Form
    {
        private IRetiradaService _retiradaService;
        public InterfacePrincipal(IRetiradaService retiradaService)
        {
            _retiradaService = retiradaService;

            InitializeComponent();
        }

        private void ExecutarRetiradaClick(object sender, EventArgs e)
        {

            MessageBox.Show("Retirada de produtos realizada com sucesso", "Retirada",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GerarRetiradaClick(object sender, EventArgs e)
        {
            _retiradaService.GerarBaseRetirada();
            MessageBox.Show("Arquivo de retirada gerado", "Sucesso",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
