class Album
{
    public Album(string nome, Banda artista)
    {
        Nome = nome;
        Artista = artista;
    }
    public string Nome {get;}
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public Banda Artista { get; }

    private List<Musica> musicas = new List<Musica>();

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        Console.WriteLine($"Musicas do album {Nome}:\n");
        foreach(var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
    }

    public void ExibirDuracaoTotal()
    {
        Console.WriteLine($"{DuracaoTotal}");
    }
}