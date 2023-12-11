using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12.Prac
{
    public class CustomClass : IPropertyModified
    {
        private string _customProperty;

        public event PropertyModifiedEventHandler PropertyModified;

        public string CustomProperty
        {
            get { return _customProperty; }
            set
            {
                if (_customProperty != value)
                {
                    _customProperty = value;
                    OnPropertyChanged(new PropertyModifiedEventArgs("CustomProperty"));
                }
            }
        }

        protected virtual void OnPropertyChanged(PropertyModifiedEventArgs e)
        {
            PropertyModified?.Invoke(this, e);
        }
    }
}
