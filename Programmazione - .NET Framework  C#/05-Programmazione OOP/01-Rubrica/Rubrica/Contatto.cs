using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubrica
{
    class Contatto
    {
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public Indirizzo Indirizzo { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Contatto(string cognome, string nome)
        {
            Cognome = cognome;
            Nome = nome;
        }

        public Contatto(string cognome, string nome, Indirizzo indirizzo, string telefono, string email)
        {
            Cognome = cognome;
            Nome = nome;
            Indirizzo = indirizzo;
            Telefono = telefono;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Cognome} {Nome}" +
                (Indirizzo!=null ? $" - {Indirizzo}" : "") +
                (!string.IsNullOrEmpty(Telefono) ? $" Tel. {Telefono}" : "") +
                (!string.IsNullOrEmpty(Email) ? $", email: {Email}" : "")
                ;
        }
    }
}
