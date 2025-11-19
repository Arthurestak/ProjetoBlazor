namespace ProjetoInicial.Models
{
    public class Pessoa
    {
        public string nome { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public DateOnly dataNascimento { get; set; }
        public string telefone { get; set; }
        public string cpf { get; set; }

    }
}
