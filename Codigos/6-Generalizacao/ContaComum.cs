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

    public long abrirConta(int senha, double saldo, Pessoa pessoa)
    {

    }

    public int ConsultarConta(long numeroConta, int senha)
    {}

    public bool validarSenha(int senha){

    }

    public double emitirSaldo()
    {

    }

    public string EmitirExtrato(DateTime dataInicio, DateTime dataFim)
    {}

    public int SacarValor(double valor)
    {

    }

    public int DepositarValor(long numeroConta, double valor){

    }

    public int encerrarConta(long numeroConta, int senha)
    {
        
    }
}