using Abstract_Factory_Design_Pattern.WebScreenGenerate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern.AbstractFactory
{
    public class GenerateWebScreen : AbstractGenerateScreen
    {
        // Sayfa Oluşturma
        public override IPage CreatePage()
        {
            return new WebPage();
        }

        // Component Oluşturma
        public override IComponent CreateComponent()
        {
            return new WebComponent();
        }
    }
}
