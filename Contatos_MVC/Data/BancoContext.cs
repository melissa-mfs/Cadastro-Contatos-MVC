using Contatos_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contatos_MVC.Data
{
    //classe que herda da classe DbContext
    public class BancoContext : DbContext
    {
        //Configura o contexto das tabelas
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        //Tabela de Contatos
        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
//Após criar a conexão(String+Service), as colunas, a config da tabela e a tabela:
//No console do Nuget digite os dois comandos:
//Add-Migration CriandoTabelaContato -context BancoContext
//Update-Database -context BancoContext
