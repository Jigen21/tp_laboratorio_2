using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        #region atributos
        int flag = 0;
        int flagDos = 0;
        int flagTres = 0;
        #endregion

        #region constructores

        public LaCalculadora()
        {
            InitializeComponent();
            Operador.Items.Add("+");
            Operador.Items.Add("-");
            Operador.Items.Add("/");
            Operador.Items.Add("*");
            Operador.SelectedIndex = 0;
            
        }
        #endregion


        #region metodos
        /// <summary>
        /// Cierra la calculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        /// <summary>
        /// llama al metodo operarr,y hace las operaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Operar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(Numero1.Text) || string.IsNullOrEmpty(Numero2.Text)))
            {
                if (flagTres == 0)
                {

                    double aux = Operarr(Numero1.Text.ToString(), Numero2.Text.ToString(), Operador.Text.ToString());

                    Resultado.Text = aux.ToString();
                    flag = 1;
                }
            }

            
        }

        /// <summary>
        /// un metodo para llamar a la operacion de la clase numero
        /// </summary>
        /// <param name="numero1">el primer numero</param>
        /// <param name="numero2">eel segundo numero</param>
        /// <param name="operador">un string con el operador</param>
        /// <returns></returns>
        public static double Operarr(string numero1,string numero2,string operador)
        {
            double aux;
            Numero a = new Numero(numero1);
            Numero b = new Numero(numero2);


            aux = Calculadora.Operar(a,b,operador);

            return aux;
        }

        /// <summary>
        /// convierte a binario el numero actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertirABinario_Click(object sender, EventArgs e)
        {
            if (flag == 1 && flagDos == 0)
            {
                //Resultado.Text=Numero.BinarioDecimal(Resultado.Text.ToString());
                //double aux = Convert.ToDouble(Resultado.Text);
                //Resultado.Text = Numero.DecimalBinario(aux);
                double aux = Convert.ToDouble(Resultado.Text);
                Resultado.Text = Numero.DecimalBinario(aux);
                flagDos = 1;
                flagTres = 1;
            }
              
        }

        /// <summary>
        /// Convierte a decimal el numero actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (flag == 1&&flagDos == 1)
            {
                Resultado.Text = Numero.BinarioDecimal(Resultado.Text);
                flagDos = 0;
                flagTres = 1;
            }
            
        }

        /// <summary>
        /// llama al metodo limpiarr
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.Limpiarr();
        }


        /// <summary>
        /// Limpia los textbox,label y combobox
        /// </summary>
        void Limpiarr()
        {
            Numero1.Text = "";
            Numero2.Text = "";
            Resultado.Text = "";
            flag = 0;
            flagDos = 0;
            Operador.Text = "";
            flagTres = 0;
        }

        #endregion
    }
}
