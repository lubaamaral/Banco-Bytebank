using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank5.funcionários
{
    public class GerenteDeContas : funcionário
    {
        public GerenteDeContas(string cpf) : base(cpf, 2000)
        {
        }
        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }
    }
}
