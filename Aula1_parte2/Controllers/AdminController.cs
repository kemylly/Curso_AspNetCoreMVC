using System;
using Microsoft.AspNetCore.Mvc;

namespace Aula1_parte2.Controllers
{
    //sempre que criar uma classe controller, Usar controller no nome
    //Importar a classe controler como heranca e adicionar sua biblioteca

    [Route("painel/admin")] //mudando rotas
    public class AdminController : Controller
    {
        //mapeando minha clase / Get - permite acessar acoes diretos da barra do navegador
        [HttpGet("batata/{nome}")] 
        //para chegar em index usasse painel/admin/batata
        //passando como parametro nome
        //[HttpGet("Segundo/{nome:int}")]
        public IActionResult Index(string nome) //isso é uma acao /com um parametro
        {
            return Content("Ola mundo " + nome);
        }

        [HttpGet("Numero/{numero:int?}")] //passando um parametro int
        public IActionResult numero(int numero) //isso é uma acao /com um paremetro
        {
            return Content("esse é o numero: " + numero);
        }

        [HttpGet("juncao/{numero:int}/{nome}")] //passando um parametro int
        public IActionResult Juncao(int numero, string nome) //isso é uma acao /com um paremetro
        {
            return Content("Esse é o numero: " + numero + " e o nome é: " + nome);
        }

        [HttpGet("son")]
        [HttpGet("")] //acssa mesmo sem passar son
        public IActionResult school()
        {
            return Content("Essa e a acao school");
        }

        [HttpGet("diferente")]
        public IActionResult query()
        {
            var nome = Request .Query["nome"]; //query string -- /diferente?nome
            return Content("Essa é uma query string " + nome);
        }

        // [HttpGet("view")]
        // public IActionResult Vizualizar()
        // {
        //     return View(); //vair retornar a pagina cshtml vizualizar que está em view
        //     //ele ja faz isso sozinho devido ao jeio que esta organizado os nomes
        // }

        // [HttpGet("view")]
        // public IActionResult Vizualizar()
        // {
        //     ViewData["helloWorld"] = false;  //mando informacoes para minha view
        //     return View(); 
        // }

        [HttpGet("view")]
        public IActionResult Vizualizar()
        {
            ViewData["helloWorld"] = true; //mando informacoes para minha view
            ViewData["nome"] = "kemylly";

            return View("nada"); //passar a view que quero usar
        }
    }
}