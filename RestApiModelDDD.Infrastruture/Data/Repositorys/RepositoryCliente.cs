using RestApiModelDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModelDDD.Domain.Entitys;

namespace RestApiModelDDD.Infrastruture.Data.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext _sqlContext;

        public RepositoryCliente(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}