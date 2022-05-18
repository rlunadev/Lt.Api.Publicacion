using Lt.Api.Publicaciones.Core;
using Lt.Api.Publicaciones.Models;

namespace Lt.Api.Publicaciones.Controllers
{
   
    public class SuscripcionItemController : CrudController<SuscripcionItem>
    {
        public SuscripcionItemController(DataContext dataContext) : base(dataContext) 
        {
        }
    }
}
