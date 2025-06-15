using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boost
{
    class Personne
    {
        private int id;
        private string nom;
        private string prenom;
        private int age;
        private string adress;

        public int Id {
            get { return id; }
            set { id = value; }
        }

        public string Nom {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom {
            get { return prenom; }
            set { prenom = value; }
        }

        public int Age {
            get { return age; }
            set { age = value; }
        }

        public string Adress {
            get { return adress; }
            set { adress = value; }
        }

        public Personne(int id, string nom, string prenom, int age, string adress) 
        {
            initialiser(id, nom, prenom, age, adress);
        }
        
        public Personne() { }

        public void initialiser(int id, string nom, string prenom, int age, string adress) 
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.adress = adress;
        } 
    }
}
