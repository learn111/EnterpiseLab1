using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;

namespace Common
{
    public static class EnumExtension
    {
        public static List<KeyValuePair<int, string>> ToList<T>()
            where T : struct, IConvertible
        {
            if (!typeof (T).IsEnum)
                throw new ArgumentException("type is not enum");
            return
                Enum.GetValues(typeof (T))
                    .OfType<T>()
                    .Select(
                        x =>
                            new KeyValuePair<int, string>(Convert.ToInt32(x),
                                Convert.ToString(x, CultureInfo.InvariantCulture))).ToList();
        }

        public static List<KeyValuePair<int, string>> ToLocalizedList<T>()
            where T : struct, IConvertible
        {
            if (!typeof (T).IsEnum)
                throw new ArgumentException("type is not enum");
            return
                Enum.GetValues(typeof (T))
                    .OfType<T>()
                    .Select(
                        x =>
                            new KeyValuePair<int, string>(Convert.ToInt32(x),
                                GetAttribute<DisplayAttribute, string>(x as Enum, y => y.GetName()))).ToList();
        }

        public static string ToLocalized<T>(T val)
            where T : struct, IConvertible
        {
            if (!typeof (T).IsEnum)
                throw new ArgumentException("type is not enum");
            return GetAttribute<DisplayAttribute, string>(val as Enum, y => y.GetName());
        }

        public static TResult GetAttribute<T, TResult>(Enum member, Func<T, TResult> selector)
            where T : Attribute
        {
            var attr =
                member.GetType().GetMember(member.ToString())
                    .FirstOrDefault()?
                    .GetCustomAttributes(typeof (T), false)
                    .OfType<T>()
                    .SingleOrDefault();

            return attr != null ? selector(attr) : (TResult) (object) member;
        }

        public static TResult GetAttribute<T, TResult>(Enum member, Func<T, TResult> selector, Func<T, bool> where)
            where T : Attribute
        {
            var attr =
                member.GetType().GetMember(member.ToString())
                    .FirstOrDefault()?
                    .GetCustomAttributes(typeof (T), false)
                    .OfType<T>()
                    .Where(where)
                    .SingleOrDefault();

            return selector(attr);
        }

        public static List<KeyValueStringInt> ToLocalizedListKeyValue<T>()
            where T : struct, IConvertible
        {
            if (!typeof (T).IsEnum)
                throw new ArgumentException("type is not enum");
            return
                ToLocalizedList<T>().Select(x => new KeyValueStringInt(x.Value, x.Key)).ToList();
        }
    }
}