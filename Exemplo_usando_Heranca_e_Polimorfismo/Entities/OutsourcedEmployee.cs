using System.Text;
using System.Globalization;

namespace Exemplo_usando_Heranca_e_Polimorfismo.Entities {
    class OutsourcedEmployee : Employee {

        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour) {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment() {
            return base.Payment() + AdditionalCharge * 1.1;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " - $" + Payment().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
