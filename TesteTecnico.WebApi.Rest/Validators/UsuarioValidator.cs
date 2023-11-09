using FluentValidation;
using TesteTecnico.Application.ViewModel;
using TesteTecnico.WebApi.Rest.Validators.Helper;

namespace TesteTecnico.WebApi.Rest.Validators
{
    public class UsuarioValidator : AbstractValidator<UsuarioViewModel>
    {
        public UsuarioValidator()
        {
            RuleFor(n => n.NomeCompleto)
                .NotEmpty()
                    .WithMessage("Nome do usuário é um campo obrigatório.")
                .MaximumLength(100)
                    .WithMessage("Nome do usuário não pode ter mais que 100 caracteres.")
                .MinimumLength(10)
                    .WithMessage("Nome do usuário não pode ter menos que 10 caracteres.");

            RuleFor(n => n.Datanascimento)
                .NotEmpty()
                    .WithMessage("Data de nascimento é um campo obrigatório.")
                .LessThan(DateTime.Now.Date)
                    .WithMessage("Data de nascimento não pode ser maior que a data de hoje.");

            RuleFor(n => n.Documento)
                .NotEmpty()
                    .WithMessage("Documento é um campo obrigatório.")
                .Must(d => d.IsValidDocument())
                    .WithMessage("Documento não é válido.");
        }
    }
}
