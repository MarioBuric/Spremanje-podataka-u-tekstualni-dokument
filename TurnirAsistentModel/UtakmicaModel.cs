using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class UtakmicaModel
    {
        /// <summary>
        /// ekipa koja sudjeluje na turniru
        /// </summary>
        public List<SudionikModel> Natjecatelji { get; set; } = new List<SudionikModel>();
        /// <summary>
        /// rezultat odabrane ekipe u utakmici
        /// </summary>
        public EkipaModel Pobjednik { get; set; }
        /// <summary>
        /// prethodna utakmica u kojoj je ova ekipa bila pobjednik
        /// </summary>
        public int BrojRunde { get; set; }
        
    }
}
