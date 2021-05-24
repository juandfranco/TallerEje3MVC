using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TallerEje3MVC.Models
{
    public class VotosModel
    {
        [Key]
        public string cedula { get; set; }
        public int id_candidato { get; set; }
    }
}
