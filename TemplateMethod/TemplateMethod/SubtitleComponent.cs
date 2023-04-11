using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class SubtitleComponent : Component
    {
        protected override void BeforeCreate()
        {
            Console.WriteLine("Before Create Subtitle Component");
        }

        protected override void Created()
        {
            Console.WriteLine("Subtitle Component Created");
        }
    }
}
