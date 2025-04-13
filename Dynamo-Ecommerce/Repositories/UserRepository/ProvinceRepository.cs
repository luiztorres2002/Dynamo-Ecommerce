using Dynamo_Ecommerce.DTOs.User.Province;
using Dynamo_Ecommerce.Repositories.Interfaces.User;
using Npgsql;

namespace Dynamo_Ecommerce.Repositories.UserRepository
{
    public class ProvinceRepository : IProvinceRepository
    {

        private readonly string _connectionString;

        public ProvinceRepository(string connectionString)
        {
            _connectionString = connectionString;   
        }


        IEnumerable<ProvinceResponseDTO> IProvinceRepository.GetAll()
        {
            var provinces = new List<ProvinceResponseDTO>();
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT id,name from users.\"province\"";
                using (var command = new NpgsqlCommand(sql, connection))
                {
                   using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var provinceDto = new ProvinceResponseDTO()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                Name = reader.GetString(reader.GetOrdinal("name"))
                            };
                            provinces.Add(provinceDto);
                        }
                    }

                }

            }
            return provinces;
        }

        ProvinceResponseDTO IProvinceRepository.GetProvinceById(int id)
        {
            var province = new ProvinceResponseDTO();
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT id,name from users.\"province\" where id = @id";

                using (var command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("id", id);

                    using(var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var response = new ProvinceResponseDTO()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                Name = reader.GetString(reader.GetOrdinal("name"))
                            };
                        }
                        else
                        {
                            throw new Exception("No se encontró la provincia con el id especificado.");
                        }
                    }
                }
            }


            return province;
        }
    }
}
