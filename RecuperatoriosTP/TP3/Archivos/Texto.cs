using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;
using EntidadesAbstractas;


namespace Archivos
{
    public class Texto:IArchivo<string>
    {

        #region Metodos
        /// <summary>
        /// Metodo para guardar un texto
        /// </summary>
        /// <param name="archivo">recibe un string archivo</param>
        /// <param name="datos">recibe un string llamado datos</param>
        /// <returns>retorna un booleano,indicando si se guardo o no</returns>
        public bool Guardar(string archivo,string datos)
        {
            try
            {
                using(StreamWriter s = new StreamWriter(archivo,true))
                {
                    s.WriteLine(datos);
                }
                return true;


            }
            catch(Exception a)
            {
                throw new ArchivosException(a);

            }
        }

        /// <summary>
        /// Metodo para leer un texto
        /// </summary>
        /// <param name="archivo">recibe un string llamado archivo</param>
        /// <param name="datos">recibe un string llamado datos</param>
        /// <returns></returns>
        public bool Leer(string archivo, out string datos)
        {
            string Leido;
            StringBuilder stringbuilder = new StringBuilder();

            try
            {
                using (StreamReader s = new StreamReader(archivo))
                {
                    while ((Leido = s.ReadLine()) != null)
                    {
                        stringbuilder.AppendLine(Leido);
                    }
                }
                datos = stringbuilder.ToString();
                return true;

            }
            catch(Exception a)
            {
                throw new ArchivosException(a);
            }



        #endregion

        }


    }
}
