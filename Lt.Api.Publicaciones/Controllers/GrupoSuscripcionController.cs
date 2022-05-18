using Lt.Api.Publicaciones.Core;
using Lt.Api.Publicaciones.Models;

namespace Lt.Api.Publicaciones.Controllers
{
   
    public class GrupoSuscripcionController : CrudController<GrupoSuscripcion>
    {
        public GrupoSuscripcionController(DataContext dataContext) : base(dataContext) 
        {
        }
    }
}
