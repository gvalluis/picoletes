using Picoletes.Core.Interfaces;
using Picoletes.Core.Models;
using System;
using System.Collections.Generic;
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
            Random n = new Random();
            
            _retiradaService.RealizarRetirada(
                new PedidoRetirada(n.Next(0, 9999),
                    Convert.ToInt32(SFloc.Value),
                    Convert.ToInt32(SMor.Value),
                    Convert.ToInt32(SChoc.Value),
                    Convert.ToInt32(PChoc.Value),
                    Convert.ToInt32(PMor.Value),
                    Convert.ToInt32(AFrut.Value),
                    Convert.ToInt32(PLim.Value)));
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
