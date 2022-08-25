using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Cheeze : DecoratorComponent
    {
        public Cheeze(Component component) : base(component)
        {
        }

        public override string Description()
        {
            return _baseComponent.Description() + nameof(Cheeze);
        }

        public override double Price()
        {
            return _baseComponent.Price() + 3;
        }
    }
}
