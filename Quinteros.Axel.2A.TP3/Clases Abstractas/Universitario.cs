using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario:Persona
    {
        //probando con private
        #region atributos
        protected int legajo;
        #endregion

        #region constructores
        public Universitario()
        {

        }

        public Universitario(int legajo,string nombre,string apellido,string dni,ENacionalidad nacionalidad):base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;

        }
        #endregion

        #region sobrecargas

        protected abstract string ParticiparEnClase();

        /// <summary>
        /// Sobrecarga del == para comparar un universitario con otro
        /// </summary>
        /// <param name="pg1">un objeto tipo universitario</param>
        /// <param name="pg2">otro objeto tipo universitario</param>
        /// <returns>retorna si son iguales o no</returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
          
            return (pg1.DNI == pg2.DNI || pg1.legajo == pg2.legajo && pg1 is Universitario && pg2 is Universitario);
            
        }

        /// <summary>
        /// Lo contrario al ==
        /// </summary>
        /// <param name="pg1">un objeto de tipo universitario</param>
        /// <param name="pg2">otro objeto de tipo universitario</param>
        /// <returns>retorna si son desiguales o no</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        /// <summary>
        /// Sobrecarga del equals
        /// </summary>
        /// <param name="obj">recibe un objeto generico</param>
        /// <returns>retorna si es igual a o no</returns>
        public override bool Equals(object obj)
        {
            if ((Universitario)obj == this)
            {
                return true;
            }
            return false;
        }

        #endregion

        #region metodos
        /// <summary>
        /// Metodo para mostrar los datos del universitario
        /// </summary>
        /// <returns>retorna los datos en string</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder a = new StringBuilder();
            a.AppendLine(base.ToString());           
            //a.AppendLine(this.legajo.ToString());
            return a.ToString();
        }

        #endregion













    }
}
