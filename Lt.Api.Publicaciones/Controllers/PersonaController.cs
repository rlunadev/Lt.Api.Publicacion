using Lt.Api.Publicaciones.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lt.Api.Publicaciones.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonaController : ControllerBase
    {
        private readonly DataContext _dataContext;
        private readonly ILogger<PersonaController> _logger;

        public PersonaController(ILogger<PersonaController> logger, DataContext dataContext)
        {
            _logger = logger;
            _dataContext = dataContext;
        }

        [HttpPost("Save")]
        public async Task<IActionResult> Save(Persona persona)
        {
            _dataContext.Add(persona);
            await _dataContext.SaveChangesAsync();
            return Ok(new { isDeleted = true, message = "Guardado", Status = 200 });
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var personas = await _dataContext.Personas.ToListAsync();
            return Ok(personas);
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var persona = await _dataContext.Personas.Where(p=>p.Id == id).FirstOrDefaultAsync();
            return Ok(persona);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var persona = await _dataContext.Personas.Where(p => p.Id == id).FirstOrDefaultAsync();
            _dataContext.Personas.Remove(persona);
            _dataContext.SaveChanges();
            return Ok(new { isDeleted = true, message = "Borrado", Status = 200});
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Delete(Persona persona)
        {
            _dataContext.Personas.Update(persona);
            _dataContext.SaveChanges();
            return Ok(new { isDeleted = true, message = "Actualizado", Status = 500 });
        }

    }
}
