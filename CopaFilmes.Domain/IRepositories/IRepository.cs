using CopaFilmes.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmes.Domain.IRepositories
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        TEntity Get(string id);
        TEntity First();
        IQueryable<TEntity> Get();
        Task<IEnumerable<Filme>> GetAll();
    }
}
