using System.ComponentModel.DataAnnotations;

namespace ProjetoInicial.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "Campo obrigatório!")]
        public String nome { get; set; }

        [Range(0.1,1000000, ErrorMessage = "Digite um preço válido!")]
        public double preco { get; set; }

        [Range(1, 1000000, ErrorMessage = "Digite uma quantidade válida!")]
        public int quantidade { get; set; }
    }
}
