using System.Security.Cryptography;

namespace Code;
class Functions
{
    public void Main()
    {
        Example1(); //Here we are running a function. Even though no parameters are needed, the parenthesis are still required to tell the program that you want to run a function.
        Example1("This is a parameter");
        Example2(4);
        Console.WriteLine(Example3(0, 100));
        Console.WriteLine(Example4(5, 9, 3)); //Should return 17
        Console.WriteLine(Example4(28, 42, 11, 35, 19)); //Should return 135
        Console.WriteLine(Example4()); //Should return 0
    }

    //The simplest form of functions. This executes some code, and nothing else. 'void' means that the function does not return anything.
    void Example1()
    {
        Console.WriteLine("'Example1' ran with no parameters"); //Printing to console that the function ran with no parameters.
    }

    //This function is already defined, but we are redefining the function with new parameters. This tell the program that the function 'Example1' can now be run with either no parameters or 1 parameter of type string. You can make as many UNIQUE redifinitions of the same function as you want.
    void Example1(string str) //Optional parameters are known as 'overloads'. If you hover over 'Example1' in the main function, it will tell you that it requires no parameters, has 1 overload.
    {
        Console.WriteLine("'Example1' ran with parameter: " + str); //Printing to console that the function ran with a parameter, and appends the parameter.
    }

    //This function takes a parameter, which can be used in the function to do all sorts of things.
    void Example2(int exponent) //This function takes a number and returns uses it to print 10^{parameter}.
    {
        int number = (int)Math.Pow(10f, exponent); //Calculating the result and storing in variable.
        Console.WriteLine($"10^{exponent} = {number}"); //Printing the whole math calculation.
    }

    //This function return a value. It also takes two parameters.
    int Example3(int min, int max) //This function takes a number and returns uses it to print 10^{parameter}.
    {
        Random rnd = new Random(); //We are defining a new random class, to use for generating a random number.
        return rnd.Next(min, max + 1); //Here we return out random value between min and max. Max is + 1 because it is exclusive, so we need to add one onto that to ensure that we can get our max value.
    }

    //This function takes a variable amount of int type parameters, sums them up, and returns the sum.
    int Example4(params int[] numbers) //The params keyword followed by an array of some type of variable specifies that any number of that type variable can be passed, and will be treated as a string of that type variable in the function. This will make sense later.
    {
        int sum = 0; //Defining a variable to hold the sum. So far we have not added any numbers, so it will be 0.
        foreach (int num in numbers){ //Here we are looking through all numbers in 'numbers', and making a local variable 'num' for every one of these numbers, before moving on the the next number in numbers.
            sum += num; //We are adding the number to the sum.
        }
        return sum; //Returning the sum after summing up all numbers given as parameters.
    }
}
