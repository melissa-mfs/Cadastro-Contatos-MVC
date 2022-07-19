using Contatos_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contatos_MVC.Data.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();

        ContatoModel Adicionar(ContatoModel contato);
    }
}