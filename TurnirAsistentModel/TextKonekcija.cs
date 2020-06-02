using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class TextKonekcija : IKonekcija
    {

        private const string NagradeDatoteke = "NagradaModeli.csv";

        
        public NagradaModel StvoriNagradu(NagradaModel model)
        {
            
            List<NagradaModel> nagrade = NagradeDatoteke.CijeliPutPodataka().UcitajDatoteku().PretvoriUNagradaModel();

            int sadasnjiID = 1;

            if (nagrade.Count > 0)
            {
                sadasnjiID = nagrade.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = sadasnjiID;

            nagrade.Add(model);

            nagrade.SpremiUNagradaDatoteke(NagradeDatoteke);

            return model;
        }
    }
}
