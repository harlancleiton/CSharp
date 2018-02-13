using System.ComponentModel.DataAnnotations;

namespace Validacao
{
    public class UsuarioModel
    {
        [Required(ErrorMessage = "O campo é de preenchimento obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessageResourceType = typeof(Recursos.Idiomas.Linguagem), ErrorMessageResourceName = "MSG_OBRIGATORIO"), EmailAddress]
        public string Email { get; set; }
        [Required, StringLength(16, MinimumLength = 6)]
        public string Senha { get; set; }
    }
}