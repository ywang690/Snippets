using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAlg
{
    public class CSLibAlgString
    {
        public int LengthOfLastWord(string s)   //58
        {
            //string s1 = "Hello World";
            //string s2 = "   fly me   to   the moon  ";
            //string s3 = "luffy is still joyboy";
            //int output = LengthOfLastWord(s3);

            int _output = 0;
            Int32 Space = 0;
            Console.WriteLine(s.Length);
            Space = s.LastIndexOf(" ");
            Console.WriteLine(s.Substring(Space, (s.Length - Space)));
            return (s.Length - Space);
        }
    }
}
