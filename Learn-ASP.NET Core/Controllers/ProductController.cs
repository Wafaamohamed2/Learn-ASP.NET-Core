using Learn_ASP.NET_Core.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Learn_ASP.NET_Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        // CRUD Operations for Products

        private readonly ApplicationDbContext _dbContext;
        public ProductController(ApplicationDbContext dbContext) // Dependency Injection
        {
            _dbContext = dbContext;
        }
        [HttpPost] // Create
        public async Task<ActionResult<int>> CreateProduct(Products product)
        {
            product.Id = 0;
            _dbContext.Set<Products>().Add(product);
            await _dbContext.SaveChangesAsync();
            return Ok(product.Id);
        }

        [HttpPut] // Update

        public async Task<ActionResult> UpdateProduct(Products product)
        {
           var exist_product = await _dbContext.Set<Products>().FindAsync(product.Id);
            if(exist_product == null)
              {
                return NotFound();
              }
            exist_product.Name = product.Name;
            exist_product.SKu = product.SKu;
            _dbContext.Set<Products>().Update(exist_product);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]   // Delete

        [Route("{id}")] // Route parameter nestead of query parameter
        public async Task<ActionResult> DeleteProduct(int id)
        {
            var exist_product = await _dbContext.Set<Products>().FindAsync(id);
            if(exist_product == null)
              {
                return NotFound();
              }
            _dbContext.Set<Products>().Remove(exist_product);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("Products")] // Read all products


        public async Task<ActionResult<IEnumerable<Products>>> GetProducts()
        {
            var products = await _dbContext.Set<Products>().ToListAsync(); // استخدام await مع ToListAsync
            return Ok(products);
        }

        [HttpGet("Products/{id}")] // Read a single product
        public async Task<ActionResult<Products>> GetProduct(int id)
        {
            var product = await _dbContext.Set<Products>().FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
