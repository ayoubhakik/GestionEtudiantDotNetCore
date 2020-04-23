using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exo5.Service
{
    public interface IEtudiantService
    {
        Etudiant Save(Etudiant e);
        IEnumerable<Etudiant> FindAll();
        IEnumerable<Etudiant> EtudiantsParMotCle(string mot);
        Etudiant GetEtudiantById(int id);
        void Update(Etudiant e);
        void Delete(int id);
    }
}
