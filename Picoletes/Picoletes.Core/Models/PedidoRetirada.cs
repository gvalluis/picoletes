using System.Collections.Generic;

namespace Picoletes.Core.Models
{
    public class PedidoRetirada
    {
        public PedidoRetirada(int id, int qntSFloc, int qntSMor, int qntSChoc, int qntPChoc, int qntPMor, int qntAFrut, int qntPLim)
        {
            Id = id;
            this.qntSFloc = qntSFloc;
            this.qntSMor = qntSMor;
            this.qntSChoc = qntSChoc;
            this.qntPChoc = qntPChoc;
            this.qntPMor = qntPMor;
            this.qntAFrut = qntAFrut;
            this.qntPLim = qntPLim;
        }

        public int Id { get; set; }
        public int qntSFloc { get; set; }
        public int qntSMor { get; set; }
        public int qntSChoc { get; set; }
        public int qntPChoc { get; set; }
        public int qntPMor { get; set; }
        public int qntAFrut { get; set; }
        public int qntPLim { get; set; }
    }
}
