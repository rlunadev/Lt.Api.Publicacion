using Lt.Api.Publicaciones.Core;
using Lt.Api.Publicaciones.Models;

namespace Lt.Api.Publicaciones.Controllers
{
   
    public class TipoProductoController : CrudController<TipoProducto>
    {
        public TipoProductoController(DataContext dataContext) : base(dataContext) 
        {
        }
    }
}
