
namespace Exercicio_fixacao_Metodos_Abstratos.Entities {
    class Individual : TaxPayer {

        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome) {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax() {
            
            double sum = 0.0;
            
            if (AnualIncome < 20000.00) {
                sum += AnualIncome * 0.15;
            } else {
                sum += AnualIncome * 0.25;
            }

            if (HealthExpenditures > 0.0) {
                sum -= HealthExpenditures * 0.50;
            }

            return sum;
        }       
    }
}
