using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Component
    {
        public abstract string Description();
        public abstract double Price();
        protected Component _baseComponent;

        public Component(Component component)
        {
            _baseComponent = component;
        }
    }
}
