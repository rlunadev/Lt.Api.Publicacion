using Lt.Api.Publicaciones.Core;
using Lt.Api.Publicaciones.Models;

namespace Lt.Api.Publicaciones.Controllers
{
   
    public class ProductoController : CrudController<Producto>
    {
        public ProductoController(DataContext dataContext) : base(dataContext) 
        {
        }
    }
}
