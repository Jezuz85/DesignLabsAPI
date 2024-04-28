using ApiDesignlabs.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiDesignlabs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        static List<Producto> productos = new()
            {
                new Producto { Id = 1, Nombre = "Producto 1", Descripcion = "Descripcion 1", Precio = 100 },
                new Producto { Id = 2, Nombre = "Producto 2", Descripcion = "Descripcion 2", Precio = 200 },
                new Producto { Id = 3, Nombre = "Producto 3", Descripcion = "Descripcion 3", Precio = 300 },
                new Producto { Id = 4, Nombre = "Producto 4", Descripcion = "Descripcion 4", Precio = 400 },
                new Producto { Id = 5, Nombre = "Producto 5", Descripcion = "Descripcion 5", Precio = 500 }
            };

        // GET: api/<Productos>
        [HttpGet]
        public List<Producto> Get()
        {
            return productos;
        }

        // GET api/<Productos>/5
        [HttpGet("{id}")]
        public Producto Get(int id)
        {
            return productos.FirstOrDefault(p => p.Id == id);
        }

        // POST api/<Productos>
        [HttpPost]
        public bool Post([FromBody] Producto product)
        {
            try
            {
                productos.Add(product);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // DELETE api/<Productos>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            try
            {
                productos.Remove(productos.FirstOrDefault(p => p.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}