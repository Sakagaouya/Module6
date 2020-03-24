using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TPDojo1_BO;

namespace TPDojo1.Models
{
    public class DojoViewModel
    {
        public Samourai Samourai { get; set; }
        public List<Arme> Armes { get; set; }
        public int? IdSelectedArme { get; set; }
    }
}