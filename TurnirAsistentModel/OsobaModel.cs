using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class OsobaModel
    {
        /// <summary>
        /// ime igraca
        /// </summary>
        public string Ime { get; set; }
        /// <summary>
        /// prezime igraca
        /// </summary>
        public string Prezime { get; set; }
        /// <summary>
        /// mail adresa igrača za primanje obavijesti o slijedećoj utakmici
        /// </summary>
        public string EmailAdresa { get; set; }
        /// <summary>
        /// broj mobitela igrača da dobije obavijest o slijedećoj utakmici
        /// </summary>
        public string BrojMobitela { get; set; }

    }
}
