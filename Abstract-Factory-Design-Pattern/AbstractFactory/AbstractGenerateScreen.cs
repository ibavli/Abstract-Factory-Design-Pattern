using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern.AbstractFactory
{
    public abstract class AbstractGenerateScreen
    {
        public abstract IComponent CreateComponent();
        public abstract IPage CreatePage();
    }
}
