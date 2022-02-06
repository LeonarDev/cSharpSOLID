using System.ComponentModel.DataAnnotations;

namespace solidInCsharp.Model
{
    public class Usuario
    {
        [Key]
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set;}
    }
}
