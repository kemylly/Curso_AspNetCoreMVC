namespace Aula2.Models
{
    public class Produto
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        // relacionamento entre produto e categoria  1-1
        //entity ja entende que um produto tem uma categoria 
        public virtual Categoria Categoria{get; set;}   //chave estrangeira

        public override string ToString()
        {
            return "Id: " + this.Id + " Nome: " + this.Nome + " Categoria: [" + this.Categoria.ToString() + "] ";
        }
    }
}