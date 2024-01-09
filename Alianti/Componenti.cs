using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alianti
{
    public abstract class Componenti
    {
        protected List<Componenti> componenti = new List<Componenti>();
        public virtual string des()
        {
            var result = $"{GetType().Name}:\n";
            foreach (var componente in componenti)
            {
                result += componente.des() + "\n";
            }
            return result;
        }
        public virtual double cos()
        {
            double tot = 0.0;
            foreach (var componente in componenti)
            {
                tot += componente.cos();
            }
            return tot;
        }
        public virtual void Aggiungi(Componenti componente)
        {
            componenti.Add(componente);
        }
        public virtual void Rimuovi(Componenti componente)
        {
            componenti.Remove(componente);
        }
        public virtual Componenti GetFiglio(int i)
        {
            if (i >= 0 && i < componenti.Count) return componenti[i];
            return null;
        }
    }
    //classe aliante composta dalle altre
    public class Aliante:Componenti
    {
        public Aliante()
        {
            Aggiungi(new Ala());
        } 
    }
    public class Ala:Componenti
    {
        private double l;
        private double a;
        public Ala(double l, double a)
        {
            this.l = l;
            this.a = a;
        }
        public override string des()
        {
            return $"Ala - Lunghezza: {l}, Apertura: {a}";
        }
    }
    
    
    
        
        
        
       
       
        
    }
}
