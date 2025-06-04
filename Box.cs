using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_alistirma
{   interface IEnglishDimensions
    {
        float Length();
        float Width();
    }
    interface IMetricDimensions
    {
        float Length();
        float Width();
    }
    class Box:IEnglishDimensions,IMetricDimensions
    {
        float lengthInches;
        float widthInches;
        public Box(float length,float width)
        {  
            this.lengthInches = length;
            this.widthInches = width;
        }
        float IEnglishDimensions.Length()
        { 
            return lengthInches;
        }
        float IEnglishDimensions.Width()
        {
          return widthInches;
        }

        float IMetricDimensions.Length()
        { 
            return lengthInches*2.54f;
        }
        float IMetricDimensions.Width()
        {
            return widthInches * 2.54f;
        }


    }
    public class ana
    {
        //static void Main()
        //{
        //    Box box1 = new Box(30.0f, 20.0f);
        //    IEnglishDimensions eDimensions = (IEnglishDimensions)box1;
        //    IMetricDimensions mDimensions = (IMetricDimensions)box1;

        //    Console.WriteLine($"Length(in): {eDimensions.Length()}");
        //    Console.WriteLine($"Length(cm): {mDimensions.Length()}");
        //    Console.WriteLine($"Width(in): {eDimensions.Width()}");
        //    Console.WriteLine($"Width(cm): {mDimensions.Width()}");

        //}

    }
}
