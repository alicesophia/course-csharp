using System.Text;
using System.Globalization;

namespace Exercicio_fixacao_Enumeracoes_e_Composicao.Entities {
    class OrderItem {

        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() {
        }

        public OrderItem(int quantity, double price, Product product) {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double Subtotal() {
            return Quantity * Price;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Product.Name}, ");
            sb.Append($"${Product.Price.ToString("F2", CultureInfo.InvariantCulture)}, ");
            sb.Append($"Quantity: {Quantity}, ");
            sb.Append($"Subtotal: ${Subtotal().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
