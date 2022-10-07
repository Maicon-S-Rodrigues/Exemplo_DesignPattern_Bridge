using Proj_Exemplo_Bridge.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Exemplo_Bridge.Implementor
{
    public interface IGeraArquivo
    {
        void GravaArquivo(Funcionario funcionario);
    }
}
