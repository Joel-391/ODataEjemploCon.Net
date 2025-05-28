using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.AspNetCore.OData.Query;
using ODataService.Models;
using System.Collections.Generic;
using System.Linq;

namespace ODataService.Controllers
{
    public class ProductsController : ODataController
    {
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1500 },
            new Product { Id = 2, Name = "Mouse", Price = 25 }
        };

        [EnableQuery]
        public ActionResult<IQueryable<Product>> Get()
        {
            return Ok(_products.AsQueryable());
        }

        [EnableQuery]
        public ActionResult<Product> Get(int key)
        {
            var product = _products.FirstOrDefault(p => p.Id == key);
            if (product == null) return NotFound();
            return Ok(product);
        }

        public IActionResult Post([FromBody] Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
            return Created(product);
        }

        public IActionResult Put(int key, [FromBody] Product updated)
        {
            var product = _products.FirstOrDefault(p => p.Id == key);
            if (product == null) return NotFound();

            product.Name = updated.Name;
            product.Price = updated.Price;
            return Updated(product);
        }

        public IActionResult Delete(int key)
        {
            var product = _products.FirstOrDefault(p => p.Id == key);
            if (product == null) return NotFound();

            _products.Remove(product);
            return NoContent();
        }
    }
}
