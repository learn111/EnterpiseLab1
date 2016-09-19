using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml.Linq;
using CommonContracts;
using DAL.Helpers;

namespace DAL.Miscellaneous
{
    internal class StoredProcedure
    {
        public StoredProcedure(XElement xml, SqlFaultData sqlError)
        {
            Error = sqlError;
            Xml = xml;
        }

        public SqlFaultData Error { get; }
        public XElement Xml { get; }

        public IEnumerable<T> GetDataFromXElement<T>() where T : BaseContract, new()
        {
            if (Xml == null)
            {
                BaseContract obj = Activator.CreateInstance<T>();
                obj.ErrorDetail = Error.HResult.ToString();
                obj.ErrorMessage = Error.Message;
                yield return (T) obj;
                yield break;
            }
            if (!Xml.HasElements)
                yield break;

            foreach (var xElement in Xml.Elements().TakeWhile(xElement => xElement.HasElements))
            {
                yield return GetObject<T>(xElement);
            }
        }

        private T GetObject<T>(XElement xElement) where T : BaseContract, new()
        {
            var type = typeof (T);
            var obj = new T();

            foreach (var propertyInfo in type.GetProperties())
            {
                if (!propertyInfo.CanWrite || !propertyInfo.IsDefined(typeof (DataMemberAttribute), false))
                    continue;

                try
                {
                    var element = xElement.Element(XName.Get(propertyInfo.Name));
                    var rowObj = element?.Value;
                    var value = SafetyConvertion(rowObj, propertyInfo);
                    propertyInfo.SetValue(obj, value);
                }
                catch (Exception)
                {
                }
            }

            return obj;
        }

        private object SafetyConvertion(object rowObj, PropertyInfo propertyInfo)
        {
            object safetyConvertionResult;
            try
            {
                safetyConvertionResult = rowObj == null
                    ? DefaultValueHelper.GetDefault(propertyInfo.PropertyType)
                    : Convert.ChangeType(rowObj,
                        Nullable.GetUnderlyingType(propertyInfo.PropertyType) ??
                        propertyInfo.PropertyType, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                safetyConvertionResult = DefaultValueHelper.GetDefault(propertyInfo.PropertyType);
            }
            return safetyConvertionResult;
        }
    }
}