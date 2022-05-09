using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacce
{
    class Calciatore:Atleta,ICloneable,IComparable
    {
        public string Squadra { get; set; }
        public int PartiteGiocate { get; set; }
        public int GoalSegnati { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            // 1 - se this è maggiore obj 
            // -1 - se this è minore di obj
            Calciatore other;
            if (obj is Calciatore) {
                other = (Calciatore)obj;

                if (this.MediaGoalSegnati() > other.MediaGoalSegnati())
                    return 1;
                else if (this.MediaGoalSegnati() < other.MediaGoalSegnati())
                    return -1;
                    }
            return 0; //tutte quanto non contemplato
        }

        public override bool Equals(object obj)
        {
            return obj is Calciatore calciatore &&
                   Nominativo == calciatore.Nominativo &&
                   Disciplina == calciatore.Disciplina &&
                   Pettorina == calciatore.Pettorina &&
                   Squadra == calciatore.Squadra &&
                   PartiteGiocate == calciatore.PartiteGiocate &&
                   GoalSegnati == calciatore.GoalSegnati;
        }                

        public double MediaGoalSegnati() {
            return (double)GoalSegnati / PartiteGiocate;
        }

        public override string ToString()
        {
            return $"{{" + base.ToString() +
                $", {nameof(Squadra)}={Squadra}" +
                $", {nameof(PartiteGiocate)}={PartiteGiocate.ToString()}" +
                $", {nameof(GoalSegnati)}={GoalSegnati.ToString()}" +
                $", Media Goal Segnati={MediaGoalSegnati()}}}";
        }
    }
}
