using Entitybasic.Model;
using Entitybasic.Repository;


namespace Entitybasic.Service
{
    public  class ProgrammerService:IProgrammerService
    {
        private readonly IProgrammerRepository _context;
        public ProgrammerService(IProgrammerRepository context)
        {
            _context = context;
        }
        public Task<string> CreateServiceAsync(ProgrammerDTO programer) 
        {
            if (programer.Name.Trim() != "" && programer.programmLanguage.Trim() !=  "")
            {
                return _context.CreateProgrammerAsync(programer);
            }
            return null;
        }
        public Task<bool> DeleteServiceByIdAsync(int id)
        {
            if (id != null)
            {
                return _context.DeleteProgrammerByIdAsync(id);
            }
            return null;
        }
        public Task<bool> UpdateServiceById(int id, ProgrammerDTO programer) 
        {
            if (id != null && programer.Name.Trim() != "" && programer.programmLanguage.Trim() == "") 
            {
                return _context.UpdateProgrammerById(id, programer);
            }
            return null;
        }
        public Task<IEnumerable<Programmer>> GetAllServiceAsync() 
        {
             return _context.GetAllProgrammerAsync();
        }
        public Task<Programmer> GetServieceByIdAsync(int id) 
        {
            if (id != null)
            {
                return _context.GetProgrammerByIdAsync(id);
            }
            return null;
        }
    }
}


