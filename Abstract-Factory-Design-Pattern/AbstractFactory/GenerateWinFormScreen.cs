using Abstract_Factory_Design_Pattern.WinFormScreenGenerate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern.AbstractFactory
{
    public class GenerateWinFormScreen : AbstractGenerateScreen
    {

        public override IPage CreatePage()
        {
            return new WinForm();
        }

        public override IComponent CreateComponent()
        {
            return new WinFormComponent();
        }
    }
}
