using System;

namespace Chees
{
    class Program
    {
        // по шахматному ходу определяет корректный ли это ход ферзя.
        // Координаты исходной и конечной позиции хода передаются строкой в обычной шахматной нотации, например, "a1".
        static void Main(string[] args)
        {
            TestMove("a1", "d4");
            TestMove("f4", "e7");
            TestMove("a1", "a4");
        }

        public static void TestMove(string from, string to)
        {
            Console.WriteLine("{0}-{1} {2}", from, to, IsCorrectMove(from, to));
        }

        public static bool IsCorrectMove(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали
            // по вертикали  - dy = 0, dx != 0
            // по горизонтали - dy != 0 dx = 0
            // по диагонали - dx = dy
            return (dy == 0 && dx != 0) || (dy != 0 && dx == 0) || (dx == dy & (dx != 0 || dy != 0));
        }
    }
}
