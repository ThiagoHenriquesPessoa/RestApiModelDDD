using RestApiModelDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModelDDD.Domain.Core.Interfaces.Services.Interface;
using RestApiModelDDD.Domain.Entitys;

namespace RestApiModelDDD.Domain.Services.Service
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente _repositoryCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)
        {
            _repositoryCliente = repositoryCliente;
        }
    }
}