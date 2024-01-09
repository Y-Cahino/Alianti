using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alianti
{
    public abstract class Componenti<T> where T : Componenti<T>
    {
        private List<T> componenti = new List<T>();
        public virtual string des()
        {
            var result = $"{typeof(T).Name}:\n";
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
        public virtual void Aggiungi(T componente)
        {
            componenti.Add(componente);
        }
        public virtual void Rimuovi(T componente)
        {
            componenti.Remove(componente);
        }
        public virtual Componenti GetFiglio(int i)
        {
            if (i >= 0 && i < componenti.Count) return componenti[i];
            return null;
        }
    }
    
    
    
        
        
        
       
       
        
    }
}
