using RestApiModelDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModelDDD.Domain.Entitys;

namespace RestApiModelDDD.Infrastruture.Data.Repositorys
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly SqlContext _sqlContext;

        public RepositoryProduto(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}