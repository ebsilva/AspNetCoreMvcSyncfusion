﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    [Table("Riscos")]
    public class Risco : BaseEntity
    {
        [MaxLength(250)]
        public string Descricao { get; set; }
    }
}
