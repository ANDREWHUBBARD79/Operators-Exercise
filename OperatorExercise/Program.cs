namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // For division creat two integer variables called a and b. 


            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a%b ;

            Console.WriteLine(a+ " / " + b + " is "+quotient + " remainder "+remainder);
            Console.WriteLine("Please enter the area of your circle:");
            
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));

            
        }
        // define a method that perfomrs functionality that can be used over 
        // and over

        public static double AreaOfCircle(double radius)
        {
            // this is the scope of the method
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }



    }
}
