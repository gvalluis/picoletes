using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Picoletes.Core.Models
{
    public class QuantidadeSabores
    {
        public QuantidadeSabores(int qntSFloc, int qntSMor, int qntSChoc, int qntPChoc, int qntPMor, int qntAFrut, int qntPLim)
        {
            this.qntSFloc = qntSFloc;
            this.qntSMor = qntSMor;
            this.qntSChoc = qntSChoc;
            this.qntPChoc = qntPChoc;
            this.qntPMor = qntPMor;
            this.qntAFrut = qntAFrut;
            this.qntPLim = qntPLim;
        }

        public int qntSFloc { get; set; }
        public int qntSMor { get; set; }
        public int qntSChoc { get; set; }
        public int qntPChoc { get; set; }
        public int qntPMor { get; set; }
        public int qntAFrut { get; set; }
        public int qntPLim { get; set; }

    }
}
