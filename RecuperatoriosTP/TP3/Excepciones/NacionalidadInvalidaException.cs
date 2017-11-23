using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException:Exception
    {
        #region constructores
        public NacionalidadInvalidaException():base()
        {

        }

        public NacionalidadInvalidaException(string message):base(message)
        {

        }
        #endregion
    }
}
