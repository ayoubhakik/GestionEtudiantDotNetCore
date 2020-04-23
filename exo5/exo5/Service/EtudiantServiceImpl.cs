using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exo5.Service
{
    public class EtudiantServiceImpl : IEtudiantService
    {
        public Dictionary<int, Etudiant> Etudiants = new Dictionary<int, Etudiant>();
        public Dictionary<int, Filiere> Filieres = new Dictionary<int, Filiere>();

        public EtudiantServiceImpl()
        {
            Filieres[Filieres.Count+1]=new Filiere {
                idFil = 1,nomFil="info"
            };
            Save(new Etudiant {
                id = 1, nom = "hakik", prenom = "ayoub", idFil = 1
            });
        }
        public void Delete(int id)
        {
            Etudiants.Remove(id);
        }

        public IEnumerable<Etudiant> EtudiantsParMotCle(string mot)
        {
            return Etudiants.Values.Where(e=>e.nom.Contains(mot));
        }

        public IEnumerable<Etudiant> FindAll()
        {
            return Etudiants.Values;
        }

        public Etudiant GetEtudiantById(int id)
        {
            Etudiant e;
            //find the object and stock it in e
            Etudiants.TryGetValue(id,out e);
            return Etudiants[id];
        }

        public Etudiant Save(Etudiant e)
        {

            e.id = Etudiants.Count + 1;
            Etudiants[e.id] = e;
            return e;
        }

        public void Update(Etudiant e)
        {
            Etudiants[e.id] = e;   
        }
    }
}
