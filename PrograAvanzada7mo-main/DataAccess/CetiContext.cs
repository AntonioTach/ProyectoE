using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess
{
    public class CetiContext : DbContext
    {
        public DbSet<PlazaEntity> Plazas { get; set; }
        public DbSet<AcademiaEntity> Academias { get; set; }
        public DbSet<PlantelEntity> Planteles { get; set; }
        public DbSet<TrabajadorEntity> Trabajadores { get; set; }
        public DbSet<PuestoEntity> Puestos { get; set; }
        public DbSet<JefeEntity> Jefes { get; set; }
        public DbSet<PermisoEntity> Permisos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                // Aqui se hace la conexion a la base de datos de sql server
                options.UseSqlServer("Server=localhost,1433; Database=CetiPermisos; User=sa; Password=reallyStrongPwd123");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // a partir de aqui podemos pre cargar entradas en la base de datos
            base.OnModelCreating(modelBuilder);
            // aqui vamos a dictaminar que registros vamos a crear en la base de datos
            // por medio de la herramienta de migraciones que nos ofrece este framework
            modelBuilder.Entity<PlazaEntity>().HasData(
                new PlazaEntity { PlazaId = 1, PlazaTipo = "fija" },
                new PlazaEntity { PlazaId = 2, PlazaTipo = "no fija" }
            );
            modelBuilder.Entity<AcademiaEntity>().HasData(
                new AcademiaEntity { AcademiaId = 1, AcademiaNombre = "Computacion" },
                new AcademiaEntity { AcademiaId = 2, AcademiaNombre = "Redes y sistemas" },
                new AcademiaEntity { AcademiaId = 3, AcademiaNombre = "Informatica" }
            );
            modelBuilder.Entity<DireccionEntity>().HasData(
                new DireccionEntity { DireccionId = 1, DireccionCalle = "Calle Nueva Escocia", DireccionNoExt = "1885", DireccionNoInt = "", DireccionCp = "44630", DireccionMunicipio = "Guadalajara" },
                new DireccionEntity { DireccionId = 2, DireccionCalle = "Camino a Matatlan", DireccionNoExt = "2400", DireccionNoInt = "", DireccionCp = "45435", DireccionMunicipio = "Tonala" },
                new DireccionEntity { DireccionId = 3, DireccionCalle = "Loma Dorada Norte", DireccionNoExt = "8962", DireccionNoInt = "", DireccionCp = "45418", DireccionMunicipio = "Tonala" },
                new DireccionEntity { DireccionId = 4, DireccionCalle = "Salto del Agua", DireccionNoExt = "2415", DireccionNoInt = "", DireccionCp = "44210", DireccionMunicipio = "Gualadajara" },
                new DireccionEntity { DireccionId = 5, DireccionCalle = "Santa Elena Alcalde", DireccionNoExt = "56", DireccionNoInt = "", DireccionCp = "44220", DireccionMunicipio = "Gualadajara" },
                new DireccionEntity { DireccionId = 6, DireccionCalle = "Domingo de Alzola", DireccionNoExt = "1134", DireccionNoInt = "", DireccionCp = "44220", DireccionMunicipio = "Gualadajara" },
                new DireccionEntity { DireccionId = 7, DireccionCalle = "Avenida Alcalde", DireccionNoExt = "2510", DireccionNoInt = "6", DireccionCp = "45190", DireccionMunicipio = "Zapopan" },
                new DireccionEntity { DireccionId = 8, DireccionCalle = "Calle Nicolas Romero", DireccionNoExt = "1328A", DireccionNoInt = "", DireccionCp = "44260", DireccionMunicipio = "Gualadajara" },
                new DireccionEntity { DireccionId = 9, DireccionCalle = "Calle Montreal", DireccionNoExt = "1587", DireccionNoInt = "", DireccionCp = "44630", DireccionMunicipio = "Gualadajara" },
                new DireccionEntity { DireccionId = 10, DireccionCalle = "Valparaiso", DireccionNoExt = "2579", DireccionNoInt = "", DireccionCp = "44630", DireccionMunicipio = "Gualadajara" },
                new DireccionEntity { DireccionId = 11, DireccionCalle = "Milan", DireccionNoExt = "2654", DireccionNoInt = "", DireccionCp = "44630", DireccionMunicipio = "Gualadajara" },
                new DireccionEntity { DireccionId = 12, DireccionCalle = "Calle Jose Enrique Rodo", DireccionNoExt = "2783", DireccionNoInt = "", DireccionCp = "44670", DireccionMunicipio = "Gualadajara" },
                new DireccionEntity { DireccionId = 13, DireccionCalle = "Domingo Sarmiento", DireccionNoExt = "2922", DireccionNoInt = "", DireccionCp = "44670", DireccionMunicipio = "Gualadajara" },
                new DireccionEntity { DireccionId = 14, DireccionCalle = "Av Mayas", DireccionNoExt = "3322", DireccionNoInt = "", DireccionCp = "44670", DireccionMunicipio = "Gualadajara" },
                new DireccionEntity { DireccionId = 15, DireccionCalle = "Kabah", DireccionNoExt = "1475", DireccionNoInt = "", DireccionCp = "45050", DireccionMunicipio = "Zapopan" },
                new DireccionEntity { DireccionId = 16, DireccionCalle = "Av Moctezuma", DireccionNoExt = "348", DireccionNoInt = "", DireccionCp = "45050", DireccionMunicipio = "Zapopan" },
                new DireccionEntity { DireccionId = 17, DireccionCalle = "Economos", DireccionNoExt = "5524", DireccionNoInt = "", DireccionCp = "45037", DireccionMunicipio = "Zapopan" },
                new DireccionEntity { DireccionId = 18, DireccionCalle = "Agustin Lara", DireccionNoExt = "5774", DireccionNoInt = "", DireccionCp = "45037", DireccionMunicipio = "Zapopan" },
                new DireccionEntity { DireccionId = 19, DireccionCalle = "Felix Mendelssohn", DireccionNoExt = "5682", DireccionNoInt = "", DireccionCp = "45030", DireccionMunicipio = "Zapopan" }
            );
            modelBuilder.Entity<PlantelEntity>().HasData(
                new PlantelEntity { PlantelId = 1, PlantelNombre = "CETI Colomos", DireccionId = 1 },
                new PlantelEntity { PlantelId = 2, PlantelNombre = "CETI Rio Santiago", DireccionId = 2 },
                new PlantelEntity { PlantelId = 3, PlantelNombre = "CETI Tonala", DireccionId = 3 }
            );
            modelBuilder.Entity<TrabajadorEntity>().HasData(
                new TrabajadorEntity
                {
                    TrabajadorNomina = "836",
                    TrabajadorRegistro = Guid.NewGuid().ToString(),
                    TrabajadorNombre = "YESENIA",
                    TrabajadorApPaterno = "GÓMEZ",
                    TrabajadorApMaterno = "GONZÁLEZ",
                    TrabajadorCurp = "XEXX010101MNEXXXA8",
                    TrabajadorFechaNacimiento = new DateTime(1976, 03, 22),
                    TrabajadorTelefono = "3318826414",
                    TrabajadorCelular = "3345678901",
                    TrabajadorEmail = "zbins@mills.biz",
                    PlantelId = 1,
                    DireccionId = 4,
                    PlazaId = 1
                },
                new TrabajadorEntity
                {
                    TrabajadorNomina = "520",
                    TrabajadorRegistro = Guid.NewGuid().ToString(),
                    TrabajadorNombre = "AKIRA",
                    TrabajadorApPaterno = "ABRAHAM",
                    TrabajadorApMaterno = "LOZANO",
                    TrabajadorCurp = "XEXX010101HNEXXXA4",
                    TrabajadorFechaNacimiento = new DateTime(1982, 03, 22),
                    TrabajadorTelefono = "3372586983",
                    TrabajadorCelular = "3391176908",
                    TrabajadorEmail = "mmoore@gmail.com",
                    PlantelId = 1,
                    DireccionId = 5,
                    PlazaId = 1
                },
                new TrabajadorEntity
                {
                    TrabajadorNomina = "969",
                    TrabajadorRegistro = Guid.NewGuid().ToString(),
                    TrabajadorNombre = "SUSANA ELIZABETH",
                    TrabajadorApPaterno = "FERRER",
                    TrabajadorApMaterno = "HERNÁNDEZ",
                    TrabajadorCurp = "XEXX010101MNEXXXA8",
                    TrabajadorFechaNacimiento = new DateTime(1983, 03, 22),
                    TrabajadorTelefono = "3319871231",
                    TrabajadorCelular = "3332185477",
                    TrabajadorEmail = "josiah.pacocha@gmail.com",
                    PlantelId = 1,
                    DireccionId = 6,
                    PlazaId = 1
                },
                new TrabajadorEntity
                {
                    TrabajadorNomina = "662",
                    TrabajadorRegistro = Guid.NewGuid().ToString(),
                    TrabajadorNombre = "SUSANA ELIZABETH",
                    TrabajadorApPaterno = "FERRER",
                    TrabajadorApMaterno = "HERNÁNDEZ",
                    TrabajadorCurp = "XEXX010101MNEXXXA8",
                    TrabajadorFechaNacimiento = new DateTime(1984, 03, 22),
                    TrabajadorTelefono = "3361564758",
                    TrabajadorCelular = "3333244215",
                    TrabajadorEmail = "stoltenberg.keshawn@yahoo.com",
                    PlantelId = 1,
                    DireccionId = 7,
                    PlazaId = 1
                },
                new TrabajadorEntity
                {
                    TrabajadorNomina = "870",
                    TrabajadorRegistro = Guid.NewGuid().ToString(),
                    TrabajadorNombre = "JUAN MANUEL",
                    TrabajadorApPaterno = "GARCÍA",
                    TrabajadorApMaterno = "DAMIAN",
                    TrabajadorCurp = "XEXX010101HNEXXXA4",
                    TrabajadorFechaNacimiento = new DateTime(1985, 03, 22),
                    TrabajadorTelefono = "3389908711",
                    TrabajadorCelular = "3390971710",
                    TrabajadorEmail = "piper33@block.org",
                    PlantelId = 1,
                    DireccionId = 8,
                    PlazaId = 1
                },
                new TrabajadorEntity
                {
                    TrabajadorNomina = "142",
                    TrabajadorRegistro = Guid.NewGuid().ToString(),
                    TrabajadorNombre = "CARLOS TOMAS",
                    TrabajadorApPaterno = "SANTANA",
                    TrabajadorApMaterno = "COLIN",
                    TrabajadorCurp = "XEXX010101HNEXXXA4",
                    TrabajadorFechaNacimiento = new DateTime(1986, 03, 22),
                    TrabajadorTelefono = "3312160223",
                    TrabajadorCelular = "3387144259",
                    TrabajadorEmail = "pbalistreri@gmail.com",
                    PlantelId = 2,
                    DireccionId = 9,
                    PlazaId = 1
                },
                new TrabajadorEntity
                {
                    TrabajadorNomina = "106",
                    TrabajadorRegistro = Guid.NewGuid().ToString(),
                    TrabajadorNombre = "ERNESTO ALEJANDRO",
                    TrabajadorApPaterno = "PLAZA",
                    TrabajadorApMaterno = "OYARZABAL",
                    TrabajadorCurp = "XEXX010101HNEXXXA4",
                    TrabajadorFechaNacimiento = new DateTime(1987, 03, 22),
                    TrabajadorTelefono = "3363713078",
                    TrabajadorCelular = "3341024910",
                    TrabajadorEmail = "benedict73@yahoo.com",
                    PlantelId = 2,
                    DireccionId = 10,
                    PlazaId = 1
                },
                new TrabajadorEntity
                {
                    TrabajadorNomina = "728",
                    TrabajadorRegistro = Guid.NewGuid().ToString(),
                    TrabajadorNombre = "AGUSTINA",
                    TrabajadorApPaterno = "VARGAS",
                    TrabajadorApMaterno = "GÓMEZ",
                    TrabajadorCurp = "XEXX010101MNEXXXA8",
                    TrabajadorFechaNacimiento = new DateTime(1988, 03, 22),
                    TrabajadorTelefono = "3347681797",
                    TrabajadorCelular = "3347681797",
                    TrabajadorEmail = "abigayle.mann@gmail.com",
                    PlantelId = 2,
                    DireccionId = 11,
                    PlazaId = 1
                },
                new TrabajadorEntity
                {
                    TrabajadorNomina = "861",
                    TrabajadorRegistro = Guid.NewGuid().ToString(),
                    TrabajadorNombre = "LOURDES",
                    TrabajadorApPaterno = "GÁNDARA",
                    TrabajadorApMaterno = "CANTÚ",
                    TrabajadorCurp = "XEXX010101MNEXXXA8",
                    TrabajadorFechaNacimiento = new DateTime(1989, 03, 22),
                    TrabajadorTelefono = "3344970611",
                    TrabajadorCelular = "3301261506",
                    TrabajadorEmail = "eddie.prosacco@will.com",
                    PlantelId = 2,
                    DireccionId = 12,
                    PlazaId = 1
                },
                new TrabajadorEntity
                {
                    TrabajadorNomina = "675",
                    TrabajadorRegistro = Guid.NewGuid().ToString(),
                    TrabajadorNombre = "ANTONIO",
                    TrabajadorApPaterno = "LOZANO",
                    TrabajadorApMaterno = "GONZÁLEZ",
                    TrabajadorCurp = "XEXX010101HNEXXXA4",
                    TrabajadorFechaNacimiento = new DateTime(1979, 03, 22),
                    TrabajadorTelefono = "3392928159",
                    TrabajadorCelular = "3315038946",
                    TrabajadorEmail = "purdy.leonora@hudson.com",
                    PlantelId = 2,
                    DireccionId = 13,
                    PlazaId = 1
                },
                new TrabajadorEntity
                {
                    TrabajadorNomina = "972",
                    TrabajadorRegistro = Guid.NewGuid().ToString(),
                    TrabajadorNombre = "CLARA GABRIELA",
                    TrabajadorApPaterno = "GARCÍA",
                    TrabajadorApMaterno = "DURÁN",
                    TrabajadorCurp = "XEXX010101MNEXXXA8",
                    TrabajadorFechaNacimiento = new DateTime(1977, 03, 22),
                    TrabajadorTelefono = "3339752838",
                    TrabajadorCelular = "3317914443",
                    TrabajadorEmail = "frami.terence@dubuque.com",
                    PlantelId = 3,
                    DireccionId = 14,
                    PlazaId = 1
                },
                new TrabajadorEntity
                {
                    TrabajadorNomina = "779",
                    TrabajadorRegistro = Guid.NewGuid().ToString(),
                    TrabajadorNombre = "JORGE",
                    TrabajadorApPaterno = "PAMPLONA",
                    TrabajadorApMaterno = "CAMPA",
                    TrabajadorCurp = "XEXX010101HNEXXXA4",
                    TrabajadorFechaNacimiento = new DateTime(1978, 03, 22),
                    TrabajadorTelefono = "3320068241",
                    TrabajadorCelular = "3326431305",
                    TrabajadorEmail = "bradtke.torrey@yahoo.com",
                    PlantelId = 3,
                    DireccionId = 15,
                    PlazaId = 1
                },
                new TrabajadorEntity
                {
                    TrabajadorNomina = "656",
                    TrabajadorRegistro = Guid.NewGuid().ToString(),
                    TrabajadorNombre = "SONIA ERIKA",
                    TrabajadorApPaterno = "IBAÑEZ",
                    TrabajadorApMaterno = "TORRES",
                    TrabajadorCurp = "XEXX010101MNEXXXA8",
                    TrabajadorFechaNacimiento = new DateTime(1982, 03, 22),
                    TrabajadorTelefono = "3307889594",
                    TrabajadorCelular = "3330028955",
                    TrabajadorEmail = "thora.hirthe@gmail.com",
                    PlantelId = 3,
                    DireccionId = 16,
                    PlazaId = 1
                },
                new TrabajadorEntity
                {
                    TrabajadorNomina = "991",
                    TrabajadorRegistro = Guid.NewGuid().ToString(),
                    TrabajadorNombre = "ALEJANDRA",
                    TrabajadorApPaterno = "ALCARAZ",
                    TrabajadorApMaterno = "TORRES",
                    TrabajadorCurp = "XEXX010101MNEXXXA8",
                    TrabajadorFechaNacimiento = new DateTime(1980, 03, 22),
                    TrabajadorTelefono = "3379836327",
                    TrabajadorCelular = "3361607678",
                    TrabajadorEmail = "vicenta72@gmail.com",
                    PlantelId = 3,
                    DireccionId = 17,
                    PlazaId = 1
                },
                new TrabajadorEntity
                {
                    TrabajadorNomina = "669",
                    TrabajadorRegistro = Guid.NewGuid().ToString(),
                    TrabajadorNombre = "MARTHA",
                    TrabajadorApPaterno = "CORNEJO",
                    TrabajadorApMaterno = "CARGÍA",
                    TrabajadorCurp = "XEXX010101MNEXXXA8",
                    TrabajadorFechaNacimiento = new DateTime(1970, 03, 22),
                    TrabajadorTelefono = "3330112050",
                    TrabajadorCelular = "3345559416",
                    TrabajadorEmail = "xgoodwin@schinner.com",
                    PlantelId = 3,
                    DireccionId = 18,
                    PlazaId = 1
                },
                new TrabajadorEntity
                {
                    TrabajadorNomina = "500",
                    TrabajadorRegistro = Guid.NewGuid().ToString(),
                    TrabajadorNombre = "SERGIO",
                    TrabajadorApPaterno = "BECERRA",
                    TrabajadorApMaterno = "DELGADO",
                    TrabajadorCurp = "XEXX010101HNEXXXA4",
                    TrabajadorFechaNacimiento = new DateTime(1996, 03, 22),
                    TrabajadorTelefono = "3348810059",
                    TrabajadorCelular = "3370661957",
                    TrabajadorEmail = "nelson45@yahoo.com",
                    PlantelId = 3,
                    DireccionId = 19,
                    PlazaId = 1
                }
            );
            modelBuilder.Entity<JefeEntity>().HasData(
                new JefeEntity { JefeId = 1, AcademiaId = 1, TrabajadorId = "836" },
                new JefeEntity { JefeId = 2, AcademiaId = 2, TrabajadorId = "728" },
                new JefeEntity { JefeId = 3, AcademiaId = 3, TrabajadorId = "500" }
            );
            modelBuilder.Entity<PuestoEntity>().HasData(
                new PuestoEntity { PuestoId = 1, TrabajadorId = "836", PlazaFechaInicio = new DateTime(2000, 02, 01), AcademiaId = 1 },
                new PuestoEntity { PuestoId = 2, TrabajadorId = "520", PlazaFechaInicio = new DateTime(2001, 01, 12), AcademiaId = 1 },
                new PuestoEntity { PuestoId = 3, TrabajadorId = "969", PlazaFechaInicio = new DateTime(2002, 03, 13), AcademiaId = 1 },
                new PuestoEntity { PuestoId = 4, TrabajadorId = "662", PlazaFechaInicio = new DateTime(2003, 04, 14), AcademiaId = 1 },
                new PuestoEntity { PuestoId = 5, TrabajadorId = "870", PlazaFechaInicio = new DateTime(2004, 05, 05), AcademiaId = 1 },
                new PuestoEntity { PuestoId = 6, TrabajadorId = "142", PlazaFechaInicio = new DateTime(2005, 06, 06), AcademiaId = 2 },
                new PuestoEntity { PuestoId = 7, TrabajadorId = "106", PlazaFechaInicio = new DateTime(2006, 01, 07), AcademiaId = 2 },
                new PuestoEntity { PuestoId = 8, TrabajadorId = "728", PlazaFechaInicio = new DateTime(2007, 02, 21), AcademiaId = 2 },
                new PuestoEntity { PuestoId = 9, TrabajadorId = "861", PlazaFechaInicio = new DateTime(2008, 03, 20), AcademiaId = 2 },
                new PuestoEntity { PuestoId = 10, TrabajadorId = "675", PlazaFechaInicio = new DateTime(2009, 04, 21), AcademiaId = 2 },
                new PuestoEntity { PuestoId = 11, TrabajadorId = "972", PlazaFechaInicio = new DateTime(2010, 05, 22), AcademiaId = 3 },
                new PuestoEntity { PuestoId = 12, TrabajadorId = "779", PlazaFechaInicio = new DateTime(2011, 06, 09), AcademiaId = 3 },
                new PuestoEntity { PuestoId = 13, TrabajadorId = "656", PlazaFechaInicio = new DateTime(2012, 07, 10), AcademiaId = 3 },
                new PuestoEntity { PuestoId = 14, TrabajadorId = "991", PlazaFechaInicio = new DateTime(2013, 08, 23), AcademiaId = 3 },
                new PuestoEntity { PuestoId = 15, TrabajadorId = "669", PlazaFechaInicio = new DateTime(2014, 09, 12), AcademiaId = 3 },
                new PuestoEntity { PuestoId = 16, TrabajadorId = "500", PlazaFechaInicio = new DateTime(2015, 12, 01), AcademiaId = 3 }
            );
        }
    }
}
