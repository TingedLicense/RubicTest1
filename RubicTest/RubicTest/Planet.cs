using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubicTest
{
    class Planet
    {
        private void Main()
        {
            CreateCat();
            CreateCat();
            CreateCat();
            Createhiman();
            Createhiman();
            Createhiman();
        }

        private void CreateCat()
        {
            Cat cat1 = new Cat();
            cat1.name = "Джони";
            cat1.age = 1;
            cat1.height = 1.5F;
            cat1.isBoy = true;
        }
        
        private void Createhiman()
        {
            himan himan1 = new himan();
            himan1.name = "Макс";
            himan1.age = 25;
            himan1.height = 1.75F;
            himan1.isBoy = true;
            himan1.salary = 40000;
            himan1.heisMarried = false;
        }

    }
}
