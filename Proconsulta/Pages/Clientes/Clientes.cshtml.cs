using Core.Entities;
using Infra.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proconsulta.Pages
{
    public class ClientesModel : PageModel
    {
        public  List<Cliente> Clientes;
        public int Registros = 0;

        #region Constructor
        private readonly IAsyncRepository<Cliente> _repo;
        public ClientesModel(IAsyncRepository<Cliente> repo) => _repo = repo;
        #endregion

        public void OnGet()
        {
            Clientes = _repo.ListAllAsync().Result.ToList();
            Registros = Clientes.Count();
        }
    }
}
