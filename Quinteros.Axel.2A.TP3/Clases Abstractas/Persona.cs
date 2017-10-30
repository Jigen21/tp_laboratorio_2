using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Text.RegularExpressions;


namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        #region atributos
        private string _nombre;
        private string _apellido;
        private ENacionalidad _nacionalidad;
        private int _dni;
        #endregion

        #region propiedades
        public string Apellido { get { return this._apellido; } set {this._apellido=value ;} }

        public int DNI 
        { 
            get { return this._dni; } 
            
            set {

                try
                {
                    this._dni=this.ValidarDni(this._nacionalidad,value);
                }

                catch(DniInvalidoException a)
                {
                    throw new DniInvalidoException(a.Message);
                }

                catch(NacionalidadInvalidaException a)
                {
                    throw new NacionalidadInvalidaException(a.Message);
                }
          
                } 
        
        }

        public ENacionalidad Nacionalidad { get { return this._nacionalidad; } set { this._nacionalidad = value ;} }

        public string Nombre { get { return this._nombre; } set {this._nombre=value ;} }

        public string StringToDni
        {
            set
            {

                try
                {
                    this._dni=this.ValidarDni(this._nacionalidad, value);
                }

                catch (DniInvalidoException a)
                {
                    throw new DniInvalidoException(a.Message);
                }

                catch (NacionalidadInvalidaException a)
                {
                    throw new NacionalidadInvalidaException(a.Message);
                }

            }
       
        }

        #endregion

        #region constructores
        public Persona()
        {

        }

        public Persona(string nombre,string apellido,ENacionalidad nacionalidad)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido,int dni,ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.DNI = dni;
        }

        public Persona(string nombre, string apellido,string dni,ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.StringToDni = dni;
        }

        #endregion

        #region sobrecarga
        public override string ToString()
        {
            StringBuilder a = new StringBuilder();
            //a.AppendLine(this.Nombre);
            a.Append("NOMBRE COMPLETO: " +this.Apellido);
            a.Append(", " + this.Nombre);
            a.Append("\nNACIONALIDAD: " + this._nacionalidad);
            a.Append("\n");
            //a.AppendLine(this.Apellido);
            //a.AppendLine(this.DNI.ToString());
            //a.AppendLine(this.Nacionalidad.ToString());

            return a.ToString();

        }

        #endregion

        #region metodos
        /// <summary>
        /// Metodo para validar un dni que recibe un entero
        /// </summary>
        /// <param name="nacionalidad">recibe una nacionalidad de tipo ENacionalidad</param>
        /// <param name="dato">recibe un entero</param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (nacionalidad == ENacionalidad.Argentino)
            {
                if (dato > 0 && dato < 89999999)
                    return dato;
                else
                    throw new DniInvalidoException("La nacionalidad no se condice con el numero de DNI.");
            }
            else if (dato > 89999999)
                return dato;
            else
                throw new NacionalidadInvalidaException("La nacionalidad no se condice con el numero de DNI.");

        }

        /// <summary>
        /// Metodo para valiar un dni que recibe un string
        /// </summary>
        /// <param name="nacionalidad">recibe una nacionalidad de tipo ENacionalidad</param>
        /// <param name="dato">recibe un string</param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dni;

            if(int.TryParse(dato,out dni))
            {
                if(dni>0)
                {
                    return this.ValidarDni(nacionalidad, dni);
                }
            }
            throw new DniInvalidoException();
        }

        /// <summary>
        /// Metodo para validar nombre y apellido,usando regex
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            
            if (!Regex.Match(dato, "^[A-Z][a-zA-Z]*$").Success)
            {
                return "SinNombreNiApellido";
            }

            return dato;
        }


        public enum ENacionalidad { Argentino, Extranjero }

        #endregion






    }
}
