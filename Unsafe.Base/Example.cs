using System;

namespace Unsafe.Base
{
    public class Example
    {
        //public unsafe static void Test(SubClass* pointer)
        public unsafe static void Test(int* pointer)
        {
            SubClass subClass = new SubClass() { Hello = "Hi" };
            string value = "Hello";
            #region cannot take the address of, get the size of, or declare a pointer to a managed type
            //int* pointer = &subClass;
            //int* pointer = &subClass.Hello;
            //int* pointer = &value;
            #endregion
            *pointer *= *pointer;
            Console.WriteLine(*pointer);
            //Console.WriteLine(pointer);
        }
        public class SubClass
        {
            public string Hello { get; set; }
        }
    }
}
