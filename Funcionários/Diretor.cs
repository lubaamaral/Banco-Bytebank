using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank5.funcionários
{
    public class Diretor : funcionário //como aqui tá implícito que diretor é funcionário, não é necessário atribuir nada a ele em relação a cadastro 
    {
        public override double GetBonificacao() //override sobrescreve na classe funcionario
        {
            return this.Salario + base.GetBonificacao();
            //o "this." serve para referir-se a propriedade nome da classe, sem ele, o programa entende que estaria se referindo apenas ao parametro
        }
        public Diretor(string cpf, double salario):base(cpf, salario)
        {
            Console.WriteLine("Criando um diretor.");
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
