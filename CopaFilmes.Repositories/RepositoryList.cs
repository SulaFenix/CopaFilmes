using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmes.Repositories
{
    public class RepositoryList<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        private readonly List<TEntity> _list;

        public RepositoryList(List<TEntity> list)
        {
            _list = list;
        }

        public TEntity First()
        {
            return _list.FirstOrDefault();
        }

        public TEntity Get(string id)
        {
            return _list.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<TEntity> Get()
        {
            return _list.AsQueryable();
        }

        public Task<IEnumerable<Filme>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
