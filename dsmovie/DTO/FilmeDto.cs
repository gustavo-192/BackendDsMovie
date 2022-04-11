using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dsmovie.DTO
{
    public class FilmeDto
    {
        public int Id { get; set; }
        public double Avaliacao { get; set; }
        public int Contagem { get; set; }
        public string TituloFilme { get; set; }
        public string Imagem { get; set; }

    }

}
