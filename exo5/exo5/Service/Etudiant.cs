using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace exo5.Service
{
    public class Etudiant
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }

        [ForeignKey("Filiere")]
        public Nullable<int> idFil { get; set; }
        public virtual Filiere Filiere { get; set; }
    }
}
