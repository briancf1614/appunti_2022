using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneIndirizzi
{
    abstract class IndirizzoGenerico
    {
        public abstract string GetIndirizzo();

        public override string ToString()
        {
            return GetIndirizzo();
        }
    }
}
