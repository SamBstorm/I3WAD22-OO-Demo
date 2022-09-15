using System;

namespace Demo_ParamStructVSParamRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Coord2DStruct c1 = new Coord2DStruct { X = 1, Y = 1 };

            Console.WriteLine($"X = {c1.X} | Y = {c1.Y}");
            ChangeValueStruct(c1);
            Console.WriteLine($"X = {c1.X} | Y = {c1.Y}");

            Coord2DRef c2 = new Coord2DRef { X = 1, Y = 1 };

            Console.WriteLine($"X = {c2.X} | Y = {c2.Y}");
            ChangeValueRef(c2);
            Console.WriteLine($"X = {c2.X} | Y = {c2.Y}");
        }

        static void ChangeValueStruct(Coord2DStruct st)
        {
            st.X = st.X * 2;
            st.Y = st.Y * 2;
        }

        static void ChangeValueRef(Coord2DRef re)
        {
            re.X = re.X * 2;
            re.Y = re.Y * 2;
        }
    }

    public struct Coord2DStruct {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Coord2DRef
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
