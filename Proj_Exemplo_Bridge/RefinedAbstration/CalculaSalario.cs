using Proj_Exemplo_Bridge.Abstraction;
using Proj_Exemplo_Bridge.Domain;
using Proj_Exemplo_Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Exemplo_Bridge.RefinedAbstration
{
    public class CalculaSalario : AbstractionGeraArquivo
    {
        public CalculaSalario(IGeraArquivo geraArquivo) : base (geraArquivo){}

        public void ProcessaSalarioFuncionario(Funcionario funcionario)
        {
            funcionario.SalarioTotal = funcionario.SalarioBase + funcionario.Incentivo;

            Console.WriteLine($"Valor do Salário Total para o Funcionario {funcionario.Id} \n" +
                              $": R$ {funcionario.SalarioTotal}");
            geraArquivo.GravaArquivo(funcionario);
        }
    }
}
