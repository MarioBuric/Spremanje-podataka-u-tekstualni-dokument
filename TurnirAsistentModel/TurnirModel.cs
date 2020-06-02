using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class TurnirModel
    {
        /// <summary>
        /// naziv turnira koji je kreiran
        /// </summary>
        public string NazivTurnira { get; set; }
        /// <summary>
        /// plaćanje za ulazak u turnir
        /// </summary>
        public decimal Kotizacija { get; set; }
        /// <summary>
        /// lista timova koji su prijavljeni na turniru
        /// </summary>
        public List<EkipaModel> PrijavljeniTimovi { get; set; } = new List<EkipaModel>();
        /// <summary>
        /// lista nagrada za prva tri mjesta (imenuj ih)
        /// </summary>
        public List<NagradaModel> Nagrade { get; set; } = new List<NagradaModel>();
        /// <summary>
        /// U turniru ima vise rundi, treba lista rundi koje ce se nalaziti u turniru 
        /// </summary>
        public List<List<UtakmicaModel>> Runde { get; set; } = new List<List<UtakmicaModel>>();
    }
}
