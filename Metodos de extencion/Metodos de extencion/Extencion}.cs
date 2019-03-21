using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_extencion
{
    public static class Extencion_
    {
        public static bool Digito(this String str)
        {
            List<char> tempStr = str.ToList();
            tempStr.RemoveAll(c => c == ' ');
            bool r = tempStr.All(c => Char.IsDigit(c));
            return r;

        }
        public static bool Letra(this String str)
        {
            List<char> tempStr = str.ToList();
            tempStr.RemoveAll(c => c == ' ');
            bool r = tempStr.All(c => Char.IsLetter(c));
            return r;

        }
        public static bool LetraoDigito(this String str)
        {
            List<char> tempStr = str.ToList();
            tempStr.RemoveAll(c => c == ' ');
            bool r = tempStr.All(c => Char.IsLetterOrDigit(c));
            return r;

        }


    }
}
