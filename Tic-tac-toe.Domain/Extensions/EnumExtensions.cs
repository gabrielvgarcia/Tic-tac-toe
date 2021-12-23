using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Tic_tac_toe.Domain.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum genericEnum)
        {
            Type genericEnumType = genericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(genericEnum.ToString());
            if (memberInfo is { Length: > 0 })
            {
                object[] _Attribs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (_Attribs is { Length: > 0 })
                    return ((DescriptionAttribute)_Attribs.ElementAt(0)).Description;
            }

            return genericEnum.ToString();
        }
    }
}
