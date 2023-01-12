namespace deliverable1
    //Gabrielle Herrick u81301565
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deliverable 1 Gabrielle Herrick:");
            Console.WriteLine("Hello, World!");

            string stg = "Hello, World!(2)";//defining the variable
            Console.WriteLine(stg); //outputting the string "Hello World!"

            Console.WriteLine("Please input your username here:");
            string userName = Console.ReadLine();

            Console.WriteLine("Your Username is " + userName);
            Console.WriteLine("Please input your username here:");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Your username is " + userName+ " and your age is " + age);
        }
    }
}