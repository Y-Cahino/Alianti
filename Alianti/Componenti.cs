﻿using System;
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
            Aggiungi(new Ala(l:20,a:15));
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
        public override double cos()
        {
            //costo arbitrario basato sull'apertura (numero casuale)
            return (a+l) * 2.5;
        }
    }
    public class Fusoliera:Componenti
    {
        private string made;
        private double l;
        public Fusoliera(string made, double l, double costom)
        {
            this.made = made;
            this.l = l;
            if (made != "Alluminio" && made != "Carbonio") throw new ArgumentException("Materiale non supportato (disponibilità Carbonio o alluminio).");
        }
        public override string des()
        {
            return $"Fusoliera - Lunghezza: {l}, Materiale: {made}";
        }
        public override double cos()
        {
            double costom=0.0;
            if (made == "Alluminio") costom = 1.5;
            else if (made == "Carbonio") costom = 2.0;

            //costo arbitrario basato sull'apertura (numero casuale)
            return l*costom;
        }
    }
    
    
    
        
        
        
       
       
        
    }
}
