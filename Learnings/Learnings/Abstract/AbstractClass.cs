using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnings.Abstract
{
    abstract class AbstractClass
    {
        //abstract cannot have the body 
        public abstract void SampleAbstractMethod();

        public virtual void SampleVirtualMethod()
        {
            // can have the body 
        }

    }
}
