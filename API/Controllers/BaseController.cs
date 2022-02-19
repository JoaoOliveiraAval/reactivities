using Domain;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    public class BaseController<T> : ControllerBase where T : BaseEntity<Guid>
    {
        protected readonly DataContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseController(DataContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<T>>> Get()
        {
            return await _dbSet.ToListAsync();
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<T>> Get(Guid id)
        {
            return await _dbSet.FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
