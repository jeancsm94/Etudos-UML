public class ContaPoupanca : ContaComum
{
    private DateTime aniversarioConta;

    public double rendaConta(DateTime data, double rendaConta){
        if (data.Month == aniversarioConta.Month)
            return saldoConta * rendaConta;
            
        return 0;
    }
}