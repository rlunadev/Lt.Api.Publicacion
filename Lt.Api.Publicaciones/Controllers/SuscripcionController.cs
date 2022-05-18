using Lt.Api.Publicaciones.Core;
using Lt.Api.Publicaciones.Models;

namespace Lt.Api.Publicaciones.Controllers
{
   
    public class SuscripcionController : CrudController<Suscripcion>
    {
        public SuscripcionController(DataContext dataContext) : base(dataContext) 
        {
        }
    }
}
