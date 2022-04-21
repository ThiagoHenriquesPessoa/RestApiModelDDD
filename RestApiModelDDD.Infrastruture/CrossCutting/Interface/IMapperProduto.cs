using RestApiModelDDD.Application.Dtos;
using RestApiModelDDD.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiModelDDD.Infrastruture.CrossCutting.Interface
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> MapperListProdutoDto(IEnumerable<Produto> produtos);

        ProdutoDto MapperEntityToDto(Produto produto);
    }
}