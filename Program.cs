

namespace kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = args[0];
            System.Console.WriteLine("Witaj " + Name);
            //foreach(var item in args)
            //{
            //    if (item == "Tomek")
            //    {
            //        System.Console.WriteLine("Chuj ci w dupe " + item);
            //    }
            //    else
            //    {
            //        System.Console.WriteLine("Witaj " + item, " !");
            //    }
            //}
        }
    }
}
