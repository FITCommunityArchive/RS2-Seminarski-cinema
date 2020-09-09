using System;

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
