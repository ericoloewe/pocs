using System;

namespace generic_type
{
    class Program
    {
        static void Main(string[] args)
        {
            var basee = new Base<Generic>();

            basee.ASD();

            Console.WriteLine("Hello World!");
        }
    }

    class Base<T>
    {
        public void ASD()
        {
            var generic = typeof(T);
            var type = Type.GetType($"{generic.FullName}_Hist");
            var genericHist = Activator.CreateInstance(type);

            Console.WriteLine(generic);
            Console.WriteLine(type);
        }
    }

    class Generic
    {
    }

    class Generic_Hist
    {
    }
}
