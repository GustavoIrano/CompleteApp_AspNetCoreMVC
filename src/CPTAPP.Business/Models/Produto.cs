using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvc.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(200, ErrorMessage = "O campo {0} não pode ter mais de 200 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(1000, ErrorMessage = "O campo {0} não pode ter mais de 1000 caracteres!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Imagem { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public decimal Valor { get; set; }

        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public Fornecedor Fornecedor { get; set; }
    }
}
