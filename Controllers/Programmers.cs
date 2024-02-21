using Entitybasic.Model;
using Entitybasic.Service;
using Microsoft.AspNetCore.Mvc;

namespace Entitybasic.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Programmers : ControllerBase
    {
        private readonly IProgrammerService _programmerService;
        public Programmers(IProgrammerService programmer)
        {
            _programmerService = programmer;
        }
        [HttpPost]
        public async Task<string> Creat(ProgrammerDTO program) 
        {
             
            return await _programmerService.CreateServiceAsync(program);
        }

        [HttpGet]
        public async Task<IEnumerable<Programmer>> Read() 
        {
            return await _programmerService.GetAllServiceAsync();
        }

        [HttpGet]
        public Task<Programmer> ReadById(int id) 
        {
            return _programmerService.GetServieceByIdAsync(id);
        }

        [HttpPatch]
        public Task<bool> Update(int id,ProgrammerDTO programer) 
        {
            return _programmerService.UpdateServiceByIdAsync(id,programer);
        }

        [HttpDelete]
        public Task<bool> Delete(int id) 
        {
            return _programmerService.DeleteServiceByIdAsync(id);
        }

    }
}
