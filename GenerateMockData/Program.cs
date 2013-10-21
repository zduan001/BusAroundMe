using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GenerateMockData
{
    class Program
    {
        static void Main(string[] args)
        {
            GetReflectionData re = new GetReflectionData();
        }
    }

    public class GetReflectionData
    {

        public static int count = 10;

        private Dictionary<string, int> classCountList;

        public GetReflectionData()
        {
            classCountList = new Dictionary<string, int>();
            classCountList.Add("Agency", 2);
            classCountList.Add("BusRoute", 20);
            classCountList.Add("BusStop", 10);
            classCountList.Add("BusStopForRoute", 100);
            classCountList.Add("GeoLocationPoint", 3000);



            Assembly asm = this.GetType().Assembly;
            foreach (Type type in asm.GetTypes())
            {
                if (classCountList.ContainsKey(type.Name))
                {
                    var genericListType = typeof(List<>).MakeGenericType(new[] { type });
                    var addMethod = genericListType.GetMethod("Add");
                    var list = Activator.CreateInstance(genericListType);

                    for (int i = 0; i < classCountList[type.Name]; i++)
                    {
                        addMethod.Invoke(list, new[] { CreateAnInstanceOfAType(type, i) });
                    }

                    XmlSerializer serializer = new XmlSerializer(list.GetType());
                    StringWriter writer = new StringWriter();
                    serializer.Serialize(writer, list, null);
                    string s = writer.ToString();

                    using(StreamWriter outfile = new StreamWriter(type.Name + ".xml",false))
                    {
                        outfile.Write(s);
                    }

                }
            }
        }

        private static object CreateAnInstanceOfAType(Type type, int index)
        {
            object item = Activator.CreateInstance(type);
            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                if (propertyInfo.CanWrite)
                {
                    if (propertyInfo.PropertyType == typeof(System.Boolean))
                    {
                        type.GetProperty(propertyInfo.Name).SetValue(item, (index % 2 == 0) ? true : false, null);
                    }
                    else if (propertyInfo.PropertyType == typeof(int))
                    {
                        type.GetProperty(propertyInfo.Name).SetValue(item, index, null);
                    }
                    else if (propertyInfo.PropertyType == typeof(double))
                    {
                        type.GetProperty(propertyInfo.Name).SetValue(item, index, null);
                    }
                    else if (propertyInfo.PropertyType == typeof(float))
                    {
                        type.GetProperty(propertyInfo.Name).SetValue(item, index, null);
                    }
                    else if (propertyInfo.PropertyType == typeof(string))
                    {
                        type.GetProperty(propertyInfo.Name).SetValue(item, propertyInfo.Name + index.ToString(), null);
                    }
                    //else if (propertyInfo.PropertyType == typeof(Uri))
                    //{
                    //    type.GetProperty(propertyInfo.Name).SetValue(item, new Uri("http://wwww.iwportal" + index.ToString() +  ".com"), null);
                    //}
                }
            }
            return item;
        }
    }
}
