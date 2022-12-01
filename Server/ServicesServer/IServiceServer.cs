using BlazorBasicSqlServer.Shared;

namespace BlazorBasicSqlServer.Server.ServicesServer
{
    public interface IServiceServer
    {
        Task<bool> GetAnyAsync();
        Task<Alunos> GetFirst();
        Task<Alunos> GetFirst2(int id1);
        Task<double> GetMedia();
        Task<Alunos> GetSingleAsync(int id1);
        Task<int> GetSoma();
    }
}
