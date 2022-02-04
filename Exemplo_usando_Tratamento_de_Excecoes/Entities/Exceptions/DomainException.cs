using System;

namespace Exemplo_usando_Tratamento_de_Excecoes.Entities.Exceptions {
    class DomainException : ApplicationException {

        public DomainException(string message) : base(message) {
        }
    }
}