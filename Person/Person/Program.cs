namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person edno = new Person();
            edno.Age = 7;
            edno.Name = "Mitio";
            edno.Familiq = "Mitkov";
            edno.Grad = "Pernik";
            edno.Introduce();

            Person dve = new Person();
            dve.Age = int.Parse(Console.ReadLine());
            dve.Name = Console.ReadLine();
            dve.Familiq = Console.ReadLine();
            dve.Grad = Console.ReadLine();
            dve.Introduce();


        }
    }
}