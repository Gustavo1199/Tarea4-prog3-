using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Infracciones
{
    class error
    {
        [Key]
        public int Id { get; set; }
        [StringLength(15)]
        public string Cedula { get; set; }
        [StringLength(25)]
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        [StringLength(25)]
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Descripcion { get; set; }
        public bool pagado { get; set; }
    


    }
}
