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

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var personas = await _dataContext.Personas.ToListAsync();
            return Ok(personas);
        }

    }
}
