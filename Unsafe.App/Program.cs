using System;
using Unsafe.Base;

namespace Unsafe.App
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int sample = 5;
            Example.Test(&sample);
            //&sample contains the pointer to stack
            Console.WriteLine(sample);
            Console.ReadLine();
        }
        //sample has value 5
        //&sample has value 0x000007ec17de10
        //in Example.Test pointer has value 0x000007ec17de10
        //and *pointer has value 5 (the value in that position in stack)
    }
}
