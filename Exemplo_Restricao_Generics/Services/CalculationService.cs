using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Restricao_Generics.Services {
    class CalculationService {

        //A lista passada como argumento deve ser do tipo T e deve ser IComparable
        public T Max<T>(List<T> list) where T : IComparable {
            if (list.Count == 0) {
                throw new ArgumentException("This list can not be empty");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++) {
                if (list[i].CompareTo(max) > 0) {
                    max = list[i];
                }
            }
            return max;
        }

    }
}
