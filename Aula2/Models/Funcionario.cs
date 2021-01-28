namespace Aula2.Models
{
    public class Funcionario
    {
        //essa é uma entidade, que sera convertida em uma tabela no banco de dados
        public int Id {get; set;}
        public string Nome {get; set;}
        public float Salario {get; set;}
        //adicionado cpf posteriormente
        public string Cpf {get; set;}
    }
}