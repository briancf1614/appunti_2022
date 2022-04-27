using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassePersona
{
    class Persona
    {
        public string Nome{ get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string LuogoNascita { get; set; }
        public Sesso Sesso { get; set; }

        public Persona()
        {           
        }

        public Persona(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;            
        }

        public Persona(string nome, string cognome, DateTime dataNascita, string luogoNascita) : this(nome, cognome)
        {
            DataNascita = dataNascita;
            LuogoNascita = luogoNascita;
        }

        public Persona(string nome, string cognome, DateTime dataNascita, string luogoNascita, Sesso sesso) : this(nome, cognome, dataNascita, luogoNascita)
        {
            Sesso = sesso;
        }

        public int Eta() {

            DateTime oggi = DateTime.Now;
                        
            int e = oggi.Year - DataNascita.Year;
            if ((DataNascita.Month > oggi.Month) || (DataNascita.Month == oggi.Month && DataNascita.Day > oggi.Day))
                e--;
            return e;

        }

        public override string ToString()
        {
            return $"{{{nameof(Nome)}={Nome}" +
                $", {nameof(Cognome)}={Cognome}" +
                $", {nameof(DataNascita)}={DataNascita}" +
                $", {nameof(LuogoNascita)}={LuogoNascita}" +
                $", {nameof(Sesso)}={Sesso.ToString()}" +
                $", {nameof(Eta)}={Eta().ToString()}}}";
        }
    }
}
