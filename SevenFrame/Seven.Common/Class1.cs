using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Seven.Common
{
    public class EnumValue
    {
        public string Text { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }
    }
    public class EnumHelper
    {
        public static List<EnumValue> GetEnumList(Type enumType)
        {
            List<EnumValue> items = new List<EnumValue>();

            foreach(var field in enumType.GetFields())
            {
                DescriptionAttribute desAttr = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));

                if (desAttr == null)
                    continue;

                string text = desAttr.Description;
                string val = ((int)Enum.Parse(enumType, field.Name)).ToString();
                items.Add(new EnumValue() { 
                    Text = text,
                    Value = val,
                });
            }

            return items;
        }
             
    }
}
