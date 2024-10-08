using Inheritance_StringBuilder_IsA_HasA;

class Program
{
    static void Main(string[] args)
    {
        #region Task 1
        Console.Write("Enter your Full name:");
        string fullName = Console.ReadLine();

        Console.Write("Enter your point:");
        double point = Convert.ToDouble(Console.ReadLine());

        Student student1 = new Student(fullName, point);

        Console.Write("Enter your birth date in this format (DD/MM/YYYY):");
        student1.BirthDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter your group no:");
        student1.GroupNo = Console.ReadLine();

        student1.ShowInfo();
        #endregion

        #region Task 2

        Console.Write("How many products do you wanna create?");
        int result;
        bool isSuccess = int.TryParse(Console.ReadLine(), out result);
        if (isSuccess)
        {

            Product[] products = new Product[result];
            for (int i = 0; i < result; i++)
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                Product product = new Product(name);
                Console.WriteLine("Enter price:");
                product.Price = double.Parse(Console.ReadLine());
                products[i] = product;
                Console.WriteLine($"{i + 1} this product has already added");

            }

            double Sumoforice = 0;

            foreach (var product in products)
            {
                Sumoforice += product.Price;

            }
            Console.WriteLine($"{Sumoforice / products.Length} is mean of prices");

        }

        else
        {
            Console.WriteLine("Enter the correct output");

        }

        #endregion

        #region Task 3
        TechStore techStore = new TechStore(20, "Techstore");
        techStore.Add(new NoteBook("A", 1000, 64));
        techStore.Add(new NoteBook("B", 2000, 128));
        techStore.Add(new NoteBook("C", 3000, 256));

        Console.WriteLine("Here are all the products:");
        techStore.ShowAll();
        #endregion
    }
}
