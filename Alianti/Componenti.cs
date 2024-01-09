using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alianti
{
    public abstract class Componenti<T> where T : Componenti<T>
    {

    }
    
    public class Aliante:Componenti
    {
        private List<Componenti> componenti=new List<Componenti>();
        public override string des()
        {
            var result = "Aliante:\n";
            foreach(var componente in componenti)
            {
                result += componente.des()+"\n";
            }
            return result;
        }
        public override double cos()
        {
            double tot = 0.0;
            foreach(var componente in componenti)
            {
                tot += componente.cos();
            }
            return tot;
        }
        public override void Aggiungi(Componenti componente)
        {
            componenti.Add(componente);
        }
        public override void Rimuovi(Componenti componente)
        {
            componenti.Remove(componente);
        }
        public override Componenti GetFiglio(int i)
        {
            if(i>=0&&i<componenti.Count) return componenti[i];
            return null;
        }
    }
}
