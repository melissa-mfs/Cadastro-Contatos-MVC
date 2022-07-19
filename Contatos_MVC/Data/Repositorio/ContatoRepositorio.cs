using Contatos_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contatos_MVC.Data.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        //Extrai variavel bancoContext
        private readonly BancoContext _bancoContext;

        //injeta para dentro de ContatoRepositorio
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }

        //gravar no banco de dados
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();

            return contato;
        }

    }
}
