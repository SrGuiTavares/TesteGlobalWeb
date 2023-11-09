using System.ComponentModel.DataAnnotations;

namespace TesteTecnico.Domain.Entites
{
    public class Usuario : BaseEntitie
    {
        [Key]
        public string Documento { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime Datanascimento { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; set; }
        public char Status { get; set; }
    }
}
