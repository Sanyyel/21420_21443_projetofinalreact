using Microsoft.AspNetCore.Mvc;

namespace ProjetoFinal_API.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController
    {
        [HttpGet]
        public String Inicio()
        {
            return "Funcionou!";
        }
    }
}