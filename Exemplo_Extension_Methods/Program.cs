using System;

namespace Exemplo_Extension_Methods {
    class Program {
        static void Main(string[] args) {

            DateTime dt = new DateTime(2022, 2, 6, 8, 0, 45);

            //Na hora de chamar o método, não é necessário passar nada porque na declaração do método já existe uma referência a ele mesmo
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));

        }
    }
}
