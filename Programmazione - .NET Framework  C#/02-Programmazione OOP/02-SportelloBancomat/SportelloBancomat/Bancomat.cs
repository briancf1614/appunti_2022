using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportelloBancomat
{
    class Bancomat
    {
        public int Banconota50 { get; set; }
        public int Banconota20 { get; set; }
        public int Banconota10 { get; set; }

        public Bancomat(int banconota50, int banconota20, int banconota10)
        {
            Banconota50 = banconota50;
            Banconota20 = banconota20;
            Banconota10 = banconota10;
        }

        public Bancomat(int banconota10) : this(0, 0, banconota10) { }

        public int Totale()
        {
            return Banconota50 * 50 + Banconota20 * 20 + Banconota10 * 10;
        }

        public bool Togli50(int numeroPezziBanconota50)
        {
            if (numeroPezziBanconota50 > Banconota50)
                return false;

            Banconota50 -= numeroPezziBanconota50;
            return true;
        }

        public string[] Prelievo(int cifra)
        {
            string[] msg = new string[4];

            //si calcolano prima i pezzi da 50, poi quelli da 20 e infine quelli da 10
            //esempio cifra = 280
            //banconota50=5
            //banconota20=1
            //banconota10=1

            int banconota50 = 0;
            int banconota20 = 0;
            int banconota10 = 0;

            if (cifra > Totale())
                msg[0] = "Operazione fallita";
            else {

                //numero di pezzi da 50 calcolati
                banconota50 = cifra / 50;

                if (banconota50 > Banconota50)
                {                    
                    banconota50 = Banconota50;                   
                }
                Banconota50 -= banconota50;
                
                //ridefinisco la cifra
                cifra -= banconota50 * 50;

                banconota20 = cifra / 20;

                if (banconota20 > Banconota20)
                {
                    banconota20 = Banconota20;
                }
                Banconota20 -= banconota20;

                cifra -= banconota20 * 20;

                banconota10 = cifra / 10;

                if (banconota10 > Banconota10)
                {
                    banconota10 = Banconota10;
                }
                Banconota10 -= banconota10;

                msg[0] = "Operazione riuscita";
            }

            msg[1] = "Numero pezzi banconota50: " + banconota50;
            msg[2] = "Numero pezzi banconota20: " + banconota20;
            msg[3] = "Numero pezzi banconota10: " + banconota10;

            return msg;
        }

        public override string ToString()
        {
            return $"Totale: {Totale()} euro" +
                $"\nNumero pezzi {nameof(Banconota50)}={Banconota50.ToString()}" +
                $"\nNumero pezzi {nameof(Banconota20)}={Banconota20.ToString()}" +
                $"\nNumero pezzi {nameof(Banconota10)}={Banconota10.ToString()}"
                ;
        }
    }
}