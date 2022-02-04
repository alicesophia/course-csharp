
namespace Exemplo_Heranca_multipla_e_problema_diamante.Devices {
    abstract class Device {

        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);

    }
}
