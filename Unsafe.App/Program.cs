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
            Console.WriteLine(sample);
            Console.ReadLine();
        }
    }
}
