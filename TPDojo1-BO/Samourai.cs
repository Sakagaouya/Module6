using System.Collections.Generic;

namespace TPDojo1_BO
{
    public class Samourai : Identity
    {
        public int Force { get; set; }
        public string Nom { get; set; }
        public virtual Arme Arme { get; set; }
        public virtual List<ArtMartial> ArtMartiaux { get; set; } = new List<ArtMartial>();


    }
}
