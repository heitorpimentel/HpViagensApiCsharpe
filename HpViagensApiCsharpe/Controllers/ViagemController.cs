using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HpViagensApiCsharpe.Context;
using HpViagensApiCsharpe.Model;

namespace HpViagensApiCsharpe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViagemController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ViagemController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Viagem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Viagem>>> GetViagens()
        {
          if (_context.Viagens == null)
          {
              return NotFound();
          }
            return await _context.Viagens.ToListAsync();
        }

        // GET: api/Viagem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Viagem>> GetViagem(int id)
        {
          if (_context.Viagens == null)
          {
              return NotFound();
          }
            var viagem = await _context.Viagens.FindAsync(id);

            if (viagem == null)
            {
                return NotFound();
            }

            return viagem;
        }

        // PUT: api/Viagem/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutViagem(int id, Viagem viagem)
        {
            if (id != viagem.Id)
            {
                return BadRequest();
            }

            _context.Entry(viagem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ViagemExists(id))
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

        // POST: api/Viagem
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Viagem>> PostViagem(Viagem viagem)
        {
          if (_context.Viagens == null)
          {
              return Problem("Entity set 'AppDbContext.Viagens'  is null.");
          }
            _context.Viagens.Add(viagem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetViagem", new { id = viagem.Id }, viagem);
        }

        // DELETE: api/Viagem/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteViagem(int id)
        {
            if (_context.Viagens == null)
            {
                return NotFound();
            }
            var viagem = await _context.Viagens.FindAsync(id);
            if (viagem == null)
            {
                return NotFound();
            }

            _context.Viagens.Remove(viagem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ViagemExists(int id)
        {
            return (_context.Viagens?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
