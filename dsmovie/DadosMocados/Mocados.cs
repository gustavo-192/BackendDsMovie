using dsmovie.Entities;
using System.Collections.Generic;

namespace Backend.DadosMocados
{
    public static class Mocados
    {

        public static List<Usuario> DbUsuarios = new List<Usuario>()
           {
            new Usuario(1, "maria@gmail.com"),
            new Usuario(2, "joao@gmail.com"),
            new Usuario(3, "ana@gmail.com"),
            new Usuario(4, "lucia@gmail.com"),
            new Usuario(5, "joaquim@gmail.com")
            };

        public static List<Filme> DbFilmes = new List<Filme>()
                {
                    new Filme(1, 4.5, 2, "The Witcher", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/jBJWaqoSCiARWtfV0GlqHrcdidd.jpg"),
                    new Filme(2, 3.3, 3, "Venom: Tempo de Carnificina", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/vIgyYkXkg6NC2whRbYjBD7eb3Er.jpg"),
                    new Filme(3, 0, 0, "O Espetacular Homem-Aranha 2: A Ameaça de Electro", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/u7SeO6Y42P7VCTWLhpnL96cyOqd.jpg"),
                    new Filme(4, 0, 0, "Matrix Resurrections", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/hv7o3VgfsairBoQFAawgaQ4cR1m.jpg"),
                    new Filme(5, 0, 0, "Shang-Chi e a Lenda dos Dez Anéis", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/cinER0ESG0eJ49kXlExM0MEWGxW.jpg"),
                    new Filme(6, 0, 0, "Django Livre", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/2oZklIzUbvZXXzIFzv7Hi68d6xf.jpg"),
                    new Filme(7, 0, 0, "Titanic", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/yDI6D5ZQh67YU4r2ms8qcSbAviZ.jpg"),
                    new Filme(8, 0, 0, "O Lobo de Wall Street", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/cWUOv3H7YFwvKeaQhoAQTLLpo9Z.jpg"),
                    new Filme(9, 0, 0, "Aves de Rapina: Arlequina e sua Emancipação Fantabulosa", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/jiqD14fg7UTZOT6qgvzTmfRYpWI.jpg"),
                    new Filme(10, 0, 0, "Rogue One: Uma História Star Wars", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/6t8ES1d12OzWyCGxBeDYLHoaDrT.jpg"),
                    new Filme(11, 0, 0, "Star Wars: A Guerra dos Clones", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/uK15I3sGd8AudO9z6J6vi0HH1UU.jpg"),
                    new Filme(12, 0, 0, "Star Wars: Episódio I - A Ameaça Fantasma", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/36LnijfQCOC89rCMOhn2OINXROI.jpg"),
                    new Filme(13, 0, 0, "Vingadores: Ultimato", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/7RyHsO4yDXtBv1zUU3mTpHeQ0d5.jpg"),
                    new Filme(14, 0, 0, "Thor", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/cDJ61O1STtbWNBwefuqVrRe3d7l.jpg"),
                    new Filme(15, 0, 0, "Cisne Negro", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/hqh5O4KssfJWI62HGAgrjHXbxhD.jpg"),
                    new Filme(16, 0, 0, "O Silêncio dos Inocentes", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/mfwq2nMBzArzQ7Y9RKE8SKeeTkg.jpg"),
                    new Filme(17, 0, 0, "Clube da Luta", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/hZkgoQYus5vegHoetLkCJzb17zJ.jpg"),
                    new Filme(18, 0, 0, "Guerra Mundial Z", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/31VpBgUX5O4Z3dn5ZbX8HLqoXH3.jpg"),
                    new Filme(19, 0, 0, "Harry Potter e as Relíquias da Morte - Parte 1", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/vcrgU0KaNj5mKUCIQSUdiQwTE9y.jpg"),
                    new Filme(20, 0, 0, "Harry Potter e a Pedra Filosofal", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/lvOLivVeX3DVVcwfVkxKf0R22D8.jpg"),
                    new Filme(21, 0, 0, "Alice no País das Maravilhas", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/qNdlZgz9yoSJ8f0YxQWfKGPoVV.jpg"),
                    new Filme(22, 0, 0, "Animais Fantásticos e Onde Habitam", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/8Qsr8pvDL3s1jNZQ4HK1d1Xlvnh.jpg"),
                    new Filme(23, 0, 0, "A Teoria de Tudo", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/kq2MHrRfH6RTfkvyDEmYLmGHE6U.jpg"),
                    new Filme(24, 0, 0, "O Livro de Boba Fett", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/sjx6zjQI2dLGtEL0HGWsnq6UyLU.jpg"),
                    new Filme(25, 0, 0, "O Último Duelo", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/4LrL40XecjGLRpX5I2gzMTUt04l.jpg"),
                    new Filme(26, 0, 0, "Interestelar", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/rAiYTfKGqDCRIIqo664sY9XZIvQ.jpg"),
                    new Filme(27, 0, 0, "Contato", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/yFkUPqBuUnbhYbQL8VFpTrAT9za.jpg"),
                    new Filme(28, 0, 0, "Duna", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/jYEW5xZkZk2WTrdbMGAPFuBqbDc.jpg"),
                    new Filme(29, 0, 0, "Aquaman", "https://www.themoviedb.org/t/p/w533_and_h300_bestv2/2cUsDz4TzFYHrKktT1bKHHQ7Cgm.jpg")
                };

        public static List<Avaliacao> DbAvaliacoes = new List<Avaliacao>()
        {
            new Avaliacao(1, 1, 5.0),
            new Avaliacao(1, 2, 4.0),
            new Avaliacao(2, 1, 3.0),
            new Avaliacao(2, 2, 3.0),
            new Avaliacao(2, 3, 4.0)
         };
    }
}