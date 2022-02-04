using System;

namespace Exercicio_fixacao_Tratamento_de_Excecao.Entities.Exceptions {
    class DomainException : ApplicationException {

        public DomainException(string message) : base(message) {
        }
    }
}
