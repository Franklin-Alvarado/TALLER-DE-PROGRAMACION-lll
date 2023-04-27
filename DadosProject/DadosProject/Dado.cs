using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosProject
{
    public class Dado : IEqualityComparer<Dado>, IComparable<Dado>
    {
        public int Value { get; set; }
    
        public void Lanzar()
        {
            Random random = new Random();   
            Value = random.Next(1,6);
        }

        public int CompareTo(Dado? other)
        {
            if (other == null) return 1;
            if (this.Value == other.Value) return 0;
            if (this.Value > other.Value) return -1;
            return 1;   
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Dado)) return false;
            if (obj == null) return false;
            Dado objDado = (Dado)obj;
            return Value == objDado.Value;
        }

        public bool Equals(Dado? x, Dado? y)
        {
            if (x == null || y == null) return false;
            return x.Value == y.Value;
        }

        public int GetHashCode([DisallowNull] Dado obj)
        {
            return obj.Value.GetHashCode();
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
