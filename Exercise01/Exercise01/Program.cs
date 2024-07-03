namespace Exercise01;

class Program
{
    static void Main(string[] args)
    {
        /*
        //hypotenuse

        Console.WriteLine("Enter side A: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter side B: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double c = Math.Sqrt((a * a) + (b * b));
        Console.WriteLine(c);

        

        //1.String

        String fullName = "Rita wang";
     
        string fullName01 = fullName.ToUpper();
        string fullName02 = fullName.ToLower();
        //Console.WriteLine(fullName01);
        //Console.WriteLine(fullName02);

        //replace
        String phoneNum = "123-456-7890";
        phoneNum = phoneNum.Replace("-", "");
        //Console.WriteLine(phoneNum);

        //insert
        //string username = fullName.Insert(0, "@");
        string username = fullName.Insert(0, "Mr.");
        // Console.WriteLine(username);

        //Length
        //Console.WriteLine(fullName.Length);

        //slice string
        string firstname = fullName.Substring(0, 4);
        Console.WriteLine(firstname);

        */

        //2.if statement
        Console.WriteLine("Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >100 )
        {
            Console.WriteLine("you are too old to sign up");
           
        }
        else if (age >= 18)
        {
            Console.WriteLine("You are now signed up!");
        }
        else if (age <0)
        {
            Console.WriteLine("you haven't been born yet");
        }
        else
        {
            Console.WriteLine("You must be 18+ to sign up!");
        }


        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        //if (name == "")
        //{
        //    Console.WriteLine("You did not enter your name!");
        //}
        //else
        //{
        //    Console.WriteLine("Hello, " + name);
        //}
        if (name != "")
        {
            Console.WriteLine("Hello, " + name);
        }
        else
        {
            Console.WriteLine("You did not enter your name!");
          
        }

    }
}

