using Lt.Api.Publicaciones.Models;

namespace Lt.Api.Publicaciones.Data
{
    public class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            context.Database.EnsureCreated();

            var personas = new Persona[]
            {
                new Persona{Nombres="ronald",Apellidos="luna", Telefono="59174002070"}
            };
                foreach (Persona s in personas)
                {
                context.Personas.Add(s);
            }
            context.SaveChanges();
        }
    }
}
