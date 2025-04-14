//using PadillaG_Liga_Pro.Models;

//namespace PadillaG_Liga_Pro.Repositories
//{
//    public class EquipoRepository
//    {
//        public List<Equipo> Equipos { get; set; }

//        public EquipoRepository()
//        {
//            Equipos = DevuelveListadoEquipos();
//        }
//        public List<Equipo> DevuelveListadoEquipos()
//        {
//            List<Equipo> equipos = new List<Equipo>();
//            Equipo ldu = new Equipo
//            {
//                Id = 1,
//                Nombre = "Liga de Quito",
//                partidosJugados = 10,
//                partidosGanados = 10,
//                partidosEmpatados = 0,
//                partidosPerdidos = 0
//            };
//            equipos.Add(ldu);

//            Equipo idv = new Equipo
//            {
//                Id = 2,
//                Nombre = "Independiente del Valle",
//                partidosJugados = 10,
//                partidosGanados = 5,
//                partidosEmpatados = 1,
//                partidosPerdidos = 3
//            };
//            equipos.Add(idv);

//            Equipo barcelona = new Equipo
//            {
//                Id = 3,
//                Nombre = "Barcelona SC",
//                partidosJugados = 10,
//                partidosGanados = 4,
//                partidosEmpatados = 2,
//                partidosPerdidos = 4
//            };
//            equipos.Add(barcelona);

//            Equipo emelec = new Equipo
//            {
//                Id = 4,
//                Nombre = "Emelec",
//                partidosJugados = 10,
//                partidosGanados = 3,
//                partidosEmpatados = 2,
//                partidosPerdidos = 5
//            };
//            equipos.Add(emelec);

//            Equipo delfin = new Equipo
//            {
//                Id = 5,
//                Nombre = "Delfin",
//                partidosJugados = 10,
//                partidosGanados = 2,
//                partidosEmpatados = 3,
//                partidosPerdidos = 5
//            };
//            equipos.Add(delfin);

//            Equipo vinotinto = new Equipo
//            {
//                Id = 6,
//                Nombre = "Vinotinto FC",
//                partidosJugados = 10,
//                partidosGanados = 1,
//                partidosEmpatados = 5,
//                partidosPerdidos = 4
//            };
//            equipos.Add(vinotinto);

//            Equipo nacional = new Equipo
//            {
//                Id = 7,
//                Nombre = "CD El Nacional",
//                partidosJugados = 10,
//                partidosGanados = 2,
//                partidosEmpatados = 3,
//                partidosPerdidos = 5
//            };
//            equipos.Add(nacional);

//            Equipo tecnico = new Equipo
//            {
//                Id = 8,
//                Nombre = "Técnico Universitario",
//                partidosJugados = 10,
//                partidosGanados = 3,
//                partidosEmpatados = 2,
//                partidosPerdidos = 5
//            };
//            equipos.Add(tecnico);

//            Equipo manta = new Equipo
//            {
//                Id = 9,
//                Nombre = "Manta FC",
//                partidosJugados = 10,
//                partidosGanados = 4,
//                partidosEmpatados = 1,
//                partidosPerdidos = 5
//            };
//            equipos.Add(manta);

//            Equipo libertad = new Equipo
//            {
//                Id = 10,
//                Nombre = "Libertad FC",
//                partidosJugados = 10,
//                partidosGanados = 1,
//                partidosEmpatados = 3,
//                partidosPerdidos = 6
//            };
//            equipos.Add(libertad);

//            Equipo cuenca = new Equipo
//            {
//                Id = 11,
//                Nombre = "Deportivo Cuenca",
//                partidosJugados = 10,
//                partidosGanados = 0,
//                partidosEmpatados = 2,
//                partidosPerdidos = 8
//            };
//            equipos.Add(cuenca);

//            Equipo aucas = new Equipo
//            {
//                Id = 12,
//                Nombre = "SD Aucas",
//                partidosJugados = 10,
//                partidosGanados = 5,
//                partidosEmpatados = 3,
//                partidosPerdidos = 2
//            };
//            equipos.Add(aucas);

