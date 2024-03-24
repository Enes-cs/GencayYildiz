namespace Boxing_UnBoxing_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object _yas = 10.2;
            Console.WriteLine(_yas);

            Type type = _yas.GetType();
            Console.WriteLine(type.FullName);

            double yas = (double)_yas;

            

        }
    }
}
