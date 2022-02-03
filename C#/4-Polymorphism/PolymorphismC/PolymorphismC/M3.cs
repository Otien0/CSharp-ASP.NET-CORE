using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    class M3:BMW
    {

        public M3(int hp, string color, string model) : base(hp, color, model)
        {
            this.Model = model;
        }

        /*
        public override void Repair()
        {
            base.Repair();
        }
        */
    }
}
