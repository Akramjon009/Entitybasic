using Entitybasic.Model;

namespace Entitybasic.Service
{
    public interface IProgrammerService
    {
        public Task<string> CreateServiceAsync(ProgrammerDTO programer);
        public Task<bool> DeleteServiceByIdAsync(int id);
      
        public  Task<IEnumerable<Programmer>> GetAllServiceAsync();
        public Task<Programmer> GetServieceByIdAsync(int id);
        public Task<bool> UpdateServiceByIdAsync(int id, ProgrammerDTO programer);
    }
}
