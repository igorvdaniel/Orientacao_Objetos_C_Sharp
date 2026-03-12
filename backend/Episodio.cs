class Episodio
{
    Episodio(string titulo, int ordem, int duracao)
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;
    }

    public int Duracao { get; }
    public string Titulo { get;}
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", Convidados)}";

    private List<string> Convidados = new List<string>();

    public int Ordem {get; set;}

    public void AdicionarConvidados(string convidado)
    {
        Convidados.Add(convidado);
    }
}