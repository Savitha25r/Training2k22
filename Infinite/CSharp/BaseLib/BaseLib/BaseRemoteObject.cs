using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public abstract class BaseRemoteObject : MarshalByRefObject
    {
        public abstract void setValue(int pvalue);
        public abstract int getValue();
        public abstract string getText();        
    }
}
