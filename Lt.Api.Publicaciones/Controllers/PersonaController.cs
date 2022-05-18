using Lt.Api.Publicaciones.Core;
using Lt.Api.Publicaciones.Models;

namespace Lt.Api.Publicaciones.Controllers
{
   
    public class PersonaController : CrudController<Persona>
    {
        public PersonaController(DataContext dataContext) : base(dataContext) 
        {
        }
    }
}
