using edd_blazor_server_poc.Data;
using edd_blazor_server_poc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace edd_blazor_server_poc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperService : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public DeveloperService(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<Developer>> GetAll()
        {
            return await _context.Developers.ToListAsync();
        }

        public async Task<bool> InsertDeveloperAsync(Developer developer)
        {
            await _context.Developers.AddAsync(developer);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Developer> GetDeveloperAsync(int id)
        {
            Developer employee = await _context.Developers.FirstOrDefaultAsync(c => c.Id.Equals(id));
            return employee;
        }

        public async Task<bool> UpdateDeveloperAsync(Developer developer)
        {
            _context.Developers.Update(developer);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteDeveloperAsync(Developer developer)
        {
            _context.Remove(developer);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}