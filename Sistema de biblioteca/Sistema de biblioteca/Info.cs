using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_biblioteca
{
    public class Info : Livro
    {
        public string _autor;
        public string _titulo;
        public Info(string titulo, string autor, bool disponivel) : base(disponivel)
        {
            this._autor = autor;
            this._titulo = titulo;
            this._disponivel = disponivel;
        }

        public void Informacoes(int resp)
        {
            Console.WriteLine(_titulo);
            Console.WriteLine(_autor);
            if (resp == 2)
            {
                Emprestar();
            }
            else
            {
                Devolver();
            }
        }
    }
}
