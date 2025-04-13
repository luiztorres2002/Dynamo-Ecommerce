using Dynamo_Ecommerce.DTOs.Product.Category;
using Dynamo_Ecommerce.Models.Product;

namespace Dynamo_Ecommerce.Repositories.Interfaces.Product
{
    public interface ICategoryRepository
    {
        public CategoryResponseDTO GetCategory(int id);
        public CategoryResponseDTO GetCategoryByName(string name); 
        public IEnumerable<CategoryResponseDTO> GetAllCategories();
    }
}
