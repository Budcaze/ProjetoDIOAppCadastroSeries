using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO.SERIES.Interfaces;

namespace DIO.SERIES
{
    public class GerenciadorAnimes : IRepository<Anime>
    {
        private List<Anime> listaAnimes = new List<Anime>();
        public void Atualiza(int id, Anime entidade)
        {
            listaAnimes[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaAnimes[id].Excluir();
        }

        public void Insere(Anime entidade)
        {
            listaAnimes.Add(entidade);
        }

        public List<Anime> Lista()
        {
            return listaAnimes;
        }

        public int ProximoId()
        {
            return listaAnimes.Count;
        }

        public Anime RetornaPorId(int id)
        {
            return listaAnimes[id];
        }
    }
}
