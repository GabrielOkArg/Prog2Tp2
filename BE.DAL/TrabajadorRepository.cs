using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.BE;

namespace TP2.DAL
{
    public  class TrabajadorRepository
    {
        private static List<Trabajador> _trabajadores;

        // Constructor que inicializa la lista con datos de prueba (mock)
        static TrabajadorRepository()
        {
            _trabajadores = new List<Trabajador>
        {
            new Trabajador { Id=1, Apellido = "Pérez",Nombre="Juan", Domicilio = "Calle Falsa 123", Localidad = "Buenos Aires", Provincia = "Buenos Aires", NroCelular = 1234567890, Categoria = new Categoria { Nombre = "Albañil" }, Rango = new Rango { Nombre = "Oficial" }, AreaTrabajo = "Construcción", CantidadHoras = 40, ValorHora = 500m, FechaIngreso = new DateTime(2020, 1, 1) },
            new Trabajador {Id=2, Apellido = "López",Nombre="Ana", Domicilio = "Av. Siempreviva 742", Localidad = "Córdoba", Provincia = "Córdoba", NroCelular = 987654321, Categoria = new Categoria { Nombre = "Arquitecto" }, Rango = new Rango { Nombre = "Capataz" }, AreaTrabajo = "Diseño", CantidadHoras = 35, ValorHora = 600m, FechaIngreso = new DateTime(2021, 5, 1) },
            // ... otros trabajadores mockeados
        };
        }

        // Obtener todos los trabajadores
        public List<Trabajador> ObtenerTrabajadores()
        {
            return _trabajadores;
        }

        // Editar un trabajador existente
        public void EditarTrabajador(int indice, Trabajador nuevoTrabajador)
        {
            if (indice >= 0 && indice < _trabajadores.Count)
            {
                _trabajadores[indice] = nuevoTrabajador;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(indice), "Índice fuera de rango.");
            }
        }

        // Agregar un nuevo trabajador
        public void AgregarTrabajador(Trabajador trabajador)
        {
            if (trabajador == null)
            {
                throw new ArgumentNullException(nameof(trabajador), "El trabajador no puede ser nulo.");
            }
            trabajador.Id = _trabajadores.Count + 1;
            _trabajadores.Add(trabajador);
        }

        // Eliminar un trabajador por índice
        public void EliminarTrabajador(int indice)
        {
            if (indice >= 0 && indice < _trabajadores.Count)
            {
                _trabajadores.RemoveAt(indice);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(indice), "Índice fuera de rango.");
            }
        }
    }
}
