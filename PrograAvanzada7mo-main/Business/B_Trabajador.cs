using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class B_Trabajador
    {
        public static TrabajadorEntity TrabajadorPorNomina(string Nomina)
        {
            using var db = new CetiContext();
            return db.Trabajadores
                .Include(t => t.Plaza)
                .ToList()
                .LastOrDefault(t => t.TrabajadorNomina == Nomina);
        }
    }
}
