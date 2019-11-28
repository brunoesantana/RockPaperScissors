using RockPaperScissors.CrossCutting.Exceptions;
using System;
using System.ComponentModel;

namespace RockPaperScissors.CrossCutting.Helpers
{
    public static class EnumHelper
    {
        public static T GetEnumFromDescription<T>(string value)
        {
            if (Enum.IsDefined(typeof(T), value))
                return (T)Enum.Parse(typeof(T), value, true);
            else
            {
                string[] enumNames = Enum.GetNames(typeof(T));
                foreach (string enumName in enumNames)
                {
                    object e = Enum.Parse(typeof(T), enumName);

                    if (value == GetDescription((Enum)e))
                        return (T)e;
                }
            }
            throw new MovementException($"Invalid moves {value}");
        }

        private static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());

            return !(Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute) ? value.ToString() : attribute.Description;
        }
    }
}