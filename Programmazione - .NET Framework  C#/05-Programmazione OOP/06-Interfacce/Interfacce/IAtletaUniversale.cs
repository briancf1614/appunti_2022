using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacce
{
    interface IAtletaUniversale:IAtleta,ITennista,INuotatore
    {
        string Mangio();
        string Bevo();

    }
}
