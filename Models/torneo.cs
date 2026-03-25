using System.Collections.Generic;

namespace LigaBetPlaySimulador.Models
{
    public class Torneo
    {
        public List<Equipo> Equipos { get; set; }

        public Torneo()
        {
            Equipos = new List<Equipo>();
        }
    }
}
