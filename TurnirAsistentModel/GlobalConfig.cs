using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnirAsistentModel.Konekcije;

namespace TurnirAsistentModel
{
    public static class GlobalConfig
    {
        public static IKonekcija Konekcija { get; private set; }

        public static void ZapoceteKonekcije(TipBazePodataka db)
        {
            if (db == TipBazePodataka.Sql)
            {
               
                SqlKonekcija sql = new SqlKonekcija();
                Konekcija = sql;
            }
            else if (db == TipBazePodataka.TextDatoteka)
            {
                
                TextKonekcija text = new TextKonekcija();
                Konekcija = text;
            }
        }

        public static string KonekcijaString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }


}
