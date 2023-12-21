using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank5.funcionários
{
    public class funcionário
    {
        public string Nome { get; set; }  //lembrando que esse tipo de classe é bom usar letras maiúsculas no início
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalFuncionarios { get; private set; }
        public virtual double GetBonificacao() //virtual deixa um override ser escrito por cima 
        {
            return this.Salario * 0.10;
            //o "this." serve para referir-se a propriedade nome da classe, sem ele, o programa entende que estaria se referindo apenas ao parametro
        }
        public funcionário(string cpf, double salario)
        {
            this.Salario = salario;
            this.Cpf = cpf;
            TotalFuncionarios++;
            Console.WriteLine("Criando um funcionário.");
        }

        public virtual void AumentarSalario()
        {
            this.Salario *= 1.10;
        }
    }
}
