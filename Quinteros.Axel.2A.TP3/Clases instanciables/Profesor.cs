using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    public sealed class Profesor:Universitario
    {

        #region atributos
        private Queue<Universidad.EClases> _clasesDelDia;
        //static int probando = 0;
        private static Random random;
        #endregion

        #region constructores
        static Profesor()
        {
            random = new Random();
        }

        public Profesor()
        {

        }


        public Profesor(int id,string nombre,string apellido,string dni,ENacionalidad nacionalidad):base(id,nombre,apellido,dni,nacionalidad)
        {
            _clasesDelDia = new Queue<Universidad.EClases>();
            //if (probando == 0)
            //{
            //    this._clasesDelDia.Enqueue(Universidad.EClases.Laboratorio);
            //    this._clasesDelDia.Enqueue(Universidad.EClases.Laboratorio);
            //    probando = 1;
            //}
            //else
            //{
            //    this._clasesDelDia.Enqueue(Universidad.EClases.Laboratorio);
            //    this._clasesDelDia.Enqueue(Universidad.EClases.Legislacion);
            //}
            //lo de arriba era para probar que la salida sea igual a lo del pdf
            this._RandomClases();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo para agregar dos clases aleatorias al profesor
        /// </summary>
        private void _RandomClases()
        {
            this._clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 4));
            this._clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 4));
        }
        #endregion

        #region sobrecargas
        /// <summary>
        /// Sobrecarga del MostrarDatos en la clase base
        /// </summary>
        /// <returns>retorna los datos del profesor</returns>
        protected override string MostrarDatos()
        {
            return this.ToString();
        }

        /// <summary>
        /// Sobrecarga del ToString
        /// </summary>
        /// <returns>retorna los datos del profesor</returns>
        public override string ToString()
        {
            //areglar este con el de participar en clase
            StringBuilder a = new StringBuilder();
            a.AppendLine(base.ToString());
            a.AppendLine("LEGAJO NuMERO: " + this.legajo);
            a.AppendLine("CLASES DEL DIA: ");
            foreach (Universidad.EClases i in this._clasesDelDia)
            {
                a.AppendLine(i.ToString());
            }
            return a.ToString();
        }

        /// <summary>
        /// SObrecarga de ParticiparEnClase de la clase base
        /// </summary>
        /// <returns>retorna la clase en las que enseña</returns>
        protected override string ParticiparEnClase()
        {
            return "CLASES DEL DIA: " + this._clasesDelDia;
        }



        /// <summary>
        /// Sobrecarga del ==
        /// </summary>
        /// <param name="i">objeto de tipo profesor</param>
        /// <param name="clase">objeto de tipo EClase</param>
        /// <returns>retorna true si el profesor da esa clase,sino false</returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            foreach (Universidad.EClases e in i._clasesDelDia)
            {
                if (e == clase)
                {
                    return true;
                }
            }
            return false;

        }

        /// <summary>
        /// Sobrecarga del !=
        /// </summary>
        /// <param name="i">objeto de tipo profesor</param>
        /// <param name="clase">objeto de tipo EClase</param>
        /// <returns>retorna si no da esa clase o si</returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

        #endregion









    }
}
