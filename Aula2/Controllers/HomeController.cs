using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Aula2.Models;
using Aula2.Database;
using Microsoft.EntityFrameworkCore;

namespace Aula2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDBContext database;
        public HomeController(ApplicationDBContext database) //aspnet injeta esse objeto
        {
            this.database = database;
        }

        //incialmente veio esse contrtutor, mas ele comecou a dar conflito com o contrutor acima que
        //que injeta as categorias e conecta com o banco
        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Teste()
        {
            /*Categoria c1 = new Categoria();
            c1.Nome = "Kemylly";
            Categoria c2 = new Categoria();
            c2.Nome = "Luciana";
            Categoria c3 = new Categoria();
            c3.Nome = "Vinycius";
            Categoria c4 = new Categoria();
            c4.Nome = "Moe";

            List<Categoria> catList = new List<Categoria>();
            catList.Add(c1);
            catList.Add(c2);
            catList.Add(c3);
            catList.Add(c4);

            database.AddRange(catList); //pega todos os elemntos da lista e salva no BD

            database.SaveChanges(); */

            //var listaDeCategorias = database.Categorias.ToList(); //lista todo mundo
            //lista apenas o que atende a condicao where
            //var listaDeCategorias = database.Categorias.Where(cat => cat.Nome == "Kemylly").ToList(); //jeito feio de fazer
            var listaDeCategorias = database.Categorias.Where(cat => cat.Nome.Equals("Kemylly")).ToList();  //jeito melhor de fazer

            Console.WriteLine("-------Categorias ----------");

            listaDeCategorias.ForEach(categoria => {
                Console.WriteLine(categoria.ToString());
            });

            return Content("Dados salvos");
        }

        public IActionResult Relacionamento()
        {
            //primeiro a gente criou essa parte com os produtos e cadastrou no banco
            //depois comenta ela e depois que cria uma lista e for para xibir os dados
            /*Produto p = new Produto();
            p.Nome = "Batata";
            p.Categoria = database.Categorias.First(c => c.Id == 1);

            Produto p2 = new Produto();
            p2.Nome = "Frango";
            p2.Categoria = database.Categorias.First(c => c.Id == 1);

            Produto p3 = new Produto();
            p3.Nome = "Bolo";
            p3.Categoria = database.Categorias.First(c => c.Id == 2);

            database.Add(p);
            database.Add(p2);
            database.Add(p3);

            database.SaveChanges(); */

            //usar o recurso de include para utlizar uma exibicicao com chave estrangeira 1-1
            /*var listaDeProdutos = database.Produtos.Include(p => p.Categoria).ToList();

            listaDeProdutos.ForEach(produto => 
            {
                Console.WriteLine(produto.ToString());
            });  */

            //listar uma categoria especifica 1-m usando where
            //var listaDeProdutosDeUmaCategoria = database.Produtos.Include(p => p.Categoria).Where(p => p.Categoria.Id == 1).ToList();
            var listaDeProdutosDeUmaCategoria = database.Produtos.Where(p => p.Categoria.Id == 1).ToList();

            listaDeProdutosDeUmaCategoria.ForEach(produto => 
            {
                Console.WriteLine(produto.ToString());
            });

            return Content("Relacionamento");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
