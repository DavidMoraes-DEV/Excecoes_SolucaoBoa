using System;
using System.Collections.Generic;
using System.Text;

namespace ExcecoesPersonalizadasBoa.Entities.Exceptions
{
    class DomainException : ApplicationException //Classe domain para Exceção personalizada
    {
        public DomainException(string message) : base(message) 
        {
        }
    }
}
