using System;
namespace Aula2.Models
{
    public class Categoria //entidade principal
    {
         public int Id {get; set;}
        public string Nome {get; set;}

        public override string ToString()
        {
            //return base.ToString();
            return "Id: " + this.Id + " Nome: " + this.Nome;
        }
    }
}