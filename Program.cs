Musica musica1 = new Musica();
Musica musica2 = new Musica();
Musica musica3 = new Musica();
Album album1 = new Album();
Banda banda1 = new Banda();

musica1.Nome = "Será";
musica1.Artista = "Legião Urbana";
//musica1.set_disponivel(true);
musica1.Disponivel = true;
musica1.Duracao = 1000;
Console.WriteLine(musica1.DescricaoResumida);

musica2.Nome = "Hoje";
musica2.Artista = "ivd";
// musica2.set_disponivel(false);
musica2.Disponivel = false;
musica2.Duracao = 0;

musica3.Nome = "Hossssje";
musica3.Artista = "ivsssssd";
musica3.Disponivel = false;
musica3.Duracao = 0;

album1.Nome = "Album1";
album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);

album1.ExibirMusicas();
album1.ExibirDuracaoTotal();

Console.WriteLine();

banda1.Nome = "Banda1";
banda1.AdicionarAlbum(album1);
banda1.ExibirDiscografia();

Console.WriteLine();

musica1.Exibir_ficha_tecnica();
musica2.Exibir_ficha_tecnica();
Console.ReadKey();