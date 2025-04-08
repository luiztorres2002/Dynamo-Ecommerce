using Dynamo_Ecommerce.DTOs.User.Province;
using Dynamo_Ecommerce.Models.UserModel;

namespace Dynamo_Ecommerce.Repositories.Interfaces.User
{
    public interface IProvinceRepository
    {
        public ProvinceResponseDTO GetProvinceById(int id);
        public IEnumerable<ProvinceResponseDTO> GetAll(); 

    }
}
