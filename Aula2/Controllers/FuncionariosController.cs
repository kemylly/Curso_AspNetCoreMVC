using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Aula2.Models;
using Aula2.Database;

namespace Aula2.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly ApplicationDBContext database;
        public FuncionariosController(ApplicationDBContext database) //aspnet injeta esse objeto
        {
            this.database = database;
        }
        public IActionResult Index() //listar funcinarios
        {
            var funcionarios = database.Funcionarios.ToList();
            return View(funcionarios);
        }

        public IActionResult Cadastrar() //formulario
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            Funcionario funcionario = database.Funcionarios.First(registro => registro.Id == id); //procura uma query no bd para achar o id
            return View("Cadastrar", funcionario); //usar o mesmo formulario
        }

        public IActionResult Deletar(int id)
        {
            Funcionario funcionario = database.Funcionarios.First(registro => registro.Id == id); //procura uma query no bd para achar o id
            database.Funcionarios.Remove(funcionario);
            database.SaveChanges(); //sempre que faz uma modificacao no bd tem qu dar um savechanges para salvar
            return RedirectToAction("Index");
        }

        [HttpPost] //essa action so pode ser acessada pelo metodo post
        public IActionResult Salvar(Funcionario funcionario) //action
        {
            //salvando as informacoes no BD
            if(funcionario.Id == 0)
            {
                //salve um novo funcionario
                database.Funcionarios.Add(funcionario);
            }
            else
            {
                //atualizar um funcionario
                Funcionario funcionarioDoBanco = database.Funcionarios.First(registro => registro.Id == funcionario.Id);
                
                funcionarioDoBanco.Nome = funcionario.Nome;
                funcionarioDoBanco.Salario = funcionario.Salario;
                funcionarioDoBanco.Cpf = funcionario.Cpf;

            }
            
            //database.Funcionarios.Add(funcionario);
            database.SaveChanges();
            //return Content("Funcionario Salvo");
            return RedirectToAction("Index");
        }
    }
}
