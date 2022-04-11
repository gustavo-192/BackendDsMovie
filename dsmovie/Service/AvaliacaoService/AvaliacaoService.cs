using dsmovie.Entities;
using dsmovie.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dsmovie.Service.AvaliacaoService
{
    public class AvaliacaoService : Service, IAvaliacaoService
    {
        private IAvaliacaoRepository _avaliacaoRepository;

        public AvaliacaoService(IAvaliacaoRepository avaliacaoRepository)
        {
            _avaliacaoRepository = avaliacaoRepository;
        }

        public void RegisterScore(int avaliacao)
        {
            _avaliacaoRepository.RegisterScore(avaliacao);
        }
    }
}
