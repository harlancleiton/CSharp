using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MinhaValidacao
{
    public class MinhaValidacaoAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value.ToString().Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}