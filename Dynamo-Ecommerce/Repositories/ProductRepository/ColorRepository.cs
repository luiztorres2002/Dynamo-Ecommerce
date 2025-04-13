using Dynamo_Ecommerce.Models.Product;
using Dynamo_Ecommerce.Repositories.Interfaces.Product;
using Npgsql;
using System.Drawing;

namespace Dynamo_Ecommerce.Repositories.ProductRepository
{
    public class ColorRepository : IColorRepository
    {

        private readonly string _connectionString;

        public ColorRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        public Models.Product.Color GetColorById(int Id)
        {
            using(var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT id,name_ FROM product.\"Category\" where id = @id";

                using(var command = new NpgsqlCommand(sql, connection)) 
                {
                    command.Parameters.AddWithValue("id", Id);

                    using(var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var color = new Models.Product.Color()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                Name = reader.GetString(reader.GetOrdinal("name_"))
                            };

                            return color;
                        }
                        else
                        {
                            throw new Exception("No se ha encontrado un color con el id: " + Id);
                        }
                    }

                }
            }
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Product.Color> GetColors()
        {
            var colors = new List<Models.Product.Color>();  
            using(var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT id,name_ FROM product.\"Category\"";

                using(var command = new NpgsqlCommand(sql, connection))
                {
                    using(var reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            var color = new Models.Product.Color()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                Name = reader.GetString(reader.GetOrdinal("name_"))
                            };
                            colors.Add(color);
                        }
                    }
                }
            }

            return colors;
        }
    }
}
