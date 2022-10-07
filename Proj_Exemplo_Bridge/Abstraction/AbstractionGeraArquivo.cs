using Proj_Exemplo_Bridge.Domain;
using Proj_Exemplo_Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Exemplo_Bridge.Abstraction
{
    public abstract class AbstractionGeraArquivo
    {
        protected IGeraArquivo geraArquivo;

        protected AbstractionGeraArquivo(IGeraArquivo geraArquivo) // metodo construtor da abstração, recebendo através da Bridge
        {
            this.geraArquivo = geraArquivo;                        // o parametro indicando qual classe geradora de arquivo sera usada (JSON / XML) que tenha a assinatura
                                                                   // da interface IGeraArquivo
        }
    }
}
