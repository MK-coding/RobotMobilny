using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotMobilny
{
    class Frame
    {
        public static string[] EncodeSensors(string readdata)
        {
            string a, b, c, d, e, f, g, h, i, j;

            a = readdata.Substring(7, 2);
            b = readdata.Substring(9, 2);
            c = readdata.Substring(11, 2);
            d = readdata.Substring(13, 2);
            e = readdata.Substring(15, 2);
            f = readdata.Substring(17, 2);
            g = readdata.Substring(19, 2);
            h = readdata.Substring(21, 2);
            i = readdata.Substring(23, 2);
            j = readdata.Substring(25, 2);

            string s1 = b + a;
            string s2 = d + c;
            string s3 = f + e;
            string s4 = h + g;
            string s5 = j + i;

            string[] sensorsValue = new string[] { s1, s2, s3, s4, s5 };

            return sensorsValue;
        }

        
    }
}
