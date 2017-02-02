using System.DirectoryServices;

namespace ToolBox
{
    public class ADHelper
    {
        #region AuthenticateUser Method
        /// <summary>
        /// Authenticates user name and password on the specified domain
        /// </summary>
        /// <param name="domainName">Domain Name</param>
        /// <param name="userName">User Name</param>
        /// <param name="password">User Password</param>
        /// <returns>True if user name and password are valid on domain</returns>
        public bool AuthenticateUser(string domainName, string userName, string password)
        {
            bool ret = false;

            try
            {
                DirectoryEntry de = new DirectoryEntry("LDAP://" + domainName, userName, password);
                DirectorySearcher dsearch = new DirectorySearcher(de);
                SearchResult results = null;

                results = dsearch.FindOne();

                ret = true;
            }
            catch
            {
                ret = false;
            }

            return ret;
        }
        #endregion
    }
}
