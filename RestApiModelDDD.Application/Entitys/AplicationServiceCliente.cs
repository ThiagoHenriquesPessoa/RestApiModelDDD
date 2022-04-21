using RestApiModelDDD.Application.Dtos;
using RestApiModelDDD.Application.Interface;
using RestApiModelDDD.Domain.Core.Interfaces.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModelDDD.Application.Entitys
{
    public class AplicationServiceCliente : IAplicationServiceCliente
    {
        private readonly IServiceCliente _serviceCliente;
        public void Add(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClienteDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }

        public void Update(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }
    }
}
