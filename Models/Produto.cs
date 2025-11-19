using System.ComponentModel.DataAnnotations;

namespace ProjetoInicial.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "Campo obrigatório!")]
        public String nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Range(0.1,1000000, ErrorMessage = "Digite um preço válido!")]
        public double preco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Range(1, 1000000, ErrorMessage = "Digite uma quantidade válida!")]
        public int quantidade { get; set; }
    }
}
