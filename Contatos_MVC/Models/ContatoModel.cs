using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contatos_MVC.Models
{
    //Colunas da tabela
    public class ContatoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}