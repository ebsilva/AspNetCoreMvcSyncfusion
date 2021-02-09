using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    [Table("Medicos")]
    [Index(nameof(Nome))]
    public class Medico : BaseEntity
    {
        public int Nome { get; set; }
        public string Crm { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }

    }
}
