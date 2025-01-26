using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Four
{

    public interface IAnimal : IMakeNoise, IMakeTrick

    {

        public string Type { get; }

        public string Name { get; }

        void Perform();

    }
}