using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Core
{
    /// <summary>
    /// A page of the application
    /// </summary>

    public enum ApplicationPage
    {
        ///<summary>
        ///The initial login page
        ///</summary>

        Login = 0,

        /// <summary>
        /// Tha Main Chat page
        /// </summary>
        Chat = 1,

        ///<summary>
        ///The initial Register page
        ///</summary>

        Register = 2,
    }
}
