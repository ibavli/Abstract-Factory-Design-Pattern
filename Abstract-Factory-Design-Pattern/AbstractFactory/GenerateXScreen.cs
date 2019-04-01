using Abstract_Factory_Design_Pattern.XScreenGenerate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern.AbstractFactory
{
    public class GenerateXScreen : AbstractGenerateScreen
    {
        // Sayfa Oluşturma
        public override IPage CreatePage()
        {
            return new XPage();
        }

        // Component Oluşturma
        public override IComponent CreateComponent()
        {
            return new XComponent();
        }
    }
}
