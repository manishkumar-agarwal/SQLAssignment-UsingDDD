using System.Data.SqlClient;

namespace TelephoneSystemEntities
{
    public interface ISqlToEntityConverter<T> where T : new()
    {
        void ConvertSqlDataToObject(SqlDataReader sqlData);
    }
}
