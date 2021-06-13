using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class B_Jefe
    {
        public static bool EsJefe(string Nomina)
        {
            List<JefeEntity> jefes = new List<JefeEntity>();
            using var db = new CetiContext();
            jefes = db.Jefes
                        .Where(j => j.TrabajadorId == Nomina)
                        .ToList();
            if (jefes.ToArray().Length == 0)
                return false;
            return true;
        }
    }
}
