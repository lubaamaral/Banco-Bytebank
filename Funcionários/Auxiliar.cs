using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank5.funcionários
{
    public class Auxiliar : funcionário
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
        }
        public override double GetBonificacao()
        {
            return this.Salario * 0.2;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}
