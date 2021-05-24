using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TallerEje3MVC.Models
{
    public class CandidatosModel
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public string imagen_nombre { get; set; }
    }
}
