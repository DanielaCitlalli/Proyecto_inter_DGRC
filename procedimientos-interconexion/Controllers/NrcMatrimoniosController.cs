﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using procedimientos_interconexion.Models;

namespace procedimientos_interconexion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NrcMatrimoniosController : ControllerBase
    {
        private readonly InterconexionContext _context;

        public NrcMatrimoniosController(InterconexionContext context)
        {
            _context = context;
        }

        // GET: api/NrcMatrimonios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NrcMatrimonios>>> GetNrcMatrimonios()
        {
            return await _context.NrcMatrimonios.ToListAsync();
        }

        // GET: api/NrcMatrimonios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NrcMatrimonios>> GetNrcMatrimonios(string id)
        {
            var nrcMatrimonios = await _context.NrcMatrimonios.FindAsync(id);

            if (nrcMatrimonios == null)
            {
                return NotFound();
                //return CreatedAtAction(nameof(GetNrcMatrimonios), new { id = nrcMatrimonios.Cadena }, nrcMatrimonios);
            }

            return nrcMatrimonios;
        }

        // PUT: api/NrcMatrimonios/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNrcMatrimonios(string id, NrcMatrimonios nrcMatrimonios)
        {
            if (id != nrcMatrimonios.Cadena)
            {
                return BadRequest();
                //return CreatedAtAction(nameof(GetNrcMatrimonios), new { id = nrcMatrimonios.Cadena }, nrcMatrimonios);
            }
           

            _context.Entry(nrcMatrimonios).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NrcMatrimoniosExists(id))
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

        // POST: api/NrcMatrimonios
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<NrcMatrimonios>> PostNrcMatrimonios(NrcMatrimonios nrcMatrimonios)
        {
            _context.NrcMatrimonios.Add(nrcMatrimonios);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (NrcMatrimoniosExists(nrcMatrimonios.Cadena))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetNrcMatrimonios", new { id = nrcMatrimonios.Cadena }, nrcMatrimonios);
        }

        // DELETE: api/NrcMatrimonios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<NrcMatrimonios>> DeleteNrcMatrimonios(string id)
        {
            var nrcMatrimonios = await _context.NrcMatrimonios.FindAsync(id);
            if (nrcMatrimonios == null)
            {
                return NotFound();
            }

            _context.NrcMatrimonios.Remove(nrcMatrimonios);
            await _context.SaveChangesAsync();

            return nrcMatrimonios;
        }

        private bool NrcMatrimoniosExists(string id)
        {
            return _context.NrcMatrimonios.Any(e => e.Cadena == id);
        }
    }
}
