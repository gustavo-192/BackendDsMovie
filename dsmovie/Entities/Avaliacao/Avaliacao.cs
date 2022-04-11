using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dsmovie.Entities
{
    public class Avaliacao 
    {
        public int IdFilme { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public Filme Filme { get; set; }
        public double Valor { get; set; }

        public Avaliacao()
        {

        }                                                                           
        public Avaliacao(int idFilme, int idUsuario, double valor)
        {
            IdFilme = idFilme;
            IdUsuario = idUsuario;
            Valor = valor;
        }
    }
}
