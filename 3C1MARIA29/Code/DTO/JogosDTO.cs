using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1MARIA29.Code.DTO
{
    class JogosDTO
    {
        private int _id;
        private string _nome, _preco, _quantidade;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Preco { get => _preco; set => _preco = value; }
        public string Quantidade { get => _quantidade; set => _quantidade = value; }
    }
}
