public class Professor
{
    private string nomeProfessor;
    private List<Turma> turmas;
    private List<SalaDeAula> salasDeAulaOcupadas;
    public Professor(string nomeProfessor)
    {
        this.nomeProfessor = nomeProfessor;
    }
}

public class Turma
{
    private string nomeTurma;
    private List<Professor> Professores;

    public Turma(string nomeTurma)
    {
        this.nomeTurma = nomeTurma;
    }
}

puclic class SalaDeAula
{
    private bool Ocupada;
    private Professor Professor;

    public SalaDeAula(bool Ocupada)
    {
        this.Ocupada = Ocupada;
    }

    public SalaDeAula(bool Ocupada, Professor Professor, Turma turma)
    {
        this.Ocupada = Ocupada;
        this.Professor = Professor;
    }
}
