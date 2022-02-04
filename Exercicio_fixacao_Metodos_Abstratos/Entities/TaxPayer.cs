using System.Text;
using System.Globalization;

namespace Exercicio_fixacao_Metodos_Abstratos.Entities {
    abstract class TaxPayer {

        public string Name { get; set; }
        public double AnualIncome { get; set; }
        
        protected TaxPayer(string name, double anualIncome) {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name}: ${Tax().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
