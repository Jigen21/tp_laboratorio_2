using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        #region atributos
        private string _archivo;

        #endregion

        #region constructores
        public Texto(string archivo)
        {
            this._archivo = archivo;
        }
        #endregion

        #region metodos
        /// <summary>
        /// Metodo para guardar los datos del historial
        /// </summary>
        /// <param name="datos">recibe los datos que va a escribir</param>
        /// <returns>retorna true si pudo hacerlo</returns>
        public bool guardar(string datos)
        {

            try
            {
                if (File.Exists(this._archivo))
                {
                    StreamWriter arch = new StreamWriter(this._archivo, true);
                    arch.WriteLine(datos);
                    arch.Close();
                }
                else
                {
                    StreamWriter arch = new StreamWriter(this._archivo, false);
                    arch.WriteLine(datos);
                    arch.Close();
                }
                return true;
            }
            catch(Exception e)
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// metodo para leer el archivo del historial
        /// </summary>
        /// <param name="datos">recibe una lista de datos</param>
        /// <returns>retorna true si pudo hacerlo o no</returns>
        public bool leer(out List<string> datos)
        {

            List<string> auxDatos = new List<string>();
            try
            {
                StreamReader arch = new StreamReader(this._archivo);
                while (!(arch.EndOfStream))
                {
                    auxDatos.Add(arch.ReadLine());
                }
                datos=auxDatos;
                return true;

            }
            catch(Exception e)
            {
                throw new NotImplementedException();
            }

        }
        #endregion
    }
}
