using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DatabaseCRUD
{
    class DAL
    {
        //accesso al database
        private SqlConnectionStringBuilder connection;

        public DAL()
        {
            connection = new SqlConnectionStringBuilder();
            connection.DataSource = "localhost";
            connection.InitialCatalog = "Anagrafica";
            connection.UserID = "sa";
            connection.Password = "Its-2022";
        }

        //visualizzare un elenco di dati
        public List<Studente> Elenco()
        {
            var lista = new List<Studente>();

            using(SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connection.ConnectionString;
                sqlConnection.Open();

                using(SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "Select * from Studenti";
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.Connection = sqlConnection;

                    using (SqlDataReader sdr = sqlCommand.ExecuteReader()) {

                        while (sdr.Read())
                            lista.Add(
                                new Studente
                                {
                                    Matricola = sdr.GetInt32("Matricola"),
                                    Nome = sdr.GetString("Nome"),
                                    Cognome = sdr.GetString("Cognome"),
                                    Email = sdr.GetString("Email"),
                                    Classe = sdr.GetString("Classe")
                                });
                    }

                }
            }
            return lista;
        }

        public Studente Dettaglio(int matricola)
        {
            Studente studente = null;

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connection.ConnectionString;
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "Select * from Studenti WHERE Matricola=@Matricola";
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.Add("@Matricola", SqlDbType.Int).Value = matricola;
                    sqlCommand.CreateParameter();

                    using (SqlDataReader sdr = sqlCommand.ExecuteReader())
                    {

                        while (sdr.Read())
                            studente = new Studente
                            {
                                Matricola = sdr.GetInt32("Matricola"),
                                Nome = sdr.GetString("Nome"),
                                Cognome = sdr.GetString("Cognome"),
                                Email = sdr.GetString("Email"),
                                Classe = sdr.GetString("Classe")
                            };
                    }

                }
            }
            return studente;
        }

        //inserire un nuovo record
        public bool Nuovo(Studente studente) {
            
            int rows = 0;

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connection.ConnectionString;
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "INSERT INTO Studenti VALUES(@Matricola,@Nome,@Cognome,@Email,@Classe)";
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.Add("@Matricola", SqlDbType.Int).Value = studente.Matricola;
                    sqlCommand.Parameters.Add("@Nome", SqlDbType.VarChar, 50).Value = studente.Nome;
                    sqlCommand.Parameters.Add("@Cognome", SqlDbType.VarChar, 50).Value = studente.Cognome;
                    sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = studente.Email;
                    sqlCommand.Parameters.Add("@Classe", SqlDbType.VarChar, 50).Value = studente.Classe;
                    sqlCommand.CreateParameter();

                    rows = sqlCommand.ExecuteNonQuery();                  

                }
            }
            return rows == 1;
        }

        //modificare un record
        public bool Modifica(Studente studente)
        {

            int rows = 0;

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connection.ConnectionString;
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "UPDATE Studenti SET Nome=@Nome, Cognome=@Cognome, Email=@Email, Classe=@Classe WHERE Matricola=@Matricola";
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.Add("@Matricola", SqlDbType.Int).Value = studente.Matricola;
                    sqlCommand.Parameters.Add("@Nome", SqlDbType.VarChar, 50).Value = studente.Nome;
                    sqlCommand.Parameters.Add("@Cognome", SqlDbType.VarChar, 50).Value = studente.Cognome;
                    sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = studente.Email;
                    sqlCommand.Parameters.Add("@Classe", SqlDbType.VarChar, 50).Value = studente.Classe;
                    sqlCommand.CreateParameter();

                    rows = sqlCommand.ExecuteNonQuery();

                }
            }
            return rows == 1;
        }
        //eliminare un record
        public bool Elimina(int matricola)
        {

            int rows = 0;

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connection.ConnectionString;
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "DELETE FROM Studenti WHERE Matricola=@Matricola";
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.Add("@Matricola", SqlDbType.Int).Value = matricola;
                    sqlCommand.CreateParameter();

                    rows = sqlCommand.ExecuteNonQuery();

                }
            }
            return rows == 1;
        }

        //cercare un elenco per classe
        public List<Studente> ElencoPerClasse(string classe)
        {
            var lista = new List<Studente>();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connection.ConnectionString;
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "Select * from Studenti WHERE Classe=@Classe";
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.Add("@Classe", SqlDbType.VarChar, 50).Value = classe;
                    sqlCommand.CreateParameter();

                    using (SqlDataReader sdr = sqlCommand.ExecuteReader())
                    {

                        while (sdr.Read())
                            lista.Add(
                                new Studente
                                {
                                    Matricola = sdr.GetInt32("Matricola"),
                                    Nome = sdr.GetString("Nome"),
                                    Cognome = sdr.GetString("Cognome"),
                                    Email = sdr.GetString("Email"),
                                    Classe = sdr.GetString("Classe")
                                });
                    }

                }
            }
            return lista;
        }
    }
}
