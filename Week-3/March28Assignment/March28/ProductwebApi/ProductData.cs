using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using ProductwebApi.models;

namespace ProductwebApi
{
   public class ProductData : IProduct
    {

        private readonly ProductContext _context;




        public ProductData(ProductContext context)
        {
              _context = context;
        }






        public async Task<List<Product>> GetAll()
        {
            var list = await _context.Products.ToListAsync();
            return list;
        }







        public async Task<Product> AddProduct(CreateProductDto productDto)
        {
            var product = new Product
            {
                Name = productDto.Name,
                Price = productDto.Price,
                Category = productDto.Category,
            };



               await _context.Products.AddAsync(product);
               await _context.SaveChangesAsync();
               return product;
        }









        public async Task<Product> DeleteProduct(int id)
        {
            var deleted = await _context.Products.FindAsync(id);
            if (deleted == null)
            {
                return null;
            }
            _context.Products.Remove(deleted);
            await _context.SaveChangesAsync();
            return deleted;
        }






        

        public async Task<Product> UpdateProduct(int id, UpdateProductDto updateDto)
        {
            var existing = await _context.Products.FindAsync(id);
            if (existing == null) {
                return null;
            }
            existing.Name = updateDto.Name=="" || updateDto.Name=="string"|| updateDto.Name == null? existing.Name:updateDto.Name;
            existing.Price = updateDto.Price== 0 || updateDto.Price ==null? existing.Price: updateDto.Price;
            existing.Category = updateDto.Category==""|| updateDto.Category=="string"|| updateDto.Category==null? existing.Category: updateDto.Category;

            await _context.SaveChangesAsync();
            return existing;
        }






    }
}
