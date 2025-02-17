using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftwareHotel.Models;

[Table("habitaciones")]
public class Habitacion
{
     [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id_serial")]
    public int Id { get; set; }

    [Column("numero")]
    public required string Numero { get; set; }

    [Column("tipo")]
    public required string Tipo { get; set; }

    [Column("capacidad")]
    public int Capacidad { get; set; }

    [Column("precio")]
    
    public decimal Precio { get; set; }

    [Column("disponible")]
    public bool Disponible { get; set; }
}
