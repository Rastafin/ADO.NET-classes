using DataAccess.Data;
using DataAccess.Models;
using DataAccess.Models.Enums;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ProductRepository() : IProductRepository
    {
        private readonly DbConnectionFactory _connectionFactory = new DbConnectionFactory();


        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM Products";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Products");

                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {
                            int id = (int)row["Id"];
                            string Name = (string)row["Name"];
                            decimal Price = (decimal)row["Price"];
                            int StockQuantity = (int)row["StockQuantity"];

                            Product product = new Product(id, Name, Price, StockQuantity);
                            products.Add(product);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to get all products. " + ex.Message);
            }

            return products;

        }

        public Product GetProduct(int productId)
        {
            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM Products WHERE Id = @ProductId";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ProductId", productId);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Product");

                        if (dataSet.Tables["Product"]!.Rows.Count > 0)
                        {
                            DataRow row = dataSet.Tables["Product"]!.Rows[0];

                            int id = (int)row["Id"];
                            string name = (string)row["Name"];
                            decimal price = (decimal)row["Price"];
                            int stockQuantity = (int)row["StockQuantity"];

                            return new Product(id, name, price, stockQuantity);
                        }
                        else
                        {
                            throw new Exception($"Product with Id: {productId} cannot be found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while trying to get product with id: {productId}. " + ex.Message);
            }
        }
            
        public List<Product> GetAllAvailableProducts()
        {
            List<Product> products = new List<Product>();

            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM Products WHERE StockQuantity > 0";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Products");

                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {
                            int id = (int)row["Id"];
                            string Name = (string)row["Name"];
                            decimal Price = (decimal)row["Price"];
                            int StockQuantity = (int)row["StockQuantity"];

                            Product product = new Product(id, Name, Price, StockQuantity);
                            products.Add(product);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to get all available products. " + ex.Message);
            }

            return products;
        }

        public void AddProduct(Product product)
        {

            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM PRODUCTS";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Products");

                        DataRow newRow = dataSet.Tables[0].NewRow();
                        newRow["Name"] = product.Name;
                        newRow["Price"] = product.Price;
                        newRow["StockQuantity"] = product.StockQuantity;

                        dataSet.Tables[0].Rows.Add(newRow);

                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                        adapter.Update(dataSet, "Products");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to add new product. " + ex.Message);
            }


        }
        public void UpdateProduct(Product product)
        {

            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {

                    connection.Open();
                    string query = "SELECT * FROM PRODUCTS WHERE Id = @Id";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", product.Id);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Products");

                        if (dataSet.Tables["Products"]!.Rows.Count==1)
                        {
                            DataRow dataRow = dataSet.Tables["Products"]!.Rows[0];
                            dataRow["Name"] = product.Name;
                            dataRow["Price"] = product.Price;
                            dataRow["StockQuantity"] = product.StockQuantity;

                            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                            adapter.Update(dataSet, "Products");

                        }
                        else
                        {
                            throw new Exception("Customer with specified ID not found.");
                        }

                    }

                }

            }
            catch(Exception ex)
            {

                throw new Exception("An error occurred while trying to update customer. " + ex.Message);
            }
        }

        public void DeleteProduct(int productId)
        {
            try
            {
                using (var connection = _connectionFactory.CreateConnection())
                {
                    connection.Open();

                    string query = "SELECT * FROM Products WHERE Id= @Id ";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", productId);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Products");


                        if (dataSet.Tables["Products"]!.Rows.Count == 1)
                        {
                            dataSet.Tables["Products"]!.Rows[0].Delete();

                            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                            adapter.Update(dataSet, "Products");
                        }
                        else
                        {
                            throw new Exception("Product with specified ID not found.");
                        }



                    }


                }

            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while trying to delete product." + ex.Message);
            }
        }
    }
}
