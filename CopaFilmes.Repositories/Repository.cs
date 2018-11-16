using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.IRepositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CopaFilmes.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        private readonly List<TEntity> _list;

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

        public async Task<IEnumerable<Filme>> GetAll()
        {
            string ApiBaseUrl = "http://copafilmes.azurewebsites.net/api/filmes";

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ApiBaseUrl);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var retorno = JsonConvert.DeserializeObject<IEnumerable<Filme>>(streamReader.ReadToEnd());

                    return retorno;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
