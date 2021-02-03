using System.Collections.Generic;

namespace Core.Entities
{
 
    public  class Cliente : BaseEntity
    {
        public string NomeCliente { get; set; }
        public string TipoCliente { get; set; }
        public string NomeContato { get; set; }
        public string TelefoneContato { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        
    }

    
}
