using System;
using System.Text;

namespace Exercicio_fixacao_Enumeracoes_e_Composicao.Entities {
    class Client {

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client() {
        }

        public Client(string name, string email, DateTime birthDate) {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} ");
            sb.Append($"({BirthDate.ToString("dd/MM/yyyy")}) ");
            sb.Append($"- {Email}");
            return sb.ToString();
        }
    }
}
