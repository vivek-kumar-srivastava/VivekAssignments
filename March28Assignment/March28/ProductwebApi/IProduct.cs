using ProductwebApi.models;

namespace ProductwebApi
{
    public interface IProduct
    {
        public Task<List<Product>> GetAll();
        public Task<Product> AddProduct(CreateProductDto product);
        public Task<Product> UpdateProduct(int id,UpdateProductDto product);
        public Task<Product> DeleteProduct(int id);
    }
}
