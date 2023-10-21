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
    internal class ProductModeRepository : BaseRepository, IProductModeRepository
    {
        public void Add(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Products (name, price, stock, category_id) " +
                                    "VALUES (@name, @price, @stock, @category_id)";

                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.name;
                command.Parameters.Add("@price", SqlDbType.Decimal).Value = productModel.price;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productModel.stock;
                command.Parameters.Add("@category_id", SqlDbType.Int).Value = productModel.category_id;

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
                command.CommandText = "DELETE FROM Products WHERE id = @id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Products SET name = @name, price = @price, stock = @stock, category_id = @category_id WHERE id = @id";

                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.name;
                command.Parameters.Add("@price", SqlDbType.Decimal).Value = productModel.price;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productModel.stock;
                command.Parameters.Add("@category_id", SqlDbType.Int).Value = productModel.category_id;
                command.Parameters.Add("@id", SqlDbType.Int).Value = productModel.id;

                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Products ORDER BY id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.id = (int)reader["id"];
                        productModel.name = reader["name"].ToString();
                        productModel.price = (int)reader["price"];
                        productModel.stock = (int)reader["stock"];
                        productModel.category_id = (int)reader["category_id"];
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }

        public IEnumerable<ProductModel> GetByValue(string value)
        {
            var productList = new List<ProductModel>();
            int productId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productName = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Products
                             WHERE id = @id OR name LIKE @name + '%'
                             ORDER BY id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.id = (int)reader["id"];
                        productModel.name = reader["name"].ToString();
                        productModel.price = (int)reader["price"];
                        productModel.stock = (int)reader["stock"];
                        productModel.category_id = (int)reader["category_id"];
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }
    }
}
