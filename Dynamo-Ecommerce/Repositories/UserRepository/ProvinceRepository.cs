using Dynamo_Ecommerce.DTOs.User.Province;
using Dynamo_Ecommerce.Repositories.Interfaces.User;
using Npgsql;

namespace Dynamo_Ecommerce.Repositories.UserRepository
{
    public class ProvinceRepository : IProvinceRepository
    {
        IEnumerable<ProvinceResponseDTO> IProvinceRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        ProvinceResponseDTO IProvinceRepository.GetProvinceById(int id)
        {
            ProvinceResponseDTO response = null;

            return response;
        }
    }
}
