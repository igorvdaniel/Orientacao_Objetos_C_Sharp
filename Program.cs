Musica musica1 = new Musica();
Musica musica2 = new Musica();

musica1.Nome = "Será";
musica1.Artista = "Legião Urbana";
//musica1.set_disponivel(true);
musica1.Disponivel = true;
musica1.Duracao = 1000;
Console.WriteLine(musica1.Descricao_Resumida);

musica2.Nome = "Hoje";
musica2.Artista = "ivd";
// musica2.set_disponivel(false);
musica2.Disponivel = false;
musica2.Duracao = 0;

musica1.Exibir_ficha_tecnica();
musica2.Exibir_ficha_tecnica();
Console.ReadKey();