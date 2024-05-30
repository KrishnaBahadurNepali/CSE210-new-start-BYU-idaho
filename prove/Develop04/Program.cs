public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();//this clears the previous screen 
            Console.WriteLine("Select an activity:");//Writing all in a order
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity; Think about yourself");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Do you want to creat a journal?");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            Activity activity = null;//declares andinitialize activity to null
            switch (choice) //I have choosed switch method instead of if or while loop
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    continue;
            }

            activity.Execute(); //this will call the execute method of the Activity class which was initialized to null
        }  
             //And also calls the Execute() from other class
             
    }
}