using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcc_csharp.Common.Extensions
{
    public static class DatareaderExtensions
    {
        public static string GetString(this IDataReader reader, string fieldName)
        {
            int ordinal = reader.GetOrdinal(fieldName);

            if (reader.GetString(ordinal) == null)
            {
                return string.Empty;
            }
            else
            {
                return reader.GetString(ordinal);
            }
        }

        public static Int32 GetInt32(this IDataReader reader, string fieldName)
        {
            int ordinal = reader.GetOrdinal(fieldName);
            return reader.GetInt32(ordinal);
        }

        public static float GetFloat(this IDataReader reader, string fieldName)
        {
            int ordinal = reader.GetOrdinal(fieldName);
            return reader.GetFloat(ordinal);
        }

        public static decimal GetDecimal(this IDataReader reader, string fieldName)
        {
            int ordinal = reader.GetOrdinal(fieldName);
            return reader.GetDecimal(ordinal);
        }

        public static IDataReader GetData(this IDataReader reader, string fieldName)
        {
            int ordinal = reader.GetOrdinal(fieldName);
            return reader.GetData(ordinal);
        }

        public static DateTime GetDateTime(this IDataReader reader, string fieldName)
        {
            int ordinal = reader.GetOrdinal(fieldName);
            return reader.GetDateTime(ordinal);
        }
    }
}
