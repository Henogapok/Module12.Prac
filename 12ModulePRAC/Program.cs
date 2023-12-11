using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12.Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomClass customObject = new CustomClass();
            customObject.PropertyModified += CustomObject_PropertyModified;

            customObject.CustomProperty = "Новое значение";

            Console.ReadLine();
        }

        private static void CustomObject_PropertyModified(object sender, PropertyModifiedEventArgs e)
        {
            Console.WriteLine($"Свойство {e.ModifiedPropertyName} было изменено.");
        }
    }
}
