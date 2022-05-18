using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Lt.Api.Publicaciones.Core
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class CrudController<T> : ControllerBase where T : EntityBase
    {
        protected readonly DataContext _dataContext;

        public CrudController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost("Save")]
        public async Task<IActionResult> Save(T entity)
        {
            _dataContext.Add(entity);
            await _dataContext.SaveChangesAsync();
            return Ok(new { isSaved = true, message = "Guardado", Status = 200 });
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var listEntity = await _dataContext.Set<T>().ToListAsync();
            return Ok(listEntity);
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _dataContext.Set<T>().Where(p => p.Id == id).FirstOrDefaultAsync();

            if (entity == null)
                return NotFound();

            return Ok(entity);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await _dataContext.Set<T>().Where(p => p.Id == id).FirstOrDefaultAsync();

            if(entity!= null )
            {
                _dataContext.Set<T>().Remove(entity);
                _dataContext.SaveChanges();
                return Ok(new { isDeleted = false, message = "No se borro", Status = 200 });
            }
            
            return Ok(new { isDeleted = true, message = "Borrado", Status = 200 });
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(T entity)
        {
            _dataContext.Set<T>().Update(entity);
            _dataContext.SaveChanges();
            return Ok(new { isDeleted = true, message = "Actualizado", Status = 500 });
        }
    
    }
}
