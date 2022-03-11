using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace EditorDeTags.Repositories
{
    //so aceito criação de repository<TModel>(TModel = tipo generico) where(aonde) TModel : class (é igual a uma classe) pois os models são classes
    public class Repository<TModel> where TModel : class
    {
        public IEnumerable<TModel> GetAll()
        => Database.Connection.GetAll<TModel>();

        public TModel Get(int id)
        => Database.Connection.Get<TModel>(id);

        public void Create(TModel model)
        => Database.Connection.Insert<TModel>(model);

        public void Update(TModel model)
        => Database.Connection.Update<TModel>(model);

        public void Delete(TModel model)
        => Database.Connection.Delete<TModel>(model);

        public void Delete(int id)
        {
            var model = Database.Connection.Get<TModel>(id);
            Database.Connection.Delete<TModel>(model);
        }
    }
}