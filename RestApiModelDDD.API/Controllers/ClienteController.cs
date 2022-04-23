using Microsoft.AspNetCore.Mvc;
using RestApiModelDDD.Application.Dtos;
using RestApiModelDDD.Application.Interface;
using System;
using System.Collections.Generic;

namespace RestApiModelDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly IAplicationServiceCliente _aplicationServiceCliente;

        public ClienteController(IAplicationServiceCliente aplicationServiceCliente)
        {
            _aplicationServiceCliente = aplicationServiceCliente;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_aplicationServiceCliente.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_aplicationServiceCliente.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null) return NotFound();
                _aplicationServiceCliente.Add(clienteDto);
                return Ok("Cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null) return NotFound();
                _aplicationServiceCliente.Update(clienteDto);
                return Ok("Cliente atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null) return NotFound();
                _aplicationServiceCliente.Remove(clienteDto);
                return Ok("Cliente removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}