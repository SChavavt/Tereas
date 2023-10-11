using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App01.Models
{
    public class Vehiculo
    {
        // Id del vehículo
        public int Id { get; set; }
        public double Capacidad { get; set; }
        public long LatitudOrigenCondicionInicial { get; set; }
        public long LongitudOrigenCondicionInicial { get; set; }
        public DateTime FechaDisponible { get; set; }   

        public List<Asignacion> ListaAsignaciones { get; set; }

        public Vehiculo() { }

        public Vehiculo(int id, double capacidad, long latitudOrigenCondicionInicial, long longitudOrigenCondicionInicial, DateTime fechaDisponible)
        {
            Id = id;
            Capacidad = capacidad;
            LatitudOrigenCondicionInicial = latitudOrigenCondicionInicial;
            LongitudOrigenCondicionInicial = longitudOrigenCondicionInicial;
            FechaDisponible = fechaDisponible;
        }
    }
}
