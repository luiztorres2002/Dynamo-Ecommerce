using Dynamo_Ecommerce.Models.Product;
using System.Drawing;

namespace Dynamo_Ecommerce.Repositories.Interfaces.Product
{
    public interface IColorRepository
    {
        public Models.Product.Color GetColorById(int Id);
        public IEnumerable<Models.Product.Color> GetColors();
    }
}
