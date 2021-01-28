using Microsoft.EntityFrameworkCore;
using Aula2.Models;
//using aso_net_e_entity_framework_master.Models;

namespace Aula2.Database
{
    public class ApplicationDBContext : DbContext
    {
        //mapear a minha entidade funcionario que ira representar uma tabela no BD
        public DbSet<Funcionario> Funcionarios {get; set;}

        public DbSet<Categoria> Categorias {get; set;}

        public DbSet<Produto> Produtos {get; set;}


        //passar um parametro para receber o usuario do bd
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }

        //onde configura o lazy loading
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        // protected override void OnModelCreating(ModelBuilder modelBuilder) //flente api - customizar as tabelas
        // {
        //     //modelBuilder.Entity<Produto>().HasKey(p => p.Codigofrbarras); //mudar a chave primaria
        //     //modelBuilder.Entity<Produto>().ToTable("Arquivos"); //mudar nome da tabela produto para arquivos
        //     modelBuilder.Entity<Produto>().Property(p => p.Nome).HasMaxLength(100); //colocando maximo de cacterie na propriedade nome
        // }
    }
}