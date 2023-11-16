namespace AnedotasApp2.Models
{
    public class Jokes
    {

        public int Id { get; set; }
        public string JokePergunta { get; set; }
        public string  JokeResposta { get; set; }

        public Jokes()
        {
            Id = 0;
            JokePergunta = String .Empty;
            JokeResposta = String .Empty;

        }

    }
}
