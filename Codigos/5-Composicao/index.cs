public class RevistaCientifica
{
    private string _tituloRevista;
    private long _serieRevista;
    private string _periodoRevista;
    private List<Edicao> _edicoes;

    public RevistaCientifica(string tituloRevista, long serieRevista, string periodoRevista, List<Edicao> edicoes)
    {
        if (edicoes.Count < 1)
            throw new Exception("Numero de edições invalido");

        this.tituloRevista = tituloRevista;
        this.serieRevista = serieRevista;
        this.periodoRevista = periodoRevista;
        this.edições = edições;
    }

    public Edicao publicaEdicao(Edicao edicao)
    {
        if (edicao == null)
            throw new Exception("Edicao nao pode ser nula");
        
        this.edicoes.Add(edicao);

        return edicao;
    }
}

public class Edicao
{
    private int numeroEdicao;
    private int volumeEdicao;
    private DateTime dataEdicao;
    private int tiragemEdicao;
    private List<Artigo> artigos;

    public Edicao(int numeroEdicao, int volumeEdicao, DateTime dataEdicao, int tiragemEdicao, List<Artigo> artigos)
    {
        if (artigos.Count > 5 && artigos.Count < 11)
            throw new Exception("Numero de artigos invalido");

        this.numeroEdicao = numeroEdicao;
        this.volumeEdicao = volumeEdicao;
        this.dataEdicao = dataEdicao;
        this.tiragemEdicao = tiragemEdicao;
        this.artigos = artigos;
    }
}

public class Artigo
{
    private string tituloArtigo;
}