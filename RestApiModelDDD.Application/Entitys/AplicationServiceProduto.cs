using RestApiModelDDD.Application.Dtos;
using RestApiModelDDD.Application.Interface;
using RestApiModelDDD.Domain.Core.Interfaces.Services.Interface;
using System.Collections.Generic;

namespace RestApiModelDDD.Application.Entitys
{
    public class AplicationServiceProduto : IAplicationServiceProduto
    {
        private readonly IServiceProduto _serviceProduto;
        private readonly IMapperProduto _mapperProduto;

        public AplicationServiceProduto(IServiceProduto serviceProduto, IMapperProduto mapperProduto)
        {
            _serviceProduto = serviceProduto;
            _mapperProduto = mapperProduto;
        }

        public void Add(ProdutoDto produtoDto)
        {
            var produto = _mapperProduto.MapperDtoToEntity(produtoDto);
            _serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produtos = _serviceProduto.GetAll();
            return _mapperProduto.MapperListProdutoDto(produtos);
        }

        public ProdutoDto GetById(int id)
        {
            var produto = _serviceProduto.GetById(id);
            return _mapperProduto.MapperEntityToDto(produto);
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produto = _mapperProduto.MapperDtoToEntity(produtoDto);
            _serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produto = _mapperProduto.MapperDtoToEntity(produtoDto);
            _serviceProduto.Update(produto);
        }
    }
}