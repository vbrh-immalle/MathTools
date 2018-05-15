using System;


namespace MathTools
{
    public class ClampRange
    {
        private int a;
        private int b;

        public ClampRange(string rangeString)
        {
            var pieces = rangeString.Split('.');

            var aStr = pieces[0].Trim();
            var bStr = pieces[2].Trim();

            Int32.TryParse(aStr, out a);
            Int32.TryParse(bStr, out b);
        }

        public int A { get { return a; } }
        public int B { get { return b; } }
    }
}
