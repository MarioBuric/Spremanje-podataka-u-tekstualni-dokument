using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel.Konekcije
{
    public class SqlKonekcija : IKonekcija
    {
        
        public NagradaModel StvoriNagradu(NagradaModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.KonekcijaString("TurnirBaza")))
            {
                var p = new DynamicParameters();
                p.Add("@osvojenoMjesto", model.OsvojenoMjesto);
                p.Add("@nazivMjesta", model.NazivMjesta);
                p.Add("@iznosNagrade", model.IznosNagrade);
                p.Add("@postotakNagrade", model.PostotakNagrade);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spNagrada_Upis", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@ID");

                return model;
            }
        }
    }
}
