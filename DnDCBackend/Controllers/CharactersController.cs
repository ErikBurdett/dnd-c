using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DnDCBackend.Data;
using DnDCBackend.Models;

namespace DnDCBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CharacterController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Character
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Character>>> GetCharacters()
        {
            return await _context.Characters
                .Include(c => c.Spells)
                .Include(c => c.Inventory)
                .Include(c => c.Proficiencies)
                .Include(c => c.Skills)
                .Include(c => c.SavingThrows)
                .Include(c => c.ClassFeatures)
                .ToListAsync();
        }

        // GET: api/Character/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetCharacter(int id)
        {
            var character = await _context.Characters
                .Include(c => c.Spells)
                .Include(c => c.Inventory)
                .Include(c => c.Proficiencies)
                .Include(c => c.Skills)
                .Include(c => c.SavingThrows)
                .Include(c => c.ClassFeatures)
                .FirstOrDefaultAsync(c => c.CharacterId == id);

            if (character == null)
            {
                return NotFound();
            }

            return character;
        }

        // POST: api/Character
        [HttpPost]
        public async Task<ActionResult<Character>> PostCharacter(Character character)
        {
            _context.Characters.Add(character);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCharacter), new { id = character.CharacterId }, character);
        }

        // PUT: api/Character/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacter(int id, Character character)
        {
            if (id != character.CharacterId)
            {
                return BadRequest();
            }

            _context.Entry(character).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterExists(id))
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

        // DELETE: api/Character/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharacter(int id)
        {
            var character = await _context.Characters.FindAsync(id);
            if (character == null)
            {
                return NotFound();
            }

            _context.Characters.Remove(character);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CharacterExists(int id)
        {
            return _context.Characters.Any(e => e.CharacterId == id);
        }
    }
}
