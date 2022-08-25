using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Calcutor
    {
        private static Calcutor _instance;

        private Calcutor()
        {

        }

        public static Calcutor Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Calcutor();
                }

                return _instance;
            }
        }

        public int Add(int a, int b) => a + b;
        public int Substract(int a, int b) => a - b;
    }
}
