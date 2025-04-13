using Dynamo_Ecommerce.DTOs.Product.Category;
using Dynamo_Ecommerce.Models.Product;
using Dynamo_Ecommerce.Repositories.Interfaces.Product;
using Microsoft.Extensions.Primitives;
using Npgsql;
using System.ComponentModel;

namespace Dynamo_Ecommerce.Repositories.ProductRepository
{
    public class CategoryRepository : ICategoryRepository
    {

        public readonly string _connectionString;

        public CategoryRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<CategoryResponseDTO> GetAllCategories()
        {
            var categories = new List<CategoryResponseDTO>();
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT id, name_, description from product.\"Category\"";
                using (var command = new NpgsqlCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var category = new CategoryResponseDTO()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                Name = reader.GetString(reader.GetOrdinal("name_")),
                                Description = reader.GetString(reader.GetOrdinal("description"))
                            };
                            categories.Add(category);
                        }
                    }
                      
                }
            }

            return categories;
        }

        public CategoryResponseDTO GetCategory(int id)
        {
           
            using(var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT id, name_, description FROM product.\"Category\" where id = @id";

                using (var command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var category = new CategoryResponseDTO()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                Name = reader.GetString(reader.GetOrdinal("name_")),
                                Description = reader.GetString(reader.GetOrdinal("description"))
                            };

                            return category;
                        }
                        else
                        {
                            throw new Exception("No se encontro la categoria especificada");
                        }
                    }
                }
            }
        }

        public CategoryResponseDTO GetCategoryByName(string name)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT id, name_, description FROM product.\"Category\" where name_ = @name";

                using (var command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("name", name);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var category = new CategoryResponseDTO()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                Name = reader.GetString(reader.GetOrdinal("name_")),
                                Description = reader.GetString(reader.GetOrdinal("description"))
                            };

                            return category;
                        }
                        else
                        {
                            throw new Exception("No se encontro el producto con el nombre especificado");
                        }
                    }
                }
            }
        }
    }
}
