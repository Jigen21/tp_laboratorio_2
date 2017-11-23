using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Numero
    {
        #region atributos
        private double numero;

        #endregion
        
        #region propiedades

        public string SetNumero { set {this.numero = ValidarNumero(value) ;} }

        #endregion

        #region constructores
        public Numero()
        {
            this.numero = 0.0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {

            this.SetNumero = strNumero; 
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Valida el numero a guardar
        /// </summary>
        /// <param name="strNumero">un string con los datos del numero</param>
        /// <returns>retorna un double,siendoe l numero</returns>
        private double ValidarNumero(string strNumero)
        {
            double aux;

            double.TryParse(strNumero, out aux);

            return aux;
        }

        /// <summary>
        /// hace la operacion de la resta de numeros
        /// </summary>
        /// <param name="n1">numero uno</param>
        /// <param name="n2">numero dos</param>
        /// <returns>retorna un double con el resultado</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// hace la operacion de la multiplicacion de numeros
        /// </summary>
        /// <param name="n1">numero uno</param>
        /// <param name="n2">numero dos</param>
        /// <returns>retorna un double con el resultado</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// hace la operacion de la division de numeros,valida la division con 0
        /// </summary>
        /// <param name="n1">numero uno</param>
        /// <param name="n2">numero dos</param>
        /// <returns>retorna un double con el resultado</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if (n1.numero == 0 || n2.numero == 0)
            {
                return 0;
            }

            return n1.numero / n2.numero;
        }

        /// <summary>
        /// hace la operacion de la suma de numeros
        /// </summary>
        /// <param name="n1">numero uno</param>
        /// <param name="n2">numero dos</param>
        /// <returns>retorna un double con el resultado</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }


        /// <summary>
        /// Convierte el numero binario a decimal
        /// </summary>
        /// <param name="binario">recibe un string con el binario</param>
        /// <returns>retorna el decimal en string</returns>
        public static string BinarioDecimal(string binario)
        {

           
            int entero = 0;

            for (int i = 1; i <= binario.Length; i++)
            {
                entero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
            }

            return entero.ToString();


        }

        /// <summary>
        ///converte el decimal en binario 
        /// </summary>
        /// <param name="numero">recibe un numero</param>
        /// <returns>devuelve el binario</returns>
        public static string DecimalBinario(double numero)
        {
            
            int entero = Convert.ToInt32(numero);
            string binario = "";
            while (entero > 0)
            {
                binario = (entero % 2).ToString() + binario;
                entero = entero / 2;
            }
            return binario;

        }
        public static string DecimalBinario(string numero)
        {
            int entero = Convert.ToInt32(numero);
            string binario = "";
            while (entero > 0)
            {
                binario = (entero % 2).ToString() + binario;
                entero = entero / 2;
            }
            return binario;
            
        }

        #endregion

    }
}
