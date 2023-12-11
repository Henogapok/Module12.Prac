using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12.Prac
{
    public delegate void PropertyModifiedEventHandler(object sender, PropertyModifiedEventArgs e);

    public class PropertyModifiedEventArgs : EventArgs
    {
        public string ModifiedPropertyName { get; set; }

        public PropertyModifiedEventArgs(string modifiedPropertyName)
        {
            ModifiedPropertyName = modifiedPropertyName;
        }
    }

    public interface IPropertyModified
    {
        event PropertyModifiedEventHandler PropertyModified;
    }
}
