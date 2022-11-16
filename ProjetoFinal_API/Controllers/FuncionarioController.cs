using Microsoft.AspNetCore.Mvc;
using ProjetoFinal_API.Data;
using ProjetoFinal_API.Models;

namespace ProjetoFinal_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class FuncionarioController : ControllerBase
    {
        private FuncionarioContext _context;
        public FuncionarioController(FuncionarioContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public ActionResult<List<Funcionario>> GetAll(){
            return _context.Funcionario.ToList();
        }
    }
}