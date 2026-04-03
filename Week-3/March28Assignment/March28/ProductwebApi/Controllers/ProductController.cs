using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductwebApi.models;

namespace ProductwebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProduct _productdata;

        public ProductController(IProduct productdata) { 
               _productdata = productdata;
        }



        [HttpGet]
        public async Task<ActionResult<List<Product>>> getallproducts()
        {
           var prodlist =  await _productdata.GetAll();
            return Ok(prodlist);
        }





        [HttpPost]
        public async Task<ActionResult<Product>> AddingProduct(CreateProductDto productDto) {
            if (!ModelState.IsValid)
            {
                return BadRequest("invalid data");
            }
            var added = await _productdata.AddProduct(productDto);
            return Ok(added);

        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> Update(int id,UpdateProductDto productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("invalid data");
            }
            var updated = await _productdata.UpdateProduct(id, productDto);
            if (updated == null)
            {
                return NotFound("product not present");
            }
            return Ok(updated);
        }




        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>>Delete(int id)
        {
            var deleted = await _productdata.DeleteProduct(id);
            return Ok(deleted);
        }



    }
}
