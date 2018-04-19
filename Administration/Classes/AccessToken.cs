using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Classes
{
    internal class AccessToken
    {
        /// <summary>
        /// </summary>
        public DateTime Expiration { get; set; }

        /// <summary>
        /// </summary>
        public string TokenString { get; set; }
    }
}
