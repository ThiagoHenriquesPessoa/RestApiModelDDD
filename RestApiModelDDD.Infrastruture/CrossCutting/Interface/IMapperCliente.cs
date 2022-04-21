using RestApiModelDDD.Application.Dtos;
using RestApiModelDDD.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiModelDDD.Infrastruture.CrossCutting.Interface
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);

        IEnumerable<ClienteDto> MapperListClienteDto(IEnumerable<Cliente> clientes);

        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}