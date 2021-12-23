using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Tic_tac_toe.Domain.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDescription(this IConvertible value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            try
            {
                DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

                if (attributes != null && attributes.Length > 0)
                    return attributes[0].Description;
                else
                    return value.ToString();
            }
            catch (Exception)
            {
                return value.ToString();
            }
        }
    }
}