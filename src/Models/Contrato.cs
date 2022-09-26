namespace src.Models;
public class Contrato{
    public int Id { get; set; }
    public DateTime DataCriacao { get; set; }
    public string tokenID { get; set; }
    public double Valor { get; set; }
    public bool pago { get; set; }
    public int PessoaId { get; set; }

    public Contrato(){
        this.DataCriacao = DateTime.Now;
        this.Valor = 0;
        this.tokenID = "000000";
        this.pago = false;
    }

    public Contrato(string tokenID, double Valor){
        this.DataCriacao = DateTime.Now;
        this.tokenID = tokenID;
        this.Valor = Valor;
        this.pago = false;
    }
}