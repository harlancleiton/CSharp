using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AutoImplementParte2
{
    class Pessoa
    {
        private string _nome;
        public string Nome {
            get { return _nome.ToLower(); }
            set {
                _nome = value.Trim().ToUpper();
            }
        }
    }
}
