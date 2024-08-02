using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Exceptions
{
    /// <summary>
    /// Classe customizada para captura de exceções
    /// </summary>
    public class ValidacaoException : Exception
    {
        /*método construtor [ctor + tab] para que possamos passar 
        a mensagem de erro que esta classe deverá exibir */
        public ValidacaoException(string mensagem)
            : base(mensagem) //passando a mensgaem para a superclasse (base class) 
        {
               
        }
    }
}
