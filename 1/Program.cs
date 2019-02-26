namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine(" Hello World! ");
            //System.Console.ReadLine();

            System.Console.Write("What is your first name: ");

            string firstName = System.Console.ReadLine();

            System.Console.Write("What is your last name: ");

            string lastName = System.Console.ReadLine();

            //string fullName = firstName + " " + lastName;
            //string fullName = 
            // string.Format("{0} {1}", firstName, lastName);
            //string fullName = string.Format("FullName: {0} {1}", firstName, lastName);
            string fullName =
                $"{firstName} {lastName}";

            System.Console.WriteLine(fullName);

            System.Console.ReadLine();





        }
    }
}
