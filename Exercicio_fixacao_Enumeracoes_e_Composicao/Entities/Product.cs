﻿
namespace Exercicio_fixacao_Enumeracoes_e_Composicao.Entities {
    class Product {

        public string Name { get; set; }
        public double Price { get; set; }

        public Product() {
        }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }
    }
}
