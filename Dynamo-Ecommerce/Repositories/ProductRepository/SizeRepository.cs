using Dynamo_Ecommerce.Models.Product;
using Dynamo_Ecommerce.Repositories.Interfaces.Product;
using Npgsql;
using System.Runtime.CompilerServices;

namespace Dynamo_Ecommerce.Repositories.ProductRepository
{
    public class SizeRepository : ISizeRepository
    {

        private readonly string _connectionString;

        public SizeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        public IEnumerable<Size> GetAll()
        {
            throw new NotImplementedException();
        }

        public Size GetById(int id)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT id, name_ FROM product.\"size\" where id = @id";

                using(var comand = new NpgsqlCommand(sql, connection))
                {
                    comand.Parameters.AddWithValue("id", id);
                    using (var reader = comand.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            var size = new Models.Product.Size()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                Name = reader.GetString(reader.GetOrdinal("name_"))
                            };

                            return size;

                        }
                        else
                        {
                            throw new Exception("No se encontro la talla con el id: " + id);
                        }
                    }
                }
            }
        }
    }
}
