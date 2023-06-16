using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Truco
{
    public class ExcepcionConectar : Exception
    {
        public ExcepcionConectar() : base("Ocurrió un error al conectarse a la base de datos. Intente nuevamente.")
        {

        }
    }
}
