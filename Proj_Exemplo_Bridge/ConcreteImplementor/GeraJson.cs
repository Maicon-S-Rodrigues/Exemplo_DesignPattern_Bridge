using Proj_Exemplo_Bridge.Domain;
using Proj_Exemplo_Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proj_Exemplo_Bridge.ConcreteImplementor
{
    public class GeraJson : IGeraArquivo
    {
        private string nomeArquivo = "SalarioFuncionario.json";

        public void GravaArquivo(Funcionario funcionario)
        {
            var funcionarioSerializado = JsonSerializer.Serialize(funcionario);

            File.WriteAllText(nomeArquivo, funcionarioSerializado);

            Console.WriteLine($"Salário para o Funcionário: {funcionario.Nome} " +
                              $"Gerado com Sucesso em: {nomeArquivo} \n");
        }
    }
}
