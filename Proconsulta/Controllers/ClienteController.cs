using Core.Entities;
using Infra.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proconsulta
{
    public class ClienteController : Controller
    {
        #region Constructor
        private readonly IAsyncRepository<Cliente> _repo;
        public ClienteController(IAsyncRepository<Cliente> repo) => _repo = repo;
        #endregion

        // GET: HomeController/Create
        [HttpGet]
        public async  Task<ActionResult> GetById(string id)
        {
            var result = await _repo.GetByIdAsync(int.Parse(id)); ;
            return Json(result);
        }

        // POST: ClienteController/NovoCliente
        [HttpPost]
        public ActionResult NovoCliente(string nome, string tipo,string contato, string fone, string rua, string bairro, string cidade)
        {
            try
            {
                if (nome != null)

                {
                    var cliente = new Cliente
                    {
                        NomeCliente = nome,
                        TipoCliente = tipo,
                        NomeContato =contato,
                        TelefoneContato = fone,
                        Logradouro = rua,
                        Bairro = bairro,
                        Cidade = cidade,
                        DataCadastro = DateTime.Now,
                        DataAtualizacao = DateTime.Now

                    };
                    var result = _repo.AddAsync(cliente);
                    return Json(result);
                }



                return Json("");
            }
            catch
            {
                return Json("");
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult AlterarCliente(Cliente cliente)
        {
            var cli =  _repo.GetByIdAsync(cliente.Id).Result;
            if(cli != null)
            {
                try
                {
                    cli.NomeCliente = cliente.NomeCliente;
                    cli.TipoCliente = cliente.TipoCliente;
                    cli.NomeContato = cliente.NomeContato;
                    cli.TelefoneContato = cliente.TelefoneContato;
                    cli.Logradouro = cliente.Logradouro;
                    cli.Bairro = cliente.Bairro;
                    cli.Cidade = cliente.Cidade;

                     _repo.Update(cli);


                    return Json("");
                }
                catch
                {
                    return Json("");
                }
            }

             return Json("");
        }

     

        // POST: HomeController/Delete/5
        [HttpPost]
        public ActionResult ExclueCliente(int id)
        {

            var cli = _repo.GetByIdAsync(id).Result;
            try
            {
                if (cli != null)
                {

                   _repo.Delete(cli);
                    return Json("ok");
                }
                return Json("");
            }
            catch
            {
                return Json("");
            }
        }
    }
}
