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
    internal class CategoriaRepository : BaseRepository, ICategoriaModelRepository
    {
        public void Add(CategoriasModel categoriaModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Category (id, name, description) " +
                                    "VALUES (@id, @name, @description)";

                command.Parameters.Add("@id", SqlDbType.Int).Value = categoriaModel.id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoriaModel.name;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = categoriaModel.description;

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
                command.CommandText = "DELETE FROM Category WHERE id = @id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CategoriasModel categoriaModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Category SET name = @name, description = @description WHERE id = @id";

                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoriaModel.name;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = categoriaModel.description;
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoriaModel.id;

                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoriasModel> GetAll()
        {
            var categoryList = new List<CategoriasModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Category ORDER BY id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModel = new CategoriasModel();
                        categoryModel.id = (int)reader["id"];
                        categoryModel.name = reader["name"].ToString();
                        categoryModel.description = reader["description"].ToString();
                        categoryList.Add(categoryModel);
                    }
                }
            }
            return categoryList;
        }

        public IEnumerable<CategoriasModel> GetByValue(string value)
        {
            var categoryList = new List<CategoriasModel>();
            int categoryId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categoryName = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Category
                              WHERE id = @id OR name LIKE @name + '%'
                              ORDER BY id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoryId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoryName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModel = new CategoriasModel();
                        categoryModel.id = (int)reader["id"];
                        categoryModel.name = reader["name"].ToString();
                        categoryModel.description = reader["description"].ToString();
                        categoryList.Add(categoryModel);
                    }
                }
            }
            return categoryList;
        }
    }
}
