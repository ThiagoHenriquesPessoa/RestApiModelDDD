using RestApiModelDDD.Application.Dtos;
using System.Collections.Generic;

namespace RestApiModelDDD.Application.Interface
{
    public interface IAplicationServiceCliente
    {
        void Add(ClienteDto clienteDto);

        void Update(ClienteDto clienteDto);

        void Remove(int id);

        IEnumerable<ClienteDto> GetAll();

        ClienteDto GetById(int id);
    }
}