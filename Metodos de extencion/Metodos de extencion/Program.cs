using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_extencion
{
    class Program
    {
        static void Main(string[] args)
        {
            string ejemplo = "Ces(///4ar";
            if(ejemplo.Digito())
            {
                Console.WriteLine("Es digito");
            }
            if (ejemplo.Letra())
            {
                Console.WriteLine("Es letra");
            }
            if (ejemplo.LetraoDigito())
            {
                Console.WriteLine("Es letras con digitos");
            }
            Console.ReadKey();
        }
    }
}
