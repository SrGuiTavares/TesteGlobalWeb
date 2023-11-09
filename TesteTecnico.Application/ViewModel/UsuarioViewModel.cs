namespace TesteTecnico.Application.ViewModel
{
    public class UsuarioViewModel : BaseViewModel
    {
        public string Documento { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime Datanascimento { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; set; }
        public char Status { get; set; }
    }
}
