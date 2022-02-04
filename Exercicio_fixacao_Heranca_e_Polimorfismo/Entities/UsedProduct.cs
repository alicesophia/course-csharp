using System;
using System.Text;
using System.Globalization;

namespace Exercicio_fixacao_Heranca_e_Polimorfismo.Entities {
    class UsedProduct : Product {

        public DateTime ManufactureDate { get; set; }

        public UsedProduct() {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price) {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag() {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} (used) ${Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})");
            return sb.ToString();
        }

    }
}
