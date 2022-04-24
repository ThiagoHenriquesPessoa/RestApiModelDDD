using RestApiModelDDD.Application.Dtos;
using System.Collections.Generic;

namespace RestApiModelDDD.Application.Interface
{
    public interface IAplicationServiceProduto
    {
        void Add(ProdutoDto produtoDto);

        void Update(ProdutoDto produtoDto);

        void Remove(int id);

        IEnumerable<ProdutoDto> GetAll();

        ProdutoDto GetById(int id);
    }
}