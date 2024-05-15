using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVehiculos.Entidades
{
    public class Vehiculo
    {
        
        public int Id { get; set; }
        public string? Placa { get; set; }
        public string? Color { get; set;}
        public DateTime Año { get; set;}

        public int MarcaId {  get; set;}
        public Marca? Marca { get; set; }

    }
}
