using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDiscos
{
    public class Edicion
    {
        public string TipoEdicion { get; set; }
        public override string ToString()
        {
            return TipoEdicion;
        }
    }
}
