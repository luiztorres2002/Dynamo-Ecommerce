namespace Dynamo_Ecommerce.Repositories.Interfaces.Product
{
    public interface ISizeRepository
    {
        public Models.Product.Size GetById(int id);

        public IEnumerable<Models.Product.Size> GetAll();   


    }
}
