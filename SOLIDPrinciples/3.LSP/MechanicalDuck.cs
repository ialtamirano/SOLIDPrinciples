using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples._3.LSP
{
     public class MechanicalDuck : Duck
    {
        bool _battery;
        public MechanicalDuck(bool battery= false) : base()
        {
            
            this._battery = battery;
        }

        public string Quack()
        {
            if (!this._battery)
            {
                throw new Exception("Need battery to operate.");
            }
            return "Quack";
        }
    }
}
