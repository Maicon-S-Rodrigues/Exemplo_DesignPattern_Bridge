using Proj_Exemplo_Bridge.ConcreteImplementor;
using Proj_Exemplo_Bridge.Domain;
using Proj_Exemplo_Bridge.RefinedAbstration;
using System;

namespace Proj_Exemplo_Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            Funcionario funcionario = new Funcionario();
            funcionario.Id = 101;
            Console.WriteLine("Informe o Nome do Funcionario");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Informe o Salario Base: ");
            funcionario.SalarioBase = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Incentivo a ser Concedido: ");
            funcionario.Incentivo = decimal.Parse(Console.ReadLine());

            //chama atraves da refined abstraction o metodo para processar o salario e então atraves da bridge com a interface gera o arquivo em XML
            CalculaSalario calculaSalario = new CalculaSalario(new GeraXML());
            calculaSalario.ProcessaSalarioFuncionario(funcionario);

            //chama atraves da refined abstraction o metodo para processar o salario e então atraves da bridge com a interface gera o arquivo em JSON
            calculaSalario = new CalculaSalario(new GeraJson());
            calculaSalario.ProcessaSalarioFuncionario(funcionario);

            Console.ReadKey();
        }
    }
}
