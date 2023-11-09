using System.ComponentModel.DataAnnotations;

namespace TesteTecnico.Domain.Entites
{
    public class BaseEntitie
    {
        [Key]
        public int Id { get; set; }
    }
}
