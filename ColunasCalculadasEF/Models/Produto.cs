namespace ColunasCalculadasEF.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public decimal ValorTotalEstoque { get; set; }
    }

}
