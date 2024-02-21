using Entitybasic.Infrastructure;
using Entitybasic.Model;
using Microsoft.EntityFrameworkCore;

namespace Entitybasic.Repository
{
    public class ProgrammerRepository : IProgrammerRepository
    {
        private readonly ApplicationDbContext _context;
        public ProgrammerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<string> CreateProgrammerAsync(ProgrammerDTO moprg)
        {
            var model = new Programmer()
            {
                Name = moprg.Name,
                programmLanguage = moprg.programmLanguage
            };
            await _context.Programmers.AddAsync(model);
            await _context.SaveChangesAsync();

            return "Malumot Yaratildi";
        }
        public async Task<bool> DeleteProgrammerByIdAsync(int id)
        {
            try
            {
                var md = await _context.Programmers.FirstOrDefaultAsync(x => x.Id == id);
                if (md != null)
                {
                    _context.Programmers.Remove(md);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<Programmer>> GetAllProgrammerAsync()
        {
            try
            {
                var x = await _context.Programmers.ToListAsync();
                return x;
            }
            catch
            {
                return Enumerable.Empty<Programmer>();
            }
        }

        public async Task<Programmer> GetProgrammerByIdAsync(int id)
        {
            try
            {
                var md = await _context.Programmers.FirstOrDefaultAsync(x => x.Id == id);
                if (md != null)
                {
                    return md;
                }
                return new Programmer() { };
            }
            catch
            {
                return new Programmer() { };
            }
        }

        public async Task<bool> UpdateProgrammerById(int id, ProgrammerDTO company)
        {
            try
            {
                var md = await _context.Programmers.FirstOrDefaultAsync(x => x.Id == id);
                if (md != null)
                {
                    md.Name = company.Name;
                    md.programmLanguage = company.programmLanguage;
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
