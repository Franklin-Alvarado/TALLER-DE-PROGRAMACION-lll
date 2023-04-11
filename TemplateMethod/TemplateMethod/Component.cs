using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Component
    {
        // Definicion del algoritmo
        public void Create()
        {
            this.BeforeCreate();
            this.Created();
        }

        // Metodos Primitivos Abstractos que implementan las clases hijas 
        protected abstract void BeforeCreate();
        protected abstract void Created();
    }
}
