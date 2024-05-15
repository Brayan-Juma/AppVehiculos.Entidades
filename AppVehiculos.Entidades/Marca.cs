using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppVehiculos.Entidades
{
    public class Marca
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nombre de la marca")]
        public string? Nombre { get; set; }

        public List<Vehiculo>? Vehiculos { get; set;}
    }
}
