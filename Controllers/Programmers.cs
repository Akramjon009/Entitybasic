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
            var result = await _programmerService.CreateProgrammerAsync(program);
            return result;
        }
    }
}