//            Equipo orense = new Equipo
//            {
//                Id = 13,
//                Nombre = "Orense SC",
//                partidosJugados = 10,
//                partidosGanados = 4,
//                partidosEmpatados = 4,
//                partidosPerdidos = 2
//            };
//            equipos.Add(orense);

//            Equipo catolica = new Equipo
//            {
//                Id = 14,
//                Nombre = "CD Universidad Católica",
//                partidosJugados = 10,
//                partidosGanados = 5,
//                partidosEmpatados = 2,
//                partidosPerdidos = 3
//            };
//            equipos.Add(catolica);

//            Equipo mushuc = new Equipo
//            {
//                Id = 15,
//                Nombre = "Mushuc Runa SC",
//                partidosJugados = 10,
//                partidosGanados = 3,
//                partidosEmpatados = 3,
//                partidosPerdidos = 4
//            };
//            equipos.Add(mushuc);

//            Equipo macara = new Equipo
//            {
//                Id = 16,
//                Nombre = "CD Macará",
//                partidosJugados = 10,
//                partidosGanados = 2,
//                partidosEmpatados = 4,
//                partidosPerdidos = 4
//            };
//            equipos.Add(macara);




//            return (equipos);

//        }
//        public Equipo DevuelveEquipoPorID(int Id)
//        {
//            var equipos = DevuelveListadoEquipos();
//            var equipo = equipos.First(item => item.Id == Id);
//            return equipo;
//        }

//        public bool ActualizarEquipo(int Id, Equipo equipo)
//        {

//            var equipoActualizado = Equipos.First(item => item.Id == Id);

//        if (equipoActualizado == null)
//            {
//                return false;
//            }
//            equipoActualizado.Nombre = equipo.Nombre;
//            equipoActualizado.partidosJugados = equipo.partidosJugados;
//            equipoActualizado.partidosGanados = equipo.partidosGanados;
//            equipoActualizado.partidosEmpatados = equipo.partidosEmpatados;
//            equipoActualizado.partidosPerdidos = equipo.partidosPerdidos;


//            return true;
//        }
//    }
//}
using PadillaG_Liga_Pro.Models;

namespace PadillaG_Liga_Pro.Repositories
{
    public class EquipoRepository
    {
        private static List<Equipo> _equipos; 

        public EquipoRepository()
        {
            if (_equipos == null) 
            {
                _equipos = InicializarEquipos();
            }
        }

        private List<Equipo> InicializarEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "Liga de Quito",
                partidosJugados = 10,
                partidosGanados = 10,
                partidosEmpatados = 0,
                partidosPerdidos = 0
            };
            equipos.Add(ldu);

            Equipo idv = new Equipo
            {
                Id = 2,
                Nombre = "Independiente del Valle",
                partidosJugados = 10,
                partidosGanados = 5,
                partidosEmpatados = 1,
                partidosPerdidos = 3
            };
            equipos.Add(idv);

            Equipo barcelona = new Equipo
            {
                Id = 3,
                Nombre = "Barcelona SC",
                partidosJugados = 10,
                partidosGanados = 4,
                partidosEmpatados = 2,
                partidosPerdidos = 4
            };
            equipos.Add(barcelona);

            Equipo emelec = new Equipo
            {
                Id = 4,
                Nombre = "Emelec",
                partidosJugados = 10,
                partidosGanados = 3,
                partidosEmpatados = 2,
                partidosPerdidos = 5
            };
            equipos.Add(emelec);

            Equipo delfin = new Equipo
            {
                Id = 5,
                Nombre = "Delfin",
                partidosJugados = 10,
                partidosGanados = 2,
                partidosEmpatados = 3,
                partidosPerdidos = 5
            };
            equipos.Add(delfin);

            Equipo vinotinto = new Equipo
            {
                Id = 6,
                Nombre = "Vinotinto FC",
                partidosJugados = 10,
                partidosGanados = 1,
                partidosEmpatados = 5,
                partidosPerdidos = 4
            };
            equipos.Add(vinotinto);

