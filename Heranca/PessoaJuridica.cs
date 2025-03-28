using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class PessoaJuridica: Pessoa    //  PessoaJuridica herda de Pessoa
    {
        //Atributos
        public string cnpj;
        public string inscricaoEstadual;
        public string inscricaoMunicipal;
    }
}
