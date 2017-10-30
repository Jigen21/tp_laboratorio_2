using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException:Exception
    {
        #region constructores
        public SinProfesorException():base("no hay profesor para la clase")
        {

        }
        #endregion

    }
}
