class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void Exibir_ficha_tecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel)
        {
            Console.WriteLine($"Está disponível no plano");    
        }
        else
        {
            Console.WriteLine($"Não está disponível! Adiquira o plano PLUS!");
        }
    }
}