using RestApiModelDDD.Application.Dtos;
using RestApiModelDDD.Application.Interface;
using RestApiModelDDD.Domain.Core.Interfaces.Services.Interface;
using System.Collections.Generic;

namespace RestApiModelDDD.Application.Entitys
{
    public class AplicationServiceCliente : IAplicationServiceCliente
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapperCliente _mapperCliente;

        public AplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            _serviceCliente = serviceCliente;
            _mapperCliente = mapperCliente;
        }

        public void Add(ClienteDto clienteDto)
        {
            var cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Add(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var clientes = _serviceCliente.GetAll();
            return _mapperCliente.MapperListClienteDto(clientes);
        }

        public ClienteDto GetById(int id)
        {
            var cliente = _serviceCliente.GetById(id);
            return _mapperCliente.MapperEntityToDto(cliente);
        }

        public void Remove(ClienteDto clienteDto)
        {
            var cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Remove(cliente);
        }

        public void Update(ClienteDto clienteDto)
        {
            var cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Update(cliente);
        }
    }
}