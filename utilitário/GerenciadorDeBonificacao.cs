using bytebank5.funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank5.utilitário
{
    public class GerenciadorDeBonificacao
    {
        public double TotalBonificacao { get; private set; }
        public void Registrar(funcionário funcionario)
        {
            this.TotalBonificacao += funcionario.GetBonificacao();
        }
    }
}
