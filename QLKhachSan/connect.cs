using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan
{
    public class connect
    {
        private static connect instance;
        public string server { get; set; }
        public string database { get; set; }
        public static connect Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new connect();
                }
                return instance;
            }
        }
    }
}
