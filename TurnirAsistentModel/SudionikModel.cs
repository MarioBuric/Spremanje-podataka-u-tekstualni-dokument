using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class SudionikModel
    {
        /// <summary>
        ///  ekipa koja se natjeće na turniru
        /// </summary>
        public EkipaModel NatjecateljskaEkipa { get; set; }
        /// <summary>
        /// rezultat ekipe 
        /// </summary>
        public double Rezultat { get; set; }
        /// <summary>
        /// Prethodna utakmica koju je ekipa odigrala
        /// </summary>
        public UtakmicaModel PrethodnaUtakmica { get; set; }
    }
}
