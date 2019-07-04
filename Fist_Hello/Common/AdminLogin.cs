using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fist_Hello.Common
{
    [Serializable]
    public class AdminLogin
    {
        public long UserID { get; set; }
        public string UserName { get; set; }
    }
}