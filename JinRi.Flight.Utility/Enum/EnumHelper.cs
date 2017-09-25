using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace JinRi.Flight.Utility
{
    /// <summary>
    /// 枚举扩展
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// 获取枚举
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumType"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T GetEnum<T>(object value)
        {
            if (value.GetType() == typeof(int))
            {
                return (T)Enum.ToObject(typeof(T), Convert.ToInt32(value));
            }
            else if (value.GetType() == typeof(string))
            {
                T item = (T)Enum.Parse(typeof(T), value.ToString(), true);
                return item;
            }
            return default(T);
        }
        /// <summary>
        /// 获取枚举项的描述
        /// </summary>
        /// <param name="typeOfEnum">枚举类型</param>
        /// <param name="value">枚举项/枚举值</param>
        /// <returns>描述</returns>
        public static string GetEnumDescription(Type typeOfEnum, object value)
        {
            if (value.GetType() == typeof(int))
            {
                return GetEnumDescriptionByValue(typeOfEnum, Convert.ToInt16(value));
            }
            else if (value.GetType() == typeof(string))
            {
                return GetDescriptionByName(typeOfEnum, value.ToString());
            }
            return "";
        }
        /// <summary>
        /// 获取枚举值的描述
        /// </summary>
        /// <param name="typeOfEnum">枚举类型</param>
        /// <param name="value">枚举值</param>
        /// <returns>描述</returns>
        public static string GetEnumDescriptionByValue(Type typeOfEnum, int value)
        {
            string result = string.Empty;
            try
            {
                FieldInfo f = typeOfEnum.GetField(System.Enum.GetName(typeOfEnum, value));
                if (f != null)
                {
                    DescriptionAttribute attributeOfVal = (DescriptionAttribute)f.GetCustomAttributes(typeof(DescriptionAttribute), false).First();
                    if (attributeOfVal != null)
                    {
                        result = attributeOfVal.Description;
                    }
                }
            }
            catch (Exception e) { result = e.Message; }
            return result;
        }
        public static string GetDescriptionByName(Type typeOfEnum, string value)
        {
            string result = string.Empty;
            try
            {
                if (value != null)
                {
                    FieldInfo f = typeOfEnum.GetField(value);
                    if (f != null)
                    {
                        DescriptionAttribute attributeOfVal = (DescriptionAttribute)f.GetCustomAttributes(typeof(DescriptionAttribute), false).First();
                        if (attributeOfVal != null)
                        {
                            result = attributeOfVal.Description;
                        }
                    }

                }
            }
            catch (Exception)
            {
            }
            return result;
        }
        public static Dictionary<string, string> GetEnumDescriptionAndKey(Type enumType)
        {
            Dictionary<string, string> list = new Dictionary<string, string>();
            FieldInfo[] members = enumType.GetFields(BindingFlags.Static | BindingFlags.Public);
            foreach (FieldInfo member in members)
            {
                list.Add(((DescriptionAttribute)member.GetCustomAttributes(typeof(DescriptionAttribute), false)[0]).Description, member.Name);
            }
            return list;
        }
        public static Dictionary<string, string> GetEnumDescriptionAndValue(Type enumType)
        {
            Dictionary<string, string> list = new Dictionary<string, string>();
            FieldInfo[] members = enumType.GetFields(BindingFlags.Static | BindingFlags.Public);
            foreach (FieldInfo member in members)
            {
                list.Add(((DescriptionAttribute)member.GetCustomAttributes(typeof(DescriptionAttribute), false)[0]).Description, System.Enum.Parse(enumType, member.Name).GetHashCode().ToString());
            }
            return list;
        }

        public static string ToDescription(this System.Enum @enum)
        {
            System.Type type = @enum.GetType();
            System.Reflection.MemberInfo[] member = type.GetMember(@enum.ToString());
            if (member != null && member.Length > 0)
            {
                object[] customAttributes = member[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (customAttributes != null && customAttributes.Length > 0)
                {
                    return ((DescriptionAttribute)customAttributes[0]).Description;
                }
            }
            return @enum.ToString();
        }

        /// <summary>
        /// 获取枚举属性
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetEnumDescription(object value)
        {
            Type enumType = value.GetType();
            if (!enumType.IsEnum)
            {
                throw new ArgumentException("不是枚举");
            }
            var name = Enum.GetName(enumType, Convert.ToInt32(value));
            if (name == null)
            {
                return string.Empty;
            }
            object[] objs = enumType.GetField(name).GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (objs == null || objs.Length == 0)
            {
                return string.Empty;
            }
            else
            {
                DescriptionAttribute attr = objs[0] as DescriptionAttribute;
                return attr.Description;
            }

        }

        public static string GetEnumDescription(this Enum value)
        {
            Type enumType = value.GetType();

            var name = Enum.GetName(enumType, Convert.ToInt32(value));
            if (name == null)
            {
                return string.Empty;
            }
            object[] objs = enumType.GetField(name).GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (objs == null || objs.Length == 0)
            {
                return string.Empty;
            }
            else
            {
                DescriptionAttribute attr = objs[0] as DescriptionAttribute;
                return attr.Description;
            }
        }
    }
}
