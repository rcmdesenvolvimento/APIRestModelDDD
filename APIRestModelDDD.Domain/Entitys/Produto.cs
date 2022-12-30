namespace APIRestModelDDD.Domain.Entitys
{
    public class Produto : Base
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool isDisponivel { get; set; }
    }
}
