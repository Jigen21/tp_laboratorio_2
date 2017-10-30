using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;
using Archivos;


namespace EntidadesInstanciables
{
    public class Jornada
    {
        #region atributos
        private List<Alumno> _alumnos;
        private Universidad.EClases _clase;
        private Profesor _instructor;
        #endregion

        #region propiedades
        public List<Alumno> Alumnos { get {return this._alumnos;} set {this._alumnos=value;} }
        public Universidad.EClases Clase { get { return this._clase; } set { this._clase = value; } }
        public Profesor Instructor { get{return this._instructor;} set{this._instructor=value;} }
        #endregion

        #region constructores
        private Jornada()
        {
            _alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor)
            : this()
        {
            this._clase = clase;
            this._instructor = instructor;
        }
        #endregion

        #region Sobrecargas
        
        /// <summary>
        /// sobrecarga del  ==
        /// </summary>
        /// <param name="j">objeto de tipo Jornada</param>
        /// <param name="a">objeto de tipo Alumno</param>
        /// <returns>retorna si el alumno pertenece a la jornada o no</returns>
        public static bool operator ==(Jornada j,Alumno a)
        {
            foreach (Alumno i in j._alumnos)
            {
                if (i == a)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// sobrecarga del !=
        /// </summary>
        /// <param name="j">objeto de tipo jornada</param>
        /// <param name="a">objeto de tipo alumno</param>
        /// <returns>retorna si el objeto no pertenece o si</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Sobrecarga del +,agrega el alumno si no se encuentra en la jornada
        /// </summary>
        /// <param name="j">objeto de tipo jornada</param>
        /// <param name="a">objeto de tipo alumno</param>
        /// <returns>retorna una jornada</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if(!(j==a))
            {
                j._alumnos.Add(a);
                return j;
            }

            return j;
        }

        /// <summary>
        /// Sobrecarga del ToString
        /// </summary>
        /// <returns>retorna los datos de la Jornada</returns>
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine("Clase de " + this._clase + " por " + this._instructor.ToString());
            s.AppendLine("ALUMNOS: ");

            foreach (Alumno i in this._alumnos)
            {
                s.AppendLine(i.ToString());
            }

            s.AppendLine("<------------------------------------------------->");

            return s.ToString();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Guarda los archivos de la jornada en un archivo de texto
        /// </summary>
        /// <param name="jornada">objeto de tipo jornada</param>
        /// <returns>retorna un booleano si pudo o no</returns>
        public static bool Guardar(Jornada jornada)
        {
            
            Texto writing = new Texto();

            return writing.Guardar("jornada.txt", jornada.ToString());
            

        }

        /// <summary>
        /// Lee un archivo de texto y trae los datos de la jornada
        /// </summary>
        /// <returns>retorna un string conteniendo los datos</returns>
        public static string Leer()
        {
           
            Texto reading = new Texto();
            string aux;
            reading.Leer("Jornada.txt", out aux);
            return aux;


        }

        #endregion




    }
}
