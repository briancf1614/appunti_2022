using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GestioneFileOggetti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestione di file binari");

            string path = @"c:\files\oggetti.dat";

            var s1 = new Studente
            {
                Matricola = "124578",
                Nome = "Paolo",
                Cognome = "Esposito",
                Corso = "Fintech Software Developer"
            };

            var s2 = new Studente
            {
                Matricola = "124123",
                Nome = "Alessandro",
                Cognome = "Fenu",
                Corso = "Fintech Software Developer"
            };

            var lista = new List<Studente> { s1, s2 };

            //faccio pulizia
            if (File.Exists(path))
                File.Delete(path);

            //accesso al file di binari in modalità scrittura
            FileStream fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, lista);           

            fs.Close();

            Console.WriteLine("Operazione eseguita con successo");


            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            
            BinaryFormatter br = new BinaryFormatter();

            var elenco = (List<Studente>)br.Deserialize(file);

            file.Close();

            Console.WriteLine("Dati recuperati:\n" + string.Join("\n",elenco));




        }
    }
}
