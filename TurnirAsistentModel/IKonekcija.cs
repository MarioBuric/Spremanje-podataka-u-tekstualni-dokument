﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public interface IKonekcija
    {
        NagradaModel StvoriNagradu(NagradaModel model);
    }
}