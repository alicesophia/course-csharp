using System;
using Exemplo_Heranca_multipla_e_problema_diamante.Devices;

namespace Exemplo_Heranca_multipla_e_problema_diamante {
    class Program {
        static void Main(string[] args) {

            //Herança múltipla e o problema do diamante
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());

        }
    }
}
