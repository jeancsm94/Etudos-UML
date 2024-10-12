public class Pessoa
{
    protected string nomePessoa;
    protected string enderecoPessoa;
    protected string telefonePessoa;
    protected double rendaPessoa;
    protected int situacaoPessoa = 1;

    public Pessoa(string nomePessoa, string enderecoPessoa, string telefonePessoa, double rendaPessoa)
    {
        this.nomePessoa = nomePessoa;
        this.enderecoPessoa = enderecoPessoa;
        this.telefonePessoa = telefonePessoa;
        this.rendaPessoa = rendaPessoa;
    }
}

public class ContaComum {
    protected long numeroConta;
    protected DateTime aberturaConta;
    protected DateTime fechamentoConta;
    protected int situacaoConta = 1;
    protected int senhaConta;
    protected double saldoConta;
    protected List<Pessoa> pessoas;

    public ContaComum(long numeroConta, DateTime aberturaConta, int senhaConta, double saldoConta, List<Pessoa> pessoas)
    {
        if (pessoas == null && pessoas.Count <= 0)
            throw new Exception("Pessoa nao pode ser nula");
        
        this.numeroConta = numeroConta;
        this.aberturaConta = aberturaConta;
        this.senhaConta = senhaConta;
        this.saldoConta = saldoConta;
        this.pessoa = pessoa;        
    }
}