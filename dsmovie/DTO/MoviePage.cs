using dsmovie.Entities;
using System.Collections.Generic;

namespace dsmovie.DTO
{
    public class MoviePage
    {
        public List<Filme> Content { get; set; } 
        public bool Last { get; set; }
        public int TotalPages { get; set; }
        public int TotalElements { get; set; }
        public int Size { get; set; }
        public int Number { get; set; }
        public bool First { get; set; }
        public int NuberOfElements { get; set; }
        public bool Empty { get; set; }
    }
}
