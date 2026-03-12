class Podcast
{
    Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Host { get;}
    public string Nome { get;}
    private int TotalEpisodios => Episodios.Count();

    private List<Episodio> Episodios = new List<Episodio>();

    public void AdicionarEpisodios(Episodio episodio)
    {
        episodio.Ordem = Episodios[^1].Ordem + 1;
        Episodios.Add(episodio);
        // pessoas.Sort((p1, p2) => p1.Idade.CompareTo(p2.Idade));
        Episodios.Sort((e1, e2) => e1.Ordem.CompareTo(e2.Ordem));
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"O podcast {Nome} possui {TotalEpisodios} episódios e {Host} é seu host.");

        foreach(Episodio episodio in Episodios)
        {
            Console.WriteLine($"{episodio.Titulo} : {episodio.Resumo}");
        }

        Console.WriteLine($"\n \nEste poscast possui {TotalEpisodios}");
    }


}