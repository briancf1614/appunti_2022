using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GuiProdottiToObjects
{
    class MyLibrary
    {
        //metodi statici per gestire file di oggetti e di testo

        public static void ScriviOggetti(string path, List<Prodotto> lista)
        {
            FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(file, lista);

            file.Close();
        }

        public static List<Prodotto> LeggiOggetti(string path)
        {
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);

            BinaryFormatter bf = new BinaryFormatter();

            var lista = (List<Prodotto>)bf.Deserialize(file);

            file.Close();

            return lista;
        }

    }
}
