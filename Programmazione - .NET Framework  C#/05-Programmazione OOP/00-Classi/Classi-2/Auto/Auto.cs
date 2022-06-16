using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Auto
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Cilindrata { get; set; }
        public Alimentazione Alimentazione { get; set; }
        public string Colore { get; set; }
        public int Velocita { get; set; }


        public int VelocitaMax()
        {
            int v = Cilindrata / 10;

            switch (Alimentazione)
            {
                case Alimentazione.BENZINA:v += 30;break;
                case Alimentazione.DIESEL: v += 20;break;
                case Alimentazione.GPL: v -= 10;break;
                case Alimentazione.METANO: v -= 30;break;
                default:break;
            }

            return v;
        }

        public void Accelera()
        {
            if (Velocita+10 > VelocitaMax())
                Velocita = VelocitaMax();
            else
                Velocita += 10;
            
        }

        public void Frena() {

            if (Velocita - 5 < 0)
                Velocita = 0;
            else
                Velocita -= 5;
        }

        public override string ToString()
        {
            return $"{{{nameof(Marca)}={Marca}" +
                $", {nameof(Modello)}={Modello}" +
                $", {nameof(Cilindrata)}={Cilindrata.ToString()}" +
                $", {nameof(Alimentazione)}={Alimentazione.ToString()}" +
                $", {nameof(Colore)}={Colore}" +
                $", { nameof(VelocitaMax)}={VelocitaMax()}}}";
        }    
        
    }

    enum Alimentazione
    {
        BENZINA,DIESEL,GPL,METANO
    }
}
