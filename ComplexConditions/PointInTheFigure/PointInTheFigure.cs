using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class PointInTheFigure
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var inFirstRectangle = (x > 0 && x < 3 * h) && (y > 0 && y < h);
            var inSecondRectangle = (x > h && x < 2 * h) && (y > h && y < 4 * h);
            var inThenMiddle = (x > h && x < 2 * h && y == h);

            var outsideFirstRectangle = (x < 0 || x > 3 * h) || (y < 0 || y > h);
            var outsideSecondRectangle = (x < h || x > 2 * h) || (y < h || y > 4 * h);

            if (inFirstRectangle || inSecondRectangle || inThenMiddle)
            {
                Console.WriteLine("inside");
            }
            else if (outsideFirstRectangle && outsideSecondRectangle)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
