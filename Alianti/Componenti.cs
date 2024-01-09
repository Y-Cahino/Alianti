using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alianti
{
    public abstract class Componenti
    {
        public abstract string des();
        public abstract double cos();
        public abstract void Aggiungi(Componenti componenti);
        public abstract void Rimuovi(Componenti componenti);
        public abstract Componenti GetFiglio(int i);
    }
    public class Aliante:Componenti
    {
        private List<Componenti> componenti=new List<Componenti>();
        public string des(string s)
        { 
        }
    }
}
