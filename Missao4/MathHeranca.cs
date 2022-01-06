using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missao4
{
    public class MathHeranca : Math
    {

        /*
        Utilizando o mesmo projeto, crie uma nova classe chamada “MathHeranca”, esta classe deverá
        herdar a classe Math. A classe “MathHeranca” também deve conter um construtor que recebe
        dois números decimais, porém o número B (atributo B) deverá ser herdado da classe “Math”
        Lembre-se da palavra chave base para esta atividade). Ainda na classe “MathHeranca” crie um
        método que faça a soma dos número A com o número B. 
        */

        // Atributos
        double numero1;

        //Construtor base é o contrutor da classe - Utilizando o atributo de uma classe herdada
        public MathHeranca(double numero1, double numeroB) : base(numeroB)
        {
          this.numero1 = numero1;
          this.numeroB = numeroB;
        }

        //Método da soma de dois números (Passo 6)
        public double Somar() => numeroA + numeroB;


        /*
        //Sobrescrita do método calcular área
        public override double calcularArea() => largura * altura;
        */





    }
}
