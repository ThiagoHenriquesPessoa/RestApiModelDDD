using RestApiModelDDD.Application.Dtos;
using RestApiModelDDD.Application.Interface;
using RestApiModelDDD.Domain.Core.Interfaces.Services.Interface;
using RestApiModelDDD.Domain.Entitys;
using System;
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
            Cliente cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            cliente.DataCadastro = DateTime.Now;
            cliente.IsAtivo = true;
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

        public void Remove(int id)
        {
            _serviceCliente.Remove(id);
        }

        public void Update(ClienteDto clienteDto)
        {
            var cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Update(cliente);
        }
    }
}