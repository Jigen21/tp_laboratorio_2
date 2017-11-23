using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;


namespace EntidadesInstanciables
{
    public sealed class Alumno:Universitario
    {

        #region enumerado
        public enum EEstadoCuenta {AlDia,Deudor,Becado }
        #endregion



        #region atributos
        private EEstadoCuenta _estadoCuenta;
        private Universidad.EClases _clasesQueToma;
        #endregion

        #region Constructores
        public Alumno()
        {

        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases clasequetoma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this._clasesQueToma = clasequetoma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases clasequetoma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, clasequetoma)
        {
            this._estadoCuenta = estadoCuenta;
        }

        #endregion


        #region sobrecargas

        /// <summary>
        /// sobrecarga del mostrarDatos en la clase base
        /// </summary>
        /// <returns>retorna los datos del alumno</returns>
        protected override string MostrarDatos()
        {
            return this.ToString();
        }

        /// <summary>
        /// Sobrecarga del ToString
        /// </summary>
        /// <returns>retorna los datos del alumno para ser usados en MostrarDatos</returns>
        public override string ToString()
        {
            StringBuilder a = new StringBuilder();
            a.AppendLine(base.ToString());
            a.AppendLine("LEGAJO NuMERO: " +this.legajo);
            a.AppendLine("");
            if (this._estadoCuenta == EEstadoCuenta.AlDia)
            {
                a.AppendLine("ESTADO DE CUENTA: Cuota al dia");
            }

            if (this._estadoCuenta == EEstadoCuenta.Becado)
            {
                a.AppendLine("ESTADO DE CUENTA: Esta Becado");
            }

            if (this._estadoCuenta == EEstadoCuenta.Deudor)
            {
                a.AppendLine("ESTADO DE CUENTA: Cuota con Deudas");
            }
            
            a.AppendLine(this.ParticiparEnClase());

            return a.ToString();
        }

        /// <summary>
        /// Sobrecarga del ParciticparEnClase en la clase base
        /// </summary>
        /// <returns>retorna la clase en la que participa</returns>
        protected override string ParticiparEnClase()
        {
            return "TOMA CLASES DE " + this._clasesQueToma;
        }

        /// <summary>
        /// sobrecarga del ==
        /// </summary>
        /// <param name="a">objeto de tipo alumno</param>
        /// <param name="b">objeto de tipo ECLases</param>
        /// <returns>retorna si cursa esa clase y no es deudor</returns>
        public static bool operator ==(Alumno a, Universidad.EClases b)
        {
            if (a._clasesQueToma == b && a._estadoCuenta != EEstadoCuenta.Deudor)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del !=
        /// </summary>
        /// <param name="a">objeto de tipo alumno</param>
        /// <param name="b">objeto de tipo EClases</param>
        /// <returns>retorna si son desiguales o no</returns>
        public static bool operator !=(Alumno a, Universidad.EClases b)
        {
            return (a._clasesQueToma != b);
        }

        #endregion






    }
}
