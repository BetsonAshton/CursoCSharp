using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_1.ClassesEMetodos
{
    class CalculadoraComum { 
    public int Somar(int a, int b)
        {
            return a + b;
        }

        public int subtrair (int a, int b) 
        {
            return a - b;
        }

        public int multiplicar (int a, int b)
        {
            return a * b;
        }
    
    
    
    }
   
    internal class MetodosComRetorno
    {
        public static void Executar ()
        {
            var CalculadoraComum = new CalculadoraComum();
            var resultado = CalculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(CalculadoraComum.subtrair(2, 7));
            Console.WriteLine(CalculadoraComum.multiplicar(4, 4));

        }
    }
}
