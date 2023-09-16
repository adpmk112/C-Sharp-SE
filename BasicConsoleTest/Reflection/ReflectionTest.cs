using BasicConsoleTest.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BasicConsoleTest.Reflection
{
    public class ReflectionTest
    {
        public string GetResult(object obj)
        {
            StringBuilder sb = new StringBuilder();

            Type type = typeof(AlbumModel);

            PropertyInfo[] properties = type.GetProperties();

            foreach(PropertyInfo property in properties)
            {
                object propertyValue = property.GetValue(obj);
                string stringValue = propertyValue?.ToString();

                sb.Append(stringValue);
            }

            return sb.ToString();
        }
    }
}
