using System;

namespace Exemplo_Heranca_multipla_e_problema_diamante.Devices {
    class ComboDevice : Device, IScanner, IPrinter {

        public void Print(string document) {
            Console.WriteLine("ComboDevice print " + document);
        }

        public override void ProcessDoc(string document) {
            Console.WriteLine("Combo device processing " + document);
        }

        public string Scan() {
            return "Combo device scan result";
        }
    }
}
