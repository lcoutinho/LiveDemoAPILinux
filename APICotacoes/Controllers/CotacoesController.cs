using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APICotacoes.Controllers
{
    [Route("api/[controller]")]
    public class CotacoesController : Controller
    {
        [HttpGet("{id}")]
        public Cotacao Get(
            [FromServices]CotacoesDAO cotacoesDAO,
            string id)
        {
            return cotacoesDAO.Obter(id);
        }
    }
}