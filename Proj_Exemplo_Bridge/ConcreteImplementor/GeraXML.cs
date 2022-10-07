using Proj_Exemplo_Bridge.Domain;
using Proj_Exemplo_Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Proj_Exemplo_Bridge.ConcreteImplementor
{
    public class GeraXML : IGeraArquivo
    {
        private string nomeArquivo = "SalarioFuncionario.xml";
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(Funcionario));
        private FileStream fileStream;

        public void GravaArquivo(Funcionario funcionario)
        {
            fileStream = new FileStream(nomeArquivo, FileMode.OpenOrCreate);

            xmlSerializer.Serialize(fileStream, funcionario);

            Console.WriteLine($"Salário para o Funcionário: {funcionario.Nome} " +
                              $"Gerado com Sucesso em: {nomeArquivo} \n");
        }
    }
}
