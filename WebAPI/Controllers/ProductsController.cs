using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;
using WebAPI.Data;

namespace WebAPI.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class ProductsController : ControllerBase
        {
        private readonly StoreContext _context;

        public ProductsController(StoreContext context)
            {
            _context = context;
        }
    
            // GET api/products
            [HttpGet("")]
            //asynchronous
            public async Task<ActionResult<List<Product>>> GetProducts(){
                var products= await  _context.Products.ToListAsync();
                return Ok(products);
            }
            //Synchronous
            // public ActionResult<List<Product>> GetProducts(){
            //    var products=_context.Products.ToList();
            //    return Ok(products); 
    
            // GET api/products/5
            [HttpGet("{id}")]
            //Async
              public async Task<ActionResult<Product>> GetProductById(int id)
            {
                return await _context.Products.FindAsync(id);
            }
            //Synchronous
            // public ActionResult<Product> GetProductById(int id)
            // {
            //     return _context.Products.Find(id);
            // }
    
            // POST api/products
            [HttpPost("")]
            public void Poststring(string value)
            {
            }
    
            // PUT api/products/5
            [HttpPut("{id}")]
            public void Putstring(int id, string value)
            {
            }
    
            // DELETE api/products/5
            [HttpDelete("{id}")]
            public void DeletestringById(int id)
            {
            }
        }
    }
  
