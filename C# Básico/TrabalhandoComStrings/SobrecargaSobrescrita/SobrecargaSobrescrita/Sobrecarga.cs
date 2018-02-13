using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaSobrescrita
{
    class Sobrecarga
    {
        public float calcularMedia(float i, float j)
        {
            return (i + j) / 2;
        }
        public float calcularMedia(float i, float j, float l)
        {
            return (i + j + l) / 3;
        }
    }
}
