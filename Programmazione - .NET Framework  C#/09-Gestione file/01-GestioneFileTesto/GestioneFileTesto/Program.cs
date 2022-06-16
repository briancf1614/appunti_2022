using System;
using System.IO;

namespace GestioneFileTesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestione file di testo");

            //file di testo
            string path = @"C:\files\testo.txt";

            //accesso al file di testo in modalità scrittura
            StreamWriter sw = new StreamWriter(path);

            string msg = DateTime.Now.ToString();

            //scrittura su file di testo
            sw.WriteLine(msg);

            sw.Flush(); //salva tutto

            sw.Close();

            Console.WriteLine("Operazione completata con successo");

            Console.WriteLine("\n\nLettura del file");
            //accesso al file di testo in modalità lettura
            StreamReader sr = new StreamReader(path);

            string testo="";

            while (!sr.EndOfStream)
                testo += sr.ReadLine();
            
            sr.Close();

            Console.WriteLine("Testo recuperato: " + testo);


        }
    }
}
