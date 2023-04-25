using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            string titulo, autor, usuario, senha;
            bool disponivel;
            int resp, resp_2;
            

            string[] livros = {"percy jackson", "harry potter","scott pilgrim","crepúsculo"};
            string[] autores = { "rick riordan", "jk rolling", "Bryan Lee", "stephenie meyer" };

            Console.WriteLine("Usuário");
            usuario = Console.ReadLine();
            Console.WriteLine("Senha");
            senha = Console.ReadLine();

            Login O = new Login(usuario, senha);

            do
            {
                
                    Console.WriteLine("Digite o título do livro");
                    titulo = Console.ReadLine().ToLower();
                    Console.WriteLine("Digite o autor do livro");
                    autor = Console.ReadLine().ToLower();

                int cont = 0;
                for (int i = 0; i < livros.Length; i++)
                {
                    if (titulo == livros[i] || autor == autores[i])
                    {
                    cont++;
                    }  
                }

                if (cont >= 1)
                {
                    disponivel = true;
                }
                else
                {
                    disponivel = false;
                }

                Livro L = new Livro(disponivel);
                do
                {
                    Console.WriteLine("Devolução ou empréstimo(1 para devolução e 2 para empréstimo)");
                    resp = int.Parse(Console.ReadLine());
                } while (resp != 1 && resp != 2);

                Info I = new Info(titulo,autor, disponivel);
                I.Informacoes(resp);

                
                Console.WriteLine("Deseja verificar outro livro?(1 para sim e 2 para não)");
                resp_2 = int.Parse(Console.ReadLine());
            } while (resp_2 == 1);

            Console.WriteLine("Muito obrigado!");


            Console.ReadKey();


            


            
        }
    }
}
