using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using Exercicio_fixacao_Enumeracoes_e_Composicao.Entities.Enums;

namespace Exercicio_fixacao_Enumeracoes_e_Composicao.Entities {
    class Order {

        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() {
        }

        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem) {
            OrderItem.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem) {
            OrderItem.Remove(orderItem);
        }

        public double Total() {
            double total = 0;
            foreach (OrderItem order in OrderItem) {
                total += order.Subtotal();
            }
            return total;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            Console.WriteLine();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine("Order items: ");
            foreach (OrderItem o in OrderItem) {
                sb.AppendLine(o.ToString());
            }
            sb.Append($"Total price: ${Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }

    }
}
