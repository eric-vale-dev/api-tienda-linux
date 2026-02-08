using System.ComponentModel.DataAnnotations;

namespace TienditaAPI.Models
{
    public class Producto
    {
        [Key] //Esta es la llave primaria
        public int Id {get; set;}

        [Required]
        [MaxLength(100)]
        public string Nombre {get; set;} = string.Empty;
        public string? Descripcion {get; set;}

        [Range(0, double.MaxValue)]
        public decimal Precio {get; set;}
        public int Stock {get; set;}
        public DateTime FechaCreacion {get; set;} = DateTime.UtcNow;
    }
}