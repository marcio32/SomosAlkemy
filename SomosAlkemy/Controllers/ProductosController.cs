using Microsoft.AspNetCore.Mvc;


namespace SomosAlkemy.Controllers
{
    [ApiController]
    [Route("/api/products")]
    public class ProductosController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Producto> GetProductos()
        {
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto()
            {
                Id = 1,
                Nombre = "Azucar",
                Descripcion = "Azucar 1 Kg Blanco",
                Precio = 10
            });


            return productos;
        }

        [HttpPost]
        public void AddProducto(Producto producto)
        {
            //productos.Add(producto);
        }

        [HttpGet]
        [Route("/api/producto/{id}")]
        public Producto GetProducto(int id)
        {
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto()
            {
                Id = 1,
                Nombre = "Azucar",
                Descripcion = "Azucar 1 Kg Blanco",
                Precio = 1000
            });
            productos.Add(new Producto()
            {
                Id = 2,
                Nombre = "Harina",
                Descripcion = "Harina 1 Kg",
                Precio = 1500
            });
            productos.Add(new Producto()
            {
                Id = 3,
                Nombre = "Jabon en polvo",
                Descripcion = "Jabon en polvo 1 Kg",
                Precio = 2000
            });

            Producto? prod = productos.FirstOrDefault(prod => prod.Id == id);

            return prod==null?new Producto():prod;
        }




    }
}

public class Producto
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public double Precio { get; set; }
    public string? Descripcion { get; set; }
}