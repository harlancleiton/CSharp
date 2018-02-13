using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Resumo

/*
 * Adicionar referencia System.Component.Model.DataAnnotations
 * 
 */

#endregion

namespace Validacao
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioModel usuario = new UsuarioModel()
            {
                Nome = "João",
                Email = "mail",
                Senha = "1234"
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