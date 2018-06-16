using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emoh.Helpers
{
    public class Constants
    {
        #region Local
        //SQL Server Standard
        public static string LocalEmohConnectionString = "data source=.;initial catalog=Emoh;integrated security=true";

        //Localdb
        public static string LocalEmohConnectionString_Localdb = "Server=(localdb)\\mssqllocaldb;Database=Emoh;Trusted_Connection=True;MultipleActiveResultSets=true";
        #endregion
        //=======================================================================================================================================================
        #region Remote
        //Suitable when we want to connect to db in server and app is in server - Use this for publishing
        public static string RemoteEmohConnectionString = "data source=.;initial catalog=Emoh;User Id=EmohDbUser;Password=!Emoh@Db#User$123098";

        //Suitable when we want to connect to db in server and app is in local
        public static string RemoteEmohConnectionString_WithIp = "data source=67.227.207.217;initial catalog=Emoh;User Id=EmohDbUser;Password=!Emoh@Db#User$123098";
        #endregion
    }
}
