class User
{
    public User(string nome, string email)
    {
        Nome = nome;
        Email = email;
        Plano_Plus = false;
    }
    public string Nome { get;}
    public string Email {get;}
    private bool Plano_Plus {get; }

    private List<Musica> favoritos = new List<Musica>();

    public void Favoritar(Musica musica)
    {
        favoritos.Add(musica);
    }
    public void Desfavoritar(Musica musica)
    {
        favoritos.Remove(musica);
    }

    

}