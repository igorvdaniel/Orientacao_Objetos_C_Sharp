class Musica
{
    public Musica(string nome, Banda artista)
    {
        Nome = nome;
        Artista = artista;

    }

    public Banda Artista {get;}
    public string Nome { get;}
    public int Duracao { get; set; }
    public bool Disponivel { get; set;} //Propriedade -> pascal Case
    /*
    public string Descricao_Resumida 
    {
        get
        {
            return $"A música {Nome} pertence à banda {Artista}";
        }
    } */ // Posso só apagar o set/get para impedir input de dados e alterar o get/set.

    public string DescricaoResumida => $"A música {Nome} pertence ao artista {Artista.Nome}"; //Função Lambda

    /*
    public void set_disponivel(bool valor)
    {
        disponivel = valor;
    }

    public bool get_disponivel()
    {
        return disponivel;
    }
    */

    public void Exibir_ficha_tecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine($"Está disponível no plano");    
        }
        else
        {
            Console.WriteLine($"Não está disponível! Adiquira o plano PLUS!");
        }
    }
}