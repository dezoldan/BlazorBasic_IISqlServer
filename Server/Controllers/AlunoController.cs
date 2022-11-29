using BlazorBasicSqlServer.Server.ServicesServer;
using BlazorBasicSqlServer.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorBasicSqlServer.Server.Controllers
{
    [Route("v0/[controller]")]
    [ApiController]
    public class AlunoController : Controller
    {
        private readonly IServiceServer _serviceServer;
        public AlunoController(IServiceServer serviceServer)
        {
            _serviceServer= serviceServer;
        }

        // Saber se a tabela contém alunos.
        [HttpGet("any")]
        public async Task<ActionResult<bool>> GetAnyAsync()
        {
            return await _serviceServer.GetAnyAsync();
        }

        // Saber qual é o primeiro aluno da tabela.
        [HttpGet("primeiro")]
        public async Task<Alunos> GetFirstAsync()
        {
            return await _serviceServer.GetFirst();
        }

        // Saber qual aluno atende a uma condição específica. {id1}
        [HttpGet("primeiro/{id1:int}")]
        public async Task<ActionResult<Alunos>> GetFirst2(int id1)
        {
            return await _serviceServer.GetFirst2(id1);
        }  
    }
}