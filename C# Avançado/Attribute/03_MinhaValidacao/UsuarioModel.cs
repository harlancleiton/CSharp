using System.ComponentModel.DataAnnotations;

namespace _03_MinhaValidacao
{
    public class UsuarioModel
    {
        [Required(ErrorMessage = "O campo é de preenchimento obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessageResourceType = typeof(Recursos.Idiomas.Linguagem), ErrorMessageResourceName = "MSG_OBRIGATORIO"), EmailAddress]
        public string Email { get; set; }
        [Required, StringLength(16, MinimumLength = 6), MinhaValidacao(ErrorMessage = "Senha deve possuir 10 caracteres.")]
        public string Senha { get; set; }
    }
}