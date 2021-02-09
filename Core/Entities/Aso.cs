using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    [Table("Asos")]
    [Index(nameof(Cpf))]
    [Index(nameof(Rg))]
    [Index(nameof(MedicoId))]
    public class Aso :BaseEntity
    {
        [MaxLength(150, ErrorMessage="Tamanho máximo é de 150 caracteres")]
        public string  Nome { get; set; }
        public int Codigo  { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public string Cargo { get; set; }
        public string Setor { get; set; }
        public DateTime RealizadoEm { get; set; }
        public bool Apto { get; set; }
        public int MedicoId { get; set; }
        public Medico Medico { get; set; }
        public string FinsDe { get; set; } 
        public List<Risco> Riscos { get; set; } 
    }
}
