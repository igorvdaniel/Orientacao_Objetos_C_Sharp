class Banda
{
    public string Nome { get; set; }
    private List<Album> albuns = new List<Album>();

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda: {Nome}");
        foreach(Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome}");
        }
    }
}