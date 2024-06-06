using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world_00{
    internal class Calculator{
        public int Calculate(string op, int value1, int value2){ //este método devolve um valor do tipo inteiro
            if(op == "+"){
                return value1 + value2;
            }

            else if(op == "-") {
                return value1 - value2;
            }

            else if(op == "*"){
                return value1 * value2;
            }

            else if(op == "/"){
                return value1 * value2;
            }

            else { }
            return 0; //sempre irá retornar dele um valor, mesmo que 0
        }
    }
}
