using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenSource.Library.DataAccess;

namespace MaterIniciativaData
{
    public class BaseData
    {
        private DbContext context;

        public DbContext Context
        {
            get { return context; }
        }
        
        public BaseData()
        {
            context = new DbContext();
        }

        public BaseData(string connectionKey)
        {
            if (ExistInConfig(connectionKey))
            {
                context = new DbContext(connectionKey);
            }
        }

        private static bool ExistInConfig(string connectionStringName)
        {
            return ConfigurationManager.ConnectionStrings[connectionStringName] != null;
        }

        protected T GetDataValue<T>(IDataReader dr, string columnName)
        {
            var i = dr.GetOrdinal(columnName);

            if (!dr.IsDBNull(i))
                return (T)dr.GetValue(i);
            return default(T);
        }

        protected T GetDataValue<T>(object[] values, int posCol)
        {
            if (values.Length > posCol && values[posCol] != null)
                return (T)values[posCol];
            return default(T);
        }

    }
}
