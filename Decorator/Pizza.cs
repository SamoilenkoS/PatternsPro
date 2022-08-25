using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Pizza : Component
    {
        public Pizza() : base(null)
        {
        }

        public override string Description()
        {
            return nameof(Pizza);
        }

        public override double Price()
        {
            return 3;
        }
    }
}
