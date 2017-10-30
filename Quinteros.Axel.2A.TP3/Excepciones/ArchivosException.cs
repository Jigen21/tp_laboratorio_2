using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException:Exception
    {
        #region constructores
        public ArchivosException(Exception innerException):base(innerException.InnerException.Message)
        {

        }
        #endregion


    }
}
