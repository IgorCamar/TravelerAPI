using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TravelerAPI.Models;

namespace TravelerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicoController : ControllerBase
    {
        private readonly ServicoDBContext _context;

        public ServicoController(ServicoDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Servico> GetServicos()
        {
            return _context.Servico;
        }





    }
}
