using System;

namespace Cse210_Unit02_Ta
{
    public class PhoneNumber
    {
        public int AreaCode;
        public int Prefix;
        public int Suffix;

        public PhoneNumber()
        {}
        public PhoneNumber(int areaCode, int prefix, int suffix)
        {
            AreaCode = areaCode;
            Prefix = prefix;
            Suffix = suffix;
        }

        public void DisplayNumber()
        {
            Console.WriteLine($"({AreaCode}) {Prefix}-{Suffix}");
        }
    }
}
