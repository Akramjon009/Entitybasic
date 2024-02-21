using Entitybasic.Model;
using Entitybasic.Repository;



namespace Entitybasic.Service
{
    public  class ProgrammerService: IProgrammerService
    {
        private readonly IProgrammerRepository _context;
        public ProgrammerService(IProgrammerRepository context)
        {
            _context = context;
        }
        public async Task<string> CreateServiceAsync(ProgrammerDTO programer) 
        {
            if (programer.Name.Trim() != "" && programer.programmLanguage.Trim() !=  "")
            {
                return await _context.CreateProgrammerAsync(programer);
            }
            return "";
        }
        public async Task<bool> DeleteServiceByIdAsync(int id)
        {
            if (id != null)
            {
                return await _context.DeleteProgrammerByIdAsync(id);
            }
            return false;
        }
       
        public async Task<IEnumerable<Programmer>> GetAllServiceAsync() 
        {
             return await _context.GetAllProgrammerAsync();
        }
        public async Task<Programmer> GetServieceByIdAsync(int id) 
        {
            if (id != null)
            {
                return  await _context.GetProgrammerByIdAsync(id);
            }
            return null;
        }

        public async Task<bool> UpdateServiceByIdAsync(int id, ProgrammerDTO programer)
        {
            if (id != null && programer.Name.Trim() != "" && programer.programmLanguage.Trim() != "")
            {
                return await _context.UpdateProgrammerById(id, programer);
            }
            return false;
        }
    }
}


