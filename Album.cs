class Album
{
    public string Nome {get; set;}
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

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