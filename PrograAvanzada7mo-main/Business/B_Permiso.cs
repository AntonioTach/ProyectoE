using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class B_Permiso
    {
        public static List<PermisoEntity> PermisoLista()
        {
            using var db = new CetiContext();
            return db.Permisos
                .Include(p => p.Trabajador)
                .Include(p => p.JefeInmediato).ThenInclude(jefe => jefe.Trabajador)
                .ToList();
        }
        public static PermisoEntity PermisoPorId(int Id)
        {
            using var db = new CetiContext();
            return db.Permisos.ToList().LastOrDefault(p => p.PermisoId == Id);
        }
        public static List<PermisoEntity> PermisosPorTrabajador(string Nomina)
        {
            using var db = new CetiContext();
            return db.Permisos
                .Include(p => p.Trabajador)
                .Include(p => p.JefeInmediato).ThenInclude(jefe => jefe.Trabajador)
                .Where(p => p.TrabajadorId == Nomina)
                .OrderByDescending(p => p.PermisoFechaAplicacion)
                .ToList();
        }
        public static void CrearPermiso(PermisoEntity oPermiso)
        {
            using var db = new CetiContext();
            db.Permisos.Add(oPermiso);
            db.SaveChanges();
        }
        public static void ActualizarPermiso(PermisoEntity oPermiso)
        {
            using var db = new CetiContext();
            db.Permisos.Update(oPermiso);
            db.SaveChanges();
        }
        public static void BorrarPermiso(PermisoEntity oPermiso)
        {
            using var db = new CetiContext();
            db.Permisos.Remove(oPermiso);
            db.SaveChanges();
        }
    }
}
