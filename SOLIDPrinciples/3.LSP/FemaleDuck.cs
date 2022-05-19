using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples._3.LSP
{
     public class FemaleDuck : Duck
        {

        private FemaleDuckButt _butt;
        public FemaleDuck():base()
        {
            
            // Initialization of female stuff
            this._butt = new FemaleDuckButt();
        }

        public string layAnEgg()
        {
            var egg = this._butt.layAnEgg();
            return egg;
        
        }
    }

    class FemaleDuckButt
    {
        public string layAnEgg()
        {
            return "An Egg";
        }
    }
}
