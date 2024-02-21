using Entitybasic.Model;

namespace Entitybasic.Repository
{
    public interface IProgrammerRepository
    {
        public Task<string> CreateProgrammerAsync(ProgrammerDTO programer);
        public Task<bool> DeleteProgrammerByIdAsync(int id);
        public Task<bool> UpdateProgrammerById(int id, ProgrammerDTO programer);
        public Task<IEnumerable<Programmer>> GetAllProgrammerAsync();
        public Task<Programmer> GetProgrammerByIdAsync(int id);
    }
}
