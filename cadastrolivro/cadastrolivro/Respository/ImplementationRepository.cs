using Microsoft.Extensions.Configuration;
using System.Data;
using System.IO;
using System;
using System.Data.SqlClient;

namespace cadastrolivro.Respository
{
    public class ImplementationRepository
    { 

        public ImplementationRepository()
        {
        }

        //Se a conexão for bem sucedida, retornará um dataset, senão retornará 0 para connectionSucess
        public (int connectionSuccess, DataTable data) ExecuteGet(string procedureName, SqlParameter[] parameters)
        {

            DataTable dataSet = new DataTable();


            SqlConnection connection = TryConnection();
            if (connection != null)
            {
                try
                {
                    try { connection.Open(); } catch { return (0, default); }

                    SqlCommand command = new SqlCommand(procedureName, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataSet);

                }
                catch (Exception ex)
                {

                    Console.WriteLine("Ocorreu um erro: " + ex.Message);

                }
                finally
                {
                    connection.Close();
                }

                return (1, dataSet);
            }
            return (0, null);

        }

        //Se a conexão for bem sucedida, retornará um dataset, senão retornará 0
        public int ExecuteInsert(string procedureName, SqlParameter[] parameters)
        {

            SqlConnection connection = TryConnection();

            if (connection != null)
            {
                try
                {
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception) { return 0; }

                    SqlCommand command = new SqlCommand(procedureName, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    int rowsAffected = command.ExecuteNonQuery();
                    return 1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro: " + ex.Message);
                    return -1;
                }
                finally
                {
                    connection.Close();
                }
            }
            return 0;
        }

        //Se a conexão for bem sucedida, retornará um dataset, senão retornará 0
        public int ExecuteDelete(string procedureName, SqlParameter[] parameters)
        {

            SqlConnection connection = TryConnection();

            if (connection != null)

            {
                try
                {
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception) { return 0; }

                    SqlCommand command = new SqlCommand(procedureName, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    return 1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return -1;
                }
                finally
                {
                    connection.Close();
                }
            }
            return 0;
        }

        //Se a conexão for bem sucedida, retornará um dataset, senão retornará 0
        public int ExecuteDeleteById(string procedureName, int id)
        {

            SqlConnection connection = TryConnection();

            if (connection != null)

            {
                try
                {
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception) { return 0; }

                    SqlCommand command = new SqlCommand(procedureName, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@Id", id));
                    command.ExecuteNonQuery();
                    return 1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return -1;
                }
                finally
                {
                    connection.Close();
                }
            }
            return 0;
        }

        private static string GetConnection()
        {
            IConfigurationRoot _configuration = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json")
           .Build();
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            return connectionString;
        }

        //Método que tenta conectar e se ocorrer tudo corretamente será retornado a sqlConnection
        private static SqlConnection TryConnection()
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                return sqlConnection;
            }
            catch
            {
                return null;
            }
        }
}
}
