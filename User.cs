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

    private List<Musica> Musicafavoritos = new List<Musica>();

    public void FavoritarMusica(Musica musica)
    {
        Musicafavoritos.Add(musica);
    }
    public void DesfavoritarMusica(Musica musica)
    {
        Musicafavoritos.Remove(musica);
    }

    

}