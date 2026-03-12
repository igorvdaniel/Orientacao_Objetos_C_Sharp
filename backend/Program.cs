Banda banda1 = new Banda("Legião Urbana");
Banda banda2 = new Banda("IVD");

Album album1 = new Album("Album1", banda1);
Album album2 = new Album("Album2", banda2);


banda1.AdicionarAlbum(album1);

Musica musica1 = new Musica("Será", banda1)
{
    Disponivel = true,
    Duracao = 1000,
};

Musica musica2 = new Musica("Hoje", banda1)
{
    Disponivel = false,
    Duracao = 0,
};

Musica musica3 = new Musica("Hossssje", banda2)
{
  Disponivel = false,
  Duracao = 0,  
};

Console.WriteLine(musica1.DescricaoResumida);

album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);
album2.AdicionarMusica(musica3);

album1.ExibirMusicas();
album1.ExibirDuracaoTotal();

Console.WriteLine();

banda1.ExibirDiscografia();

Console.WriteLine();

musica1.Exibir_ficha_tecnica();
musica2.Exibir_ficha_tecnica();
Console.ReadKey();