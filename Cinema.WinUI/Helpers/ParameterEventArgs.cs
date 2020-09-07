using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.WinUI.Helpers
{
    public class ParameterEventArgs : EventArgs
    {
        public ParameterEventArgs(object value)
        {
            Value = value;
        }
            
        public object Value { get; set; }
    }
}
