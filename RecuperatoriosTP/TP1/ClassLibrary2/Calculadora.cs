using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Calculadora
    {
        public static double Operar(Numero num1,Numero num2,string operador)
        {
            double resultado = 0;

            switch(operador)
            {
                case "+":
                    resultado=num1+num2;
                    break;
                case "-":
                    resultado=num1-num2;
                    break;
                case "*":
                    resultado=num1*num2;
                    break;
                case "/":
                    resultado=num1/num2;
                    break;

            }

            return resultado;
        }

        public string ValidarOperador(string Operador)
        {
            if(Operador != "-" && Operador != "*" && Operador != "/")
            {
                return "+";
            }

            return Operador;
        }

    }
}
