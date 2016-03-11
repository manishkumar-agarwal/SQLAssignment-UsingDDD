using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EntityDBInterface
{
    public class DBStoredProcedureConfiguration : ConfigurationSection
    {
        public string StoredProcedureName
        {
            get
            {
                return (string)this["SPName"];
            }
        }

        public string StoredProcedureParameters
        {
            get
            {
                return (string)this["SPParameters"];
            }
        }

    }
}
