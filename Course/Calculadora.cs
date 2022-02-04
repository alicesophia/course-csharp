using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course {
    class Calculadora {

        //Paramêtro params (para passar n valores como paramêtro)
        public static int Soma(params int[] numeros) {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++) {
                soma += numeros[i];
            }
            return soma;
        }

        //Modificador de parâmetros ref (para referenciar uma variável fora do escopo local) 
        //public static void Triple(ref int x) {
        //    x = x * 3;
        //}

        //Modificador de paramêtros out (joga o resultado da função em outra variável)
        public static void Triple(int origem, out int resultado) {
            resultado = origem * 3;
        }
    }
}
