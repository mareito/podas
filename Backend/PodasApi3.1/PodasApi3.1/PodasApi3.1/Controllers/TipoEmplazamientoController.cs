using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PodasApi.Entities.Tables;
using PodasApi3._1.DataContext;
using PodasApi3._1.Services;

namespace PodasApi3._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoEmplazamientoController : ControllerBase
    {
        private readonly PodasContext _context;
        private readonly ITipoEmplazamiento tipoEmplazamiento;

        public TipoEmplazamientoController(PodasContext context)
        {
            _context = context;
        }

        // GET: api/TipoEmplazamientoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoEmplazamiento>>> GetTiposEmplazamiento()
        {
            return await _context.TiposEmplazamiento.ToListAsync();
        }

        // GET: api/TipoEmplazamientoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoEmplazamiento>> GetTipoEmplazamiento(int id)
        {
            var tipoEmplazamiento = await _context.TiposEmplazamiento.FindAsync(id);

            if (tipoEmplazamiento == null)
            {
                return NotFound();
            }

            return tipoEmplazamiento;
        }

        // PUT: api/TipoEmplazamientoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoEmplazamiento(int id, TipoEmplazamiento tipoEmplazamiento)
        {
            if (id != tipoEmplazamiento.Id)
            {
                return BadRequest();
            }

            _context.Entry(tipoEmplazamiento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoEmplazamientoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TipoEmplazamientoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TipoEmplazamiento>> PostTipoEmplazamiento(TipoEmplazamiento tipoEmplazamiento)
        {
            _context.TiposEmplazamiento.Add(tipoEmplazamiento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoEmplazamiento", new { id = tipoEmplazamiento.Id }, tipoEmplazamiento);
        }

        // DELETE: api/TipoEmplazamientoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TipoEmplazamiento>> DeleteTipoEmplazamiento(int id)
        {
            var tipoEmplazamiento = await _context.TiposEmplazamiento.FindAsync(id);
            if (tipoEmplazamiento == null)
            {
                return NotFound();
            }

            _context.TiposEmplazamiento.Remove(tipoEmplazamiento);
            await _context.SaveChangesAsync();

            return tipoEmplazamiento;
        }

        private bool TipoEmplazamientoExists(int id)
        {
            return _context.TiposEmplazamiento.Any(e => e.Id == id);
        }
    }
}
