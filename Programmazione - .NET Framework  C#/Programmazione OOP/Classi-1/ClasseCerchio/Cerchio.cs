using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseCerchio
{
    class Cerchio
    {
        //attributo o campo
        private double _raggio;

        //proprietà
        public double Raggio
        {
            get { return _raggio; }
            set { _raggio = value; }
        }

        //metodi
        public double Diametro()
        {
            return 2 * _raggio;
        }

        public double Circonferenza()
        {
            return Math.PI * Diametro();
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Raggio, 2);
        }

        public override string ToString()
        {
            return $"Raggio: {Raggio}" +
                $", Diametro: {Diametro()}" +
                $", Circonferenza: {Circonferenza()}" +
                $", Area: {Area()}";
        }


    }
}
