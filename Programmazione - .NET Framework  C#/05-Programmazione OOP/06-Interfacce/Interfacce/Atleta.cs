using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacce
{
    class Atleta:IAtleta,ITennista,INuotatore,IAtletaUniversale
    {
        public string Nominativo { get; set; }
        public string Disciplina { get; set; }
        public int Pettorina { get; set; }

        public string Bevo()
        {
            return "Sto bevendo ...";
        }

        public string Corro()
        {
            return "Sto correndo ...";
        }

        public string Dorso()
        {
            return "Sto nuotando a dorso ...";
        }

        public string Dritto()
        {
            return "Sto tirando di dritto ...";
        }

        public string Mangio()
        {
            return "Sto mangiando ...";
        }

        public string Rana()
        {
            throw new NotImplementedException();
        }

        public string Rovescio()
        {
            return "Sto tirando di rovescio ...";
        }

        public string Salto()
        {
            return "Sto saltando ...";
        }

        public override string ToString()
        {
            return $"{{{nameof(Nominativo)}={Nominativo}, {nameof(Disciplina)}={Disciplina}, {nameof(Pettorina)}={Pettorina.ToString()}}}";
        }
    }
}
