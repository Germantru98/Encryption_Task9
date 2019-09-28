using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Task9
{
    public class DataPharser
    {
        public string getMessage()
        {
            using (StreamReader stream = new StreamReader("Message.txt", Encoding.Default))
            {
                return stream.ReadToEnd().ToUpper();
            }
        }
        
    }
}
