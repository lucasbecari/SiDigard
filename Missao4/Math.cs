using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missao4
{
     public class Math
    {
        //Variáveis, atributos
        public double numeroA { get; set; }
        public double numeroB { get; set; }


        //Construtor Math
        public Math(double numeroA, double numeroB)
        {
            this.numeroA = numeroA;
            this.numeroB = numeroB;
        }

        //Construtor Math (Para o Passo 6)
        public Math(double numeroB)
        {
            this.numeroB = numeroB;
        }

        //Método da divisão dos dois números
        public double Dividir() => numeroA / numeroB;


        //Método de multiplicação dos dois números
        public double Multiplicar() => numeroA * numeroB;
    }
}
