using System;

namespace StudentProject
{
    public class Utility
    {
        public static void SetProperty<T> (T obj, string propertyName, string propertyValue)
        {
            var property = obj.GetType ().GetProperty (propertyName);
            var propertyType = property.PropertyType;
            object propertyValueWithCorrectType;
            if (propertyType.IsEnum)
            {
                Enum.TryParse (propertyType, propertyValue, true, out propertyValueWithCorrectType);                
            }
            else if (propertyType == typeof(DateTimeOffset))
            {
                DateTimeOffset.TryParse(propertyValue, out var dateTimeOffset);
                propertyValueWithCorrectType = dateTimeOffset;
            }
            else
            {
                propertyValueWithCorrectType = Convert.ChangeType (propertyValue, propertyType);
            }
            property.SetValue (obj, propertyValueWithCorrectType);

        }
    }

}