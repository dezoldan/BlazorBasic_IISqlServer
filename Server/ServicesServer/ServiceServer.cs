using BlazorBasicSqlServer.Server.Data;
using BlazorBasicSqlServer.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorBasicSqlServer.Server.ServicesServer
{
    public class ServiceServer : IServiceServer
    {
        private readonly DataContext _dataContext;
        public ServiceServer(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        // Vídeo #36.
       // Saber se a tabela contém alunos.
        public async Task<bool> GetAnyAsync()
        {
            return await _dataContext.TblTeste3.AnyAsync();
        }

        // Saber qual é o primeiro aluno da tabela.
        public async Task<Alunos> GetFirst()
        {
            return await _dataContext.TblTeste3.FirstAsync();
        }

        // Saber qual aluno atende uma condição específica. {id}
        public async Task<Alunos> GetFirst2(int id1)
        {
            // Verificar antes se a tabela contém alunos.
            if (await _dataContext.TblTeste3.AnyAsync())
            {
                return await _dataContext.TblTeste3.FirstAsync(x => x.Id== id1);
            }
            else
            {
                return null!;
            }
        }     
        
        // Vídeo #37.
        // Saber se na tabela existe um único aluno que atende a uma condição específica. {id1}
        public async Task<Alunos> GetSingleAsync(int id1)
        {
            try
            {
                // Verificar se a tabela contém alunos.
                if (await _dataContext.TblTeste3.AnyAsync())
                {
                    return await _dataContext.TblTeste3.SingleAsync(x => x.Id== id1);
                }
                else
                {
                    return null!;
                }
            }
            catch (Exception)
            {
                throw new Exception($"Não há na tabela um único aluno que atende a essa condição: {id1}");
            }
        }

        // Saber a média das idades dos alunos.
        public async Task<double> GetMedia()
        {
            return await _dataContext.TblTeste3.AverageAsync(x => x.Idade);
        }

        // Saber a soma das idades dos alunos.
        public async Task<int> GetSoma()
        {
            return await _dataContext.TblTeste3.SumAsync(x => x.Idade);
        }
    }
}