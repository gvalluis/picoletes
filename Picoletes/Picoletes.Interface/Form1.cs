using Picoletes.Dominio.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picoletes.Interface
{
    public partial class Form1 : Form
    {
        public Form1()
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
