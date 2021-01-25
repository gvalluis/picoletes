using Picoletes.Core.Interfaces;
using Picoletes.Core.Models;
using Picoletes.Interface.Services;
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
            Random n = new Random();

            RetiradaService retiradaService = new RetiradaService();
            retiradaService.RealizarRetirada(
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
            //_retiradaService.GerarBaseRetirada();
            MessageBox.Show("Arquivo de retirada gerado", "Sucesso",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
