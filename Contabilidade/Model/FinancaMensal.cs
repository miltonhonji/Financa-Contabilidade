namespace Contabilidade.Model
{
    public class FinancaMensal
    {
        public string CentroCusto { get; set; }
        public double ValorRecebido { get; set; }
        public int MesRecebido { get; set; }
        public int NomeEmpresaPagadora { get; set; }
    }
}