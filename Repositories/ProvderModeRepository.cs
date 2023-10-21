using Microsoft.Data.SqlClient;
using supermarket.Models;
using supermarket.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket.Repositories
{
    internal class ProvderModeRepository : BaseRepository, IProvidersRepository
    {

        public ProvderModeRepository(string conctionString)
        {
            this.connectionString = conctionString;
        }
        public void Add(ProvidersModel providersModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Providers (id, name, description) " +
                                    "VALUES (@id, @name, @description)";

                command.Parameters.Add("@id", SqlDbType.Int).Value = providersModel.id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providersModel.name;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = providersModel.description;

                command.ExecuteNonQuery();
            }
        }
        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Providers WHERE id = @id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProvidersModel providerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Providers SET name = @name, description = @description WHERE id = @id";

                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providerModel.name;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = providerModel.description;
                command.Parameters.Add("@id", SqlDbType.Int).Value = providerModel.id;

                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProvidersModel> GetAllProviders()
        {
            var providerList = new List<ProvidersModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Providers ORDER BY id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providerModel = new ProvidersModel();
                        providerModel.id = (int)reader["id"];
                        providerModel.name = reader["name"].ToString();
                        providerModel.description = reader["description"].ToString();
                        providerList.Add(providerModel);
                    }
                }
            }
            return providerList;
        }
        public IEnumerable<ProvidersModel> GetProvidersByValue(string value)
        {
            var providerList = new List<ProvidersModel>();
            var providerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string providerName = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Providers
                              WHERE id = @id OR name LIKE @name + '%'
                              ORDER BY id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = providerId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providerName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providerModel = new ProvidersModel();
                        providerModel.id = (int)reader["id"];
                        providerModel.name = reader["name"].ToString();
                        providerModel.description = reader["description"].ToString();
                        providerList.Add(providerModel);
                    }
                }
            }
            return providerList;
        }
    }
}
