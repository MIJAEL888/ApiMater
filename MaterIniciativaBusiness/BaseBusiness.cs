using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MaterIniciativaBusiness
{
    public abstract class BaseBusiness
    {
        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        protected void RegistrarLog(Exception ex)
        {
            Logger.Error(string.Format("Message: {0} Trace: {1}", ex.Message, ex.StackTrace));
        }
    }
}
