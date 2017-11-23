using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException:Exception
    {
        #region atributores
        private static string mensajeBase = "DNI Invalido";
        #endregion

        #region constructores
        public DniInvalidoException():base(mensajeBase)
        {

        }

        //a este le falta
        public DniInvalidoException(Exception e):base(mensajeBase,e)
        {
             
        }

        public DniInvalidoException(string message):base(message)
        {

        }

        public DniInvalidoException(string message, Exception e):base(message,e)
        {

        }
        #endregion

    }
}
