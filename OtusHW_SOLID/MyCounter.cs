using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHW_SOLID
{
    public class MyCounter
    {
        public MyCounter() { }
        public uint MyCounterValue {  get; set; } = 1;

        public void Increment() 
        {
            MyCounterValue++;
        }
        public void Reset() 
        {
            MyCounterValue = 1;
        }
    }
}
