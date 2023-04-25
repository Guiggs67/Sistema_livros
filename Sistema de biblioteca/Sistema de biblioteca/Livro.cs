using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_biblioteca
{
    public class Livro
    {
       
        public bool _disponivel;

        public Livro(bool disponivel)
        {
       
            _disponivel = disponivel;
        }

        public void Emprestar()
        {
            string resp="s";
            do
            {
                if (_disponivel == true)
                {
                    Console.WriteLine("Disponível");
                    Console.WriteLine("Deseja confirmar o empréstimo?(S/N)");
                    resp = Console.ReadLine().ToLower();

                }
                if (resp == "s")
                {
                    Console.WriteLine("Empréstimo concluído!");
                }
                else if (resp == "n")
                {
                    Console.WriteLine("Indeciso, hein!");
                }

                else
                {
                    Console.WriteLine("Indisponível");
                }
            } while (resp != "s" && resp != "n");

           
        }

        public void Devolver()
        {
            Console.WriteLine("Devolvido");
        }

       
    }

    
}
