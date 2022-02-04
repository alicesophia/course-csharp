
namespace Exercicio_fixacao_Metodos_Abstratos.Entities {
    class Company : TaxPayer {

        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome) {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax() {

            double sum = 0.0;

            if (NumberOfEmployees < 10) {
                sum += AnualIncome * 0.16;
            } else {
                sum += AnualIncome * 0.14;
            }

            return sum;
        }
    }
}
