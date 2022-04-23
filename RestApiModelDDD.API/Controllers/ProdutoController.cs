using Microsoft.AspNetCore.Mvc;
using RestApiModelDDD.Application.Dtos;
using RestApiModelDDD.Application.Interface;
using System;
using System.Collections.Generic;

namespace RestApiModelDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IAplicationServiceProduto _aplicationServiceProduto;

        public ProdutoController(IAplicationServiceProduto aplicationServiceProduto)
        {
            _aplicationServiceProduto = aplicationServiceProduto;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_aplicationServiceProduto.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_aplicationServiceProduto.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null) return NotFound();
                _aplicationServiceProduto.Add(produtoDto);
                return Ok("Cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null) return NotFound();
                _aplicationServiceProduto.Update(produtoDto);
                return Ok("Cliente atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null) return NotFound();
                _aplicationServiceProduto.Remove(produtoDto);
                return Ok("Cliente removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}