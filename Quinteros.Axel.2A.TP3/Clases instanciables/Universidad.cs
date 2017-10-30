using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Excepciones;
using Archivos;

namespace EntidadesInstanciables
{
    public class Universidad
    {
        #region atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #endregion

        #region propiedades
        public List<Alumno> Alumnos { get { return this.alumnos; } set {this.alumnos=value ;} }
        public List<Jornada> Jornada { get {return this.jornada ;} set {this.jornada=value ;} }
        public List<Profesor> Profesores { get {return this.profesores ;} set {this.profesores=value ;} }
        public Jornada this[int i] { get {return this.jornada[i] ;} set {this.jornada[i] =value ;} }
        #endregion

        #region constructores
        public Universidad()
        {
            this.alumnos=new List<Alumno>();
            this.jornada=new List<Jornada>();
            this.profesores=new List<Profesor>();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo para guardar los datos de la universidad en un archivo xml
        /// </summary>
        /// <param name="gim">recibe un objeto de tipo universidad</param>
        public static void Guardar(Universidad gim)
        {
            
            Xml<Universidad> xmlFile = new Xml<Universidad>();
            xmlFile.Guardar("Universidad.xml", gim);

        }

        /// <summary>
        /// Metodo para mostrar los datos de la universidad
        /// </summary>
        /// <param name="gim"></param>
        /// <returns>retorna un string con los datos de la universidad</returns>
        private string MostrarDatos(Universidad gim)
        {
            StringBuilder a = new StringBuilder();
            a.AppendLine("JORNADA: ");

            
            foreach (Jornada i in gim.jornada)
            {
                a.AppendLine(i.ToString());

            }
            return a.ToString();
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// sobrecarga del ==
        /// </summary>
        /// <param name="g">objeto de tipo universidad</param>
        /// <param name="a">objeto de tipo alumno</param>
        /// <returns>retorna si el alumno pertenece a la lista de alumnos de la universidad o no</returns>
        public static bool operator ==(Universidad g,Alumno a)
        {
            foreach (Alumno i in g.alumnos)
            {
                if (i == a)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del !=
        /// </summary>
        /// <param name="g">objeto de tipo universidad</param>
        /// <param name="a">objeto de tipo alumno</param>
        /// <returns>retorna si el alumno no pertenece a la lista de alumnos de la universidad o si</returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Sobrecarga del ==
        /// </summary>
        /// <param name="g">objeto de tipo universidad</param>
        /// <param name="clase">objeto de tipo EClase</param>
        /// <returns>retorna si la universidad tiene profesor para esa clase o no</returns>
        public static Profesor operator ==(Universidad g, EClases clase)
        {
            foreach (Profesor i in g.profesores)
            {
                if (i == clase)
                {
                    return i;
                }
            }
            throw new SinProfesorException();

        }

        /// <summary>
        /// Sobrecarga del !=
        /// </summary>
        /// <param name="g">objeto de tipo universidad</param>
        /// <param name="clase">objeto de tipo EClase</param>
        /// <returns>retorna si la universidad no tiene profesor para esa clase o si</returns>
        public static Profesor operator !=(Universidad g, EClases clase)
        {
            foreach (Profesor i in g.profesores)
            {
                if (i != clase)
                {
                    return i;
                }
            }
            throw new SinProfesorException();
        }

        /// <summary>
        /// sobrecarga del ==
        /// </summary>
        /// <param name="g">objeto de tipo universidad</param>
        /// <param name="i">objeto de tipo profesor</param>
        /// <returns>retorna si existe ese profesor en la universidad o no</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor p in g.profesores)
            {
                if (p == i)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del !=
        /// </summary>
        /// <param name="g">objeto de tipo universidad</param>
        /// <param name="i">objeto de tipo profesor</param>
        /// <returns>retorna si no existe el profesor en la universidad o si</returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// Sobrecarga del +,suma el alumno a la universidad si no se encuentra en la misma
        /// </summary>
        /// <param name="g">objeto de tipo universidad</param>
        /// <param name="a">objeto de tipo alumno</param>
        /// <returns>retorna un objeto de tipo universidad</returns>
        public static Universidad operator +(Universidad g, Alumno a)
        {
            if (g != a)
            {
                g.alumnos.Add(a);
                return g;

            }


            else
                throw new AlumnoRepetidoException();
               
            
            
        }

        /// <summary>
        /// sobrecarga del +
        /// </summary>
        /// <param name="g">objeto de tipo universidad</param>
        /// <param name="clase">objeto de tipo EClase</param>
        /// <returns>retorna un objeto de tipo universidad</returns>
        public static Universidad operator +(Universidad g, Universidad.EClases clase)
        {
            //areglar este
            Profesor a;

            try
            {
                a = g == clase;
                Jornada jorn = new Jornada(clase, a);

                foreach (Alumno i in g.alumnos)
                {
                    if (i == clase)
                    {
                        jorn = jorn + i;
                    }
                }

                g.jornada.Add(jorn);

            }

            catch(SinProfesorException b)
            {
                throw b;
            }

            catch(Exception b)
            {
                throw new Exception(b.Message);
            }

            return g;

        }

        /// <summary>
        /// Sobrecarga del +.suma el profesor a la universidad si no se encuentra en la misma
        /// </summary>
        /// <param name="g">objeto tipo universidad</param>
        /// <param name="i">objeto tipo profesor</param>
        /// <returns>retorna un objeto de tipo universidad</returns>
        public static Universidad operator +(Universidad g, Profesor i)
        {
            if (g != i)
            {
                g.profesores.Add(i);
                
            }

            return g;
        }

        /// <summary>
        /// Sobrecarga del ToString
        /// </summary>
        /// <returns>retorna un string conteniendo los datos de la universidad</returns>
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }
        #endregion


        #region enumerado
        public enum EClases { Programacion, Laboratorio, Legislacion, SPD }
        #endregion




    }
}
