using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace ConsoleNetCoreApp1
{
    public partial class Extensions
    {
        public static object To(this object @this, Type type)
        {
            if (@this == null) return @this;

            Type targetType = type;

            if (@this.GetType() == targetType)
            {
                return @this;
            }

            TypeConverter converter = TypeDescriptor.GetConverter(@this);
            if (converter is not null)
            {
                if (converter.CanConvertTo(targetType))
                {
                    return converter.ConvertTo(@this, targetType);
                }
            }

            converter = TypeDescriptor.GetConverter(targetType);
            if (converter is not null)
            {
                if (converter.CanConvertFrom(@this.GetType()))
                {
                    return converter.ConvertFrom(@this);
                }
            }

            if (@this == DBNull.Value)
            {
                return null;
            }

            return @this;
        }
    }
}
