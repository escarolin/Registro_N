
using System;
using  System.ComponentModel.DataAnnotations;

namespace Registro_N.Entidades{

public class Persona {
   [Key]

    public int ID { get; set; }
    public string Nombres { get; set; }
    public double Telefono { get; set; }
     
    public string Cedula { get; set; }
    public string Direcion { get; set; }
    public DateTime Fecha_Nacimiento { get; set; }

}
}