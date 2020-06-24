using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Quanlikhohang.NghiepVu
{
    public static class LazyUtilities<T> where T : class, new()
    {
        public static object ChangeType(object value, Type conversion)
        {
            var t = conversion;

            if (t.IsGenericType
                && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null)
                {
                    return null;
                }
                t = Nullable.GetUnderlyingType(t);
            }

            return Convert.ChangeType(value, t);
        }

        //DataGridView's row to object, since mapping manually is boilerplate code
        public static T DataRowToObject(DataRow dataRow)
        {
            T item = new T();
            foreach (DataColumn column in dataRow.Table.Columns)
            {
                PropertyInfo property = item.GetType().GetProperty(column.ColumnName);
                if (property != null && dataRow[column] != DBNull.Value)
                {
                    object result = ChangeType(dataRow[column], property.PropertyType);
                    property.SetValue(item, result, null);
                }
            }

            return item;
        }

        public static void QuickMap(T source, T destination)
        {
            foreach(PropertyInfo property in source.GetType().GetProperties())
            {
                property.SetValue(destination, property.GetValue(source));
            }
        }
    }
}
