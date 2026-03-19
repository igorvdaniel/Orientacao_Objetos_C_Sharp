namespace ScreenSound.Modelos;

internal class Avaliacao // Internal = Visibiliade de classes; Apenas o projeto vai conseguir enxergar;
{
    public Avaliacao(int nota)
    {
        if (nota > 10 || nota < 0)
         throw new ArgumentOutOfRangeException(nameof(nota), "O valor da nota deve estar entre 0 e 10.");
        
        Nota = nota;
    }

    public int Nota { get;}
}