namespace PersonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BMI Calculator!");
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter your height(in metres): ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Enter your weight(in kgs) : ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("For " + name + " with user defined height and weight values");
            Person person1 = new Person(id, name, age, height, weight);
            person1.CalculateBMI();

            Console.WriteLine("For " + name + " with pre defined height and weight values");
            Person person2 = new Person(id, name, age);
            person2.CalculateBMI();
        }
    }
}
