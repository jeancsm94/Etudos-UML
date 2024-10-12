public class Socio {
    private string nomeSocio;
    private string endercoSocio;
    private string telefoneSocio;
    private DateTime aniversarioSocio;
    private List<Depeendente> dependentesSocio;

    public Socio(string nomeSocio, string enderecoSocio, string telefoneSocio, DateTime aniversarioSocio)
    {
        this.nomeSocio = nomeSocio;
        this.enderecoSocio = enderecoSocio;
        this.telefoneSocio = telefoneSocio;
        this.aniversarioSocio = aniversarioSocio;
    }
    public Socio(string nomeSocio, string enderecoSocio, string telefoneSocio, DateTime aniversarioSocio, List<Dependente> dependentes)
    {
        this.nomeSocio = nomeSocio;
        this.enderecoSocio = enderecoSocio;
        this.telefoneSocio = telefoneSocio;
        this.aniversarioSocio = aniversarioSocio;
        this.dependentesSocio = dependentes;
    }
}

public class Dependente {
    private string nomeDepentende;
    private DateTime aniversarioDependente;
    public Socio socio;
    public Dependente(string nomeDependente, DateTime aniversarioDependente, Socio socio)
    {
        if (socio == null)
         throw new Exception("Socio nao pode ser nulo");
        
        this.nomeDependente = nomeDependente;
        this.aniversarioDependente = aniversarioDependente;
    }
}