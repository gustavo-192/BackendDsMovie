namespace dsmovie.Entities
{
    public class Filme : Entity
    {
        public string Title { get; set; }
        public int Count { get; set; }
        public double Score { get; set; }
        public string Image { get; set; }

        public Filme()
        {

        }
        public Filme(long id, double avaliacao, int contagem, string titulo, string imagem)
        {
            Id = id;
            Score = avaliacao;
            Count = contagem;
            Title = titulo;
            Image = imagem;
        }
    }
}
