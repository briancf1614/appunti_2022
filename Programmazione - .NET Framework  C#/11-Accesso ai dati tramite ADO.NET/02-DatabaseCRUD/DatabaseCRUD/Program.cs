using System;

namespace DatabaseCRUD
{
    class Program
    {
        static void Main(string[] args)
        {            
            string menu = "\n\nScegli una delle seguenti operazioni:" +
                "\n1 - Visualizza tutti i dati" +
                "\n2 - Nuovo studente" +
                "\n3 - Modifica studente" +
                "\n4 - Elimina studente" +
                "\n5 - Cerca studenti per classe" +
                "\n0 - Esci";
            
            DAL dal = new DAL();

            int scelta;
            do
            {
                Console.WriteLine(menu);
                Console.Write("\nScelta: ");
                scelta = Convert.ToInt32(Console.ReadLine());
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Elenco studenti\n"+string.Join("\n",dal.Elenco())); 
                        break;
                    case 2:
                        var studente = new Studente();
                        Console.Write("Matricola: ");
                        studente.Matricola = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nome: ");
                        studente.Nome = Console.ReadLine();
                        Console.Write("Cognome: ");
                        studente.Cognome = Console.ReadLine();
                        Console.Write("Email: ");
                        studente.Email = Console.ReadLine();
                        Console.Write("Classe: ");
                        studente.Classe = Console.ReadLine();
                        if (dal.Nuovo(studente))
                            Console.WriteLine("Operazione eseguita con successo");
                        else
                            Console.WriteLine("Operazione fallita");                        
                        break;

                    case 3:
                        Console.WriteLine("Non disponibile");
                        break;

                    case 4:
                        Console.Write("Matricola: ");
                        var matricola = Convert.ToInt32(Console.ReadLine());
                        
                        if (dal.Elimina(matricola))
                            Console.WriteLine("Operazione eseguita con successo");
                        else
                            Console.WriteLine("Operazione fallita");
                        break;

                    case 5:                                                
                        Console.Write("Classe: ");
                        var classe = Console.ReadLine();
                        
                        Console.WriteLine("Elenco studenti per classe\n" + string.Join("\n", dal.ElencoPerClasse(classe)));
                        break;
                    case 0: Console.WriteLine("Programma terminato"); break;

                    default:Console.WriteLine("Scelta non valida");break;
                }
            } while (scelta!=0);

        }
    }
}
