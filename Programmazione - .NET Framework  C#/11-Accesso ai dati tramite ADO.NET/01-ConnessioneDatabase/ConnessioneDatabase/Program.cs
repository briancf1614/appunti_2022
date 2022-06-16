using System.Data.SqlClient;
using System;
using System.Data;

namespace ConnessioneDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connessione al database MS SQL Server");

            //creo la stringa di connessione
            SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
            connection.DataSource = "localhost";
            connection.UserID = "sa";
            connection.Password = "Its-2022";
            connection.InitialCatalog = "Anagrafica";

            //connessione al database
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connection.ConnectionString;
            sqlConnection.Open();
            
            Console.WriteLine("Scegli l'iniziale del nome");
            string iniziale = Console.ReadLine();

            //accesso ai dati
            string sql = $"Select * from Studenti where Nome Like '' + @Iniziale + '%'";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = sql;
            sqlCommand.CommandType = CommandType.Text;

            //uso di query parametriche
            sqlCommand.Parameters.Add("@Iniziale", SqlDbType.VarChar, 50).Value = iniziale;
            sqlCommand.CreateParameter();

            SqlDataReader sdr = sqlCommand.ExecuteReader();

            string msg = $"Elenco studenti con iniziale nome {iniziale}";
            while (sdr.Read())
            {
                msg += "\nmatricola: " + sdr.GetInt32("Matricola");
                msg += ", nome: " + sdr.GetString("Nome");
                msg += ", cognome: " + sdr.GetString("Cognome");
                msg += ", email: " + sdr.GetString("Email");
                msg += ", classe: " + sdr.GetString("Classe");
            }

            Console.WriteLine(msg);

            //finalizzo gli oggetti creati per accesso al database
            sdr.Close();
            sqlCommand.Dispose();
            sqlConnection.Close();


            

        }
    }
}
