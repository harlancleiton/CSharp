using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MinhaValidacao
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioModel usuario = new UsuarioModel()
            {
                Nome = "João",
                Email = "mail@mail.com",
                Senha = "123456"
            };
            ValidationContext validationContext = new ValidationContext(usuario);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            if (Validator.TryValidateObject(usuario, validationContext, validationResults, true) == false)
            {
                foreach (var erro in validationResults)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }
            }

            Console.ReadKey();
        }
    }
}
