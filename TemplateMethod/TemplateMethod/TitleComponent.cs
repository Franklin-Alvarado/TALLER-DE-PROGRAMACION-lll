using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class TitleComponent : Component
    {
        protected override void BeforeCreate()
        {
            Console.WriteLine("Before Create Title Component");
        }

        protected override void Created()
        {
            Console.WriteLine("Title Component Created");
        }
    }
}
