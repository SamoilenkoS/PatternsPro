using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class DecoratorComponent : Component
    {
        protected Component _baseComponent;

        public DecoratorComponent(Component component)
        {
            _baseComponent = component;
        }
    }
}