            Equipo nacional = new Equipo
            {
                Id = 7,
                Nombre = "CD El Nacional",
                partidosJugados = 10,
                partidosGanados = 2,
                partidosEmpatados = 3,
                partidosPerdidos = 5
            };
            equipos.Add(nacional);

            Equipo tecnico = new Equipo
            {
                Id = 8,
                Nombre = "Técnico Universitario",
                partidosJugados = 10,
                partidosGanados = 3,
                partidosEmpatados = 2,
                partidosPerdidos = 5
            };
            equipos.Add(tecnico);

            Equipo manta = new Equipo
            {
                Id = 9,
                Nombre = "Manta FC",
                partidosJugados = 10,
                partidosGanados = 4,
                partidosEmpatados = 1,
                partidosPerdidos = 5
            };
            equipos.Add(manta);

            Equipo libertad = new Equipo
            {
                Id = 10,
                Nombre = "Libertad FC",
                partidosJugados = 10,
                partidosGanados = 1,
                partidosEmpatados = 3,
                partidosPerdidos = 6
            };
            equipos.Add(libertad);

            Equipo cuenca = new Equipo
            {
                Id = 11,
                Nombre = "Deportivo Cuenca",
                partidosJugados = 10,
                partidosGanados = 0,
                partidosEmpatados = 2,
                partidosPerdidos = 8
            };
            equipos.Add(cuenca);

            Equipo aucas = new Equipo
            {
                Id = 12,
                Nombre = "SD Aucas",
                partidosJugados = 10,
                partidosGanados = 5,
                partidosEmpatados = 3,
                partidosPerdidos = 2
            };
            equipos.Add(aucas);

            Equipo orense = new Equipo
            {
                Id = 13,
                Nombre = "Orense SC",
                partidosJugados = 10,
                partidosGanados = 4,
                partidosEmpatados = 4,
                partidosPerdidos = 2
            };
            equipos.Add(orense);

            Equipo catolica = new Equipo
            {
                Id = 14,
                Nombre = "CD Universidad Católica",
                partidosJugados = 10,
                partidosGanados = 5,
                partidosEmpatados = 2,
                partidosPerdidos = 3
            };
            equipos.Add(catolica);

            Equipo mushuc = new Equipo
            {
                Id = 15,
                Nombre = "Mushuc Runa SC",
                partidosJugados = 10,
                partidosGanados = 3,
                partidosEmpatados = 3,
                partidosPerdidos = 4
            };
            equipos.Add(mushuc);

            Equipo macara = new Equipo
            {
                Id = 16,
                Nombre = "CD Macará",
                partidosJugados = 10,
                partidosGanados = 2,
                partidosEmpatados = 4,
                partidosPerdidos = 4
            };
            equipos.Add(macara);

            return equipos;
        }

        public List<Equipo> DevuelveListadoEquipos()
        {
            return _equipos;
        }

        public Equipo DevuelveEquipoPorID(int Id)
        {
            return _equipos.FirstOrDefault(item => item.Id == Id);
        }
        public bool EliminarEquipo(int Id)
        {
            var equipoAEliminar = _equipos.FirstOrDefault(item => item.Id == Id);
            if (equipoAEliminar == null)
            {
                return false;
            }

            _equipos.Remove(equipoAEliminar); 
            return true; 
        }
        public bool ActualizarEquipo(int Id, Equipo equipo)
        {
            var equipoActualizado = _equipos.FirstOrDefault(item => item.Id == Id);

            if (equipoActualizado == null)
            {
                return false;
            }

            equipoActualizado.Nombre = equipo.Nombre;
            equipoActualizado.partidosJugados = equipo.partidosJugados;
            equipoActualizado.partidosGanados = equipo.partidosGanados;
            equipoActualizado.partidosEmpatados = equipo.partidosEmpatados;
            equipoActualizado.partidosPerdidos = equipo.partidosPerdidos;

            return true;
        }
    }
}
