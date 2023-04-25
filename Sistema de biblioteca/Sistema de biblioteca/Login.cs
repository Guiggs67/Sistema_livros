using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_biblioteca
{
    public class Login
    {
        public string _usuario;
        public string _senha;

        public Login(string usuario, string senha)
        {
            _usuario = usuario;
            _senha = senha;
        }
    }
}
