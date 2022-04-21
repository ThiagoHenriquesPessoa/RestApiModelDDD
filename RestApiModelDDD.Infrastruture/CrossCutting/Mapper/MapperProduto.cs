﻿using RestApiModelDDD.Application.Dtos;
using RestApiModelDDD.Domain.Entitys;
using RestApiModelDDD.Infrastruture.CrossCutting.Interface;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModelDDD.Infrastruture.CrossCutting.Mapper
{
    internal class MapperProduto : IMapperProduto
    {
        private IEnumerable<ProdutoDto> produtoDto = new List<ProdutoDto>();

        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                Id = produtoDto.Id,
                Nome = produtoDto.Nome,
                Valor = produtoDto.Valor
            };
            return produto;
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            };
            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListProdutoDto(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(p => new ProdutoDto
            {
                Id = p.Id,
                Nome = p.Nome,
                Valor = p.Valor
            });
            return dto;
        }
    }
}